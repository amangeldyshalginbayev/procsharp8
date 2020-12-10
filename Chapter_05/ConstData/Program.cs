using System;

namespace ConstData
{
    class MyMathClass
    {
        //public const double PI = 3.14;
        public readonly double PI;

        public MyMathClass()
        {
            //PI = 3.14444;
            PI = 3.14;
        }

        public void ChangePI()
        {
            //PI = 3.14444;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Const *****\n");
            //Console.WriteLine("The value of PI is: {0}", MyMathClass.PI);

            //MyMathClass.PI = 3.1444;

            Console.ReadLine();
        }
    }
}