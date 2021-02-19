using System;

namespace CarLibrary
{
    public class SportsCar : Car
    {
        public SportsCar()
        {
        }

        public SportsCar(string petName, int currentSpeed, int maxSpeed) : base(petName, currentSpeed, maxSpeed)
        {
        }

        public override void TurboBoost()
        {
            Console.WriteLine("Ramming speed! Faster is better...");
        }
    }
}