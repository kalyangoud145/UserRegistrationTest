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
            //Gets user input and store in firstname variable
            Console.WriteLine("Enter First Name");
            string firstName = Console.ReadLine();
            //Here it calls ValidateFirstName method for validating the firstname
            //parameter for the method is firstName
            Console.WriteLine(pattern.ValidateFirstName(firstName));
        }
    }
}
