using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace FunWithObservableCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            // Making a collection to observe
            // and adding a few Person objects
            ObservableCollection<Person> people = new ObservableCollection<Person>()
            {
                new Person {FirstName = "Peter", LastName = "Murphy", Age = 52},
                new Person {FirstName = "Kevin", LastName = "Key", Age = 48}
            };

            people.CollectionChanged += people_CollectionChanged;
            
            people.Add(new Person(32,"Fred","Smith"));
            
            people.RemoveAt(0);

        }

        static void people_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            // What was the action that caused the even?
            Console.WriteLine("Action for this event: {0}", e.Action);
            
            // Removed something
            if (e.Action == NotifyCollectionChangedAction.Remove)
            {
                Console.WriteLine("Here are the OLD items:");
                foreach (Person p in e.OldItems)
                {
                    Console.WriteLine(p.ToString());
                }

                Console.WriteLine();
            }
            
            // Added something
            if (e.Action == NotifyCollectionChangedAction.Add) 
            {
                Console.WriteLine("Here are the NEW items:");
                foreach (Person p in e.NewItems)
                {
                    Console.WriteLine(p.ToString());
                }
            }
        }
    }
}