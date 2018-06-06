using System;

namespace Lab02_UnitTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            //welcome line and start of program
            Console.WriteLine("Welcome to the Bank");
            StartProgram();
        }

        //global variables available to all methods
        public static double TotalBalance = 5000;
        public static bool RunProgram = true;

        //method to initiate program
        public static void StartProgram()
        {
            while (RunProgram == true)
            {
                ChooseOptions();
            }

            //put receipt here
        }

        //prints menu options to console, calls next method based on user input
        public static void ChooseOptions()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdrawal");
            Console.WriteLine("4. Exit");

            //put try here
            int UserChoice = Int32.Parse(Console.ReadLine());

            switch (UserChoice)
            {
                case 1:
                    CheckBalance();
                    break;

                case 2:
                    DepositMoney();
                    break;

                case 3:
                    WithdrawMoney();
                    break;

                case 4:
                    Console.WriteLine("Thanks for playing");
                    RunProgram = false;
                    break;

                default:
                    Console.WriteLine("Please choose an option.");
                    break;
            }
        }

        //method to check remaining balance
        public static void CheckBalance()
        {
            Console.Clear();
            string TotalBalanceConverted = String.Format("{0:C}", TotalBalance);
            Console.WriteLine($"Your current balance is {TotalBalanceConverted}");
        }

        //method to deposit money into account
        public static void DepositMoney()
        {
            Console.Clear();
            Console.WriteLine("How much money would you like to deposit?");
            double AddMoney = Double.Parse(Console.ReadLine());
            TotalBalance += AddMoney;
            Console.Clear();
            Console.WriteLine("Deposit successful.");
        }

        //method to withdraw money from account
        public static void WithdrawMoney()
        {
            Console.Clear();
            Console.WriteLine("How much money would you like to withdraw?");
            double SubtractMoney = Double.Parse(Console.ReadLine());

            if(TotalBalance - SubtractMoney < 0)
            {
                Console.Clear();
                Console.WriteLine("Insufficient funds available.");
            } else
            {
                TotalBalance -= SubtractMoney;
                Console.Clear();
                Console.WriteLine("Operation successful.");
            }

          
        }


    }
}
