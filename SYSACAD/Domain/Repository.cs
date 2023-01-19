using Model;
using Model.Enums;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.Json;

namespace Domain
{
    public sealed partial class Repository
    {
        static string connectionString;
        static SqlCommand command;
        static SqlConnection connection;

        static Repository()
        {
            connectionString = @"Data Source=.; Initial Catalog=parcial_dos; Integrated Security=True";
            command = new SqlCommand();
            connection = new SqlConnection(connectionString);
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
        }

//Database Getters

        //USUARIOS
        public static Usuario? GetUser(string username)
        {
            Usuario? usuario = null;

            try
            {
                connection.Open();
                command.CommandText = $"(SELECT * FROM Usuarios WHERE Usuarios.username = '{username}')";
                SqlDataReader dataReader = command.ExecuteReader();                

                while (dataReader.Read())
                {
                    switch (dataReader["credencial"].ToString())
                    {
                        case "Admin":
                            usuario = new Admin(dataReader["id"].ToString(), dataReader["username"].ToString(), dataReader["password"].ToString(), EPermiso.Admin);
                            break;
                        case "Docente":
                            usuario = new Profesor(dataReader["id"].ToString(), dataReader["nombre"].ToString(), dataReader["apellido"].ToString(), dataReader["dni"].ToString(), dataReader["genero"].ToString(), dataReader["username"].ToString(), dataReader["password"].ToString(), EPermiso.Docente);
                            break;
                        case "Estudiante":
                            usuario = new Estudiante(dataReader["id"].ToString(), dataReader["nombre"].ToString(), dataReader["apellido"].ToString(), dataReader["dni"].ToString(), dataReader["genero"].ToString(), dataReader["username"].ToString(), dataReader["password"].ToString(), EPermiso.Estudiante);
                            break;
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

            return usuario;
        }

        public static Usuario? GetUser(int id)
        {
            Usuario? usuario = null;

            try
            {
                connection.Open();
                command.CommandText = $"(SELECT * FROM Usuarios WHERE Usuarios.id = {id})";
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    switch (dataReader["credencial"].ToString())
                    {
                        case "Admin":
                            usuario = new Admin(dataReader["id"].ToString(), dataReader["username"].ToString(), dataReader["password"].ToString(), EPermiso.Admin);
                            break;
                        case "Docente":
                            usuario = new Profesor(dataReader["id"].ToString(), dataReader["nombre"].ToString(), dataReader["apellido"].ToString(), dataReader["dni"].ToString(), dataReader["genero"].ToString(), dataReader["username"].ToString(), dataReader["password"].ToString(), EPermiso.Docente);
                            break;
                        case "Estudiante":
                            usuario = new Estudiante(dataReader["id"].ToString(), dataReader["nombre"].ToString(), dataReader["apellido"].ToString(), dataReader["dni"].ToString(), dataReader["genero"].ToString(), dataReader["username"].ToString(), dataReader["password"].ToString(), EPermiso.Estudiante);
                            break;
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

            return usuario;
        }


        //ASIGNATURAS
        public static Dictionary<int, Asignatura> GetPlanDeEstudios()
        {
            Dictionary<int, Asignatura> planDeEstudios = new Dictionary<int, Asignatura>();

            try
            {
                connection.Open();
                command.CommandText = "SELECT * FROM Asignaturas";

                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    string? codigoGenerico = dataReader["codigoGenerico"].ToString();
                    string? titulo = dataReader["titulo"].ToString();

                    if (int.TryParse(dataReader["codigo"].ToString(), out int codigo) && codigoGenerico is not null && titulo is not null)
                    {
                        planDeEstudios.Add(codigo, new Asignatura(codigo, codigoGenerico, titulo));
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

            return planDeEstudios;
        }

        public static int CargarCorrelativas(Dictionary<int, Asignatura> planDeEstudios)
        {
            int cargasRealizadas = 0;

            try
            {
                connection.Open();
                command.CommandText = "SELECT * FROM Correlativas";

                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    if(int.TryParse(dataReader["codigoAsignatura"].ToString(), out int codigoAsignatura) && int.TryParse(dataReader["codigoCorrelativa"].ToString(), out int codigoCorrelativa)
                        && planDeEstudios.ContainsKey(codigoAsignatura) && planDeEstudios.ContainsKey(codigoCorrelativa))
                    {
                        Asignatura asignatura = planDeEstudios[codigoAsignatura];
                        Asignatura correlativa = planDeEstudios[codigoCorrelativa];

                        if (!asignatura.Correlativas.Contains(correlativa))
                        {
                            asignatura.Correlativas.Add(correlativa);
                            cargasRealizadas++;
                        }
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

            return (cargasRealizadas == ContarCorrelatividadesCargadas())? 1 : 0 ;
        }

        public static int ContarCorrelatividadesCargadas()
        {
            int count = 0;

            try
            {
                StringBuilder sb = new StringBuilder();
                
                connection.Open();
                command.CommandText = "SELECT COUNT(*) FROM Correlativas";

                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    sb.Append(dataReader[0].ToString());
                }

                int.TryParse(sb.ToString(), out count);
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

        public static int ContarAsignaturasCargadas()
        {
            int count = 0;

            try
            {
                StringBuilder sb = new StringBuilder();

                connection.Open();
                command.CommandText = "SELECT COUNT(*) FROM Asignaturas";

                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    sb.Append(dataReader[0].ToString());
                }

                int.TryParse(sb.ToString(), out count);
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


        public static string? GetCodigoGenericoDeAsignatura(int codigoAsignatura)
        {            
            string? codigoGenerico = null;

            try
            {
                connection.Open();
                command.CommandText = $"SELECT codigoGenerico FROM Asignaturas WHERE codigo = {codigoAsignatura};";

                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    codigoGenerico = dataReader[0].ToString();
                }
            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }

            return codigoGenerico;
        }

        public static Asignatura? GetAsignatura(int codigoAsignatura)
        {
            Asignatura? asignatura = null;

            try
            {
                connection.Open();
                command.CommandText = $"SELECT a.codigoGenerico [CodigoGenerico], a.titulo [Titulo] FROM Asignaturas a WHERE a.codigo = {codigoAsignatura};";

                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    string? codigoGenerico = dataReader["CodigoGenerico"].ToString();
                    string? titulo = dataReader["Titulo"].ToString();

                    if(codigoGenerico is not null && titulo is not null)
                    {
                        asignatura = new Asignatura(codigoAsignatura, codigoGenerico, titulo);
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

            return asignatura;
        }

        //MATERIAS

        public static Materia? GetMateria(string codigoMateria)
        {
            Materia? materia = null;
            StringBuilder codigoAsignatura = new StringBuilder();
            StringBuilder codigoCuatrimestre = new StringBuilder();

            try
            {
                connection.Open();
                command.CommandText = $"SELECT m.codigo[Codigo], m.idAsignatura[CodigoAsignatura], m.codigoCuatrimestre[Cuatrimestre] FROM Materias m WHERE m.codigo = '{codigoMateria}';";
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    codigoAsignatura.Append(dataReader["CodigoAsignatura"].ToString());
                    codigoCuatrimestre.Append(dataReader["Cuatrimestre"].ToString());
                }
            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }

            if (codigoCuatrimestre is not null && int.TryParse(codigoAsignatura.ToString(), out int codigo))
            {
                Asignatura a = GetAsignatura(codigo);
                Cuatrimestre c = GetCuatrimestre(codigoCuatrimestre.ToString());

                materia = new Materia(a, c);
            }

            return materia;
        }

        public static Cuatrimestre? GetCuatrimestre(string codigoCuatrimestre)
        {
            Cuatrimestre? cuatrimestre = null;

            try
            {
                connection.Open();
                command.CommandText = $"SELECT * FROM Cuatrimestres WHERE Cuatrimestres.codigo = '{codigoCuatrimestre}';";

                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    string? periodo = dataReader["periodo"].ToString();
                    string? anio = dataReader["anio"].ToString();

                    if (periodo is not null && int.TryParse(anio, out int year))
                    {
                        ECuatrimestre cuatri = Cuatrimestre.ParseECuatrimestre(periodo);
                        cuatrimestre = new Cuatrimestre(cuatri, year);
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

            return cuatrimestre;
        }


        //Get Cuatrimestre
        public static string GetCuatrimestre(string periodo, string anio)
        {
            string code = Cuatrimestre.Keygen(periodo, anio);

            if (!DoesCuatrimestreExist(code) && int.TryParse(anio, out int year))
            {
                CrearCuatrimestre(code, periodo, year);
            }

            return code;
        }
        
        private static void CrearCuatrimestre(string codigo, string periodo, int anio)
        {
            try
            {
                connection.Open();

                command.CommandText = "INSERT INTO Cuatrimestres(codigo, periodo, anio)" +
                                        $" VALUES('{codigo}', '{periodo}', {anio});";

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


        public static void CargarMateriasInscripto(Estudiante estudiante)
        {
            List<string> materias = new List<string>();

            try
            {
                connection.Open();
                command.CommandText = $"SELECT i.idMateria [idMateria] FROM Inscripciones AS i WHERE idEstudiante = {estudiante.Id};";

                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    materias.Add(dataReader[0].ToString());
                }
            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }

            foreach (string str in materias)
            {
                Materia m = GetMateria(str);
                estudiante.MateriasInscripto.Add(m);
            }
        }
        
        public static string CrearArchivoCSV(string codigoMateria)
        {
            StringBuilder sb = new StringBuilder();

            if (DoesCourseExist(codigoMateria))
            {
                try
                {
                    connection.Open();
                    command.CommandText = "SELECT u.id[ID], u.username[Usuario], u.nombre[Nombre], u.apellido[Apellido], u.dni[DNI], u.genero[Género], i.condicion[Condición]," +
                                           " i.notaPrimerParcial[Nota Primer Parcial], i.notaSegundoParcial[Nota Segundo Parcial] FROM Inscripciones i" +
                                           " INNER JOIN Usuarios u ON u.id = i.idEstudiante" +
                                          $" WHERE i.idMateria = '{codigoMateria}';";

                    SqlDataReader dataReader = command.ExecuteReader();

                    sb.AppendLine("ID,Usuario,Nombre,Apellido,DNI,Género,Condición,Nota Primer Parcial,Nota Segundo Parcial");

                    while (dataReader.Read())
                    {
                        sb.AppendLine($"{dataReader[0].ToString()},{dataReader[1].ToString()},{dataReader[2].ToString()},{dataReader[3].ToString()},{dataReader[4].ToString()}," +
                                      $"{dataReader[5].ToString()},{dataReader[6].ToString()},{dataReader[7].ToString()},{dataReader[8].ToString()}");
                    }
                }
                catch
                {
                    throw new Exception();
                }
                finally
                {
                    connection.Close();
                }
            }

            return sb.ToString();
        }

        public static string CrearArchivoJSON(string codigoMateria)
        {
            string JSON = null;

            if (DoesCourseExist(codigoMateria))
            {
                try
                {
                    List<Estudiante> estudiantes = new List<Estudiante>();
                    List<int> idList = GetEnrolledStudentsIdList(codigoMateria);

                    foreach (int id in idList)
                    {
                        Estudiante e = (Estudiante) GetUser(id);
                        estudiantes.Add(e);
                    }

                    JSON = Serialize.SerializarAJson(estudiantes);
                }
                catch
                {
                    throw new Exception();
                }
            }
            return JSON;
        }

        public static List<int> GetEnrolledStudentsIdList(string codigoMateria)
        {
            List<int> idList = new List<int>();

            if (DoesCourseExist(codigoMateria))
            {
                try
                {
                    connection.Open();
                    command.CommandText = $"SELECT i.idEstudiante FROM Inscripciones i WHERE i.idMateria = '{codigoMateria}';";

                    SqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        if(int.TryParse(dataReader[0].ToString(), out int id))
                        {
                            idList.Add(id);
                        }
                    }
                }
                catch
                {
                    throw new Exception();
                }
                finally
                {
                    connection.Close();
                }
            }

            return idList;
        }
    }
}
