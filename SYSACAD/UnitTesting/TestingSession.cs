using Domain;
using Model.Enums;
using Model;

namespace UnitTesting
{
    [TestClass]
    public class UT_Session
    {
//Login
        [TestMethod]
        public void Login_WhenReceivesInvalidUsername_ShouldReturnNegativeOne() //TEST Invalid User = -1
        {
            //Arrange
            const int expected = -1;

            //Act
            int actual = Session.Login("wrongUser", "wrongPwd");

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Login_WhenReceivesValidUsernameAndWrongPwd_ShouldReturnZero() //TEST Invalid Password = 0
        {
            //Arrange
            string username = "root";
            const int expected = 0;

            //Act
            int actual = Session.Login(username, "wrongPassword");

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Login_WhenReceivesValidUsernameAndPwd_ShouldReturnOne() //TEST Invalid User = 1
        {
            //Arrange
            string username = "aturing";
            string password = "Laboratorio";
            const int expected = 1;

            //Act
            int actual = Session.Login(username, password);

            //Assert
            Assert.AreEqual(expected, actual);
        }


//IsSessionActive
        [TestMethod]
        public void IsSessionActive_BeforeLogin_ShouldReturnFalse()
        {
            //Arrange
            const bool expected = false;

            //Act
            bool actual = Session.IsSessionActive();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsSessionActive_AfterLogout_ShouldReturnFalse()
        {
            //Arrange
            string username = "aturing";
            string password = "Laboratorio";
            const bool expected = false;

            //Act
            Session.Login(username, password);
            Session.Logout();
            bool actual = Session.IsSessionActive();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsSessionActive_AfterLogin_ShouldReturnTrue()
        {
            //Arrange
            string username = "aturing";
            string password = "Laboratorio";
            const bool expected = true;

            //Act
            Session.Login(username, password);
            bool actual = Session.IsSessionActive();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsAnAdminSession_AfterAdminLogin_ShouldReturnTrue()
        {
            //Arrange
            string username = "root";
            string password = "r00t";
            const bool expected = true;

            //Act
            Session.Login(username, password);
            bool actual = Session.IsAnAdminSession();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsAProfSession_AfterProfessorLogin_ShouldReturnTrue()
        {
            //Arrange
            string username = "aturing";
            string password = "Laboratorio";
            const bool expected = true;

            //Act
            Session.Login(username, password);
            bool actual = Session.IsAProfSession();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsAStudentSession_AfterStudentLogin_ShouldReturnTrue()
        {
            //Arrange
            string username = "monroe26";
            string password = "7yearitch";
            const bool expected = true;

            //Act
            Session.Login(username, password);
            bool actual = Session.IsAStudentSession();

            //Assert
            Assert.AreEqual(expected, actual);
        }



        [TestMethod]
        public void GetUser_AfterStudentLogin_ShouldReturnAStudent()
        {
            //Arrange
            string username = "monroe26";
            const bool expected = true;

            //Act
            Usuario user = Repository.GetUser(username);

            //Assert
            bool actual = user.GetType().Equals(typeof(Estudiante));
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetUser_AfterProfessorLogin_ShouldReturnAProfesor()
        {
            //Arrange
            string username = "aturing";
            const bool expected = true;

            //Act
            Usuario user = Repository.GetUser(username);

            //Assert
            bool actual = user.GetType().Equals(typeof(Profesor));
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetUser_AfterAdminLogin_ShouldReturnAnAdmin()
        {
            //Arrange
            string username = "root";
            const bool expected = true;

            //Act
            Usuario user = Repository.GetUser(username);

            //Assert
            bool actual = user.GetType().Equals(typeof(Admin));
            Assert.AreEqual(expected, actual);
        }
    }
}