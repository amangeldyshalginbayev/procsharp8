using System;

namespace FunWithEnums
{
    enum EmpTypeEnum : byte
    {
        Manager = 102,
        Grunt,
        Contractor,
        VicePresident
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with Enums ****");

            // EmpTypeEnum emp = EmpTypeEnum.Contractor;
            // AskForBonus(emp);
            //
            // Console.WriteLine("EmpTypeEnum uses a {0} for storage",Enum.GetUnderlyingType(emp.GetType()));
            // Console.WriteLine(emp.GetType());
            // Console.WriteLine("EmpTypeEnum uses a {0} for storage",Enum.GetUnderlyingType(typeof(EmpTypeEnum)));
            // EmpTypeEnum emp = EmpTypeEnum.Contractor;
            // Console.WriteLine("{0} = {1}", emp.ToString(), (byte) emp);
            // Console.ReadLine();

            EmpTypeEnum e2 = EmpTypeEnum.Contractor;

            DayOfWeek day = DayOfWeek.Monday;
            ConsoleColor cc = ConsoleColor.Gray;
            
            EvaluateEnum(e2);
            EvaluateEnum(day);
            EvaluateEnum(cc);
            Console.ReadLine();
        }

        static void AskForBonus(EmpTypeEnum e)
        {
            switch (e)
            {
                case EmpTypeEnum.Manager:
                    Console.WriteLine("How about stock options instead?");
                    break;
                case EmpTypeEnum.Grunt:
                    Console.WriteLine("You have to be kidding ...");
                    break;
                case EmpTypeEnum.Contractor:
                    Console.WriteLine("You already get enough cash ...");
                    break;
                case EmpTypeEnum.VicePresident:
                    Console.WriteLine("Very good, Sir!");
                    break;
            }
        }

        static void EvaluateEnum(System.Enum e)
        {
            Console.WriteLine(e.GetType());
            Console.WriteLine("=> Information about {0}", e.GetType().Name);
            Console.WriteLine("Underlying storage type: {0}", Enum.GetUnderlyingType(e.GetType()));

            Array enumData = Enum.GetValues(e.GetType());
            Console.WriteLine("This enum has {0} members.", enumData.Length);

            for (int i = 0; i < enumData.Length; i++)
            {
                Console.WriteLine("Name: {0}, Value: {0:D}", enumData.GetValue(i));
            }

            Console.WriteLine();
        }
    }
}