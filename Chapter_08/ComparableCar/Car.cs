using System;
using System.Collections;

namespace ComparableCar
{
    public class Car : IComparable
    {
        public int CarID { get; set; }

        public static IComparer SortByPetName => (IComparer) new PetNameComparer();
        
        // Constant for maximum speed.
        public const int MaxSpeed = 100;

        // Car properties.
        public int CurrentSpeed {get; set;} = 0;
        public string PetName {get; set;} = "";

        // Is the car still operational?
        private bool _carIsDead;

        // A car has-a radio.
        private readonly Radio _theMusicBox = new Radio();

        // Constructors.
        public Car() {}
        public Car(string name, int speed)
        {
            CurrentSpeed = speed;
            PetName = name;
        }

        public Car(string petName, int currentSpeed, int carId)
        {
            PetName = petName;
            CurrentSpeed = currentSpeed;
            CarID = carId;
        }

        public void CrankTunes(bool state)
        {
            // Delegate request to inner object.
            _theMusicBox.TurnOn(state);
        }

        // See if Car has overheated.
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
                    Console.WriteLine("{0} has overheated!", PetName);
                    CurrentSpeed = 0;
                    _carIsDead = true;
                    // Use the "throw" keyword to raise an exception and return to the caller.
                    throw new Exception($"{PetName} has overheated!")
                    {
                        HelpLink = "http://www.CarsRUs.com",
                        Data = { 
                            {"TimeStamp",$"The car exploded at {DateTime.Now}"},
                            {"Cause","You have a lead foot."}
                        }
                    };
                }
                //Final else is optional since the throw statement returns to the caller
                //else
                //{
                Console.WriteLine("=> CurrentSpeed = {0}", CurrentSpeed);
                //}
            }
            
            
        }

        // int IComparable.CompareTo(object obj)
        // {
        //     if (obj is Car temp)
        //     {
        //         if (this.CarID > temp.CarID)
        //         {
        //             return 1;
        //         }
        //
        //         if (this.CarID < temp.CarID)
        //         {
        //             return -1;
        //         }
        //
        //         return 0;
        //     }
        //
        //     throw new ArgumentException("Parameter is not a Car!");
        // }

        int IComparable.CompareTo(object obj)
        {
            if (obj is Car temp)
            {
                return this.CarID.CompareTo(temp.CarID);
            }

            throw new ArgumentException("Parameter is not a Car!");
        }
    }
}