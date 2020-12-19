using System;

namespace SimpleDispose
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Dispose *****\n");

            // MyResourceWrapper rw = new MyResourceWrapper();
            // if (rw is IDisposable)
            // {
            //     rw.Dispose();
            // }

            // MyResourceWrapper rw = new MyResourceWrapper();
            // try
            // {
            //     // Use rw members
            // }
            // finally
            // {
            //     rw.Dispose();
            // }
            //
            // using (MyResourceWrapper rw2 = new MyResourceWrapper())
            // {
            //     // Use rw2 object
            // }

            Console.WriteLine("Demonstrate using declarations");
            UsingDeclaration();
            

            Console.ReadLine();
        }

        private static void UsingDeclaration()
        {
            using var rw = new MyResourceWrapper();
            // Do something here
            Console.WriteLine("About to dispose");
            // Variable disposed at this point
        }
    }
}