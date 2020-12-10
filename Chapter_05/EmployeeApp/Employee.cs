using System;

namespace EmployeeApp
{
    public partial class Employee
    {
        // // Field data.
        // private string _empName;
        // private int _empId;
        // private float _currPay;
        // private string _empSSN;
        // private EmployeePayTypeEnum _payType;
        // private int _empAge;
        //
        // // Properties
        // public string SocialSecurityNumber
        // {
        //     get => _empSSN;
        //     private set => _empSSN = value;
        // }
        //
        // public EmployeePayTypeEnum PayType
        // {
        //     get => _payType;
        //     set => _payType = value;
        // }
        // public string Name
        // {
        //     get { return _empName; }
        //     set
        //     {
        //         if (value.Length > 15)
        //         {
        //             Console.WriteLine("Error! Name length exceeds 15 characters!");
        //         }
        //         else
        //         {
        //             _empName = value;
        //         }
        //     }
        // }
        //
        // public int Id
        // {
        //     get { return _empId; }
        //     set { _empId = value; }
        // }
        //
        // public float Pay
        // {
        //     get { return _currPay; }
        //     set { _currPay = value; }
        // }
        //
        // public int Age
        // {
        //     get => _empAge;
        //     set => _empAge = value;
        // }

        // Constructors
        public Employee()
        {
        }

        public Employee(string name, int id, float pay, string empSsn) : this(name, 0, id, pay,empSsn,EmployeePayTypeEnum.Salaried)
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
        public void GiveBonus(float amount)
        {
            Pay = this switch
            {
                {PayType: EmployeePayTypeEnum.Commission} =>
                    Pay += .10F * amount,
                {PayType: EmployeePayTypeEnum.Hourly} =>
                    Pay += 40F * amount/2080F,
                {PayType: EmployeePayTypeEnum.Salaried} =>
                    Pay += amount,
                _ => Pay += 0
            };
        }

        public void DisplayStats()
        {
            Console.WriteLine("Name: {0}", _empName);
            Console.WriteLine("ID: {0}", _empId);
            Console.WriteLine("Age: {0}", _empAge);
            Console.WriteLine("Pay: {0}", _currPay);
        }

        // Accessor (get method)
        public string GetName() => _empName;

        // Mutator (set method)
        public void SetName(string name)
        {
            if (name.Length > 15)
            {
                Console.WriteLine("Error! Name Length exceeds 15 characters!");
            }
            else
            {
                _empName = name;
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