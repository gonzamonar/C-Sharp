using System.Data;
using System.Data.SqlClient;
using Domain;
using Model;
using Model.Enums;

namespace Presentation
{
    internal static partial class View
    {
        internal static class DatabaseViews
        {
            static string connectionString;
            static SqlCommand command;
            static SqlConnection connection;

            static DatabaseViews()
            {
                connectionString = @"Data Source=.; Initial Catalog=parcial_dos; Integrated Security=True";
                command = new SqlCommand();
                connection = new SqlConnection(connectionString);
                command.Connection = connection;
                command.CommandType = CommandType.Text;
            }


            public static DataTable GetUsersGridview()
            {
                DataTable dataTable = new DataTable();

                dataTable.Columns.Add("Credencial");
                dataTable.Columns.Add("Username");
                dataTable.Columns.Add("Nombre");
                dataTable.Columns.Add("Apellido");
                dataTable.Columns.Add("DNI");
                dataTable.Columns.Add("Género");

                try
                {
                    connection.Open();
                    command.CommandText = "SELECT credencial[Credencial], username[Username],"+
                                          " CASE WHEN nombre IS NULL THEN '' ELSE nombre END AS[Nombre],"+
                                          " CASE WHEN apellido IS NULL THEN '' ELSE apellido END AS[Apellido],"+
                                          " CASE WHEN dni IS NULL THEN '' ELSE dni END AS[DNI],"+
                                          " CASE WHEN genero IS NULL THEN '' ELSE genero END AS[Género]"+
                                          " FROM Usuarios ORDER BY credencial, apellido;";

                    SqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        string? DNI = (dataReader["DNI"].ToString() == "0") ? "" : dataReader["DNI"].ToString();
                        dataTable.Rows.Add(dataReader["Credencial"].ToString(), dataReader["Username"].ToString(), dataReader["Nombre"].ToString(), dataReader["Apellido"].ToString(), DNI, dataReader["Género"].ToString());
                    }
                }
                catch
                {
                    ShowErrorMessageBox(Error.Msg.DgvError, "Error inesperado");
                }
                finally
                {
                    connection.Close();
                }

                return dataTable;
            }


            public static DataTable GetCoursesGridview()
            {
                DataTable dataTable = new DataTable();

                try
                {
                    dataTable.Columns.Add("Código");
                    dataTable.Columns.Add("Asignatura");
                    dataTable.Columns.Add("Cuatrimestre");
                    dataTable.Columns.Add("Año");

                    connection.Open();
                    command.CommandText = "SELECT Materias.codigo[Código], Asignaturas.titulo[Asignatura], Cuatrimestres.periodo[Cuatrimestre], Cuatrimestres.anio[Año]"+
                                          " FROM Materias"+
                                          " INNER JOIN Cuatrimestres ON Materias.codigoCuatrimestre = Cuatrimestres.codigo"+
                                          " INNER JOIN Asignaturas ON Materias.idAsignatura = Asignaturas.codigo;";

                    SqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        dataTable.Rows.Add(dataReader["Código"].ToString(), dataReader["Asignatura"].ToString(), dataReader["Cuatrimestre"].ToString(), dataReader["Año"].ToString());
                    }
                }
                catch
                {
                    ShowErrorMessageBox(Error.Msg.DgvError, "Error inesperado");
                }
                finally
                {
                    connection.Close();
                }

                return dataTable;
            }


            public static DataTable GetEnrolledGridview(string codigoMateria)
            {
                DataTable dataTable = new DataTable();

                try
                {
                    dataTable.Columns.Add("Id");
                    dataTable.Columns.Add("Usuario");
                    dataTable.Columns.Add("Nombre");
                    dataTable.Columns.Add("Apellido");
                    dataTable.Columns.Add("DNI");
                    dataTable.Columns.Add("Género");
                    dataTable.Columns.Add("Condicion");
                    dataTable.Columns.Add("Nota Primer Parcial");
                    dataTable.Columns.Add("Nota Segundo Parcial");

                    connection.Open();
                    command.CommandText = "SELECT u.id[Id], u.username[Username], u.nombre[Nombre], u.apellido[Apellido], u.dni[DNI],"+
                                          " u.genero[Género], i.condicion[Condición], i.notaPrimerParcial[Nota Primer Parcial], i.notaSegundoParcial[Nota Segundo Parcial]"+
                                          " FROM Inscripciones AS i" +
                                          " LEFT JOIN Usuarios AS u ON i.idEstudiante = u.id"+
                                          $" WHERE idMateria = '{codigoMateria}';";

                    SqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        string? primerParcial = (dataReader["Nota Primer Parcial"].ToString() == "") ? "Sin Calificar" : dataReader["Nota Primer Parcial"].ToString();
                        string? segundoParcial = (dataReader["Nota Segundo Parcial"].ToString() == "") ? "Sin Calificar" : dataReader["Nota Segundo Parcial"].ToString();

                        dataTable.Rows.Add(dataReader["Id"].ToString(), dataReader["Username"].ToString(), dataReader["Nombre"].ToString(), dataReader["Apellido"].ToString(),
                                           dataReader["DNI"].ToString(), dataReader["Género"].ToString(), dataReader["Condición"].ToString(), primerParcial, segundoParcial);
                    }
                }
                catch
                {
                    ShowErrorMessageBox(Error.Msg.DgvError, "Error inesperado");
                }
                finally
                {
                    connection.Close();
                }

                return dataTable;
            }


            public static DataTable GetTeachersInCourseGridview(string codigoMateria)
            {
                DataTable dataTable = new DataTable();

                try
                {
                    dataTable.Columns.Add("Username");
                    dataTable.Columns.Add("Docentes a cargo");

                    connection.Open();
                    command.CommandText = "SELECT u.username[Username], CONCAT(u.nombre, ' ', u.apellido) AS[Docentes a Cargo]" +
                                          " FROM DesignacionesDocentes AS d" +
                                          " LEFT JOIN Usuarios AS u ON d.idDocente = u.id" +
                                          $" WHERE idMateria = '{codigoMateria}'" +
                                          " ORDER BY [Docentes a Cargo] ASC";

                    SqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        dataTable.Rows.Add(dataReader["Username"].ToString(), dataReader["Docentes a Cargo"].ToString());
                    }
                }
                catch
                {
                    ShowErrorMessageBox(Error.Msg.DgvError, "Error inesperado");
                }
                finally
                {
                    connection.Close();
                }


                return dataTable;
            }

            public static DataTable GetStudentApprovedAssignmentsGridview(string studentUsername)
            {
                DataTable dataTable = new DataTable();

                try
                {
                    dataTable.Columns.Add("Código");
                    dataTable.Columns.Add("Asignatura");
                    dataTable.Columns.Add("Cuatrimestre");

                    connection.Open();
                    command.CommandText = "SELECT a.codigo [Código], a.titulo [Asignatura], CONCAT(c.periodo,' ', c.anio) [Cuatrimestre]" +
                                          " FROM HistorialAcademico AS h" +
                                          " INNER JOIN Materias AS m ON h.idMateria = m.codigo" +
                                          " INNER JOIN Asignaturas AS a ON m.idAsignatura = a.codigo" +
                                          " INNER JOIN Cuatrimestres AS c ON m.codigoCuatrimestre = c.codigo" +
                                         $" WHERE (SELECT Usuarios.id FROM Usuarios WHERE Usuarios.username = '{studentUsername.ToLower()}') = h.idEstudiante;";

                    SqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        dataTable.Rows.Add(dataReader["Código"].ToString(), dataReader["Asignatura"].ToString(), dataReader["Cuatrimestre"].ToString());
                    }
                }
                catch
                {
                    ShowErrorMessageBox(Error.Msg.DgvError, "Error inesperado");
                }
                finally
                {
                    connection.Close();
                }


                return dataTable;
            }


            public static DataTable GetStudentEnrolledCoursesGridview(int studentId)
            {
                DataTable dataTable = new DataTable();

                try
                {
                    dataTable.Columns.Add("Materia");
                    dataTable.Columns.Add("Asignatura");
                    dataTable.Columns.Add("Cuatrimestre");
                    dataTable.Columns.Add("Año");
                    dataTable.Columns.Add("Condicion");
                    dataTable.Columns.Add("Asistencia");
                    dataTable.Columns.Add("Nota Primer Parcial");
                    dataTable.Columns.Add("Nota Segundo Parcial");

                    connection.Open();
                    command.CommandText = "SELECT i.idMateria[Materia], a.titulo[Asignatura], c.periodo[Cuatrimestre], c.anio[Año], i.condicion[Condición], "+
                                          " CASE i.asistencia WHEN 1 THEN 'Dada' ELSE 'Sin Dar' END AS[Asistencia]," +
                                          " i.notaPrimerParcial[Nota Primer Parcial], i.notaSegundoParcial[Nota Segundo Parcial]" +
                                          " FROM Inscripciones AS i" +
                                          " INNER JOIN Usuarios AS u ON i.idEstudiante = u.id" +
                                          " INNER JOIN Materias AS m ON i.idMateria = m.codigo" +
                                          " INNER JOIN Asignaturas AS a ON m.idAsignatura = a.codigo" +
                                          " INNER JOIN Cuatrimestres AS c ON m.codigoCuatrimestre = c.codigo" +
                                         $" WHERE {studentId} = i.idEstudiante;";

                    SqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        string? primerParcial = (dataReader["Nota Primer Parcial"].ToString() == "") ? "Sin Calificar" : dataReader["Nota Primer Parcial"].ToString();
                        string? segundoParcial = (dataReader["Nota Segundo Parcial"].ToString() == "") ? "Sin Calificar" : dataReader["Nota Segundo Parcial"].ToString();

                        dataTable.Rows.Add(dataReader["Materia"].ToString(), dataReader["Asignatura"].ToString(), dataReader["Cuatrimestre"].ToString(), dataReader["Año"].ToString(),
                                           dataReader["Condición"].ToString(), dataReader["Asistencia"].ToString(), primerParcial, segundoParcial);
                    }
                }
                catch
                {
                    ShowErrorMessageBox(Error.Msg.DgvError, "Error inesperado");
                }
                finally
                {
                    connection.Close();
                }

                return dataTable;
            }

            static public DataTable GetExamsDataTable(string codigoMateria)
            {
                DataTable dataTable = new DataTable();

                dataTable.Columns.Add("Primer Parcial");
                dataTable.Columns.Add("Fecha PP");
                dataTable.Columns.Add("Segundo Parcial");
                dataTable.Columns.Add("Fecha SG");

                if (!Repository.IsCourseEmpty(codigoMateria))
                {
                    string primerParcial = "Sin Crear";
                    string segundoParcial = "Sin Crear";
                    string fechaPP = "-";
                    string fechaSP = "-";

                    if (Repository.IsExamCreated(codigoMateria, "PrimerParcial"))
                    {
                        primerParcial = "Creado";
                        fechaPP = Repository.GetExamDate(codigoMateria, "PrimerParcial");
                    }

                    if (Repository.IsExamCreated(codigoMateria, "SegundoParcial"))
                    {
                        segundoParcial = "Creado";
                        fechaSP = Repository.GetExamDate(codigoMateria, "SegundoParcial");
                    }

                    dataTable.Rows.Add(primerParcial, fechaPP, segundoParcial, fechaSP);
                }
                return dataTable;
            }
        }



        internal static class DatabaseCmb
        {
            static string connectionString;
            static SqlCommand command;
            static SqlConnection connection;

            static DatabaseCmb()
            {
                connectionString = @"Data Source=.; Initial Catalog=parcial_dos; Integrated Security=True";
                command = new SqlCommand();
                connection = new SqlConnection(connectionString);
                command.Connection = connection;
                command.CommandType = CommandType.Text;
            }

            public static DataTable GetStudentsListDatatable()
            {
                DataTable dataTable = new DataTable();

                try
                {
                    dataTable.Columns.Add("Id");
                    dataTable.Columns.Add("Estudiante");

                    connection.Open();
                    command.CommandText = "SELECT u.id [Id], CONCAT(u.nombre,' ', u.apellido) [Estudiante]"+
                                          " FROM Usuarios u WHERE (u.credencial = 'Estudiante');";

                    SqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        dataTable.Rows.Add(dataReader["Id"].ToString(), dataReader["Estudiante"].ToString());
                    }
                }
                catch
                {
                    ShowErrorMessageBox(Error.Msg.DgvError, "Error inesperado");
                }
                finally
                {
                    connection.Close();
                }

                return dataTable;
            }

            public static DataTable GetSubjectsListDatatable(bool addEmptyOption)
            {
                DataTable dataTable = new DataTable();

                try
                {
                    dataTable.Columns.Add("CodigoAsignatura");
                    dataTable.Columns.Add("Asignatura");

                    connection.Open();
                    command.CommandText = "SELECT Asignaturas.codigo [Codigo], Asignaturas.titulo [Asignatura] FROM Asignaturas;";

                    SqlDataReader dataReader = command.ExecuteReader();

                    if (addEmptyOption)
                    {
                        dataTable.Rows.Add("", "");
                    }

                    while (dataReader.Read())
                    {
                        dataTable.Rows.Add(dataReader["Codigo"].ToString(), dataReader["Asignatura"].ToString());
                    }
                }
                catch
                {

                }
                finally
                {
                    connection.Close();
                }

                return dataTable;
            }

            public static DataTable GetCoursesListDatatable()
            {
                DataTable dataTable = new DataTable();

                try
                {
                    dataTable.Columns.Add("Materia");

                    connection.Open();
                    command.CommandText = "SELECT Materias.codigo FROM Materias;";

                    SqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        dataTable.Rows.Add(dataReader["codigo"].ToString());
                    }
                }
                catch
                {

                }
                finally
                {
                    connection.Close();
                }

                return dataTable;
            }


            public static DataTable GetUndesignatedTeachersInCourseDatatable(string codigoMateria)
            {
                DataTable dataTable = new DataTable();

                try
                {
                    dataTable.Columns.Add("Id");
                    dataTable.Columns.Add("Docente");

                    connection.Open();
                    command.CommandText = "SELECT u.id [Id], CONCAT(u.nombre,' ', u.apellido) [Docente] FROM Usuarios AS u"+
                                          " WHERE u.credencial = 'Docente' AND"+
                                          $" u.id NOT IN(SELECT d.idDocente FROM DesignacionesDocentes AS d WHERE d.idMateria = '{codigoMateria}');";

                    SqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        dataTable.Rows.Add(dataReader["Id"].ToString(), dataReader["Docente"].ToString());
                    }
                }
                catch
                {

                }
                finally
                {
                    connection.Close();
                }

                return dataTable;
            }

            public static DataTable GetStudentAbleToEnrollCoursesDatatable(int idEstudiante, string codigoCuatriActivo)
            {
                DataTable dataTable = new DataTable();

                try
                {
                    dataTable.Columns.Add("Materia");

                    connection.Open();
                    command.CommandText = "SELECT m.codigo [Materia] FROM Materias AS m" +
                                         $" WHERE codigoCuatrimestre = '{codigoCuatriActivo}'" + //Sólo este cuatrimestre
                                         $" AND idAsignatura NOT IN(SELECT m.idAsignatura FROM HistorialAcademico AS h INNER JOIN Materias AS m ON m.codigo = h.idMateria WHERE h.idEstudiante = {idEstudiante})"+ //Evitar las aprobadas
                                         " AND idAsignatura NOT IN(SELECT c.codigoAsignatura FROM Correlativas AS c WHERE c.codigoCorrelativa" + //Evitar las correlatividades sin cumplir
                                                $" NOT IN (SELECT m.idAsignatura FROM HistorialAcademico AS h INNER JOIN Materias AS m ON m.codigo = h.idMateria WHERE h.idEstudiante = {idEstudiante}))" + 
                                         $" AND m.codigo NOT IN (SELECT i.idMateria FROM Inscripciones AS i WHERE idEstudiante = {idEstudiante});"; //Evitar las que ya se inscribió

                    SqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        dataTable.Rows.Add(dataReader["Materia"].ToString());
                    }
                }
                catch
                {

                }
                finally
                {
                    connection.Close();
                }

                return dataTable;
            }

            public static DataTable GetProfessorDesignatedCoursesDatatable(int idProfesor)
            {
                DataTable dataTable = new DataTable();

                try
                {
                    dataTable.Columns.Add("Materia");

                    connection.Open();
                    command.CommandText = $"SELECT d.idMateria [Materia] FROM DesignacionesDocentes d WHERE idDocente = {idProfesor};";

                    SqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        dataTable.Rows.Add(dataReader["Materia"].ToString());
                    }
                }
                catch
                {

                }
                finally
                {
                    connection.Close();
                }

                return dataTable;
            }
        }

            //static public DataTable StatisticsEnrollments()
            //{
            //    DataTable dataTable = new DataTable();

            //    dataTable.Columns.Add("Materia");
            //    dataTable.Columns.Add("Cantidad Inscriptos");

            //    Repository r = Repository.GetInstance();

            //    dataTable.Rows.Add("TOTAL INSCRIPTOS", Estadisticas.CalcularTotalInscriptos());
            //    dataTable.Rows.Add("TOTAL MATERIAS", Estadisticas.CalcularTotalMaterias());
            //    dataTable.Rows.Add("PROMEDIO POR MATERIA", Estadisticas.CalcularPromedioInscriptos());

            //    foreach (Materia m in r.ListadoMaterias.Values)
            //    {
            //        dataTable.Rows.Add(m.Codigo, Estadisticas.CalcularInscriptosPorMateria(m).ToString());
            //    }

            //    return dataTable;
            //}

            //static public DataTable StatisticsGrades()
            //{
            //    DataTable dataTable = new DataTable();

            //    dataTable.Columns.Add("Materia");
            //    dataTable.Columns.Add("Promedio PP");
            //    dataTable.Columns.Add("Promedio SG");
            //    dataTable.Columns.Add("Promedio Total");

            //    Repository r = Repository.GetInstance();
            //    foreach (Materia m in r.ListadoMaterias.Values)
            //    {
            //        float promedioPP = Estadisticas.CalcularNotaPromedioPrimerParcialPorMateria(m);
            //        float promedioSP = Estadisticas.CalcularNotaPromedioSegundoParcialPorMateria(m);
            //        float promedioTotal = Estadisticas.CalcularNotaPromedioPorMateria(m);

            //        dataTable.Rows.Add(m.Codigo, promedioPP.ToString(), promedioSP.ToString(), promedioTotal.ToString());
            //    }

            //    return dataTable;
            //}
    }
}
