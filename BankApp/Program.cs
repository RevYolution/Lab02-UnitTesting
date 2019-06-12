using System;

namespace BankApp
{
    public class Program
    {
    public static int balance = 1000;
       public static void Main(string[] args)
        {
            try
            {
                BankConsole();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Thank you. Your transaction is complete");
            }

        }

        public static void BankConsole()
        {
            while (true)
            {
                int userAction = MainScreen();

                if (userAction == 1)
                {
                    ViewBalance();
                }
                if (userAction == 2)
                {
                    Console.WriteLine("How much would you like to withdraw?");
                    try
                    {
                    string userWithdraw = Console.ReadLine();
                    int desiredWithdraw = Convert.ToInt32(userWithdraw);

                     balance = Withdraw(desiredWithdraw, balance);
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
        }

        public static int MainScreen()
        {
            Console.WriteLine("Welcome!");
            Console.WriteLine("Please select from the following choices:");
            Console.WriteLine("1: View Balance");
            Console.WriteLine("2: Withdrawal");
            Console.WriteLine("3: Deposit");
            Console.WriteLine("4: Exit");

            string userChoice = Console.ReadLine();
            int userAction = Convert.ToInt32(userChoice);
            return userAction;
        }

        public static void ViewBalance()
        {
            Console.WriteLine($"Your Current balance is {balance}");
            //return balance;
            
        }

        
        public static int Withdraw(int number, int balance)
        {
           return balance -= number;
            
        }

        //public static int Deposit(decimal balance)
        //{
        //    Console.WriteLine("How much would you like to deposit?");
        //    string deposit = Console.ReadLine();
        //    decimal depositAmount = Convert.ToDecimal(deposit);
        //    decimal newBalance = balance + depositAmount;
        //    return newBalance;
        //}

        //public static string Exit()
        //{
        //    return "Exit";
        //}
    }
}
