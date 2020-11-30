using System;

namespace BasicConsoleIO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("***** Basic Console I/O *****");
            // GetUserData();
            // Console.ReadLine();
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            Console.Write("Please enter your age: ");
            string userAge = Console.ReadLine();

            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            
            Console.WriteLine("Hello {0}! Your are {1} years old.",userName,userAge);

            Console.ForegroundColor = prevColor;
        }

        private static void GetUserData()
        {
        }

        private static void FormatNumericalData()
        {
            
        }
    }
}