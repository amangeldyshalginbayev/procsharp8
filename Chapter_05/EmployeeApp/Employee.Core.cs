using System;


namespace EmployeeApp
{
    public partial class Employee
    {
        // Field data.
        private string _empName;
        private int _empId;
        private float _currPay;
        private string _empSSN;
        private EmployeePayTypeEnum _payType;
        private int _empAge;

        // Properties
        public string SocialSecurityNumber
        {
            get => _empSSN;
            private set => _empSSN = value;
        }

        public EmployeePayTypeEnum PayType
        {
            get => _payType;
            set => _payType = value;
        }

        public string Name
        {
            get { return _empName; }
            set
            {
                if (value.Length > 15)
                {
                    Console.WriteLine("Error! Name length exceeds 15 characters!");
                }
                else
                {
                    _empName = value;
                }
            }
        }

        public int Id
        {
            get { return _empId; }
            set { _empId = value; }
        }

        public float Pay
        {
            get { return _currPay; }
            set { _currPay = value; }
        }

        public int Age
        {
            get => _empAge;
            set => _empAge = value;
        }
    }
}