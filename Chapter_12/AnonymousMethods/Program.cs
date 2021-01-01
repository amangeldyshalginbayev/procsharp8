using System;

namespace AnonymousMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Anonymous Methods! *****\n");

            int aboutToBlowCounter = 0;

            Car c1 = new Car("SlugBug", 100, 10);

            c1.AboutToBlow += delegate
            {
                aboutToBlowCounter++;
                Console.WriteLine("Eek! Going too fast!");
            };
            
            c1.AboutToBlow += delegate(object sender, CarEventArgs eventArgs)
            {
                aboutToBlowCounter++;
                Console.WriteLine("Critical Message from Car: {0}", eventArgs.msg);
            };
            
            c1.Exploded += delegate(object sender, CarEventArgs eventArgs)
            {
                Console.WriteLine("Fatal Message from Car: {0}", eventArgs.msg);
            };
            
            // triggering events
            for (int i = 0; i < 6; i++)
            {
                c1.Accelerate(20);
            }

            Console.WriteLine("AboutToBlow event was fired {0} times.", aboutToBlowCounter);

            Console.ReadLine();
        }
    }
}