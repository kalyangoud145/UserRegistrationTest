using System;

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
            //Gets user input and store in email variable
            Console.WriteLine("Enter the email");
            string email = Console.ReadLine();
            //Here it calls ValidateEmail method for validating the email
            //parameter for the method is email
            Console.WriteLine(pattern.ValidateEmail(email));
        }
    }
}
