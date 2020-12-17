using System;

namespace CustomInterfaces
{
    public interface IRegularPointy : IPointy
    {
        int SideLength { get; set; }
        int NumberOfSides { get; set; }
        int Perimeter => SideLength * NumberOfSides;

        static string ExampleProperty { get; set; }

        static IRegularPointy()
        {
            ExampleProperty = "Foo";
            Console.WriteLine("Static constructor inside IRegularPointy interface");
        }
    }
}