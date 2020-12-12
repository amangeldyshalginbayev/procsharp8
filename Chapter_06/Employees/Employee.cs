using System;

namespace Employees
{
    abstract partial class Employee
    {
        public class BenefitPackage
        {
            public enum BenefitPackageLevel
            {
                Standard, Gold, Platinum
            }
            public double ComputePayDeduction()
            {
                return 125.0;
            }
        }

        // Constructors
        public Employee()
        {
        }

        public Employee(string name, int id, float pay, string empSsn) : this(name, 0, id, pay, empSsn,
            EmployeePayTypeEnum.Salaried)
        {
        }

        public Employee(string empName, int empAge, int empId, float currPay, string ssn, EmployeePayTypeEnum payType)
        {
            Name = empName;
            Age = empAge;
            Id = empId;
            Pay = currPay;
            SocialSecurityNumber = ssn;
            PayType = payType;
        }

        // Methods.
        public virtual void GiveBonus(float amount)
        {
            Pay = this switch
            {
                {PayType: EmployeePayTypeEnum.Commission} =>
                    Pay += .10F * amount,
                {PayType: EmployeePayTypeEnum.Hourly} =>
                    Pay += 40F * amount / 2080F,
                {PayType: EmployeePayTypeEnum.Salaried} =>
                    Pay += amount,
                _ => Pay += 0
            };
        }

        public virtual void DisplayStats()
        {
            Console.WriteLine("Name: {0}", EmpName);
            Console.WriteLine("ID: {0}", EmpId);
            Console.WriteLine("Age: {0}", EmpAge);
            Console.WriteLine("Pay: {0}", CurrPay);
            Console.WriteLine("SSN: {0}", SocialSecurityNumber);
        }

        // Accessor (get method)
        public string GetName() => EmpName;

        // Mutator (set method)
        public void SetName(string name)
        {
            if (name.Length > 15)
            {
                Console.WriteLine("Error! Name Length exceeds 15 characters!");
            }
            else
            {
                EmpName = name;
            }
        }
    }

    public enum EmployeePayTypeEnum
    {
        Hourly,
        Salaried,
        Commission
    }
}