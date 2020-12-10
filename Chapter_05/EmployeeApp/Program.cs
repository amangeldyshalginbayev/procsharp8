using System;

namespace EmployeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Encapsulation *****\n");
            
            // Employee emp = new Employee("Marvin",456,30_000);
            // emp.GiveBonus(1000);
            // emp.DisplayStats();
            //
            // emp.SetName("Marv");
            // Console.WriteLine("Employee is named: {0}", emp.Name);
            //
            // Employee emp2 = new Employee();
            // emp2.SetName("dffefefwefwefwefwefwefwefwefwefwefwefwefwefwefwef");
            
            // Employee joe = new Employee();
            // joe.Age++;
            //
            // joe.DisplayStats();
            
            Employee emp = new Employee("Marvin",45,123,1000,"111-11-1111",EmployeePayTypeEnum.Salaried);
            Console.WriteLine(emp.Pay);
            emp.GiveBonus(100);
            Console.WriteLine(emp.Pay);
            
            Console.ReadLine();
        }
    }
}