using System;


namespace Employees
{
    public partial class Employee
    {
        // Field data.
        protected string EmpName;
        protected int EmpId;
        protected float CurrPay;
        protected int EmpAge;
        protected string EmpSSN;
        protected EmployeePayTypeEnum EmpPayType;
        protected BenefitPackage EmpBenefits = new BenefitPackage();

        public double GetBenefitCost() => EmpBenefits.ComputePayDeduction();

        public BenefitPackage Benefits
        {
            get => EmpBenefits;
            set => EmpBenefits = value;
        }


        // Properties
        public string SocialSecurityNumber
        {
            get => EmpSSN;
            private set => EmpSSN = value;
        }

        public EmployeePayTypeEnum PayType
        {
            get => EmpPayType;
            set => EmpPayType = value;
        }

        public string Name
        {
            get { return EmpName; }
            set
            {
                if (value.Length > 15)
                {
                    Console.WriteLine("Error! Name length exceeds 15 characters!");
                }
                else
                {
                    EmpName = value;
                }
            }
        }

        public int Id
        {
            get { return EmpId; }
            set { EmpId = value; }
        }

        public float Pay
        {
            get { return CurrPay; }
            set { CurrPay = value; }
        }

        public int Age
        {
            get => EmpAge;
            set => EmpAge = value;
        }
    }
}