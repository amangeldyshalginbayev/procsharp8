using System;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** The Employee Class Hierarchy *****\n");
            // SalesPerson fred = new SalesPerson
            // {
            //     Age = 31,
            //     Name = "Fred",
            //     SalesNumber = 50
            // };
            
            // Manager chucky = new Manager("Chucky",50,92,100000,"333-23-2322",9000);
            // double cost = chucky.GetBenefitCost();
            // Console.WriteLine($"Benefit Cost: {cost}");

            // Employee.BenefitPackage.BenefitPackageLevel myBenefitLevel =
            //     Employee.BenefitPackage.BenefitPackageLevel.Platinum;
            
            // Manager chucky = new Manager("Chucky", 50, 92,100000,"333-23-2322",9000);
            // chucky.GiveBonus(300);
            // chucky.DisplayStats();
            // Console.WriteLine();
            //
            // SalesPerson fran = new SalesPerson("Fran",43,93,3000,"932-32-3232",31);
            // fran.GiveBonus(200);
            // fran.DisplayStats();
            
            // object frank = new Manager();
            // Hexagon hex;
            // try
            // {
            //     hex = (Hexagon) frank;
            // }
            // catch (InvalidCastException e)
            // {
            //     Console.WriteLine(e.Message);
            // }
            
            object[] things = new object[4];
            things[0] = new Hexagon();
            things[1] = false;
            things[2] = new Manager();
            things[3] = "Last thing";

            foreach (var item in things)
            {
                Hexagon h = item as Hexagon;
                if (h == null)
                {
                    Console.WriteLine("Item is not a hexagon");
                }
                else
                {
                    h.Draw();
                }
            }
            
            
            Console.ReadLine();
        }

        static void CastingExamples()
        {
            object frank = new Manager("Frank Zappa",9,3000,40000,"111-11-1111",5);
            GivePromotion((Manager)frank);
            
            Employee moonUnit = new Manager("MoonUnit Zappa",2,3001,20000,"101-11-1321",1);
            GivePromotion(moonUnit);
            
            SalesPerson jill = new PtSalesPerson("Jill",834,3002,100000,"111-12-1119",90);
            GivePromotion(jill);
            
        }

        static void GivePromotion(Employee emp)
        {
            Console.WriteLine("{0} was promoted!", emp.Name);
        }

        static void GivePromotionUpdated(Employee emp)
        {
            Console.WriteLine("{0} was promoted!",emp.Name);
            if (emp is SalesPerson)
            {
                Console.WriteLine("{0} made {1} sale(s)!",emp.Name, ((SalesPerson)emp).SalesNumber);
                Console.WriteLine();
            }
            else if (emp is Manager)
            {
                Console.WriteLine("{0} had {1} stock options...",emp.Name,((Manager)emp).StockOptions);
                Console.WriteLine();
            }
        }

        static void GivePromotionWithElegantCast(Employee emp)
        {
            Console.WriteLine("{0} was promoted!", emp.Name);
            if (emp is SalesPerson s)
            {
                Console.WriteLine("{0} made {1} sale(s)",s.Name,s.SalesNumber);
                Console.WriteLine();
            }
            else if (emp is Manager m)
            {
                Console.WriteLine("{0} had {1} stock options...",m.Name,m.StockOptions);
                Console.WriteLine();
            }
            else if (emp is var _)
            {
                Console.WriteLine("Unable to promote {0}. Wrong employee type", emp.Name);
            }
        }

        static void GivePromotionWithPatternMatching(Employee emp)
        {
            Console.WriteLine("{0} was promoted!",emp.Name);
            switch (emp)
            {
                // case SalesPerson s when s.SalesNumber > 5:
                // if object can be casted to Salesperson then check this condition s.SalesNumber > 5, 
                // if the condition is true, then we hit this branch of switch statement
                case SalesPerson s:
                    Console.WriteLine("{0} made {1} sale(s)!",emp.Name,s.SalesNumber);
                    break;
                case Manager m:
                    Console.WriteLine("{0} had {1} stock options...",m.Name,m.StockOptions);
                    break;
                case Employee _:
                    Console.WriteLine("Unable to promote {0}. Wrong employee type",emp.Name);
                    break;
            }

            Console.WriteLine();
        }
    }
}