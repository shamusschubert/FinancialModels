using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FinancialModels.UnitTests
{
    [TestClass]
    public class RevenueTests
    {
        [TestMethod]
        public void CalcTotalRevenueTest()
        {
            IRevenue rev = new Revenue();

            var expected = 0;

            Assert.AreEqual(expected, rev.Amount);
        }
    }
}
