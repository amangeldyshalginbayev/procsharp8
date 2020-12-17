using System;

namespace CustomInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("***** A First Look at Interfaces *****\n");
            // CloneableExample();

            Console.WriteLine("\n***** Fun with Interfaces *****\n");
            // Circle c = new Circle("Lisa");
            // IPointy itfPt = null;
            //
            // try
            // {
            //     itfPt = (IPointy) c;
            //     Console.WriteLine(itfPt.Points);
            // }
            // catch (InvalidCastException e)
            // {
            //     Console.WriteLine(e.Message);
            // }

            // Hexagon hex2 = new Hexagon("Peter");
            // IPointy itfPt2 = hex2 as IPointy;
            // if (itfPt2 != null)
            // {
            //     Console.WriteLine("Points: {0}", itfPt2.Points);
            // }
            // else
            // {
            //     Console.WriteLine("OOPS! Not pointy...");
            // }

            // Hexagon hex2 = new Hexagon("Peter");
            // if (hex2 is IPointy itfP3)
            // {
            //     Console.WriteLine("Points: {0}", itfP3.Points);
            // }
            // else
            // {
            //     Console.WriteLine("OOPS! Not pointy...");
            // }

            // var sq = new Square("Boxy")
            // {
            //     NumberOfSides = 4,
            //     SideLength = 4
            // };
            //
            // sq.Draw();
            //
            // Console.WriteLine($"{sq.PetName} has {sq.NumberOfSides} of length {sq.SideLength} and a perimeter of {((IRegularPointy)sq).Perimeter}");

            // Hexagon hex = new Hexagon();
            // Console.WriteLine("Points: {0}", hex.Points);

            // Circle c = new Circle("Lisa");
            // IPointy itfPt = null;
            // try
            // {
            //     itfPt = (IPointy) c;
            //     Console.WriteLine(itfPt.Points);
            // }
            // catch (InvalidCastException e)
            // {
            //     Console.WriteLine(e);
            // }

            // Hexagon hex2 = new Hexagon("Peter");
            // IPointy itfPt2 = hex2 as IPointy;
            // if (itfPt2 != null)
            // {
            //     Console.WriteLine("Points: {0}",itfPt2.Points);
            // }
            // else
            // {
            //     Console.WriteLine("OOPS! Not pointy...");
            // }
            
            // Hexagon hex2 = new Hexagon("Peter");
            // if (hex2 is IPointy itfPt3)
            // {
            //     Console.WriteLine("Points: {0}",itfPt3.Points);
            // }
            // else
            // {
            //     Console.WriteLine("OOPS! Not pointy...");
            // }

            // var sq = new Square("Boxy")
            // {
            //     NumberOfSides = 4,
            //     SideLength = 4
            // };
            // sq.Draw();
            // Console.WriteLine($"{sq.PetName} has {sq.NumberOfSides} of length {sq.SideLength} and a perimeter of {((IRegularPointy)sq).Perimeter}");

            // Console.WriteLine($"Example property: {IRegularPointy.ExampleProperty}");
            // IRegularPointy.ExampleProperty = "Updated";
            // Console.WriteLine($"Example property: {IRegularPointy.ExampleProperty}");

            //Shape[] myShapes = {new Hexagon(), new Circle(), new Triangle("Joe"), new Circle("JoJo")};
            // for (int i = 0; i < myShapes.Length; i++)
            // {
            //     if (myShapes[i] is IDraw3D s)
            //     {
            //         DrawIn3D(s);
            //     }
            // }

            // IPointy firstPointyItem = FindFirstPointyShape(myShapes);
            // Console.WriteLine("The item has {0} points",firstPointyItem?.Points);

            IPointy[] myPointyObjects = {new Hexagon(), new Knife(), new Triangle(), new Fork(), new PitchFork()};

            foreach (IPointy i in myPointyObjects)
            {
                Console.WriteLine("Object has {0} points.", i.Points);
            }

            Console.ReadLine();
        }

        static void CloneableExample()
        {
            string myStr = "Hello";
            OperatingSystem unixOS = new OperatingSystem(PlatformID.Unix, new Version());
            
            CloneMe(myStr);
            CloneMe(unixOS);

            static void CloneMe(ICloneable c)
            {
                object theClone = c.Clone();
                Console.WriteLine("Your clone is a: {0}",theClone.GetType().Name);
            }
        }

        static void DrawIn3D(IDraw3D itf3d)
        {
            Console.WriteLine("-> Drawing IDraw3D compatible type");
            itf3d.Draw3D();
        }

        static IPointy FindFirstPointyShape(Shape[] shapes)
        {
            foreach (Shape s in shapes)
            {
                if (s is IPointy ip)
                {
                    return ip;
                }
            }

            return null;
        }
    }
}