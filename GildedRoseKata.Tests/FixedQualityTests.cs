using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GildedRoseKata.Tests
{
    [TestClass]
    public class FixedQualityTests 
    { 
        [TestMethod]
        public void QualityAndSellInRemainsTheSame()
        {
            FixedQuality fixedQuality = new FixedQuality { Name = "foo", Quality = 15, SellIn = 15 };
            fixedQuality.UpdateQuality();
            Assert.AreEqual(15, fixedQuality.Quality);
            Assert.AreEqual(15, fixedQuality.SellIn);
        }
    }
}
