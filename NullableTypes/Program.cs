using System;

namespace NullableTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nullable Class App");

            //Explaination
            Console.WriteLine("\nIn C#, nullable types allow value types (int, double) to have null values ");

            //example
            int? nullableInt = null;
            Console.WriteLine($"Nullable Integer value: {nullableInt}");

            Console.WriteLine("Please enter a number or leave blank & press Enter:");

            string userInput = Console.ReadLine();
            int?userNumber = null;

            if (string.IsNullOrEmpty(userInput))
            {
                userNumber = null;
                Console.WriteLine("You have entered a null value");
            }
            else
            {
                userNumber = int.Parse(userInput);
                Console.WriteLine($"You entered the number:{userNumber}");
  
            }
            
            }



        }
    }