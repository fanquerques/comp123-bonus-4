using BankApp;
using System.Security.Principal;

namespace BankTests
{
    [TestClass]
    public class BankAppTests
    {
        public BankAccount testerAccount = new BankAccount(123456, "BB-8", 2000.00);

        [TestMethod]
        [Owner("Fan Yang")]
        [TestCategory("Important")]
        public void Deposit_ValidAmount_UpdatesBalance()
        {
            // Arrange
            double depositAmount = 500.00;

            // Act
            testerAccount.Deposit(depositAmount);

            // Assert
            Assert.AreEqual(2500.00, testerAccount.Balance);
        }

        [TestMethod]
        [Owner("Fan Yang")]
        [TestCategory("Important")]
        public void Withdraw_ValidAmount_UpdatesBalance()
        {
            // Arrange
            double withdrawAmount = 300.00;

            // Act
            testerAccount.Withdraw(withdrawAmount);

            // Assert
            Assert.AreEqual(1700.00, testerAccount.Balance);
        }

        [TestMethod]
        [Owner("Fan Yang")]
        [TestCategory("Very Important")]
        public void Withdraw_MoreThanBalance_ThrowsException()
        {
            // Arrange
            double withdrawAmount = 2500.00;

            // Act
            testerAccount.Withdraw(withdrawAmount);

            // Assert
            throw new ArgumentOutOfRangeException("Can not withdraw more than the balance");
        }

        [TestMethod]
        [Owner("Fan Yang")]
        [TestCategory("Very Important")]
        public void Withdraw_ZeroOrNegativeAmount_ThrowsException()
        {
            // Arrange
            double withdrawAmount = -100.00;

            // Act
            testerAccount.Withdraw(withdrawAmount);

            //Assert
            throw new ArgumentOutOfRangeException("Can not withdraw 0 or a negative amount");
        }

        [TestMethod]
        [Owner("Fan Yang")]
        [TestCategory("Very Important")]
        public void Deposit_ZeroOrNegativeAmount_ThrowsException()
        {
            // Arrange
            double depositAmount = -500.00;

            // Act
            testerAccount.Deposit(depositAmount);

            // Assert
            throw new ArgumentOutOfRangeException("Can not deposit 0 or a negative amount");
        }
    }
}