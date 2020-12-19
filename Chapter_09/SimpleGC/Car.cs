namespace SimpleGC
{
    public class Car
    {
        public int CurrentSpeed { get; set; }
        public string PetName { get; set; }

        public Car()
        {
            
        }

        public Car(int currentSpeed, string petName)
        {
            CurrentSpeed = currentSpeed;
            PetName = petName;
        }

        public override string ToString()
        {
            return $"{PetName} is going {CurrentSpeed} MPH";
        }
    }
}