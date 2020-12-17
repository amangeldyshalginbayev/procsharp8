using System;
using System.Collections;

namespace CustomEnumerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with IEnumerable / IEnumerator *****\n");

            Garage carLot = new Garage();

            foreach (Car c in carLot)
            {
                Console.WriteLine("{0} is going {1} MPH", c.PetName, c.CurrentSpeed);
            }
            
            // Manually work with IEnumerator
            // IEnumerator i = carLot.GetEnumerator();
            // i.MoveNext();
            // Car myCar = (Car) i.Current;
            // Console.WriteLine("{0} is going {1} MPH", myCar?.PetName, myCar?.CurrentSpeed);
            
            Console.ReadLine();
        }
    }
}