using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankAccount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount.Tests
{
    [TestClass()]
    public class AccountTests
    {
        [TestMethod()]
        public void Deposit_PoisitveAmount_AddsToBalance()
        {
            // AAA Pattern (Arrange, Act, Assert)

            //Arrange - Init objects/variables
            Account checking = new Account();
            double depositAmt = 10;
            double expectedBalance = 10;

            //Act - Call method under test
            checking.Deposit(depositAmt);

            //Assert - Verification step
            Assert.AreEqual(expectedBalance, checking.Balance);

        }

        [TestMethod]
        public void Deposit_PositiveAmount_ReturnsUpdatedBalance()
        {
            //Arrange
            Account acc = new Account();
            double depositAmt = 10.55;
            double expectedReturn = 10.55;

            //Act
            double result = acc.Deposit(depositAmt);

            //Assert
            Assert.AreEqual(expectedReturn, result);
        }

        [TestMethod]
        public void Depost_NegativeAmount_ThrowsArgumentException()
        {
            //Arrange
            Account acc = new Account();
            double depositAmt = -1;

            //Act => Assert 
            Assert.ThrowsException<ArgumentException>
                (() => acc.Deposit(depositAmt));
        }
    }
}