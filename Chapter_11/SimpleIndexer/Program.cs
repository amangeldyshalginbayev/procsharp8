using System;
using System.Collections.Generic;
using  System.Data;

namespace SimpleIndexer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Indexers *****\n");

            // PersonCollection myPeople = new PersonCollection();
            //
            // myPeople[0] = new Person(40, "Homer", "Simpson");
            // myPeople[1] = new Person(38, "Marge", "Simpson");
            // myPeople[2] = new Person(9, "Lisa", "Simpson");
            // myPeople[3] = new Person(7, "Bart", "Simpson");
            // myPeople[4] = new Person(2, "Maggie", "Simpson");
            //
            // for (int i = 0; i < myPeople.Count; i++)
            // {
            //     Console.WriteLine("Person number: {0}",i);
            //     Console.WriteLine("Name: {0} {1}", myPeople[i].FirstName, myPeople[i].LastName);
            //     Console.WriteLine("Age: {0}", myPeople[i].Age);
            //     Console.WriteLine();
            // }
            
            //UseGenericListOfPeople();

            PersonCollectionStringIndexer myPeopleStrings = new PersonCollectionStringIndexer
            {
                ["Homer"] = new Person(40, "Homer", "Simpson"), ["Marge"] = new Person(38, "Marge", "Simpson")
            };


            Person homer = myPeopleStrings["Homer"];
            Console.WriteLine(homer);
            Console.ReadLine();
        }

        static void UseGenericListOfPeople()
        {
            List<Person> myPeople = new List<Person>();
            myPeople.Add(new Person(9,"Lisa","Simpson"));
            myPeople.Add(new Person(7, "Bart", "Simpson"));

            myPeople[0] = new Person(2, "Maggie", "Simpson");

            for (int i = 0; i < myPeople.Count; i++)
            {
                Console.WriteLine("Person number: {0}",i);
                Console.WriteLine("Name: {0} {1}", myPeople[i].FirstName, myPeople[i].LastName);
                Console.WriteLine("Age: {0}", myPeople[i].Age);
                Console.WriteLine();
            }
        }

        static void MultipleIndexerWithDataTable()
        {
            // Make a simple DataTable with 3 columns
            DataTable myTable = new DataTable();
            myTable.Columns.Add(new DataColumn("FirstName"));
            myTable.Columns.Add(new DataColumn("LastName"));
            myTable.Columns.Add(new DataColumn("Age"));

            myTable.Rows.Add("Mel", "Appleby", 60);

            Console.WriteLine("First Name: {0}", myTable.Rows[0][0]);
            Console.WriteLine("Last Name: {0}", myTable.Rows[0][1]);
            Console.WriteLine("Age: {0}", myTable.Rows[0][2]);
        }
    }
}