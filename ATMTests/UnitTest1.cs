using System;
using Xunit;
using BankApp;

namespace ATMTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("Balance", "1")]
        [InlineData("Withdraw", "2")]
        [InlineData("Deposit", "3")]
        [InlineData("Exit", "4")]
        public void MigratesToCorrectOperation(string expected, string commandInput)
        {
            Assert.Equal(expected, Program.Main(commandInput));
        }

        //[Fact]
        public void CannotHaveNegativeBalance()
        {

        }

        //[Fact]
        public void CannotDepositNegative()
        {

        }
        
        //[Fact]
        public void CanDepositDecimal()
        {

        }


    }
}
