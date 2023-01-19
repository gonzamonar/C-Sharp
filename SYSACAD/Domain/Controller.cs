using Model;
using Model.Enums;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Domain
{
    public static class Controller
    {
        static string connectionString;
        static SqlCommand command;
        static SqlConnection connection;

        static Controller()
        {
            connectionString = @"Data Source=.; Initial Catalog=parcial_dos; Integrated Security=True";
            command = new SqlCommand();
            connection = new SqlConnection(connectionString);
            command.Connection = connection;
            command.CommandType = CommandType.Text;
        }

//FUNCIONES ADMIN//
        public static void CambiarRegularidad(string codigoMateria, string idEstudiante, string condicion)
        {
            if (codigoMateria is not null && idEstudiante is not null && condicion is not null
                && int.TryParse(idEstudiante, out int userId) && Repository.DoesCourseExist(codigoMateria) && Repository.DoesUserExist(userId, "Estudiante"))
            {
                try
                {
                    connection.Open();

                    command.CommandText = $"UPDATE Inscripciones SET condicion = '{condicion}' WHERE idEstudiante = {idEstudiante} AND idMateria = '{codigoMateria}';";

                    command.ExecuteNonQuery();
                }
                catch
                {

                }
                finally
                {
                    connection.Close();
                }
            }
        }


        public static void AsignarDocente(string codigoMateria, string idDocente)
        {
            if (int.TryParse(idDocente, out int userId) && Repository.DoesCourseExist(codigoMateria) && Repository.DoesUserExist(userId, "Docente"))
            {
                try
                {
                    connection.Open();
                    command.CommandText = "INSERT INTO DesignacionesDocentes(idMateria, idDocente)"+
                                         $" VALUES ('{codigoMateria}', {userId});";

                    command.ExecuteNonQuery();
                }
                catch
                {

                }
                finally
                {
                    connection.Close();
                }
            }
        }

//Crear Cuatrimestre Completo
        public static int CargarCuatrimestreCompleto(string periodo, string anio)
        {
            int count = 0;

            Dictionary<int, Asignatura> planDeEstudios = Repository.GetPlanDeEstudios();
            string codigoCuatrimestre = Repository.GetCuatrimestre(periodo, anio);

            foreach (Asignatura asignatura in planDeEstudios.Values)
            {
                string codigoMateria = Materia.Keygen(asignatura.CodigoGenerico, codigoCuatrimestre);
                count += CrearMateria(codigoMateria, asignatura.Codigo, codigoCuatrimestre);
            }

            return count;
        }

//Crear Materia
        public static int CrearMateria(string codigoAsignatura, string periodo, string anio)
        {
            int count = 0;

            if(int.TryParse(codigoAsignatura, out int codAsignatura))
            {
                string codigoCuatrimestre = Repository.GetCuatrimestre(periodo, anio);
                string? codigoGenerico = Repository.GetCodigoGenericoDeAsignatura(codAsignatura);
                string codigoMateria = Materia.Keygen(codigoGenerico, codigoCuatrimestre);

                count = CrearMateria(codigoMateria, codAsignatura, codigoCuatrimestre);
            }

            return count;
        }

        private static int CrearMateria(string codigoMateria, int codigoAsignatura, string codigoCuatrimestre)
        {
            int count = 0;

            try
            {
                connection.Open();

                if (Repository.DoesSubjectExist(codigoAsignatura) && !Repository.DoesCourseExist(codigoMateria))
                {
                    command.CommandText = "INSERT INTO Materias(codigo, idAsignatura, codigoCuatrimestre)" +
                                         $" VALUES ('{codigoMateria}', {codigoAsignatura}, '{codigoCuatrimestre}');";

                    command.ExecuteNonQuery();

                    if (Repository.DoesCourseExist(codigoMateria))
                    {
                        count = 1;
                    }
                }
            }
            catch
            {
                
            }
            finally
            {
                connection.Close();
            }

            return count;
        }

        //Crear Asignatura

        public static int CrearAsignatura(string codigoAsignatura, string titulo, string tituloCodificado)
        {
            int result = 0;

            try
            {
                connection.Open();

                if(int.TryParse(codigoAsignatura, out int codigo) && !Repository.DoesSubjectExist(codigo))
                {
                    command.CommandText = "INSERT INTO Asignaturas(codigo, codigoGenerico, titulo)" +
                                         $" VALUES({codigo}, '{tituloCodificado}', '{titulo}');";

                    command.ExecuteNonQuery();

                    if (Repository.DoesSubjectExist(codigo))
                    {
                        result = 1;
                    }
                }
            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }

            return result;
        }

        public static int CrearAsignatura(string codigoAsignatura, string titulo, string tituloCodificado, string codigoCorrelativa)
        {
            int count = CrearAsignatura(codigoAsignatura, titulo, tituloCodificado);

            if (count == 1)
            {
                AgregarCorrelativa(codigoAsignatura, codigoCorrelativa);
            }

            return count;
        }

        public static int CrearAsignatura(string codigoAsignatura, string titulo, string tituloCodificado, string codigoCorrelativa1, string codigoCorrelativa2)
        {
            int count = CrearAsignatura(codigoAsignatura, titulo, tituloCodificado, codigoCorrelativa1);

            if (count == 1)
            {
                AgregarCorrelativa(codigoAsignatura, codigoCorrelativa2);
            }

            return count;
        }

        public static int CrearAsignatura(string codigoAsignatura, string titulo, string tituloCodificado, string codigoCorrelativa1, string codigoCorrelativa2, string codigoCorrelativa3)
        {
            int count = CrearAsignatura(codigoAsignatura, titulo, tituloCodificado, codigoCorrelativa1, codigoCorrelativa2);

            if (count == 1)
            {
                AgregarCorrelativa(codigoAsignatura, codigoCorrelativa3);
            }

            return count;
        }

        
        private static void AgregarCorrelativa(string codigoAsignatura, string codigoCorrelativa)
        {
            try
            {
                connection.Open();

                if (int.TryParse(codigoAsignatura, out int codAsignatura) && int.TryParse(codigoCorrelativa, out int codCorrelativa)
                    && Repository.DoesSubjectExist(codAsignatura) && Repository.DoesSubjectExist(codCorrelativa) && !Repository.DoesCorrelativityExist(codAsignatura, codCorrelativa))
                {
                    command.CommandText = "INSERT INTO Correlativas(codigoAsignatura, codigoCorrelativa)" +
                                         $" VALUES({codAsignatura}, {codCorrelativa});";

                    command.ExecuteNonQuery();
                }
            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }
        }


        //Crear Usuario
        public static int CrearUsuario(string username, string password, string credencial, string nombre, string apellido, int dni, string genero)
        {
            int result = 0;

            try
            {
                connection.Open();

                if (credencial.Equals("Admin"))
                {
                    command.CommandText = "INSERT INTO Usuarios (username, password, credencial)" +
                                          $" VALUES ('{username.ToLower()}', '{password}', '{credencial}');";
                }
                else
                {
                    command.CommandText = "INSERT INTO Usuarios (nombre, apellido, dni, genero, username, password, credencial)" +
                                          $" VALUES ('{nombre}', '{apellido}', {dni}, '{genero}', '{username.ToLower()}', '{password}', '{credencial}');";
                }

                command.ExecuteNonQuery();

                if (Repository.DoesUserExist(username.ToLower()))
                {
                    result = 1;
                }
            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }

            return result;
        }


//FUNCIONES DOCENTE
        public static void CrearExamen(string codigoMateria, int idDocente, string tipoExamen, string fecha)
        {
            if (Repository.DoesCourseExist(codigoMateria) && Repository.DoesUserExist(idDocente, "Docente"))
            {
                try
                {
                    connection.Open();

                    if (!Repository.IsExamCreated(codigoMateria, tipoExamen))
                    {
                        command.CommandText =  "INSERT INTO Examenes(tipo, fecha, idMateria)"+
                                              $" VALUES ('{tipoExamen}', '{fecha}', '{codigoMateria}');";
                    }
                    else
                    {
                        command.CommandText = $"UPDATE Examenes SET fecha = '{fecha}' WHERE tipo = '{tipoExamen}' AND idMateria = '{codigoMateria}'";
                    }

                    command.ExecuteNonQuery();
                }
                catch
                {

                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public static void Calificar(string codigoMateria, int idEstudiante, int nota, ETipoExamen tipoExamen)
        {
            if (Repository.DoesCourseExist(codigoMateria) && Repository.DoesUserExist(idEstudiante, "Estudiante"))
            {
                try
                {
                    connection.Open();

                    string parcial = (tipoExamen == ETipoExamen.PrimerParcial) ? "notaPrimerParcial" : "notaSegundoParcial";
                    command.CommandText = $"UPDATE Inscripciones SET {parcial} = {nota} WHERE idEstudiante = {idEstudiante} AND idMateria = '{codigoMateria}'";

                    command.ExecuteNonQuery();
                }
                catch
                {

                }
                finally
                {
                    connection.Close();
                }
            }
        }


//FUNCIONES ESTUDIANTE
        public static void InscribirEstudiante(string codigoMateria, Estudiante e)
        {
            if (Repository.DoesCourseExist(codigoMateria) && Repository.DoesUserExist(e.Id, "Estudiante") && e.MateriasInscripto.Count() < Estudiante.MaxInscripcionesPermitidas)
            {
                try
                {
                    connection.Open();

                    command.CommandText = "INSERT INTO Inscripciones(idEstudiante, idMateria, condicion, asistencia)" +
                                         $" VALUES({e.Id},'{codigoMateria}','Regular', 0);";

                    command.ExecuteNonQuery();
                }
                catch
                {

                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public static void DarAsistencia(string codigoMateria, int idEstudiante)
        {
            if (Repository.DoesCourseExist(codigoMateria) && Repository.DoesUserExist(idEstudiante, "Estudiante"))
            {
                try
                {
                    connection.Open();

                    command.CommandText = $"UPDATE Inscripciones SET asistencia = 1 WHERE idEstudiante = {idEstudiante} AND idMateria = '{codigoMateria}';";

                    command.ExecuteNonQuery();
                }
                catch
                {

                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}
