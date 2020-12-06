using System;

namespace FunWithMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with Methods ****\n");
            
            // Pass two variables in by value.
            // int x = 9;
            // int y = 10;
            //
            // Console.WriteLine("Before call: X: {0}, Y: {1}", x,y);
            // Console.WriteLine("Answer is: {0}", Add(x,y));
            // Console.WriteLine("After call: X: {0}, Y:{1}",x,y);
            // Console.ReadLine();
            //
            // Console.WriteLine("=> Working with out parameter.");
            //int some_value;
            Add(90, 90, out int some_value);
            //Console.WriteLine(some_value);
            
            // FillTheseValues(out int z, out string x, out bool y);
            // Console.WriteLine("Int is: {0}",z);
            // Console.WriteLine("String is: {0}",x);
            // Console.WriteLine("Bool is: {0}",y);

            // string str1 = "Flip";
            // string str2 = "Flop";
            // Console.WriteLine("Before: {0}, {1}",str1,str2);
            // SwapStrings(ref str1, ref str2);
            // Console.WriteLine("After: {0}, {1}", str1, str2);

            // double average;
            // average = CalculateAverage(4.0, 3.2, 5.7, 64.22, 87.2);
            // Console.WriteLine(average);
            //EnterLogData("Stop Stop");
            //EnterLogData("Stop Stop", "Goat Police");
            DisplayFancyMessage(message:"Very fancy text!", textColor:ConsoleColor.DarkRed, backgroundColor:ConsoleColor.Cyan);
            Console.ReadLine();

        }

        static int Add(int x, int y)
        {
            int ans = x + y;
            x = 10000;
            y = 88888;
            return ans;
        }

        static void Add(int x, int y, out int ans)
        {
            ans = x + y;
        }
        
        //Returning multiple output parameters.
        static void FillTheseValues(out int a, out string b, out bool c)
        {
            a = 9;
            b = "Enjoy your string.";
            c = true;
        }
        
        // Reference parameters
        public static void SwapStrings(ref string s1, ref string s2)
        {
            string tempStr = s1;
            s1 = s2;
            s2 = tempStr;
        }

        static int Add2(int x, int y)
        {
            x = 10000;
            y = 88888;
            int ans = x + y;
            return ans;
        }

        static int AddReadOnly(in int x, in int y)
        {
            //x = 10000;
            //y = 88888;
            int ans = x + y;
            return ans;
        }

        static double CalculateAverage(params double[] values)
        {
            Console.WriteLine("You sent me {0} doubles.", values.Length);

            double sum = 0;
            if (values.Length == 0)
            {
                return sum;
            }

            for (int i = 0; i < values.Length; i++)
            {
                sum += values[i];
            }

            return (sum / values.Length);
        }

        static void EnterLogData(string message, string owner = "Programmer")
        {
            Console.Beep();
            Console.WriteLine("Error: {0}",message);
            Console.WriteLine("Owner of Error: {0}", owner);
        }

        static void DisplayFancyMessage(ConsoleColor textColor, ConsoleColor backgroundColor, string message)
        {
            ConsoleColor oldTextColor = Console.ForegroundColor;
            ConsoleColor oldBackgroundColor = Console.BackgroundColor;

            Console.ForegroundColor = textColor;
            Console.BackgroundColor = backgroundColor;
            Console.WriteLine(message);

            Console.ForegroundColor = oldTextColor;
            Console.BackgroundColor = oldBackgroundColor;
        }
    }
}