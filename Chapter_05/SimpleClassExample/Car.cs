

using System;

namespace SimpleClassExample
{
    public class Car
    {
        public string petName;
        public int currSpeed;

        public void PrintState() => Console.WriteLine("{0} is going {1} MPH.",petName,currSpeed);

        public void SpeedUp(int delta) => currSpeed += delta;

        public Car()
        {
            petName = "Chuck";
            currSpeed = 10;
        }

        public Car(string pn)
        {
            petName = pn;
        }

        public Car(string pn, int cs)
        {
            petName = pn;
            currSpeed = cs;
        }

        public Car(string pn, int cs, out bool inDanger)
        {
            petName = pn;
            currSpeed = cs;
            if (cs > 100)
            {
                inDanger = true;
            }
            else
            {
                inDanger = false;
            }
        }
    }
}