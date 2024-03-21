//using BankAccountNS;
using Bank;

namespace BankTestt
{
    [TestFixture]
    public class Tests
    {

        [Test]
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            double begginingBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;

            BankAccountNS account = new BankAccountNS()
            {
                m_cutomerName = "Mr. Bryan Walton",
                m_balance = begginingBalance,
            };

            //Act
            account.Debit(debitAmount);

            //Assert
            double actual = account.Balance;
            Assert.AreEqual(expected, actual,0.001 , "Actual not debited correctly");
        }

        //making debitamount in - to catch the exception
        [Test]
        public void Debit_WhemAmountIsLessThanZero_shouldThrowArugmentOutOfRange()
        {
            // Arrange
            double beginningBalance = 11.99;
            double debitAmount = -100.00;
            BankAccountNS account = new BankAccountNS()
            {
                m_cutomerName = "Mr . Bryan Walton",
                m_balance = beginningBalance,
            };

            // Act and assert
            Assert.Throws<System.ArgumentOutOfRangeException>(() => account.Debit(debitAmount));
        }
        //Making the debit amount greathen than Balance to catch the exception
        [Test]
        public void Debit_WhenAmountIsLEssThanZero_ShouldThrowArugmentOutOfRange()
        {
            double beginningBalance = 11.99;
            double debitAmount = 100.00;
            BankAccountNS account = new BankAccountNS()
            {
                m_cutomerName = "Mr . Bryan Walton",
                m_balance = beginningBalance,
            };

            // Act and assert
            Assert.Throws<System.ArgumentOutOfRangeException>(() => account.Debit(debitAmount));
        }
    }
}