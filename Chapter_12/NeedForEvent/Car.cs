namespace NeedForEvent
{
    public class Car
    {
        public delegate void CarEngineHandler(string msgForCaller);
        
        // public member!
        public CarEngineHandler ListOfHandlers;

        public void Accelerate(int delta)
        {
            ListOfHandlers?.Invoke("Sorry, this car is dead...");
        }
    }
}