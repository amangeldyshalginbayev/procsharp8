using System;

namespace SimpleCSharpConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "My Rocking App";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("***********************");
            Console.WriteLine("***** Welcome to my Rocking App! *****");
            Console.WriteLine("***********************");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ReadLine();
        }
    }
}