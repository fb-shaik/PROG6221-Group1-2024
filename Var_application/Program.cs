using System;

namespace Var_application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myNumber = 19; //explicitly typed variable
            Console.WriteLine($"My number is: {myNumber}");

            string myName = "Joe";//explicitly typed variable
            Console.WriteLine($"My Name is: {myName}");

            var newNumber = 15; //implicitly typed variable
            Console.WriteLine($"The new number is: {newNumber}");

            var newName = "Jane";//implicitly typed variable
            Console.WriteLine($"Your name is: {newName}");

            int myInt = newNumber;

        }
    }
}
