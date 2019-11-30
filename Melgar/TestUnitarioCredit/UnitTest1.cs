using System;
using Camila;
using Camila.BankAccountNS;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestUnitarioCredito
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Credit_WithValidAmount_UpdatesBalance()
        {
            
    // Arrange
    double beginningBalance = 11.99;
    double creditAmount = 4.55;
    double expected = 7.44;
    BankAccount account = new BankAccount("Mr. Alberto S", beginningBalance);

    // Act
    account.Credit(creditAmount);

    // Assert
    double actual = account.Balance;
    Assert.AreEqual(expected, actual, 0.001, "Account not credited correctly");
        }
    }

}