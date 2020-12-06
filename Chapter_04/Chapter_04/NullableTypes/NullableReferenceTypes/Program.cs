using System;

namespace NullableReferenceTypes
{
    public class TestClass
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string? nullableString = null;
            TestClass? myNullableClass = null;

            TestClass myNonNullableClass = myNullableClass;
            
            #nullable disable
            TestClass anotherNullableClass = null;
            TestClass? badDefinition = null;
            string? anotherNullableString = null;
            # nullable restore
        }
    }
}