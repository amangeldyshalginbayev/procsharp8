using System;

namespace AnonymousTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Anonymous Types *****\n");

            //var myCar = new { Color = "Bright Pink", Make = "Saab", CurrentSpeed = 55 };

            // Console.WriteLine("My car is a {0} {1}.", myCar.Color, myCar.Make);
            //
            // BuildAnonType("BMW", "Black", 90);
            
            //ReflectOverAnonymousType(myCar);
            
            EqualityTest();

            Console.ReadLine();
        }

        static void BuildAnonType(string make, string color, int currSp)
        {
            var car = new {Make = make, Color = color, Speed = currSp};

            Console.WriteLine("You have a {0} {1} going {2} MPH", car.Color, car.Make, car.Speed);

            Console.WriteLine("ToString() == {0}", car);
        }

        static void ReflectOverAnonymousType(object obj)
        {
            Console.WriteLine("obj is an instance of: {0}", obj.GetType().Name);
            Console.WriteLine("Base class of {0} is {1}", obj.GetType().Name, obj.GetType().BaseType);
            Console.WriteLine("obj.ToString() == {0}", obj.ToString());
            Console.WriteLine("obj.GetHashCode() == {0}", obj.GetHashCode());

            Console.WriteLine();
        }

        static void EqualityTest()
        {
            var firstCar = new { Color = "Bright Pink", Make = "Saab", CurrentSpeed = 55 };
            var secondCar = new { Color = "Bright Pink", Make = "Saab", CurrentSpeed = 55 };

            if (firstCar.Equals(secondCar))
            {
                Console.WriteLine("Same anonymous object!");
            }
            else
            {
                Console.WriteLine("Not the same anonymous object!");
            }

            Console.WriteLine();
            Console.WriteLine("Are they considered equal when using == operator ?");
            if (firstCar == secondCar)
            {
                Console.WriteLine("Same anonymous object!");
            }
            else
            {
                Console.WriteLine("Not the same anonymous object!");
            }

            Console.WriteLine();

            Console.WriteLine("Are these objects the same underlying type?");
            if (firstCar.GetType().Name == secondCar.GetType().Name)
            {
                Console.WriteLine("We are both the same type!");
            }
            else
            {
                Console.WriteLine("We are different types!");
            }

            Console.WriteLine();
            ReflectOverAnonymousType(firstCar);
            Console.WriteLine("----------------------------------------------------");
            ReflectOverAnonymousType(secondCar);
            
        }
    }
}