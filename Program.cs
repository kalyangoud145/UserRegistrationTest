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
            //Gets user input and store in mobileNumber variable
            Console.WriteLine("Enter the mobile number");
            string mobileNumber = Console.ReadLine();
            //Here it calls ValidateMobileNumber method for validating the email
            //parameter for the method is mobileNumber
            Console.WriteLine(pattern.ValidateMobileNumber(mobileNumber));
        }
    }
}
