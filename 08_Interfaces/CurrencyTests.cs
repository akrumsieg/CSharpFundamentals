using _08_Interfaces.Currency;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _08_Interfaces
{
    [TestClass]
    public class CurrencyTests
    {
        [TestMethod]
        public void CurrencyValueTests()
        {
            ICurrency penny = new Penny();
            ICurrency dime = new Dime();
            ICurrency dollar = new Dollar();

            Assert.AreEqual(.01m, penny.Value);
            Assert.AreEqual(.10m, dime.Value);
            Assert.AreEqual(1m, dollar.Value);
        }

        [DataTestMethod]
        [DataRow(100.2)]
        [DataRow(37.12837451787342)]
        [DataRow(0)]
        [DataRow(-0.213984713897137487913874)]

        public void EPaymentTests (double value)
        {
            //DataRow uses double by default, so we need to convert to decimal first
            decimal convertedValue = Convert.ToDecimal(value);

            var ePay = new ElectronicPayment(convertedValue);

            Assert.AreEqual(convertedValue, ePay.Value);
        }
    }
}
