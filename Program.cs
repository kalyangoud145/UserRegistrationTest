using System;
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
            //Pattern method object is created
            Pattern pattern = new Pattern();
            //Gets user input and store in firstname variable
            Console.WriteLine("Enter First Name");
            string firstName = Console.ReadLine();
            //Here it calls ValidateFirstName method for validating the firstname
            //parameter for the method is firstName
            Console.WriteLine(pattern.ValidateFirstName(firstName));
            //Gets user input and store in lastname variable
            Console.WriteLine("Enter Last Name");
            string lastName = Console.ReadLine();
            //Here it calls ValidateLastName method for validating the lastname
            //parameter for the method is lastName
            Console.WriteLine(pattern.ValidateLastName(lastName));
            //Gets user input and store in mobileNumber variable
            Console.WriteLine("Enter the mobile number");
            string mobileNumber = Console.ReadLine();
            //Here it calls ValidateMobileNumber method for validating the email
            //parameter for the method is mobileNumber
            Console.WriteLine(pattern.ValidateMobileNumber(mobileNumber));
            //Gets user input and store in password variable
            Console.WriteLine("Enter the password");
            string password = Console.ReadLine();
            //Here it calls ValidatePassword method for validating the password
            //parameter for the method is password
            Console.WriteLine(pattern.ValidatePassword(password));
            //sampleEmaiList for storing the emails
            List<string> sampleEmailList = new List<string>()
            {
                "abc@yahoo.com",
                "abc-100@yahoo.com",
                "abc.100@yahoo.com",
                "abc111@abc.com",
                "abc-100@abc.net",
                "abc.100@abc.com.au",
                "abc@1.com",
                "abc@gmail.com.com",
                "abc+100@gmail.com"
            };
            //Here item is the  email in the sampleEmailList
            //foreach loop for getting each email at a time
            foreach (string item in sampleEmailList)
            {
                //Here it calls ValidateEmail method for validating the email
                //parameter for the method is email and prints "valid email" 
                //if email is valid
                if (pattern.ValidateEmail(item))
                {
                    Console.WriteLine("Valid Email");
                }
                //If email is invalid then it prints "invalid email"
                else
                {
                    Console.WriteLine("Invalid Email");
                }
            }
        }
    }
}
