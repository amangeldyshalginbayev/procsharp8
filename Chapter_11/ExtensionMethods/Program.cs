using System;
using System.Data;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Extension Methods *****\n");

            int myInt = 12345678;
            myInt.DisplayDefiningAssemble();

            System.Data.DataSet d = new DataSet();
            d.DisplayDefiningAssemble();

            Console.WriteLine("Value of myInt: {0}", myInt);
            Console.WriteLine("Reversed digits of myInt: {0}", myInt.ReverseDigits());

            Console.ReadLine();
        }
    }
}