using System;

namespace CustomConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Conversions *****\n");
            
            // Making a Rectangle
            // Rectangle r = new Rectangle(15, 4);
            // Console.WriteLine(r.ToString());
            // r.Draw();
            //
            // Console.WriteLine();
            //
            // Square s = (Square)r;
            // Console.WriteLine(s);
            // s.Draw();
            //
            // Rectangle rect = new Rectangle(10, 5);
            // DrawSquare((Square)rect);
            
            // Converting an int to a Square
            // Square sq2 = (Square) 90;
            // Console.WriteLine("sq2 = {0}", sq2);
            
            // Converting a Square to an int
            // int side = (int) sq2;
            // Console.WriteLine("Side length of sq2 = {0}", side);

            Square s3 = new Square {Length = 83};
            Rectangle rect2 = s3;

            Square s4 = new Square {Length = 3};
            Rectangle rect3 = (Rectangle) s4;

            Console.WriteLine("rect3 = {0}", rect3);

            Console.ReadLine();
        }

        static void DrawSquare(Square sq)
        {
            Console.WriteLine(sq);
            sq.Draw();
        }
    }
}