using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace PincodePattern
{
    public class Pattern
    {
        //The regex pattern for firstname
        public static string REGEX_FIRSTNAME = "^[A-Z]{1}[a-zA-Z]{2,}";
        /// <summary>
        /// Validates the first name by taking firstname as argument.
        /// And returns true or false
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <returns></returns>
        public bool ValidateFirstName(string firstName)
        {
            return Regex.IsMatch(firstName, REGEX_FIRSTNAME);
        }
        //The regex pattern for lastname
        public static string REGEX_LASTNAME = "^[A-Z]{1}[a-zA-Z]{2,}";
        /// <summary>
        /// Validates the last name by taking lastname as argument.
        /// And returns true or false
        /// </summary>
        /// <param name="lastName">The last name.</param>
        /// <returns></returns>
        public bool ValidateLastName(string lastName)
        {
            return Regex.IsMatch(lastName, REGEX_LASTNAME);
        }
        //The regex pattern for mobile number
        public static string REGEX_MOBILE_NUMBER = "^[1-9]{1}[0-9]{1,2}[ ][1-9]{1}[0-9]{9}$";
        /// <summary>
        /// Validates the mobile number by taking mobile number as argument.
        /// And returns true or false
        /// </summary>
        /// <param name="mobileNumber">The mobile Number.</param>
        /// <returns></returns>
        public bool ValidateMobileNumber(string mobileNumber)
        {
            return Regex.IsMatch(mobileNumber, REGEX_MOBILE_NUMBER);
        }
        //The regex pattern for password
        public static string REGEX_PASSWORD = "^(?=.*[A-Z])(?=.*[0-9])(?=[\\w]*[\\W][\\w]*$)(?=.{8,}$).*$";
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
            return Regex.IsMatch(password, REGEX_PASSWORD);
        }
        //The regex pattern for email
        public static string REGEX_EMAIL = "^[0-9a-zA-Z]{1,}([._+-][0-9a-zA-Z]{0,})*[@][0-9a-zA-Z]{1,}.[a-zA-Z]{2,3}(.[a-zA-Z]{2,3})?$";
        /// <summary>
        /// Validates the email by taking email as argument.
        /// And returns true or false
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns></returns>
        public bool ValidateEmail(string email)
        {
            return Regex.IsMatch(email, REGEX_EMAIL);
        }
    }
}
