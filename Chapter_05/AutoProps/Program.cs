using System;

namespace AutoProps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Automatic Properties *****\n");
            
            // Car c = new Car();
            // c.PetName = "Frank";
            // c.Speed = 55;
            // c.Color = "Red";
            //
            // Console.WriteLine("You car is named {0}? That's odd...",c.PetName);
            //
            // c.DisplayStats();
            
            // Garage g = new Garage();
            //
            // Console.WriteLine("Number of Cars: {0}", g.NumberOfCars);
            //
            // Console.WriteLine(g.MyAuto.PetName);
            
            Car c = new Car();
            c.PetName = "Frank";
            c.Speed = 55;
            c.Color = "Red";
            c.DisplayStats();
            
            Garage g = new Garage();
            g.MyAuto = c;
            Console.WriteLine("Number of Cars in garage: {0}", g.NumberOfCars);
            Console.WriteLine("Your cas is named: {0}", g.MyAuto.PetName);

            Console.ReadLine();
        }
    }
}