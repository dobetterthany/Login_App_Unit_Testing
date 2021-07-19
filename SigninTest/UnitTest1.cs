using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StartPage;

namespace SigninTest
{
    [TestClass]
    public class SigninTest
    {
        [TestMethod]
        public void TC_Signin_001()
        {
            //Arrange
            string Username = "Joseph";
            string Password = "01qwertyu";
            string Credential = "Admin";
            string expected = "Signin Successfully!";
            var Signin = new Signin();

            //Act
            Signin.validation(Username, Password, Credential);

            //Assert
            
            Assert.AreEqual(expected,Signin.validation(Username, Password, Credential));
        }
        [TestMethod]
        public void TC_Signin_002()
        {
            //Arrange
            string Username = "Joseph";
            string Password = "qwertyu";
            string Credential = "Admin";
            string expected = "Sign in Failed. Please check what is wrong";
            var Signin = new Signin();

            //Act
            Signin.validation(Username, Password, Credential);

            //Assert
            Assert.AreEqual(expected, Signin.validation(Username, Password, Credential));
        }

        [TestMethod]
        public void TC_Signin_003()
        {
            //Arrange
            string Username = "Joseph";
            string Password = "1234aa";
            string Credential = "Admin";
            string expected = "Sign in Failed. Please check what is wrong";
            var Signin = new Signin();

            //Act
            Signin.validation(Username, Password, Credential);

            //Assert
            Assert.AreEqual(expected, Signin.validation(Username, Password, Credential));
        }
        [TestMethod]
        public void TC_Signin_004()
        {
            //Arrange
            string Username = "Joseph";
            string Password = "qwerty";
            string Credential = "Admin";
            string expected = "Sign in Failed. Please check what is wrong";
            var Signin = new Signin();

            //Act
            Signin.validation(Username, Password, Credential);

            //Assert
            Assert.AreEqual(expected, Signin.validation(Username, Password, Credential));
        }
        [TestMethod]
        public void TC_Signin_005()
        {
            //Arrange
            string Username = "Admin1";
            string Password = "1qwertyu";
            string Credential = "Admin";
            string expected = "Sign in Failed. Please check what is wrong";
            var Signin = new Signin();

            //Act
            Signin.validation(Username, Password, Credential);

            //Assert
            Assert.AreEqual(expected, Signin.validation(Username, Password, Credential));
        }
        [TestMethod]
        public void TC_Signin_006()
        {
            //Arrange
            string Username = "Admin1";
            string Password = "qwertyuio";
            string Credential = "Admin";
            string expected = "Sign in Failed. Please check what is wrong";
            var Signin = new Signin();

            //Act
            Signin.validation(Username, Password, Credential);

            //Assert
            Assert.AreEqual(expected, Signin.validation(Username, Password, Credential));
        }
        [TestMethod]
        public void TC_Signin_007()
        {
            //Arrange
            string Username = "Admin1";
            string Password = "qwert12";
            string Credential = "Admin";
            string expected = "Sign in Failed. Please check what is wrong";
            var Signin = new Signin();

            //Act
            Signin.validation(Username, Password, Credential);

            //Assert
            Assert.AreEqual(expected, Signin.validation(Username, Password, Credential));
        }
        [TestMethod]
        public void TC_Signin_008()
        {
            //Arrange
            string Username = "Admin1";
            string Password = "aaaa";
            string Credential = "Admin";
            string expected = "Sign in Failed. Please check what is wrong";
            var Signin = new Signin();

            //Act
            Signin.validation(Username, Password, Credential);

            //Assert
            Assert.AreEqual(expected, Signin.validation(Username, Password, Credential));
        }
        [TestMethod]
        public void TC_Signin_009()
        {
            //Arrange
            string Username = "";
            string Password = "123456aa";
            string Credential = "Admin";
            string expected = "Sign in Failed. Please check what is wrong";
            var Signin = new Signin();

            //Act
            Signin.validation(Username, Password, Credential);

            //Assert
            Assert.AreEqual(expected, Signin.validation(Username, Password, Credential));
        }
        [TestMethod]
        public void TC_Signin_010()
        {
            //Arrange
            string Username = "";
            string Password = "qwertyuio";
            string Credential = "Admin";
            string expected = "Sign in Failed. Please check what is wrong";
            var Signin = new Signin();

            //Act
            Signin.validation(Username, Password, Credential);

            //Assert
            Assert.AreEqual(expected, Signin.validation(Username, Password, Credential));
        }
        [TestMethod]
        public void TC_Signin_011()
        {
            //Arrange
            string Username = "Joseph";
            string Password = "1234aa";
            string Credential = "Admin";
            string expected = "Sign in Failed. Please check what is wrong";
            var Signin = new Signin();

            //Act
            Signin.validation(Username, Password, Credential);

            //Assert
            Assert.AreEqual(expected, Signin.validation(Username, Password, Credential));
        }
        [TestMethod]
        public void TC_Signin_012()
        {
            //Arrange
            string Username = "Jacob";
            string Password = "";
            string Credential = "Admin";
            string expected = "Sign in Failed. Please check what is wrong";
            var Signin = new Signin();

            //Act
            Signin.validation(Username, Password, Credential);

            //Assert
            Assert.AreEqual(expected, Signin.validation(Username, Password, Credential));
        }
        [TestMethod]
        public void TC_Signin_013()
        {
            //Arrange
            string Username = "";
            string Password = "";
            string Credential = "Admin";
            string expected = "Sign in Failed. Please check what is wrong";
            var Signin = new Signin();

            //Act
            Signin.validation(Username, Password, Credential);

            //Assert
            Assert.AreEqual(expected, Signin.validation(Username, Password, Credential));
        }

    }
}
