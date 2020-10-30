using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using UserRegistrationProblem;

namespace UserRegistration
{
    public class Pattern
    {
        ///The regex pattern for name
        public const  string REGEX_NAME = "^[A-Z][a-zA-Z]{3,}";
        /// <summary>
        /// Validates the  name by taking name as argument.
        /// And returns true or false
        /// </summary>
        /// <param name="Name">The name.</param>
        /// <returns></returns>
        public bool ValidateName(string name)
        {
            try
            {
                if (Regex.IsMatch(name, REGEX_NAME))
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
        public bool ValidateMobileNumber(string mobileNumber)
        {
            try
            {
                if (Regex.IsMatch(mobileNumber, REGEX_MOBILE_NUMBER))
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
        public bool ValidatePassword(string password)
        {
            try
            {
                if (Regex.IsMatch(password, REGEX_PASSWORD))
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
        public bool ValidateEmail(string email)
        {
            try
            {
                if (Regex.IsMatch(email, REGEX_EMAIL))
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
        /// <summary>
        /// Method Validates list of sample emails 
        /// </summary>
        public void ValidateSampleMails()
        {
            ///sampleEmaiList for storing the emails
            List<string> sampleEmailList = new List<string>()
            {
                "abc@yahoo.com",
                "abc-100@yahoo.com",
                "abc.100@yahoo.com",
                "abc111@abc.com",
                "abc-100@abc.net",
                "abc.100@abc.com.au",
                "abc@1.com",
                "abc@gmail.com.com",
                "abc+100@gmail.com"
            };
            ///Here item is the  email in the sampleEmailList
            ///foreach loop for getting each email at a time
            foreach (string item in sampleEmailList)
            {
                ///Here it calls ValidateEmail method for validating the email
                ///parameter for the method is email and prints "valid email" 
                ///if email is valid
                if (ValidateEmail(item))
                {
                    Console.WriteLine("Valid Email");
                }
                ///If email is invalid then it prints "invalid email"
                else
                {
                    Console.WriteLine("Invalid Email");
                }
            }
        }
    }
}
