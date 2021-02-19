using System;

namespace CarLibrary
{
    public class MiniVan : Car
    {
        public MiniVan()
        {
        }

        public MiniVan(string petName, int currentSpeed, int maxSpeed) : base(petName, currentSpeed, maxSpeed)
        {
        }

        public override void TurboBoost()
        {
            State = EngineState.EngineDead;
            Console.WriteLine("Eek! Your engine block exploded!");
        }
    }
}