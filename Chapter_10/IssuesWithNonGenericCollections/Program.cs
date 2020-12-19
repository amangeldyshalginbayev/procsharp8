using System;
using System.Collections;
using System.Collections.Generic;

namespace IssuesWithNonGenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            SimpleBoxUnboxOperation();
        }

        static void SimpleBoxUnboxOperation()
        {
            int myInt = 25;

            // Box the int into an object reference
            object boxedInt = myInt;
            
            // Unbox the reference back into a corresponding int.
            int unboxedInt = (int) boxedInt;
            
            // Unbox in the wrong data type to trigger runtime exception.
            try
            {
                long unboxedLong = (long) boxedInt;
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void WorkWithArrayList()
        {
            // Value types are automatically boxed when
            // passed to a method requesting an object
            // this ArrayList class methods takes as 
            // input parameters of System.Object type aka object
            ArrayList myInts = new ArrayList();
            myInts.Add(10); // 10 is initally saved in stack, when passed as parameter here it is automatically boxed to object type, value of 25 is copied to heap from stack
            myInts.Add(20);
            myInts.Add(35);

            // Unboxing occurs when an object is converted back to stack-based data
            int i = (int)myInts[0];

            // Boxed again, as WriteLine() requires object types
            Console.WriteLine("Value if your int: {0}", i);
        }

        static void ArrayListOfRandomObjects()
        {
            ArrayList allMyObjects = new ArrayList();
            allMyObjects.Add(true);
            allMyObjects.Add(new OperatingSystem(PlatformID.MacOSX, new Version(10, 0)));
            allMyObjects.Add(66);
            allMyObjects.Add(3.14);
        }

        static void UserPersonCollection()
        {
            Console.WriteLine("***** Custom Person Collection *****\n");
            PersonCollection myPeople = new PersonCollection();
            myPeople.AddPerson(new Person(40,"Homer","Simpson"));
            myPeople.AddPerson(new Person(38,"Marge","Simpson"));
            myPeople.AddPerson(new Person(9,"Lisa","Simpson"));
            myPeople.AddPerson(new Person(7,"Bart","Simpson"));
            myPeople.AddPerson(new Person(2,"Maggie","Simpson"));
            
            //myPeople.AddPerson("Firstname Lastname");

            foreach (Person p in myPeople)
            {
                Console.WriteLine(p);
            }
        }

        static void UseGenericList()
        {
            Console.WriteLine("***** Fun with Generics *****\n");

            List<Person> morePeople = new List<Person>();
            
            morePeople.Add(new Person(50, "Frank", "Black"));
            Console.WriteLine(morePeople[0]);

            List<int> moreInts = new List<int>();
            moreInts.Add(10);
            moreInts.Add(2);
            int sum = moreInts[0] + moreInts[1];
            
            //moreInts.Add(new Person(22,"Iron","Man"));
        }
    }
}