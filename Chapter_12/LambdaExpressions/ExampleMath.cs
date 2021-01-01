using System;

namespace LambdaExpressions
{
    public class ExampleMath
    {
        public int Add(int x, int y) => x + y;
        // {
        //     return x + y;
        // }

        public void PrintSum(int x, int y) => Console.WriteLine(x + y);
        // {
        //     Console.WriteLine(x + y);
        // }


    }
}