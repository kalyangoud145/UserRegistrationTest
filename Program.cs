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
