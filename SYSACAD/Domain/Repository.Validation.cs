using Model;
using System.Data.SqlClient;
using System.Text;

namespace Domain
{
    public sealed partial class Repository
    {
        //** REPOSITORY INFO & VALIDATION **//

//USUARIOS
        public static bool DoesUserExist(string username)
        {
            return string.Equals(VerifyUsername(username.ToLower()), "1");
        }

        public static bool DoesUserExist(int id)
        {
            return string.Equals(VerifyUserId(id), "1");
        }

        private static string VerifyUsername(string username)
        {
            StringBuilder sb = new StringBuilder();

            try
            {
                connection.Open();
                command.CommandText = $"(SELECT 1 FROM Usuarios WHERE Usuarios.username = '{username}')";
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    sb.Append(dataReader[0].ToString());
                }
            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }

            return sb.ToString();
        }

        private static string VerifyUserId(int id)
        {
            StringBuilder sb = new StringBuilder();

            try
            {
                connection.Open();
                command.CommandText = $"(SELECT 1 FROM Usuarios WHERE Usuarios.id = '{id}')";
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    sb.Append(dataReader[0].ToString());
                }
            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }

            return sb.ToString();
        }

        public static bool IsUsernameAvailable(string username)
        {
            return !DoesUserExist(username);
        }

        public static bool DoesUserExist(string username, string credential)
        {
            return string.Equals(VerifyCredential(username.ToLower(), credential), "1");
        }

        public static bool DoesUserExist(int userId, string credential)
        {
            return string.Equals(VerifyCredential(userId, credential), "1");
        }

        private static string VerifyCredential(string username, string credential)
        {
            StringBuilder sb = new StringBuilder();

            try
            {
                connection.Open();
                command.CommandText = $"(SELECT 1 FROM Usuarios WHERE Usuarios.username = '{username}' AND Usuarios.credencial = '{credential}')";
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    sb.Append(dataReader[0].ToString());
                }
            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }

            return sb.ToString();
        }

        private static string VerifyCredential(int userId, string credential)
        {
            StringBuilder sb = new StringBuilder();

            try
            {
                connection.Open();
                command.CommandText = $"(SELECT 1 FROM Usuarios WHERE Usuarios.id = {userId} AND Usuarios.credencial = '{credential}')";
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    sb.Append(dataReader[0].ToString());
                }
            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }

            return sb.ToString();
        }



        //MATERIAS
        public static bool DoesCourseExist(string codigoMateria)
        {
            return string.Equals(VerifyCourseExistance(codigoMateria), "1");
        }

        private static string VerifyCourseExistance(string codigoMateria)
        {
            StringBuilder sb = new StringBuilder();

            try
            {
                connection.Open();
                command.CommandText = $"(SELECT 1 FROM Materias WHERE Materias.codigo = '{codigoMateria}')";
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    sb.Append(dataReader[0].ToString());
                }
            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }

            return sb.ToString();
        }


        //ASIGNATURAS
        public static bool DoesSubjectExist(int codigoAsignatura)
        {
            return string.Equals(VerifySubjectExistance(codigoAsignatura), "1");
        }

        public static bool DoesSubjectExist(string codigoAsignatura)
        {
            bool exists = false;
            if (int.TryParse(codigoAsignatura, out int codigo))
            {
                exists = DoesSubjectExist(codigo);
            }
            return exists;
        }

        private static string VerifySubjectExistance(int codigoAsignatura)
        {
            StringBuilder sb = new StringBuilder();

            try
            {
                connection.Open();
                command.CommandText = $"(SELECT 1 FROM Asignaturas WHERE Asignaturas.codigo = {codigoAsignatura})";
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    sb.Append(dataReader[0].ToString());
                }
            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }

            return sb.ToString();
        }


        public static bool DoesCorrelativityExist(int codigoAsignatura, int codigoCorrelativa)
        {
            return string.Equals(VerifyCorrelativityExistance(codigoAsignatura, codigoCorrelativa), "1");
        }

        private static string VerifyCorrelativityExistance(int codigoAsignatura, int codigoCorrelativa)
        {
            StringBuilder sb = new StringBuilder();

            try
            {
                connection.Open();
                command.CommandText = $"(SELECT 1 FROM Correlativas c WHERE c.codigoAsignatura = {codigoAsignatura} AND c.codigoCorrelativa = {codigoCorrelativa});";
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    sb.Append(dataReader[0].ToString());
                }
            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }

            return sb.ToString();
        }



        public static bool IsSubjectTitleUsed(string title)
        {
            bool isCurrentlyUsed = false;
            if (title is not null)
            {
                Dictionary<int, Asignatura> planDeEstudios = GetPlanDeEstudios();
                foreach (Asignatura a in planDeEstudios.Values)
                {
                    if (a.Titulo == title)
                    {
                        isCurrentlyUsed = true;
                        break;
                    }
                }
            }
            return isCurrentlyUsed;
        }

        public static bool IsSubjectCodedTitleUsed(string codedTitle)
        {
            bool isCurrentlyUsed = false;
            if (codedTitle is not null)
            {
                Dictionary<int, Asignatura> planDeEstudios = GetPlanDeEstudios();
                foreach (Asignatura a in planDeEstudios.Values)
                {
                    if (a.CodigoGenerico == codedTitle)
                    {
                        isCurrentlyUsed = true;
                        break;
                    }
                }
            }
            return isCurrentlyUsed;
        }


        public static bool DoesCuatrimestreExist(string codigoCuatrimestre)
        {
            return string.Equals(VerifyCuatrimestreExistance(codigoCuatrimestre), "1");
        }

        private static string VerifyCuatrimestreExistance(string codigoCuatrimestre)
        {
            StringBuilder sb = new StringBuilder();

            try
            {
                connection.Open();
                command.CommandText = $"(SELECT 1 FROM Cuatrimestres WHERE Cuatrimestres.codigo = '{codigoCuatrimestre}');";
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    sb.Append(dataReader[0].ToString());
                }
            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }

            return sb.ToString();
        }


        //EXAMENES

        public static bool IsExamCreated(string codigoMateria, string tipoExamen)
        {
            return string.Equals(VerifyExamExistance(codigoMateria, tipoExamen), "1");
        }

        private static string VerifyExamExistance(string codigoMateria, string tipoExamen)
        {
            StringBuilder sb = new StringBuilder();

            try
            {
                connection.Open();
                command.CommandText = $"(SELECT 1 FROM Examenes WHERE Examenes.idMateria = '{codigoMateria}' AND Examenes.tipo = '{tipoExamen}');";
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    sb.Append(dataReader[0].ToString());
                }
            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }

            return sb.ToString();
        }

        public static string GetExamDate(string codigoMateria, string tipoExamen)
        {
            StringBuilder sb = new StringBuilder();

            try
            {
                connection.Open();
                command.CommandText = $"SELECT convert(varchar(10), Examenes.fecha, 120)[Fecha] FROM Examenes WHERE Examenes.idMateria = '{codigoMateria}' AND Examenes.tipo = '{tipoExamen}';";
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    sb.Append(dataReader[0].ToString());
                }
            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }

            return sb.ToString();
        }

        public static bool IsCourseEmpty(string codigoMateria)
        {
            return !string.Equals(VerifyIfHasEnrollements(codigoMateria), "1");
        }

        private static string VerifyIfHasEnrollements(string codigoMateria)
        {
            StringBuilder sb = new StringBuilder();

            try
            {
                connection.Open();
                command.CommandText = $"SELECT DISTINCT 1 FROM Inscripciones WHERE Inscripciones.idMateria = '{codigoMateria}';";
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    sb.Append(dataReader[0].ToString());
                }
            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }

            return sb.ToString();
        }
    }
}
