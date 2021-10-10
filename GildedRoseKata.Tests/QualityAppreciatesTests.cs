using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GildedRoseKata.Tests
{
    [TestClass]
    public class QualityAppreciatesTests
    { 
        [TestMethod]
        public void QualityIsNeverGreaterThanFifty()
        {
            QualityAppreciates qualityAppreciates = new QualityAppreciates { Name = "foo", Quality = 50, SellIn = 5 };
            qualityAppreciates.UpdateQuality();
            Assert.AreEqual(50, qualityAppreciates.Quality);
            Assert.AreEqual(4, qualityAppreciates.SellIn);
        }

        [TestMethod]
        public void QualityAppreciatesByOne()
        {
            QualityAppreciates qualityAppreciates = new QualityAppreciates { Name = "foo", Quality = 40, SellIn = 9 };
            qualityAppreciates.UpdateQuality();
            Assert.AreEqual(41, qualityAppreciates.Quality);
            Assert.AreEqual(8, qualityAppreciates.SellIn);
        }
    }
}
