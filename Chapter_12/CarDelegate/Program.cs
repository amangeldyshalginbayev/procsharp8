using System;

namespace CarDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("***** Delegates as event enablers *****\n");
            //
            // Car c1 = new Car("Slugbug", 100, 10);
            // c1.RegisterWithCarEngine(new Car.CarEngineHandler(OnCarEngineEvent));
            //
            // Car.CarEngineHandler handler2 = new Car.CarEngineHandler(OnCarEngineEvent2);
            // c1.RegisterWithCarEngine(handler2);
            //
            // Console.WriteLine("***** Speeding up *****");
            // for (int i = 0; i < 6; i++)
            // {
            //     c1.Accelerate(20);
            // }
            //
            // c1.UnRegisterWithCarEngine(handler2);
            //
            // Console.WriteLine("***** Speeding up *****");
            // for (int i = 0; i < 6; i++)
            // {
            //     c1.Accelerate(20);
            // }

            Console.WriteLine("***** Method Group Conversion *****\n");
            Car c2 = new Car();
            
            c2.RegisterWithCarEngine(OnCarEngineEvent);
            
            Console.WriteLine("***** Speeding Up *****");
            for (int i = 0; i < 6; i++)
            {
                c2.Accelerate(20);
            }
            
            c2.UnRegisterWithCarEngine(OnCarEngineEvent);
            
            // No more notifications!
            Console.WriteLine("No more notifications!");
            for (int i = 0; i < 6; i++)
            {
                c2.Accelerate(20);
            }
            
            Console.ReadLine();


        }

        static void OnCarEngineEvent(string msg)
        {
            Console.WriteLine("\n*** Message From Car Object ***");
            Console.WriteLine("=> {0}", msg);
            Console.WriteLine("*************************\n");
        }

        static void OnCarEngineEvent2(string msg)
        {
            Console.WriteLine("=> {0}", msg.ToUpper());
        }
    }
}