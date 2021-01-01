using System;

namespace AnonymousMethods
{
    public class Car
    {
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; }
        public string PetName { get; set; }

        private bool _carIsDead;

        //public delegate void CarEngineHandler(object sender, CarEventArgs e);

        // public event CarEngineHandler Exploded;
        // public event CarEngineHandler AboutToBlow;

        public event EventHandler<CarEventArgs> Exploded;
        public event EventHandler<CarEventArgs> AboutToBlow; 

        public Car()
        {
            
        }

        public Car(string name, int maxSpeed, int currentSpeed)
        {
            CurrentSpeed = currentSpeed;
            MaxSpeed = maxSpeed;
            PetName = name;
        }

        public void Accelerate(int delta)
        {
            if (_carIsDead)
            {
                Exploded?.Invoke(this,new CarEventArgs("Sorry, this car is dead..."));
            }
            else
            {
                CurrentSpeed += delta;

                if (10 == MaxSpeed - CurrentSpeed)
                {
                    AboutToBlow?.Invoke(this,new CarEventArgs("Careful buddy! Gonna blow!"));
                }

                if (CurrentSpeed >= MaxSpeed)
                {
                    _carIsDead = true;
                }
                else
                {
                    Console.WriteLine("CurrentSpeed = {0}", CurrentSpeed);
                }
            }
        }

        public override string ToString() => PetName;
    }
}