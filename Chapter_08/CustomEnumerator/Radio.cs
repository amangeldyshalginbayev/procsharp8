using System;

namespace CustomEnumerator
{
    public class Radio
    {
        
        public void TurnOn(bool on)
        {
            Console.WriteLine(on ? "Jamming..." : "Quiet time...");
        }
    }
}