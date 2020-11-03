using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationProblem
{
    /// <summary>
    /// Validating user using lambda expressions
    /// </summary>
    public class ValidateUsingLambda
    {
        /// <summary>
        /// The regex patterns
        /// </summary>
        public const string REGEX_NAME = "^[A-Z][a-zA-Z]{3,}";
        public const string REGEX_MOBILE_NUMBER = "^[1-9]{1}[0-9]{1,2}[ ][1-9]{1}[0-9]{9}$";
        public const string REGEX_PASSWORD = "^(?=.*[A-Z])(?=.*[0-9])(?=[\\w]*[\\W][\\w]*$)(?=.{8,}$).*$";
        public const string REGEX_EMAIL = "^[0-9a-zA-Z]{1,}([._+-][0-9a-zA-Z]{0,})*[@][0-9a-zA-Z]{1,}.[a-zA-Z]{2,3}(.[a-zA-Z]{2,3})?$";
        /// <summary>
        /// Validating  the name
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public bool ValidateName(string name) => (Regex.IsMatch(name, REGEX_NAME));
        /// <summary>
        /// Validates the email.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns></returns>
        public bool ValidateEmail(string email) => (Regex.IsMatch(email, REGEX_EMAIL));
        /// <summary>
        /// Validates the mobile number.
        /// </summary>
        /// <param name="mobNumber">The mob number.</param>
        /// <returns></returns>
        public bool ValidateMobileNumber(string mobNumber) => (Regex.IsMatch(mobNumber, REGEX_MOBILE_NUMBER));
        /// <summary>
        /// Validates the password.
        /// </summary>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        public bool ValidatePassword(string password) => (Regex.IsMatch(password, REGEX_PASSWORD));
    }
}
