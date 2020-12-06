using System;

namespace FunWithTuples
{
    class Program
    {
        static void Main(string[] args)
        {
          (string, int, string) values = ("a", 5, "c");
          var values1 = ("a", 5, "c");
          Console.WriteLine(values.Item1);
          Console.WriteLine(values.Item2);
          Console.WriteLine(values.Item3);

          Console.WriteLine("Hello World!");
        }
    }
}