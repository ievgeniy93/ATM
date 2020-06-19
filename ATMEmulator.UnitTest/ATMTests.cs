using ATMEmulator.Models;
using NUnit.Framework;
using System;


namespace ATMEmulator.UnitTests
{
    [TestFixture]
    public class ATMTests
    {
        [Test]
        public void GetSumMoney_EmptyList_ReturnsZero()
        {
            // Arrange - подготовка
            var atm = new ATM();

            // Act - Выполнение действия, которое мы хотим протестировать
            int result = atm.GetSumMoney();

            // Assert - Проверка того, что результат совпадает с нашим ожиданием
            Assert.AreEqual(0, result);
        }

        [Test]
        public void GetSumMoney_NotEmptyList_ReturnsSum()
        {
            // Arrange - подготовка
            var atm = new ATM();
            var banknotes = new Banknote();
            banknotes.Nominal = 1;
            atm.Banknotes.Add(banknotes);


            // Act - Выполнение действия, которое мы хотим протестировать
            int result = atm.GetSumMoney();

            // Assert - Проверка того, что результат совпадает с нашим ожиданием
            Assert.AreEqual(1, result);
        }
    }
}
