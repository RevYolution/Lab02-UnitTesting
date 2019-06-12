using System;

namespace BankApp
{
    public class Program
    {
    public static int startingBalance = 1000;
       public static void Main(string[] args)
        {
           
            Console.WriteLine("Welcome!");
            Console.WriteLine("Please select from the following choices:");
            Console.WriteLine("1: View Balance");
            Console.WriteLine("2: Withdrawal");
            Console.WriteLine("3: Deposit");
            Console.WriteLine("4: Exit");

            string userChoice = Console.ReadLine();
            int commandInput = Convert.ToInt32(userChoice);
            if (userChoice == "1")
            {
                ViewBalance();
            }
            if (userChoice == "2")
            {
                Withdrawal();
            }
            //if (userChoice == "3")
            //{
            //    Deposit();
            //}
            //if (userChoice == "4")
            //{
            //    Exit();
            //}

        }

        public static int ViewBalance()
        {
            int balance = startingBalance;
            Console.WriteLine($"Your Current balance is {balance}");
            return balance;
            
        }

        //public static int Withdrawal()
        //{
        //    return "Withdraw";
        //}

        //public static int Deposit()
        //{
        //    return "Deposit";
        //}

        //public static string Exit()
        //{
        //    return "Exit";
        //}
    }
}
