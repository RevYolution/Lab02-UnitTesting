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
        /// <summary>
        /// Switch port for the user to choose what option to run
        /// </summary>
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
                if (userAction == 3)
                {
                    Console.WriteLine("How much would you like to deposit?");
                    try
                    {
                        string userDeposit = Console.ReadLine();
                        int desiredDeposit = Convert.ToInt32(userDeposit);
                        balance = Deposit(desiredDeposit, balance);
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
                if (userAction == 4)
                {
                    break;
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

        /// <summary>
        /// Allows users to view their balance at any point
        /// </summary>
        public static void ViewBalance()
        {
            Console.WriteLine($"Your Current balance is {balance}");
            //return balance;
            
        }

        /// <summary>
        /// Allows user to withdraw based off the withdraw amount.
        /// </summary>
        /// <param name="number">Amount to be withdrawn from balance</param>
        /// <param name="balance">Current balance</param>
        /// <returns>integer balance</returns>
        public static int Withdraw(int number, int balance)
        {
            if (balance - number < 0)
            {
                 Console.WriteLine($"Insufficient funds. Your balance is {balance}");
                int userAction = 2;
                return userAction;
            }
           return balance -= number;
            
        }

        /// <summary>
        /// Allows users to add to balance.
        /// </summary>
        /// <param name="number">Amount to be added to balance</param>
        /// <param name="balance">Current balance</param>
        /// <returns>integer balance</returns>
        public static int Deposit(int number,int balance)
        {
            if (number < 0)
            {
                Console.WriteLine("Invalid deposit");
                int userAction = 3;
                return userAction;
            }

            return balance += number;
        }

    }
}
