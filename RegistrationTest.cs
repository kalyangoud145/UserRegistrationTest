using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration;


namespace UserRegistrationMSTesting
{
    /// <summary>
    /// UserRegistration validation MSTesting 
    /// </summary>
    [TestClass]
    public class RegistrationTest
    {
        /// <summary>
        /// Opening pattern class of UserRegistration problem in readonly mode
        /// </summary>
        private readonly Pattern pattern;
        /// <summary>
        /// Initializes a new instance of the <see cref="RegistrationTest"/> class.
        /// </summary>
        public RegistrationTest()
        {
            pattern = new UserRegistration.Pattern();
        }
        ///Valid Test cases
        /// <summary>
        /// Given the user fist name on validation should return true.
        /// </summary>
        [TestMethod]
        public void GivenUserFistName_OnValidation_ShouldReturnTrue()
        {
            //Arrange
            string firstName = "Kalyan";
            //Act
            var result = pattern.ValidateName(firstName);
            //Assert
            Assert.IsTrue(result);
        }
        /// <summary>
        /// Given the user last name on validation should return true.
        /// </summary>
        [TestMethod]
        public void GivenUserLastName_OnValidation_ShouldReturnTrue()
        {
            //Arrange
            string lastName = "Ravula";
            //Act
            var result = pattern.ValidateName(lastName);
            //Assert
            Assert.IsTrue(result);
        }
        /// <summary>
        /// Given the user email id on validation should return true.
        /// </summary>
        [TestMethod]
        public void GivenUserEmailId_OnValidation_ShouldReturnTrue()
        {
            //Arrange
            string emailId = "kalyangoud145@gmail.com";
            //Act
            var result = pattern.ValidateEmail(emailId);
            //Assert
            Assert.IsTrue(result);
        }
        /// <summary>
        /// Given the user mobile number on validation should return true.
        /// </summary>
        [TestMethod]
        public void GivenUserMobileNumber_OnValidation_ShouldReturnTrue()
        {
            //Arrange
            string mobileNumber = "91 7732063720";
            //Act
            var result = pattern.ValidateMobileNumber(mobileNumber);
            //Assert
            Assert.IsTrue(result);
        }
        /// <summary>
        /// Given the user password on validation should return true.
        /// </summary>
        [TestMethod]
        public void GivenUserPassword_OnValidation_ShouldReturnTrue()
        {
            //Arrange
            string password = "Qwerty@1234";
            //Act
            var result = pattern.ValidatePassword(password);
            //Assert
            Assert.IsTrue(result);
        }
        /// <summary>
        /// parameterised Testing
        /// Given the list of user email ids on validation should return true.
        /// </summary>
        /// <param name="email">The email.</param>
        [TestMethod]
        [DataRow("abc@yahoo.com")]
        [DataRow("abc-100@yahoo.com")]
        [DataRow("abc.100@yahoo.com")]
        [DataRow("abc111@abc.com")]
        [DataRow("abc.100@abc.com.au")]
        [DataRow("abc-100@abc.net")]
        [DataRow("abc@1.com")]
        [DataRow("abc@gmail.com.com")]
        [DataRow("abc+100@gmail.com")]
        public void GivenUserEmailIds_OnValidation_ShouldReturnTrue(string email)
        {
            //Act
            var result = pattern.ValidateEmail(email);
            //Assert
            Assert.IsTrue(result);
        }
        /// Invalid test cases
        /// <summary>
        /// Given the user fist name on validation should return false.
        /// </summary>
        [TestMethod]
        public void GivenUserFistName_OnValidation_ShouldReturnFalse()
        {
            //Arrange
            string firstName = "kalyan";
            //Act
            var result = pattern.ValidateName(firstName);
            //Assert
            Assert.IsFalse(result);
        }
        /// <summary>
        /// Given the user last name on validation should return false.
        /// </summary>
        [TestMethod]
        public void GivenUserLastName_OnValidation_ShouldReturnFalse()
        {
            //Arrange
            string lastName = "ravula";
            //Act
            var result = pattern.ValidateName(lastName);
            //Assert
            Assert.IsFalse(result);
        }
        /// <summary>
        /// Given the user mobile number on validation should return false.
        /// </summary>
        [TestMethod]
        public void GivenUserMobileNumber_OnValidation_ShouldReturnFalse()
        {
            //Arrange
            string mobileNumber = "919999999999";
            //Act
            var result = pattern.ValidateMobileNumber(mobileNumber);
            //Assert
            Assert.IsFalse(result);
        }
        /// <summary>
        /// Given the user password on validation should return false.
        /// </summary>
        [TestMethod]
        public void GivenUserPassword_OnValidation_ShouldReturnFalse()
        {
            //Arrange
            string password = "Qwerty@@1234";
            //Act
            var result = pattern.ValidatePassword(password);
            //Assert
            Assert.IsFalse(result);
        }
        /// <summary>
        /// Given list of  user email ids on validation should return false.
        /// </summary>
        /// <param name="email">The email.</param>
        [TestMethod]
        [DataRow("abc@.com.my")]
        [DataRow("abc100@yahoo.a")]
        [DataRow("abc100@.com")]
        [DataRow("abc111@.com.com")]
        [DataRow(".abc.100@abc.com")]
        [DataRow("abc()*@abc.net")]
        [DataRow("abc@%*.com")]
        [DataRow("abc@abc@gmail.com")]
        [DataRow("abc@gmail.com.1a")]
        [DataRow("abc@gmail.com.aa.au")]
        public void GivenUserEmailIds_OnValidation_ShouldReturnFalse(string email)
        {
            //Act
            var result = pattern.ValidateEmail(email);
            //Assert
            Assert.IsFalse(result);
        }



    }
}
