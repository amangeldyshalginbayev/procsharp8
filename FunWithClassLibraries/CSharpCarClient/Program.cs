using System;
using CarLibrary;


namespace CSharpCarClient
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("***** C# CarLibrary Client App *****");
            SportsCar viper = new SportsCar("Viper", 40, 240);
            viper.TurboBoost();

            MiniVan mv = new MiniVan();
            mv.TurboBoost();

            Console.WriteLine("Done. Press any key to terminate");
            Console.ReadLine();

            var internalClassInstance = new MyInternalClass();

        }
    }
}