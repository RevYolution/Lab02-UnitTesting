using System;
using Xunit;
using BankApp;

namespace ATMTests
{
    public class UnitTest1
    {
    [Fact]
    public void canViewBalance()
        {
            Assert.Equal(1000, Program.ViewBalance());
        }

    [Theory]
    [InlineData(900, 100)]
    [InlineData(750, 250)]
    [InlineData(0, 1000)]
    [InlineData(500, 500)]

        public void canWithdraw(int expected, int withdrawn)
        {
            Assert.Equal(expected, Program.Withdrawal(withdrawn));
        }
    [Fact]
    public void canDeposit()
        {
            Assert.Equal(50, Program.Deposit());
        }
    }
}
