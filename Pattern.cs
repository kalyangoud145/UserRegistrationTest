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

    }
}
