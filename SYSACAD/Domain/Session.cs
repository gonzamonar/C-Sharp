using Model;
using Model.Enums;

namespace Domain
{
    public static class Session
    {
        private static Usuario?    loggedUser;
        private static Admin?      loggedAdmin;
        private static Profesor?   loggedProfessor;
        private static Estudiante? loggedStudent;

        public static Usuario?    LoggedUser      { get { return loggedUser; }}
        public static Admin?      LoggedAdmin     { get { return loggedAdmin; } }
        public static Profesor?   LoggedProfessor { get { return loggedProfessor; } }
        public static Estudiante? LoggedStudent   { get { return loggedStudent; } }


        public static int Login(string username, string password)
        {
            int result = -1;

            if (Repository.DoesUserExist(username.ToLower()))
            {
                result = 0;
                loggedUser = Repository.GetUser(username.ToLower());

                if (loggedUser.CheckPassword(password))
                {
                    result = 1;
                    CreateSession(loggedUser);
                }
            }
            return result;
        }

        public static void Logout()
        {
            switch (SessionAccessLevel())
            {
                case 1:
                    loggedAdmin = null;
                    break;
                case 2:
                    loggedProfessor = null;
                    break;
                case 3:
                    loggedStudent = null;
                    break;
            }
            loggedUser = null;
        }

        private static int SessionAccessLevel()
        {
            int level = 0;
            if(loggedUser is not null)
            {
                level = (int) loggedUser.Credencial;
            }
            return level;
        }
        
        private static void CreateSession(Usuario user)
        {
            loggedUser = user;
            switch (SessionAccessLevel())
            {
                case 1:
                    loggedAdmin = (Admin) loggedUser;
                    break;
                case 2:
                    loggedProfessor = (Profesor) loggedUser;
                    break;
                case 3:
                    loggedStudent = (Estudiante) loggedUser;
                    break;
            }
        }


//Session Info
        public static bool IsSessionActive()
        {
            return LoggedUser is not null;
        }

        public static bool IsAnAdminSession()
        {
            return LoggedAdmin is not null;
        }

        public static bool IsAProfSession()
        {
            return LoggedProfessor is not null;
        }

        public static bool IsAStudentSession()
        {
            return LoggedStudent is not null;
        }

        public static EGenero GetUserGender()
        {
            EGenero gender = EGenero.O;
            if (!IsAnAdminSession())
            {
                int sessionType = SessionAccessLevel();
                if (LoggedProfessor is not null && sessionType == 2)
                {
                    gender = LoggedProfessor.Genero;
                }
                else if (LoggedStudent is not null && sessionType == 3)
                {
                    gender = LoggedStudent.Genero;
                }
            }
            return gender;
        }
    }
}
