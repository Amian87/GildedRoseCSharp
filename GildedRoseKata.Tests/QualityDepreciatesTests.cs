using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GildedRoseKata.Tests
{
    [TestClass]
    public class QualityDepreciatesTests
    {
        [TestMethod]
        public void QualityDepreciatesByOneBeforeSellInDate()
        {
            QualityDepreciates qualityDepreciates = new QualityDepreciates { Name = "foo", Quality = 30, SellIn = 5 };
            qualityDepreciates.UpdateQuality();
            Assert.AreEqual(29, qualityDepreciates.Quality);
            Assert.AreEqual(4, qualityDepreciates.SellIn);
        }

        [TestMethod]
        public void QualityDepreciatesByTwoAfterSellInDate()
        {
            QualityDepreciates qualityDepreciates = new QualityDepreciates { Name = "foo", Quality = 35, SellIn = 0 };
            qualityDepreciates.UpdateQuality();
            Assert.AreEqual(33, qualityDepreciates.Quality);
            Assert.AreEqual(-1, qualityDepreciates.SellIn);
        }

        [TestMethod]
        public void QualityIsNeverNegative()
        {
            QualityDepreciates qualityDepreciates = new QualityDepreciates { Name = "foo", Quality = 0, SellIn = 0 };
            qualityDepreciates.UpdateQuality();
            Assert.AreEqual(0, qualityDepreciates.Quality);
            Assert.AreEqual(-1, qualityDepreciates.SellIn);
        }
    }
}
