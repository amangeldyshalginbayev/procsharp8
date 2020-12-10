using System;

namespace ObjectInitializers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Object Init Syntax *****\n");

            Point firstPoint = new Point();
            firstPoint.X = 10;
            firstPoint.Y = 10;
            firstPoint.DisplayStats();

            Point anotherPoint = new Point(20, 20);
            anotherPoint.DisplayStats();

            Point finalPoint = new Point {X = 30, Y = 30};
            finalPoint.DisplayStats();

            Point goldPoint = new Point(PointColor.Gold) {X = 90, Y = 20};
            goldPoint.DisplayStats();
            Console.ReadLine();

            Rectangle myRect = new Rectangle
            {
                TopLeft = new Point {X = 10, Y = 10},
                BottomRight = new Point {X = 200, Y = 200}
            };
            
            // Old-school approach, Java still uses it :)
            Rectangle r = new Rectangle();
            Point p1 = new Point();
            p1.X = 10;
            p1.Y = 10;
            r.TopLeft = p1;
            Point p2 = new Point();
            p2.X = 200;
            p2.Y = 200;
            r.BottomRight = p2;
        }
    }
}