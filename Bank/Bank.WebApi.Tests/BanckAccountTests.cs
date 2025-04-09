using Bank.WebApi.Models;
using NUnit.Framework;

namespace Bank.WebApi.Tests
{
    [TestFixture]  // Atributo de NUnit para marcar la clase de pruebas
    public class BankAccountTests
    {
        [Test]  // Atributo de NUnit para marcar el método de prueba
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
            Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
        }
    }
}
