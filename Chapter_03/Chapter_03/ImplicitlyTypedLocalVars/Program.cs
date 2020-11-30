using System;
using System.Linq;

namespace ImplicitlyTypedLocalVars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //DeclareImplicitVars();
            //DeclareImplicitNumerics();
            LinqQueryOverInts();
        }
        
        static void DeclareImplicitVars()
        {
            var myInt = 0;
            var myBool = true;
            var myString = "Time, marches on...";

            Console.WriteLine("myInt is a: {0}", myInt.GetType().Name);
            Console.WriteLine("myBool is a: {0}", myBool.GetType().Name);
            Console.WriteLine("myString is a: {0}", myString.GetType().Name);
        }

        static void DeclareImplicitNumerics()
        {
            var myUInt = 0u;
            var myInt = 0;
            var myLong = 0L;
            var myDouble = 0.5;
            var myFloat = 0.5F;
            var myDecimal = 0.5M;
            
            Console.WriteLine(myUInt.GetType().Name);
            Console.WriteLine(myInt.GetType().Name);
            Console.WriteLine(myDouble.GetType().Name);
            Console.WriteLine(myFloat.GetType().Name);
            Console.WriteLine(myDecimal.GetType().Name);
            Console.WriteLine(myLong.GetType().Name);
        }

        static void ImplicitTypingIsStrongTyping()
        {
            var s = "This variable can only hold string data!";
            s = "This is fine...";

            string upper = s.ToUpper();

            s = 44.ToString();
        }

        static void LinqQueryOverInts()
        {
            int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8};

            var subset = from i in numbers where i < 10 select i;

            Console.WriteLine("Values in subset: ");
            foreach (var i in subset)
            {
                Console.WriteLine("{0} ", i);
            }
            Console.WriteLine();

            Console.WriteLine("subset is a: {0}", subset.GetType().Name);
            Console.WriteLine("subset is defined in: {0}", subset.GetType().Namespace);
        }
    }
    
    
}