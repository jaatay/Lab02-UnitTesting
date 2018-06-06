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

        public static void RunUntilQuit()
        {
            while 
        }

        public static void ChooseOptions()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdrawal");
            Console.WriteLine("4. Exit");

            int UserChoice = Int32.Parse(Console.ReadLine());

           
        }

        public static double CheckBalance()
        {
            Console.WriteLine($"Your current balance is {TotalBalance}");
            return TotalBalance;
        }
    }
}
