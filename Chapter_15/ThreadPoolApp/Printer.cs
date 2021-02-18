using System;
using System.Threading;

namespace ThreadPoolApp
{
    public class Printer
    {
       public string createdDateTime = DateTime.Now.ToLongTimeString();
        
        public void PrintNumbers()
        {
            Console.WriteLine("-> {0} is executing PrintNumbers()", Thread.CurrentThread.ManagedThreadId);

            Console.WriteLine("Your numbers: ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0}, ", i);
                Thread.Sleep(2000);
            }

            Console.WriteLine();
        }
    }
}