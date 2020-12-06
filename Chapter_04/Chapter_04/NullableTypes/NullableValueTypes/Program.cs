using System;

namespace NullableValueTypes
{
    class DatabaseReader
    {
        public int? numericValue = null;
        public bool? boolValue = true;

        public int? GetIntFromDatabase()
        {
            return numericValue;
        }

        public bool? GetBoolFromDatabase()
        {
            return boolValue;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Nullable Value Types *****\n");
            // DatabaseReader dr = new DatabaseReader();
            //
            // int myData = dr.GetIntFromDatabase() ?? 100;
            // Console.WriteLine("VAlue of myData: {0}", myData);
            // Console.ReadLine();

            int? nullableInt = null;
            nullableInt ??= 12;
            nullableInt ??= 14;
            Console.WriteLine(nullableInt);

            // int? i = dr.GetIntFromDatabase();
            // if (i.HasValue)
            // {
            //     Console.WriteLine("Value of 'i' is: {0}", i.Value);
            // }
            // else
            // {
            //     Console.WriteLine("Value of 'i' is undefined.");
            // }
            //
            // bool? b = dr.GetBoolFromDatabase();
            // if (b != null)
            // {
            //     Console.WriteLine("Value of 'b' is: {0}", b.Value);
            // }
            // else
            // {
            //     Console.WriteLine("Value of 'b' is undefined.");
            // }
            //
            // Console.ReadLine();

            //bool myBool = null;
            //int myInt = null;
        }

        static void LocalNullableVariables()
        {
            // Define some local nullable variables
            int? nullableInt = 10;
            double? nullableDouble = 3.14;
            bool? nullableBool = null;
            char? nullableChar = 'a';
            int?[] arrayOfNullableInts = new int?[10];
        }

        static void LocalNullableVariablesUsingNullable()
        {
            Nullable<int> nullableInt = 10;
            Nullable<double> nullableDouble = 3.14;
            Nullable<bool> nullableBool = null;
            Nullable<char> nullableChar = 'a';
            Nullable<int>[] arrayOfNullableInts = new Nullable<int>[10];
        }
    }
}