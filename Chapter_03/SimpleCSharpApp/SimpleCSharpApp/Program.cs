using System;

namespace SimpleCSharpApp
{
    class Program
    {
        static int Main(string[] args)
        {
            Console.WriteLine("*** My First C# App! ***");
            Console.WriteLine("Hello World!");
            Console.WriteLine();
            
            // for (int i = 0; i < args.Length; i++)
            // {
            //     Console.WriteLine("Arg: {0}", args[i]);
            // }

            // foreach (var arg in args)
            // {
            //     Console.WriteLine("Arg: {0}",arg);
            // }

            // string[] theArgs = Environment.GetCommandLineArgs();
            // foreach (var arg in theArgs)
            // {
            //     Console.WriteLine("Arg: {0}", arg);
            // }

            ShowEnvironmentDetails();
            
            Console.ReadLine();

            return -1;
        }

        private static void ShowEnvironmentDetails()
        {
            foreach (var drive in Environment.GetLogicalDrives())
            {
                Console.WriteLine("Drive: {0}", drive);
            }

            Console.WriteLine("OS: {0}",Environment.OSVersion);
            Console.WriteLine("Number of processors: {0}",Environment.ProcessorCount);
            Console.WriteLine(".NET Core version: {0}",Environment.Version);
        }
    }
}