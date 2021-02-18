using System;
using System.Threading;

namespace AddWithThreads
{
    class Program
    {
        private static AutoResetEvent _waitHandle = new AutoResetEvent(false);
        
        static void Main(string[] args)
        {
            Console.WriteLine("***** Adding with Thread objects *****");
            Console.WriteLine("ID of thread in Main(): {0}", Thread.CurrentThread.ManagedThreadId);

            AddParams ap = new AddParams(10, 10);
            Thread t = new Thread(new ParameterizedThreadStart(Add));
            t.Start(ap);
            
            //Thread.Sleep(5);
            _waitHandle.WaitOne();
            Console.WriteLine("Other thread is done!");
            
            Console.ReadLine();
        }

        static void Add(object data)
        {
            if (data is AddParams ap)
            {
                Console.WriteLine("ID of thread in Add(): {0}", Thread.CurrentThread.ManagedThreadId);

                Console.WriteLine("{0} + {1} is {2}", ap.a, ap.b, ap.a + ap.b);

                _waitHandle.Set();
            }
        }
    }
}