using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace PincodePattern
{
    public class Pattern
    {
        //The regex pattern for password
        public static string REGEX_PASSWORD = ".{8,}";
        /// <summary>
        /// Validates the password such that with minimum of 8 charecters
        /// By taking password as argument.
        /// And returns true or false
        /// </summary>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        public bool ValidatePassword(string password)
        {
            return Regex.IsMatch(password, REGEX_PASSWORD);
        }

    }
}
