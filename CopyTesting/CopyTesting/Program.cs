using System;
using System.Collections.Generic;
using System.Linq;

namespace CopyTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var originalList = new List<Person>()
            {
                new Person("Aman"),
                new Person("Aisultan"),
                new Person("Zeus")
            };

            

            Console.WriteLine("Original list below: ");
            foreach (var person in originalList)
            {
                Console.WriteLine(person);
            }
            
            var copy = originalList.Where(p => p.Name == "Zeus");
            // Console.WriteLine("Is copied references: ");
            // for (int i = 0; i < originalList.Count; i++)
            // {
            //     Console.WriteLine(originalList[i] == copy[i]);
            // }
            
            foreach (var man in originalList.Where(p => p.Name == "Zeus"))
            {
                originalList.Remove(man);
            }

            Console.WriteLine("Original list after modification: ");
            foreach (var person in originalList)
            {
                Console.WriteLine(person);
            }
            
            
        }
    }
}