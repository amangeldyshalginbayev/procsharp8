using System;
using System.Collections;
using System.Collections.Generic;

namespace FunWithCollectionInitialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Collection Initialization *****");
        }

        static void CollectionInitialization()
        {
            int[] myArrayOfInts = { 0,1,2,3,4,5,6,7,8,9 };

            List<int> myGenericList = new List<int> { 0,1,2,3,4,5,6,7,8,9};

            ArrayList myList = new ArrayList {0,1,2,3,4,5,6,7,8,9};
            
        }
    }
}