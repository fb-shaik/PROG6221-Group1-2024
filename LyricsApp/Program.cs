using System;

namespace LyricsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green; //change the text colour on console
            Console.BackgroundColor = ConsoleColor.Gray; //changes the background of the text
            //prompt the user for song lyrics
            Console.WriteLine("Enter the first line of your favorite song: ");
            string line1 = Console.ReadLine();

            Console.WriteLine("Enter the second line of your favorite song: ");
            string line2 = Console.ReadLine();

            Console.WriteLine("Enter the third line of your favorite song: ");
            string line3 = Console.ReadLine();

            Console.WriteLine("Enter the fourth line of your favorite song: ");
            string line4 = Console.ReadLine();

            //Display the captured lyrics
            Console.WriteLine("\nYour favorite song lyrics are: ");
            Console.WriteLine(line1);
            Console.WriteLine(line2);
            Console.WriteLine(line3);
            Console.WriteLine(line4);

            //keep conosle window open until the user presses a key
            Console.WriteLine("\nPress any key to exit");
            Console.ReadKey();


        }
    }
}
