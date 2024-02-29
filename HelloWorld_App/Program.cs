using System;

namespace HelloWorld_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare variables to hold info
            string name = "Joe Blog";
            string workPhoneNumber = "031-209-4567";
            string cellPhoneNumber = "082-123-4567";
            DateTime birthDate = new DateTime(1990, 5, 24);//Year, Month,Day
            //DateTime ia a value defined type found in the .Net Framework to represent dates & time

            //Display the above person's details on console
            Console.WriteLine("Personal Information");
            Console.WriteLine("-------------------------");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Work Number: {workPhoneNumber}");
            Console.WriteLine($"Cellphone Number: {cellPhoneNumber}");
            Console.WriteLine($"Birth Date: {birthDate}");
        }
    }
}
