using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace PincodePattern
{
    public class Pattern
    {
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

    }
}
