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
            //Gets user input and store in lastname variable
            Console.WriteLine("Enter Last Name");
            string lastName = Console.ReadLine();
            //Here it calls ValidateLastName method for validating the lastname
            //parameter for the method is lastName
            Console.WriteLine(pattern.ValidateLastName(lastName));
        }
    }
}
