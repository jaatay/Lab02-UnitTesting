using System;

namespace Lab02_UnitTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Bank");
            ChooseOptions();
        }

        public static double TotalBalance = 5000;

        public static void ChooseOptions()
        {
            Console.WriteLine("Please choose an option.");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw");
            Console.WriteLine("4. Exit");
        }

        public static double CheckBalance()
        {
            Console.WriteLine($"Your current balance is {TotalBalance}");
            return TotalBalance;
        }
    }
}
