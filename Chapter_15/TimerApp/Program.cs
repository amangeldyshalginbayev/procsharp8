using System;
using System.Threading;

namespace TimerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Working with Timer type *****\n");
            
            // Create the delegate for the Timer type
            TimerCallback timeCB = new TimerCallback(PrintTime);
            
            // Establish timer settings
            Timer t = new Timer(timeCB, "Some info value passed", 0, 1000);

            Console.WriteLine("Hit Enter key to terminate....");
            Console.ReadLine();
        }

        static void PrintTime(object state)
        {
            Console.WriteLine(state);
            Console.WriteLine("Time is: {0}", DateTime.Now.ToLongTimeString());
        }
    }
}