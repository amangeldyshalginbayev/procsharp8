using System;

namespace TypeConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with type conversions *****");

            // Add two shorts and print the result
            // short numb1 = 9, numb2 = 10;
            // Console.WriteLine("{0} + {1} = {2}", numb1, numb2, Add(numb1, numb2));
            // Console.ReadLine();

            // short numb1 = 30000, numb2 = 30000;
            // short answer = (short) Add(numb1, numb2);
            //
            // Console.WriteLine("{0} + {1} = {2}", numb1, numb2, answer);
            // NarrowingAttempt();
            // Console.ReadLine();

            ProcessBytes();
        }

        static int Add(int x, int y)
        {
            return x + y;
        }

        static void NarrowingAttempt()
        {
            byte myByte = 0;
            int myInt = 200;

            myByte = (byte) myInt;
            Console.WriteLine("Value of myByte: {0}", myByte);
        }

        static void ProcessBytes()
        {
            byte b1 = 100;
            byte b2 = 250;

            try
            {
                checked
                {
                    byte sum = (byte) Add(b1, b2);
                    Console.WriteLine("sum = {0}", sum);
                }
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}