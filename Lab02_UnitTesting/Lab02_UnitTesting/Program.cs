using System;
using System.Collections.Generic;

namespace Lab02_UnitTesting
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //function call to start program
            StartProgram();
        }

        //global variables available to all methods
        public static double TotalBalance = 5000;
        public static double AmountAdded;
        public static double AmountWithdrawn;
        public static bool RunProgram = true;

        //method to initiate program
        public static void StartProgram()
        {
            while (RunProgram == true)
            {
                ChooseOptions();
            }

            PrintReceipt();
        }

        //prints menu options to console, calls next method based on user input
        public static void ChooseOptions()
        {
            Console.WriteLine("Thanks for visiting Bank of 'Murica!");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdrawal");
            Console.WriteLine("4. Exit");

            int UserChoice = 0;

            try
            {
                UserChoice = Int32.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Please make a valid selection.");
            }
            finally
            {
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
                        RunProgram = false;
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Please make a valid selection.");
                        break;
                }
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

            double AddMoney = 0;

            try
            {
                AddMoney = Double.Parse(Console.ReadLine());

                if (AddMoney < 0)
                {
                    throw new FormatException();
                }

                DepositMoneyMath(AddMoney);
            }
            catch (FormatException)
            {
                Console.Clear();
                Console.WriteLine("Invalid input.");
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Invalid input.");
            }
        }

        //method to math the user's input (mostly added because xUnit can't test ReadLine)
        public static double DepositMoneyMath(double AddedMoney)
        {
            Console.Clear();
            Console.WriteLine("Deposit successful.");
            TotalBalance += AddedMoney;
            AmountAdded += AddedMoney;

            return AddedMoney;
        }

        //method to withdraw money from account
        public static void WithdrawMoney()
        {
            Console.Clear();
            Console.WriteLine("How much money would you like to withdraw?");

            double SubtractMoney = 0;

            try
            {
                SubtractMoney = Double.Parse(Console.ReadLine());
                if (SubtractMoney < 0)
                {
                    throw new FormatException();
                }

                WithdrawMoneyMath(SubtractMoney);
            }
            catch (FormatException)
            {
                Console.Clear();
                Console.WriteLine("Invalid input.");
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Invalid input.");
            }
        }

        //method to do the computations for WithdrawMoney, added for TDD
        public static double WithdrawMoneyMath(double SubtractedMoney)
        {
            try
            {
                if (TotalBalance - SubtractedMoney < 0)
                {
                    Console.Clear();
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    TotalBalance -= SubtractedMoney;
                    AmountWithdrawn += SubtractedMoney;
                    Console.Clear();
                    Console.WriteLine("Operation successful.");
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Insufficient funds.");
            }
            return SubtractedMoney;
        }

        //method to print receipt
        public static void PrintReceipt()
        {
            int NewTotalBalance = 0;
            Console.Clear();
            Console.WriteLine("Thanks for banking with the Bank of 'Murica.");
            Console.WriteLine("Electronic Receipt:");
            Console.WriteLine(String.Format("You added {0:C}", AmountAdded));
            Console.WriteLine(String.Format("You withdrew {0:C}", AmountWithdrawn));
            Console.WriteLine(String.Format("Before 'Murica surcharges, your balance was {0:C}", TotalBalance));
            Console.WriteLine(String.Format("After surcharges, your remaining balance is {0:C}", NewTotalBalance));
            Console.WriteLine("Press any key to exit. Have a great day.");
            Console.ReadLine();
        }
    }



}
