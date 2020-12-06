using System;

namespace FunWithArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //SimpleArrays();
            //ArrayInitialization();
            //DeclareImplicitArrays();
            //ArrayOfObjects();
            //RectMultidimensionalArray();
            //JaggedMultidimensionalArray();
            //PassAndReceiveArrays();
            //SystemArrayFunctionality();
            IndicesAndRanges();
        }

        static void SimpleArrays()
        {
            Console.WriteLine("=> Simple Array Creation.");
            int[] myInts = new int[3];
            myInts[0] = 100;
            myInts[1] = 200;
            myInts[2] = 300;

            foreach (var i in myInts)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            string[] booksOnDotNet = new string[100];
            Console.WriteLine();
        }

        static void ArrayInitialization()
        {
            Console.WriteLine("=> Array Initialization.");

            string[] stringArray = new string[] {"one", "two", "three"};

            Console.WriteLine("stringArray has {0} elements", stringArray.Length);

            bool[] boolArray = {false, false, true};
            Console.WriteLine("boolArray has {0} elements", boolArray.Length);

            int[] intArray = new int[4] {20, 22, 23, 0};
            Console.WriteLine("intArray has {0} elements", intArray.Length);

            Console.WriteLine();
        }

        static void DeclareImplicitArrays()
        {
            Console.WriteLine("=> Implicit Array Initialization");

            var a = new[] {1, 10, 100, 1000};
            Console.WriteLine("a  is a: {0}", a.ToString());

            var b = new[] {1, 1.5, 2, 2.5};
            Console.WriteLine("b is a: {0}", b.ToString());

            var c = new[] {"hello", null, "world"};
            Console.WriteLine("c is a: {0}", c.ToString());
            Console.WriteLine();
        }

        static void ArrayOfObjects()
        {
            Console.WriteLine("=> Array of Objects.");
            object[] myObjects = new object[4];
            myObjects[0] = 10;
            myObjects[1] = false;
            myObjects[2] = new DateTime(1969, 3, 24);
            myObjects[3] = "Form & Void";
            foreach (var obj in myObjects)
            {
                Console.WriteLine("Type: {0}, Value: {1}", obj.GetType(), obj);
            }

            Console.WriteLine();
        }

        static void RectMultidimensionalArray()
        {
            Console.WriteLine("=> Rectangular multidimensional array.");
            int[,] myMatrix;
            myMatrix = new int[3, 4];

            // fill
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    myMatrix[i, j] = i * j;
                }
            }

            // print
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(myMatrix[i, j] + "\t");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }

        static void JaggedMultidimensionalArray()
        {
            Console.WriteLine("=> Jagged multidimensional array.");
            // an array of 5 different arrays
            int[][] myJagArray = new int[5][];

            for (int i = 0; i < myJagArray.Length; i++)
            {
                myJagArray[i] = new int[i + 7];
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < myJagArray[i].Length; j++)
                {
                    Console.Write(myJagArray[i][j] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }

        #region Arrays as params and return values

        static void PrintArray(int[] myInts)
        {
            for (int i = 0; i < myInts.Length; i++)
            {
                Console.WriteLine("Item {0} is {1}", i, myInts[i]);
            }
        }

        static string[] GetStringArray()
        {
            string[] theStrings = {"Hello", "from", "GetStringArray"};
            return theStrings;
        }

        static void PassAndReceiveArrays()
        {
            Console.WriteLine("=> Arrays as params and return values.");
            // Pass array as parameter
            int[] ages = {20, 22, 23, 0};
            PrintArray(ages);

            // Get array as return value
            string[] strs = GetStringArray();
            foreach (string s in strs)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine();
        }

        #endregion

        #region System.Array functionality

        static void SystemArrayFunctionality()
        {
            Console.WriteLine("=> Working with System.Array.");
            string[] gothicBands = {"Tones on Tail", "Bauhaus", "Sisters of Mercy"};

            Console.WriteLine("-> Here is the array:");
            for (int i = 0; i < gothicBands.Length; i++)
            {
                Console.Write(gothicBands[i] + ", ");
            }

            Console.WriteLine("\n");

            Array.Reverse(gothicBands);
            Console.WriteLine("-> The reversed array");

            for (int i = 0; i < gothicBands.Length; i++)
            {
                Console.Write(gothicBands[i] + ", ");
            }

            Console.WriteLine("\n");

            Console.WriteLine("-> Cleared out all but one ...");
            Array.Clear(gothicBands, 1, 2);

            for (int i = 0; i < gothicBands.Length; i++)
            {
                Console.Write(gothicBands[i] + ", ");
            }

            Console.WriteLine();
            Console.WriteLine(gothicBands[1] == null);
            //Console.WriteLine(gothicBands[1].Length);

            Console.WriteLine();
        }

        #endregion

        #region Indices and Ranges (C# 8)

        static void IndicesAndRanges()
        {
            Console.WriteLine("=> Working with Indices and Ranges.");
            string[] gothicBands = {"Tones on Tail", "Bauhaus", "Sisters of Mercy"};

            for (int i = 1; i <= gothicBands.Length; i++)
            {
                Index idx = ^i;
                Console.Write(gothicBands[idx] + ", ");
            }

            Console.WriteLine("=> using range[0..2]");
            foreach (var itm in gothicBands[0..2])
            {
                Console.Write(itm + ", ");
            }

            Console.WriteLine("\n");

            Console.WriteLine("=> Passing Range data type to a sequence");
            Range r = 0..2;
            foreach (var itm in gothicBands[r])
            {
                Console.Write(itm + ", ");
            }

            Console.WriteLine("\n");

            Console.WriteLine("=> Defining Range type using integers and Index data type");
            Index idx1 = 0;
            Index idx2 = 2;
            Range range = idx1..idx2; // the end is exclusive
            foreach (var itm in gothicBands[range])
            {
                Console.Write(itm + ", ");
            }

            Console.WriteLine("\n");
        }

        #endregion
    }
}