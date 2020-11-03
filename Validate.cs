using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks.Dataflow;

namespace UserRegistrationProblem
{
    class Validate
    {
        public string name, mobileNumber, email, password;

        public Validate()
        {
        }
        public Validate(string message, string mobileNumber, string email, string password)
        {
            this.name = message;
            this.mobileNumber = mobileNumber;
            this.password = password;
            this.email = email;
        }
        public const string REGEX_NAME = "^[A-Z][a-zA-Z]{3,}";
        /// <summary>
        /// Validates the  name by taking name as argument.
        /// And returns true or false
        /// </summary>
        /// <param name="Name">The name.</param>
        /// <returns></returns>
        public bool ValidateName()
        {
            try
            {
                if (Regex.IsMatch(this.name, REGEX_NAME))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                throw new RegistrationCustomException(RegistrationCustomException.ExceptionType.INVALID_FIRST_NAME, "invalid name format");
            }
        }
        ///The regex pattern for mobile number
        public const string REGEX_MOBILE_NUMBER = "^[1-9]{1}[0-9]{1,2}[ ][1-9]{1}[0-9]{9}$";
        /// <summary>
        /// Validates the mobile number by taking mobile number as argument.
        /// And returns true or false
        /// </summary>
        /// <param name="mobileNumber">The mobile Number.</param>
        /// <returns></returns>
        public bool ValidateMobileNumber()
        {
            try
            {
                if (Regex.IsMatch(this.mobileNumber, REGEX_MOBILE_NUMBER))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                throw new RegistrationCustomException(RegistrationCustomException.ExceptionType.INVALID_MOBILENO, "invalid mobile number");
            }

        }
        ///The regex pattern for password
        public const string REGEX_PASSWORD = "^(?=.*[A-Z])(?=.*[0-9])(?=[\\w]*[\\W][\\w]*$)(?=.{8,}$).*$";
        /// <summary>
        /// Validates the password such that with atleast one uppercase charecter
        /// And atleast one numeric,exact one special charecter 
        /// and length of minimum  8 charecters
        /// By taking password as argument and Returns true or false
        /// </summary>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        public bool ValidatePassword()
        {
            try
            {
                if (Regex.IsMatch(this.password, REGEX_PASSWORD))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                throw new RegistrationCustomException(RegistrationCustomException.ExceptionType.INVALID_PASSWORD, "invalid password");

            }

        }
        ///The regex pattern for email
        public const string REGEX_EMAIL = "^[0-9a-zA-Z]{1,}([._+-][0-9a-zA-Z]{0,})*[@][0-9a-zA-Z]{1,}.[a-zA-Z]{2,3}(.[a-zA-Z]{2,3})?$";
        /// <summary>
        /// Validates the email by taking email as argument.
        /// And returns true or false
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns></returns>
        public bool ValidateEmail()
        {
            try
            {
                if (Regex.IsMatch(this.email, REGEX_EMAIL))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                throw new RegistrationCustomException(RegistrationCustomException.ExceptionType.INVALID_EMAIL, "invalid email");
            }
        }
    }
    }

