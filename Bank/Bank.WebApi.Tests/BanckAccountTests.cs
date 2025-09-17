using Bank.WebApi.Models;
using NUnitAssert = NUnit.Framework.Assert;
using MsTestAssert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using NUnit.Framework;

namespace Bank.Domain.Tests
{
    public class BankAccountTests
    {
        [Test]
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            // Arrange
            double beginningBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);
            // Act
            account.Debit(debitAmount);
            // Assert
            double actual = account.Balance;
            MsTestAssert.AreEqual(expected, actual, 0.001);
        }
    }
}