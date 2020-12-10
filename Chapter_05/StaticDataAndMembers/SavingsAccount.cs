using System;

namespace StaticDataAndMembers
{
    public class SavingsAccount
    {
        public double currBalance;

        public static double currInterestRate = 0.04;

        public SavingsAccount(double balance)
        {
            //currInterestRate = 0.04;
            currBalance = balance;
        }

        static SavingsAccount()
        {
            Console.WriteLine("In static ctor!");
            currInterestRate = 0.04;
        }

        public static void SetInterestRate(double newRate) =>
            currInterestRate = newRate;

        public static double GetInterestRate() => currInterestRate;

        public static double InterestRate
        {
            get { return currInterestRate; }
            set { currInterestRate = value; }
        }
    }
}