using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistrationProblem
{
    public class RegistrationCustomException : Exception
    {
        public enum ExceptionType
        {
            NULL_MESSAGE, EMPTY_MESSAGE, NO_SUCH_FIELD, NO_SUCH_METHOD, NO_SUCH_CLASS, OBJECT_CREATION_ISSUE,
            INVALID_FIRST_NAME, INVALID_LAST_NAME, INVALID_EMAIL, INVALID_MOBILENO, INVALID_PASSWORD

        }
        private readonly ExceptionType type;
        public RegistrationCustomException(ExceptionType Type, string message) : base(message)
        {
            this.type = Type;
        }
    }
}
