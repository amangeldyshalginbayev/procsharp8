using System;

namespace MiInterfaceHierarchy
{
    public class Rectangle : IShape
    {
        public void Print()
        {
            Console.WriteLine("Printing...");
        }

        public void Draw()
        {
            Console.WriteLine("Drawing...");
        }

        public int GetNumberOfSides() => 4;
    }
}