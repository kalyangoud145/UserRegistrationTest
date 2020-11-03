using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration;
using UserRegistrationProblem;

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
        /// Constructer
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
        /// <summary>
        /// Given user first name should return custom exception as invalid name format
        /// </summary>
        [TestMethod]
        public void GivenUserFistName_WhenValidate_Should_Throw_CustomException_Indicating_Invalid_FirstName()
        {
            try
            {
                //Arrange
                string firstName = "kalyan";
                ///Act
                bool result = pattern.ValidateName(firstName);
            }
            catch (RegistrationCustomException e)
            {
                //Assert
                Assert.AreEqual("invalid name format", e.Message);
            }
        }
        /// <summary>
        /// Given user last name should return custom exception as invalid name format
        /// </summary>
        [TestMethod]
        public void GivenUserLastName_WhenValidate_Should_Throw_CustomException_Indicating_Invalid_LastName()
        {
            try
            {
                //Arrange
                string lastName = "goud";
                ///Act
                bool result = pattern.ValidateName(lastName);
            }
            catch (RegistrationCustomException e)
            {
                //Assert
                Assert.AreEqual("invalid name format", e.Message);
            }
        }
        /// <summary>
        /// Given user email id should throw custom exception invalid email
        /// </summary>
        [TestMethod]
        public void GivenUserEmailID_WhenValidate_Should_Throw_CustomException_Indicating_Invalid_EMALID()
        {
            try
            {
                //Arrange
                string emailId = "abc111@.com.com";
                ///Act
                bool result = pattern.ValidateEmail(emailId);
            }
            catch (RegistrationCustomException e)
            {
                //Assert
                Assert.AreEqual("invalid email", e.Message);
            }
        }
        /// <summary>
        /// given user mobile numbet should throw exception as invalid mobile number
        /// </summary>
        [TestMethod]
        public void GivenUserMobileNumber_WhenValidate_Should_Throw_CustomException_Indicating_Invalid_MOBILENUMBER()
        {
            try
            {
                //Arrange
                string mobileNumber = "09 7732063720";
                ///Act
                bool result = pattern.ValidateMobileNumber(mobileNumber);
            }
            catch (RegistrationCustomException e)
            {
                //Assert
                Assert.AreEqual("invalid mobile number", e.Message);
            }
        }
        /// <summary>
        /// Given user password should throw custom exception as invalid password
        /// </summary>
        [TestMethod]
        public void GivenUserPassword_WhenValidate_Should_Throw_CustomException_Indicating_Invalid_PASSWORD()
        {
            try
            {
                //Arrange
                string password = "9542316708sw";
                ///Act
                bool result = pattern.ValidatePassword(password);
            }
            catch (RegistrationCustomException e)
            {
                //Assert
                Assert.AreEqual("invalid password", e.Message);
            }
        }
        ///Using Reflection
        /// <summary>
        /// Givens the proper field name input parameter and method name for validating name should return true.
        /// </summary>
        [TestMethod]
        public void Given_ProperFieldName_InputParameter_And_MethodName_For_ValidatingFirstName_Should_Return_true()
        {
            ///Arrange
            string name = "Kalyan";
            string fieldName = "name";
            string methodName = "ValidateName";
            /// Act
            object actual = UserRegistrationReflection.SetFieldValue(name, fieldName, methodName);

            /// Assert
            Assert.AreEqual(true, actual);
        }
        /// <summary>
        /// Givens the proper field name input parameter and method name for validating name should return true.
        /// </summary>
        [TestMethod]
        public void Given_ProperFieldName_InputParameter_And_MethodName_For_ValidatingLastName_Should_Return_true()
        {
            ///Arrange
            string name = "Goud";
            string fieldName = "name";
            string methodName = "ValidateName";
            /// Act
            object actual = UserRegistrationReflection.SetFieldValue(name, fieldName, methodName);

            /// Assert
            Assert.AreEqual(true, actual);
        }
        /// <summary>
        /// Givens the proper field name proper input parameter and method name for validating mobile number should return true.
        /// </summary>
        [TestMethod]
        public void Given_ProperFieldName_Proper_InputParameter_And_MethodName_For_ValidatingMobileNumber_Should_Return_true()
        {
            ///Arrange
            string name = "91 7732063720";
            string fieldName = "mobileNumber";
            string methodName = "ValidateMobileNumber";
            /// Act
            object actual = UserRegistrationReflection.SetFieldValue(name, fieldName, methodName);

            /// Assert
            Assert.AreEqual(true, actual);
        }
        /// <summary>
        /// Givens the proper field name proper input parameter and method name for validating password should return true.
        /// </summary>
        [TestMethod]
        public void Given_ProperFieldName_Proper_InputParameter_And_MethodName_For_ValidatingPassword_Should_Return_true()
        {
            ///Arrange
            string name = "12345678@Kd";
            string fieldName = "password";
            string methodName = "ValidatePassword";
            /// Act
            object actual = UserRegistrationReflection.SetFieldValue(name, fieldName, methodName);

            /// Assert
            Assert.AreEqual(true, actual);
        }
        /// <summary>
        /// Givens the proper field name proper input parameter and method name for validating email should return true.
        /// </summary>
        [TestMethod]
        public void Given_ProperFieldName_Proper_InputParameter_And_MethodName_For_ValidatingEmail_Should_Return_true()
        {
            ///Arrange
            string name = "kalyangoud145@gmail.com";
            string fieldName = "email";
            string methodName = "ValidateEmail";
            /// Act
            object actual = UserRegistrationReflection.SetFieldValue(name, fieldName, methodName);

            /// Assert
            Assert.AreEqual(true, actual);
        }
        ///Checking false cases
        /// <summary>
        /// Givens the proper field name improper input parameter and method name for validating name should return false.
        /// </summary>
        [TestMethod]
        public void Given_ProperFieldName_Improper_InputParameter_And_MethodName_For_ValidatingFirstName_Should_Return_false()
        {
            ///Arrange
            string name = "shiva";
            string fieldName = "name";
            string methodName = "ValidateName";
            /// Act
            object actual = UserRegistrationReflection.SetFieldValue(name, fieldName, methodName);

            /// Assert
            Assert.AreEqual(false, actual);
        }
        /// <summary>
        /// Givens the proper field name improper input parameter and method name for validating name should return false.
        /// </summary>
        [TestMethod]
        public void Given_ProperFieldName_Improper_InputParameter_And_MethodName_For_ValidatingLastName_Should_Return_false()
        {
            ///Arrange
            string name = "reddy";
            string fieldName = "name";
            string methodName = "ValidateName";
            /// Act
            object actual = UserRegistrationReflection.SetFieldValue(name, fieldName, methodName);

            /// Assert
            Assert.AreEqual(false, actual);
        }
        /// <summary>
        /// Givens the proper field name improper input parameter and method name for validating mobile number should return false.
        /// </summary>
        [TestMethod]
        public void Given_ProperFieldName_Improper_InputParameter_And_MethodName_For_ValidatingMobileNumber_Should_Return_false()
        {
            ///Arrange
            string name = "917732063720";
            string fieldName = "mobileNumber";
            string methodName = "ValidateMobileNumber";
            /// Act
            object actual = UserRegistrationReflection.SetFieldValue(name, fieldName, methodName);

            /// Assert
            Assert.AreEqual(false, actual);
        }
        /// <summary>
        /// Givens the proper field name improper input parameter and method name for validating password should return false.
        /// </summary>
        [TestMethod]
        public void Given_ProperFieldName_Improper_InputParameter_And_MethodName_For_ValidatingPassword_Should_Return_false()
        {
            ///Arrange
            string name = "12345678Kd";
            string fieldName = "password";
            string methodName = "ValidatePassword";
            /// Act
            object actual = UserRegistrationReflection.SetFieldValue(name, fieldName, methodName);

            /// Assert
            Assert.AreEqual(false, actual);
        }
        /// <summary>
        /// Givens the proper field name improper input parameter and method name for validating email should return false.
        /// </summary>
        [TestMethod]
        public void Given_ProperFieldName_Improper_InputParameter_And_MethodName_For_ValidatingEmail_Should_Return_false()
        {
            ///Arrange
            string name = "kalyangoud145gmail.com";
            string fieldName = "email";
            string methodName = "ValidateEmail";
            /// Act
            object actual = UserRegistrationReflection.SetFieldValue(name, fieldName, methodName);

            /// Assert
            Assert.AreEqual(false, actual);
        }
    }
}
