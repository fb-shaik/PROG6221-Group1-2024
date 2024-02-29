using System;


namespace ConvertTypeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}!"); //string interpolation 
            
            //use a parse method & try-catch for below
            //Using int.Parse() to convert string to int
            Console.WriteLine("Enter your age: ");
            string ageInput = Console.ReadLine();
            try { 
                    //code that works; normal behaviour for the app 
                 int age = int.Parse(ageInput);
                Console.WriteLine($"You are {age} years old!");
            } 
            
            catch(FormatException) {
                Console.WriteLine("The age entered is not a valid number");
                    //error msg for what did not work; exceptions to the norm
            }

            //use Convert.ToInt32() to convert string to int
            Console.WriteLine("Enter the number of siblings you have:");
            string siblingsInput = Console.ReadLine();
            try { 
                    int siblings = Convert.ToInt32(siblingsInput);
                    Console.WriteLine($"You have {siblings} siblings");
            }
            catch (FormatException) {
                Console.WriteLine("The number of siblings entered is not a valid number");
            }
            catch (OverflowException) { 
                    Console.WriteLine("The number entered is too larger or too small"); //alternate example for class
            } 
            //InvalidCastException

            //double.Parse(): covert string to double
            //make use of a try-catch as well
            Console.WriteLine("Enter your height in meters (e.g.1,75): ");
            string heightInput = Console.ReadLine();

            try { 
                //Double.Parse(heightInput);
                double height = Double.Parse(heightInput);
                Console.WriteLine($"Your height is {height} meters.");
            } 
            
            catch(FormatException) {
                Console.WriteLine("The height entered is not a valid number");
            }


            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
/*
 * Console.Read() & Console.ReadLine()
 * methods used in .NET to obtain user input from console & they can return
 * data in different formats
 * 
 * Console.Read() method
 * this method returns an int, specifically, it reads from one character to next  
 * 
 * Console.ReadLine()
 * this method returns string. It reads a line of characters & returns as string
 
 */
