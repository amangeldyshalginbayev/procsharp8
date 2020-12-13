using System;
using System.IO;

namespace ProcessMultipleExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Handling Multiple Exceptions *****\n");
            Car myCar = new Car(90,"Rusty");
            myCar.CrankTunes(true);
            try
            {
                try
                {
                    myCar.Accelerate(150);
                }
                catch (CarIsDeadException e) when (e.ErrorTimeStamp.DayOfWeek != DayOfWeek.Friday)
                {
                    try
                    {
                        FileStream fs = File.Open(@"carErrors.txt", FileMode.Open);
                    }
                    catch (Exception e2)
                    {
                        throw new CarIsDeadException(e.CauseOfError, e.ErrorTimeStamp, e.Message, e2);
                    }
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                myCar.CrankTunes(false);
                Console.WriteLine("This code block executed anyway>>>>>>>>>>>>>>>>>>>>>>>>");
            }

            Console.ReadLine();
        }
    }
}