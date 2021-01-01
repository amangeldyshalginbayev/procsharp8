using System;

namespace CarEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("***** Fun with Events *****\n");
            //
            // Car c1 = new Car("SlugBug", 100, 10);
            //
            // // Registering event handlers
            // c1.AboutToBlow += CarIsAlmostDoomed;
            // c1.AboutToBlow += CarAboutToBlow;
            //
            // Car.CarEngineHandler d = new Car.CarEngineHandler(CarExploded);
            // c1.Exploded += d;
            //
            // Console.WriteLine("***** Speeding up *****\n");
            // for (int i = 0; i < 6; i++)
            // {
            //     c1.Accelerate(20);
            // }
            //
            // // Remove CarExploded method from invocation list
            // c1.Exploded -= d;
            //
            // Console.WriteLine("After removal from invocation list");
            // Console.WriteLine("***** Speeding up *****");
            // for (int i = 0; i < 6; i++)
            // {
            //     c1.Accelerate(20);
            // }

            // Console.WriteLine("***** Prim and Proper Events *****\n");
            //
            // Car c1 = new Car("SlugBug", 100, 10);
            //
            // c1.AboutToBlow += CarIsAlmostDoomed;
            // c1.AboutToBlow += CarAboutToBlow;
            //
            // EventHandler<CarEventArgs> d = CarExploded;
            // c1.Exploded += d;
            //
            // Console.WriteLine("***** Speeding up *****");
            // for (int i = 0; i < 6; i++)
            // {
            //     c1.Accelerate(20);
            // }
            
            // Using lambda expressions
            Car c1 = new Car("SlugBug", 100, 10);

            c1.AboutToBlow += (sender, e) => { Console.WriteLine(e.msg); };
            c1.Exploded += (sender, e) => { Console.WriteLine(e.msg); };

            Console.WriteLine("***** Speeding up *****\n");
            for (int i = 0; i < 6; i++)
            {
                c1.Accelerate(20);
            }

            Console.ReadLine();
        }

        public static void CarAboutToBlow(object sender, CarEventArgs e)
        {
            Console.WriteLine("Inside CarAboutToBlow()");
            Console.WriteLine($"{sender} says: {e.msg}");
        }

        public static void CarIsAlmostDoomed(object sender, CarEventArgs e)
        {
            Console.WriteLine("Inside CarIsAlmostDoomed()");

            if (sender is Car c)
            {
                Console.WriteLine($"Critical Message from {c.PetName} : {e.msg}");
            }
        }

        public static void CarExploded(object sender, CarEventArgs e)
        {
            Console.WriteLine("Inside CarExploded()");
            Console.WriteLine($"{sender} says: {e.msg}");
        }
    }
}