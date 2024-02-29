using System;

namespace SimpleConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name: ");//prompt the user for input
            string userInput = Console.ReadLine();//Read user input from the console
            Console.WriteLine("Your name is: " +  userInput);//Display back what the user had entered when prompted
        }
    }
}
/*Difference between Console.WriteLine & Console.Write
    Console.Write - simply outputs the text to console without moving to a new line
    Console.WriteLine - outputs text to console & then moves to a new line        
 
 */  