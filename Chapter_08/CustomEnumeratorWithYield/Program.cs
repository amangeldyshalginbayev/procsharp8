using System;
using System.Collections;

namespace CustomEnumeratorWithYield
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Custom Iterator using yield! *****\n");

            Garage carLot = new Garage();

            // try
            // {
            //     IEnumerator carEnumerator = carLot.GetEnumerator();
            // }
            // catch (Exception e)
            // {
            //     Console.WriteLine($"Exception occured on GetEnumerator");
            //}

            foreach (Car c in carLot)
            {
                Console.WriteLine("{0} is going {1} MPH", c.PetName, c.CurrentSpeed);
            }

            Console.WriteLine();

            foreach (Car c in carLot.GetTheCars(true))
            {
                Console.WriteLine("{0} is going {1} MPH", c.PetName, c.CurrentSpeed);
            }

            Console.ReadLine();


        }
    }
}