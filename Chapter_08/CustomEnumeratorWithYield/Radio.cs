using System;

namespace CustomEnumeratorWithYield
{
    public class Radio
    {
        
        public void TurnOn(bool on)
        {
            Console.WriteLine(on ? "Jamming..." : "Quiet time...");
        }
    }
}