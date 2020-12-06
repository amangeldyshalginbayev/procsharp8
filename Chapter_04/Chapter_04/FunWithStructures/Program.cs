using System;

namespace FunWithStructures
{
    struct Point
    {
        public int X;
        public int Y;

        public Point(int xPos, int yPos)
        {
            X = xPos;
            Y = yPos;
        }

        public void Increment()
        {
            X++;
            Y++;
        }

        public void Decrement()
        {
            X--;
            Y--;
        }

        public void Display()
        {
            Console.WriteLine("X = {0}, Y = {1}", X, Y);
        }
    }

    readonly struct ReadOnlyPoint
    {
        public int X { get; }
        public int Y { get; }

        public void Display()
        {
            Console.WriteLine($"X = {X}, Y = {Y}");
        }

        public ReadOnlyPoint(int xPos, int yPos, string name)
        {
            X = xPos;
            Y = yPos;
        }
    }

    struct PointWithReadOnly
    {
        public int X;
        public readonly int Y;
        public readonly string Name;

        public readonly void Display()
        {
            Console.WriteLine($"X = {X}, Y = {Y}, Name = {Name}");
        }

        public PointWithReadOnly(int xPos, int yPos, string name)
        {
            X = xPos;
            Y = yPos;
            Name = name;
        }
    }

    ref struct DisposableRefStruct
    {
        public int X;
        public readonly int Y;

        public readonly void Display()
        {
            Console.WriteLine($"X = {X}, Y = {Y}");
        }

        public DisposableRefStruct(int xPos, int yPos)
        {
            X = xPos;
            Y = yPos;
            Console.WriteLine("Created!");
        }

        public void Dispose()
        {
            Console.WriteLine("Disposed!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** A First Look at Structures *****\n");

            // Point myPoint;
            // myPoint.X = 349;
            // myPoint.Y = 76;
            // myPoint.Display();
            //
            // myPoint.Increment();
            // myPoint.Display();
            // Console.ReadLine();
            //
            // Point p1 = new Point();
            // p1.Display();
            // Console.ReadLine();
            //
            // Point p2 = new Point(50,60);
            // p2.Display();
            //
            // Console.ReadLine();
            //
            // PointWithReadOnly p3 = new PointWithReadOnly(50,60,"Point w/RO");
            // p3.Display();
            // p3.X = 120;
            // p3.Y = 340; // readonly can be assigned only in constructor
            // p3.Name = "New Name"; // readonly can be assigned only in constructor
            
            var s = new DisposableRefStruct(50,60);
            s.Display();
            s.Dispose();
            Console.ReadLine();
        }
    }
}