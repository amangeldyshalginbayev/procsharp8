using System;

namespace SimpleDelegate
{
    public delegate int BinaryOp(int arg1, int arg2);

    public class SimpleMath
    {
        public int Add(int x, int y) => x + y;
        public int Subtract(int x, int y) => x - y;
        public static int SquareNumber(int a) => a * a;
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Simple Delegate Example *****\n");

            SimpleMath m = new SimpleMath();
            
            BinaryOp b = new BinaryOp(m.Add);
            
            DisplayDelegateInfo(b);
            
            Console.WriteLine("10 + 10 is {0}", b(10,10));

            Console.ReadLine();
        }

        static void DisplayDelegateInfo(Delegate delObj)
        {
            // Printing the names of each member in the delegate's invocation list
            foreach (Delegate d in delObj.GetInvocationList())
            {
                Console.WriteLine("Method Name: {0}", d.Method);
                Console.WriteLine("Type Name: {0}", d.Target);
            }
        }
    }
}