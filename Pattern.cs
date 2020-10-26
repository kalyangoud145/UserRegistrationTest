using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace PincodePattern
{
    public class Pattern
    {
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

    }
}
