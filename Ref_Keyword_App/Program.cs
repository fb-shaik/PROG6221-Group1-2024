
using System;

namespace Ref_Keyword_App
{
     class Program
    {
        static void Main(string[] args)
        {
            //Example 1: Passing a variable by reference
            int x = 10;
            Console.WriteLine("Before calling the ModifyValue method: " + x);
            //Call the ModifyValue() 
            ModifyValue(ref x);
            Console.WriteLine("After calling the ModifyValue method: " + x);
            Console.WriteLine("\n-----------------------------------------\n");

            //Example 2: Swapping values of two variables using ref keyword
            int a = 10;
            int b = 20;
            Console.WriteLine($"Before swapping a = {a}, b= {b}");
            //Call the Swap()
            Swap(ref a, ref b);
            Console.WriteLine($"After swapping a = {a}, b= {b}");
            Console.WriteLine("\n-----------------------------------------\n");

            //Example 3: Modify the elements of an array without creating additional copies
            int[] numbers = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Before modifying the array: ");
            PrintArray(numbers);
            ModifyArray(ref numbers); //array passed by ref
            Console.WriteLine("After modifying the array: ");
            PrintArray(numbers);
            Console.WriteLine("\n-----------------------------------------\n");

            //Example 4: Resize the array & assign new elements to the array 
            Console.WriteLine("Before resizing the array: ");
            int[] originalArray = { 9, 8, 7, 6, 5 };
            PrintArray(originalArray);
            ResizeArray(ref originalArray,19);
            Console.WriteLine("After resizing the array: ");
            PrintArray(originalArray);
            Console.WriteLine("\n-----------------------------------------\n");


        }

      static void ResizeArray(ref int[]array, int newSize)
        {
           int[] newArray = new int[newSize];//Create new array with specified size
            Array.Copy(array, newArray, array.Length);
            array = newArray;//Update the reference to the original array
        }

        //Example 1 : Passing a variable by reference
        static void ModifyValue(ref int value )
        {
            value *= 2; //Double the original value
        }
        //Example 2: Swapping values of two variables 
        static void Swap(ref int a, ref int b) { 
            int temp = a;
            a = b;
            b = temp;
        }
        //Example 3: Modify array elements
        static void ModifyArray(ref int[] array) 
        {
            //for each loop
            foreach (int i in array) 
            {
                array[i-1] *=3; //Modify the element by multiplication of 3
            }        
                
        }
        //Helper Method to PrintArray
        static void PrintArray(int[] array) 
        {
            foreach(int num in array)
            {  Console.WriteLine(num + " "); }
    
        }


    }
}
