using System.Runtime.CompilerServices;
[assembly:InternalsVisibleTo("CSharpCarClient")]
[assembly:InternalsVisibleTo("VisualBasicCarClient")]
namespace CarLibrary
{
    public enum EngineState
    {
        EngineAlive,
        EngineDead
    }
    
    public abstract class Car
    {
        public string PetName { get; set; }
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; }

        protected EngineState State = EngineState.EngineAlive;
        public EngineState EngineState => State;
        public abstract void TurboBoost();

        protected Car()
        {
        }

        protected Car(string petName, int currentSpeed, int maxSpeed)
        {
            PetName = petName;
            CurrentSpeed = currentSpeed;
            MaxSpeed = maxSpeed;
        }
    }
}