using System;
using System.Threading;

namespace ThreadPoolApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with the CoreCLR Thread Pool *****\n");

            Console.WriteLine("Main thread started. ThreadID = {0}", Thread.CurrentThread.ManagedThreadId);

            Printer p = new Printer();

            WaitCallback workItem = new WaitCallback(PrintNumbers);

            for (int i = 0; i < 10; i++)
            {
                ThreadPool.QueueUserWorkItem(workItem, p);
            }

            Console.WriteLine("All tasks queued");
            Console.ReadLine();
        }

        static void PrintNumbers(object state)
        { 
            Printer task = (Printer) state;
            Console.WriteLine(task.createdDateTime);
            task.PrintNumbers();
        }
    }
}