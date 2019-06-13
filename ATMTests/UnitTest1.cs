using System;
using Xunit;
using BankApp;

namespace ATMTests
{
    public class UnitTest1
    {
    [Theory]
    [InlineData(900, 100)]
    [InlineData(750, 250)]
    [InlineData(0, 1000)]
    [InlineData(500, 500)]

        public void canWithdraw(int expected, int withdrawn)
        {
            Program.balance = 1000;
            Assert.Equal(expected, Program.Withdraw(withdrawn, Program.balance));
        }

        [Theory]
        [InlineData(1100, 100)]
        [InlineData(1250, 250)]
        [InlineData(2000, 1000)]
        [InlineData(1500, 500)]

        public void canDeposit(int expected, int deposit)
        {
            Program.balance = 1000;
            Assert.Equal(expected, Program.Deposit(deposit, Program.balance));
        }

        [Theory]
        [InlineData(1000, -10)]
        [InlineData(1000, -100)]
        [InlineData(1000, -5)]
        [InlineData(1000, -6)]

        public void cannotDepositNegative(int expected, int deposit)
        {
            Program.balance = 1000;
            Assert.Equal(expected, Program.Deposit(deposit, Program.balance));
        }

        [Theory]
        [InlineData(0,10)]
        [InlineData(0, 100)]
        [InlineData(0, 5)]
        [InlineData(0, 6)]
        [InlineData(0, 0)]


        public void cannotOverWithdraw(int expected, int withdrawn)
        {
            Program.balance = 0;
            Assert.Equal(expected, Program.Withdraw(withdrawn, Program.balance));
        }
    }
}
