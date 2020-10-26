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
            //Gets user input and store in password variable
            Console.WriteLine("Enter the password");
            string password = Console.ReadLine();
            //Here it calls ValidatePassword method for validating the password
            //parameter for the method is password
            Console.WriteLine(pattern.ValidatePassword(password));
        }
    }
}
