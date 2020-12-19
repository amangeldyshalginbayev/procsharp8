using System;

namespace SimpleFinalize
{
    public class MyResourceWrapper
    {
        ~MyResourceWrapper()
        {
            Console.Beep();
            Console.WriteLine("MyResourceWrapper finalizer called!");
        }
    }
}