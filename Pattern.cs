using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace PincodePattern
{
    public class Pattern
    {
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
