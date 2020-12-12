using System;

namespace Employees
{
    public class SalesPerson : Employee
    {
        public int SalesNumber { get; set; }

        public SalesPerson(string fullName, int age, int empId, float currPay, string ssn, int numbOfSales)
        :base(fullName,age,empId,currPay,ssn,EmployeePayTypeEnum.Commission)
        {
            SalesNumber = numbOfSales;
        }

        public SalesPerson()
        {
        }

        public sealed override void GiveBonus(float amount)
        {
            int salesBonus = 0;
            if (SalesNumber >= 0 && SalesNumber <= 100)
            {
                salesBonus = 10;
            }
            else
            {
                if (SalesNumber >= 101 && SalesNumber <= 200)
                {
                    salesBonus = 15;
                }
                else
                {
                    salesBonus = 20;
                }
                base.GiveBonus(amount * salesBonus);
            }
        }

        public override void DisplayStats()
        {
            base.DisplayStats();
            Console.WriteLine("Number of sales: {0}", SalesNumber);
        }
    }
}