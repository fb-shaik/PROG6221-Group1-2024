using System;

namespace CalculatorConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bool - datatype for boolean in C#
            bool exitRequested = false;

            do
            {
                Console.WriteLine("Welcome to my calculator app");
                Console.WriteLine("Choose an operation:");
                Console.WriteLine("1 - Addition");
                Console.WriteLine("2 - Subtraction");
                Console.WriteLine("3 - Multiplication");
                Console.WriteLine("4 - Division");
                Console.WriteLine("5 - Exit");

                Console.WriteLine("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                double result = 0; //variable to hold the result of calculation performed

                //Switch Case: Perform calculation based on the user selection/choice
                switch (choice)
                {
                    case 1:
                        result = PerformOperation('+'); //Addition
                        break;
                    case 2:
                        result = PerformOperation('-'); //Subtraction
                        break;
                    case 3:
                        result = PerformOperation('*'); //Multiplication
                        break;
                    case 4:
                        result = PerformOperation('/'); //Division
                        break;
                    case 5:
                        exitRequested = true;//Exit
                        break;
                    default:
                        Console.WriteLine("Invalid Choice. Please choose again"); //Invalid option
                        break;
                }
                //Display the result if not exiting app 
                if (!exitRequested)
                {
                    Console.WriteLine("Result: " + result);
                    Console.WriteLine();
                }
            } while (!exitRequested);
        }
        //Method to perform the calculator operations
        static double PerformOperation(char operation)
        {
            Console.WriteLine("Enter the first number: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            double num2 = double.Parse(Console.ReadLine());
            double result = 0;
            
            //Perform the operation based on the operator passed through
            switch (operation)
            {
                case '+':
                    result = num1 + num2;//Addition
                    break;
                case '-':
                    result = num1 - num2;//Subtraction
                    break;
                case '*':   
                    result = num1 * num2;//Multiplication
                    break;
                case '/':
                    result = num1 / num2; //Division
                    break;
            }
            return result;
        }

    }
}
