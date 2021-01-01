using System;

namespace NeedForEvent
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Agh! No Encapsulation! *****\n");

            Car myCar = new Car();
            myCar.ListOfHandlers = CallWhenExploded;
            myCar.Accelerate(10);

            myCar.ListOfHandlers += CallHereToo;
            myCar.Accelerate(10);
            
            myCar.ListOfHandlers.Invoke("Some Custom Text Here! He he!");

            Console.ReadLine();

        }

        static void CallWhenExploded(string msg)
        {
            Console.WriteLine("Inside CallWhenExploded()");
            Console.WriteLine(msg);
        }

        static void CallHereToo(string msg)
        {
            Console.WriteLine("Inside CallHereToo()");
            Console.WriteLine(msg);
        }
    }
}