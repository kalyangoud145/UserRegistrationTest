using System;
using UserRegistration;
using System.Collections.Generic;

namespace PincodePattern
{
    /// <summary>
    /// Main Class for calling the respective methods
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            ///Pattern method object is created
            Pattern pattern = new Pattern();
            ///Gets user input and store in firstname variable
            Console.WriteLine("Enter First Name");
            string firstName = Console.ReadLine();
            ///Here it calls ValidateFirstName method for validating the firstname
            ///parameter for the method is firstName
            Console.WriteLine(pattern.ValidateName(firstName));
            ///Gets user input and store in lastname variable
            Console.WriteLine("Enter Last Name");
            string lastName = Console.ReadLine();
            ///Here it calls ValidateName method for validating the lastname
            ///parameter for the method is lastName
            Console.WriteLine(pattern.ValidateName(lastName));
            ///Gets user input and store in mobileNumber variable
            Console.WriteLine("Enter the mobile number");
            string mobileNumber = Console.ReadLine();
            ///Here it calls ValidateMobileNumber method for validating the email
            ///parameter for the method is mobileNumber
            Console.WriteLine(pattern.ValidateMobileNumber(mobileNumber));
            ///Gets user input and store in password variable
            Console.WriteLine("Enter the password");
            string password = Console.ReadLine();
            ///Here it calls ValidatePassword method for validating the password
            ///parameter for the method is password
            Console.WriteLine(pattern.ValidatePassword(password));
            ///Calling ValidateSampleMails() for checking list of mails are valid
            pattern.ValidateSampleMails();
        }
    }
}
