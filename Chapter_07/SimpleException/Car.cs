using System;

namespace SimpleException
{
    public class Car
    {
        public const int MaxSpeed = 100;

        public int CurrentSpeed { get; set; } = 0;
        public string PetName { get; set; } = "";

        private bool _carIsDead;

        private readonly Radio _theMusicBox = new Radio();

        public Car()
        {
        }

        public Car(int currentSpeed, string petName)
        {
            CurrentSpeed = currentSpeed;
            PetName = petName;
        }

        public void CrankTunes(bool state)
        {
            _theMusicBox.TurnOn(state);
        }

        public void Accelerate(int delta)
        {
            if (_carIsDead)
            {
                Console.WriteLine("{0} is out of order...", PetName);
            }
            else
            {
                CurrentSpeed += delta;
                if (CurrentSpeed > MaxSpeed)
                {
                    CurrentSpeed = 0;
                    _carIsDead = true;

                    throw new Exception($"{PetName} has overheated!")
                    {
                        HelpLink = "http://www.CarsRus.com",
                        Data =
                        {
                            {"TimeStamp", $"The car exploded at {DateTime.Now}"},
                            {"Cause", "You have a lead foot."}
                        }
                    };
                }

                Console.WriteLine("=> CurrentSpeed = {0}", CurrentSpeed);
            }
        }
    }
}