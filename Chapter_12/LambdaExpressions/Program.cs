using System;
using System.Collections.Generic;

namespace LambdaExpressions
{
    class Program
    {
        
        public delegate string VerySimpleDelegateType();
        
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Lambdas *****\n");

            //TraditionalDelegateSyntax();

            //AnonymousMethodSyntax();

            //LambdaExpressionSyntax();

            // SimpleMath m = new SimpleMath();
            // m.SetMathHandler((string msg, int result) => { Console.WriteLine("Message: {0}, Result: {1}", msg, result); });
            //
            // m.Add(66,34);

            VerySimpleDelegateType d = new VerySimpleDelegateType(() =>
            {
                return "Enjoy your string!";
            });

            VerySimpleDelegateType d2 = new VerySimpleDelegateType(() => "Enjoy your string!");

            VerySimpleDelegateType d3 = () => "Enjoy your string!";

            Console.ReadLine();
        }

        static void TraditionalDelegateSyntax()
        {
            List<int> list = new List<int>();
            list.AddRange(new int[] {20, 1, 4, 8, 9, 44});

            Predicate<int> callback = IsEvenNumber;
            List<int> evenNumbers = list.FindAll(callback);

            Console.WriteLine("Here are your even numbers:");
            foreach (var evenNumber in evenNumbers)
            {
                Console.Write("{0}\t", evenNumber);
            }

            Console.WriteLine();
        }

        static void AnonymousMethodSyntax()
        {
            List<int> list = new List<int>();
            list.AddRange(new[] {20, 1, 4, 8, 9, 44});

            List<int> evenNumbers = list.FindAll(delegate(int i) { return i % 2 == 0; });

            Console.WriteLine("Here are your even numbers: ");
            foreach (var evenNumber in evenNumbers)
            {
                Console.Write("{0}\t", evenNumber);
            }

            Console.WriteLine();
        }

        static void LambdaExpressionSyntax()
        {
            List<int> list = new List<int>();
            list.AddRange(new int[] {20, 1, 4, 8, 9, 44});

            //List<int> evenNumbers = list.FindAll(i => (i % 2) == 0);

            List<int> evenNumbers = list.FindAll((i) =>
            {
                Console.WriteLine("value of i is currently: {0}", i);
                bool isEven = ((i % 2) == 0);
                return isEven;
            });

            Console.WriteLine("Here are your even numbers:");
            foreach (var evenNumber in evenNumbers)
            {
                Console.Write("{0}\t", evenNumber);
            }

            Console.WriteLine();
        }

        static bool IsEvenNumber(int i)
        {
            return i % 2 == 0;
        }
    }
}