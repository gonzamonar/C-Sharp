using Domain;
using Model;
using Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    [TestClass]
    public class UT_Repository
    {
//DoesUserExist
        [TestMethod]
        public void DoesUserExist_WhenReceivesValidUsername_ShouldReturnTrue() //TEST Existing username = true
        {
            //Arrange
            string username = "aturing";
            bool expected = true;

            //Act
            bool actual = Repository.DoesUserExist(username);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DoesUserExist_WhenReceivesInvalidUsername_ShouldReturnFalse() //TEST Non-Existing username = false
        {
            //Arrange
            bool expected = false;

            //Act
            bool actual = Repository.DoesUserExist("InvalidUsername");

            //Assert
            Assert.AreEqual(expected, actual);
        }

//DoesUserExist with Credential
        [TestMethod]
        public void DoesUserExistType_WhenReceivesValidUsernameAndMatchingType_ShouldReturnTrue()
        {
            //Arrange
            string username = "root";
            bool expected = true;

            //Act
            bool actual = Repository.DoesUserExist(username, "Admin");

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DoesUserExistType_WhenReceivesValidUsernameAndUnmatchingType_ShouldReturnFalse()
        {
            //Arrange
            string username = "root";
            bool expected = false;

            //Act
            bool actual = Repository.DoesUserExist(username, "Docente");

            //Assert
            Assert.AreEqual(expected, actual);
        }


//Get Plan de Estudios

        [TestMethod]
        public void GetPlanDeEstudios_WhenDictionaryEntriesAreCountedAndCompared_ShouldReturnTrue()
        {
            //Arrange
            Dictionary<int, Asignatura> planDeEstudios = Repository.GetPlanDeEstudios();
            int expected = Repository.ContarAsignaturasCargadas();

            //Act
            int actual = planDeEstudios.Values.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void GetMateria_WhenReceivesAValidCode_ShouldReturnNotNull()
        {
            //Arrange
            //Materia? m = Repository.GetMateria("Laboratorio1_2C2022");
            Materia? m = Repository.GetMateria("Laboratorio1_2C2022");

            //Assert
            Assert.IsNotNull(m);
        }

        [TestMethod]
        public void GetMateria_WhenReceivesAnInvalidCode_ShouldReturnNull()
        {
            //Arrange
            Materia? m = Repository.GetMateria("Laboratorio1_1C1602");

            //Assert
            Assert.IsNull(m);
        }


        [TestMethod]
        public void GetUser_WhenReceivesAnInvalidId_ShouldReturnNull()
        {
            //Arrange
            Usuario? u = Repository.GetUser(15005);

            //Assert
            Assert.IsNull(u);
        }

        [TestMethod]
        public void GetUser_WhenReceivesAValidId_ShouldReturnNotNull()
        {
            //Arrange
            Usuario? u = Repository.GetUser(57);

            //Assert
            Assert.IsNotNull(u);
        }


        [TestMethod]
        public void GetAsignatura_WhenReceivesAValidCode_ShouldReturnNotNull()
        {
            //Arrange
            Asignatura? a = Repository.GetAsignatura(1124);

            //Assert
            Assert.IsNotNull(a);
        }

        [TestMethod]
        public void GetAsignatura_WhenReceivesAnInvalidCode_ShouldReturnNull()
        {
            //Arrange
            Asignatura? a = Repository.GetAsignatura(600);

            //Assert
            Assert.IsNull(a);
        }

        [TestMethod]
        public void GetCuatrimestre_WhenReceivesAValidCode_ShouldReturnNotNull()
        {
            //Arrange
            Cuatrimestre? c = Repository.GetCuatrimestre("2C2022");

            //Assert
            Assert.IsNotNull(c);
        }



        [TestMethod]
        public void GetCuatrimestre_WhenReceivesAnInvalidCode_ShouldReturnNull()
        {
            //Arrange
            Cuatrimestre? c = Repository.GetCuatrimestre("1C1690");

            //Assert
            Assert.IsNull(c);
        }


//Get Enrolled Id List

        [TestMethod]
        public void GetEnrolledStudentsIdList_WhenEntriesAreCountedAndCompared_ShouldReturnTrue()
        {
            //Arrange
            List<int> listId = Repository.GetEnrolledStudentsIdList("Programacion1_2C2022");
            int expected = 10;

            //Act
            int actual = listId.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetEnrolledStudentsIdList_WhenCheckIfContainsValidEntry_ShouldReturnTrue()
        {
            //Arrange
            List<int> listId = Repository.GetEnrolledStudentsIdList("Programacion1_2C2022");
            bool expected = true;

            //Act
            bool actual = listId.Contains(70);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
