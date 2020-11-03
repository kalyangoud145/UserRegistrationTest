using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using UserRegistration;

namespace UserRegistrationProblem
{
    public class UserRegistrationReflection
    {
        /// <summary>
        /// Sets the field value, parameters to the method are field name,method name,input message
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="fieldName">Name of the field.</param>
        /// <param name="methodName">Name of the method.</param>
        /// <returns></returns>
        /// <exception cref="RegistrationCustomException">
        /// No such field found
        /// or
        /// Input parameter should not be NULL
        /// </exception>
        public static Object SetFieldValue(string message, string fieldName, string methodName)
        {
            // Get the type of the class
            Type type = typeof(Validate);

            // Create an object of class
            object instance = Activator.CreateInstance(type);

            //Get the field and If the field is not found it throws null exception and if message is empty throw exception
            // catch the exception if thrown
            try
            {
                // Get the field by using reflections
                FieldInfo fieldInfo = type.GetField(fieldName);

                // set the field value of a particular field in particular object
                fieldInfo.SetValue(instance, message);

                // Get the method using reflection
                MethodInfo method = type.GetMethod(methodName);

                // Invoke the method using reflection
                object methodReturn = method.Invoke(instance, null);
                return methodReturn;
            }
            catch (NullReferenceException)
            {
                throw new RegistrationCustomException(RegistrationCustomException.ExceptionType.NO_SUCH_FIELD, "No such field found");
            }
            catch
            {
                throw new RegistrationCustomException(RegistrationCustomException.ExceptionType.NULL_MESSAGE, "Input parameter should not be NULL");
            }
        }
    }
}
