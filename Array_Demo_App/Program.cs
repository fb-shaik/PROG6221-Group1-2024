using System;

namespace Array_Demo_App
{
    class Program
    {
        static void Main(string[] args)
        {
            // How can the concept of an array be defined?
            Console.WriteLine("An array is a data structure that stores a fixed-size sequential collection of elements of the same type.");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");
            // Under what condition(s) can variables be stored in an array?
            Console.WriteLine("Variables can be stored in an array when you need to group multiple values of the same type under a single name.");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");
            // What would be needed to specify in square brackets in order to access a specific element in an array?
            Console.WriteLine("You would need to specify the index of the element in square brackets to access it.");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");
            // What is the syntax to declare an array in C#?
            Console.WriteLine("Syntax to declare an array in C#:");
            Console.WriteLine("type[] arrayName; // For single-dimensional arrays");
            Console.WriteLine("type[,] arrayName; // For rectangular two-dimensional arrays");
            Console.WriteLine("type[][] arrayName; // For jagged arrays");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");
            // What is the index of the first element in an array?
            Console.WriteLine("The index of the first element in an array is 0.");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");
            // What is the syntax for declaring a rectangular two-dimensional array?
            Console.WriteLine("Syntax for declaring a rectangular two-dimensional array:");
            Console.WriteLine("type[,] arrayName = new type[rows, columns];");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");
            // What is a jagged array?
            Console.WriteLine("A jagged array is an array whose elements are arrays. Each element can be of different sizes and dimensions.");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");
            // What is the syntax for declaring a jagged array?
            Console.WriteLine("Syntax for declaring a jagged array:");
            Console.WriteLine("type[][] arrayName = new type[size][];");
            Console.WriteLine("arrayName[index] = new type[size]; // Initialize each inner array separately");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");
            // Example:
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] { 1, 2, 3 };
            jaggedArray[1] = new int[] { 4, 5 };
            jaggedArray[2] = new int[] { 6, 7, 8, 9 };

            // Accessing elements in the jagged array
            Console.WriteLine("Accessing elements in the jagged array:");
            Console.WriteLine("jaggedArray[0][1]: " + jaggedArray[0][1]); // Output: 2
            Console.WriteLine("jaggedArray[1][0]: " + jaggedArray[1][0]); // Output: 4
            Console.WriteLine("jaggedArray[2][3]: " + jaggedArray[2][3]); // Output: 9


        }
    }
}
