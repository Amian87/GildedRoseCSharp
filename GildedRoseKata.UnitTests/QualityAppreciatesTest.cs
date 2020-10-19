using NUnit.Framework;

namespace GildedRoseKata.UnitTests
{
    public class QualityAppreciatesTest
    {
        [Test]
        public void QualityAppreciatesByOneBeforeSellInDate()
        {
            QualityAppreciates qualityAppreciates = new QualityAppreciates {Name = "foo", Quality = 41, SellIn = 3};
            qualityAppreciates.UpdateQuality();
            Assert.AreEqual(42, qualityAppreciates.Quality);
            Assert.AreEqual(2, qualityAppreciates.SellIn);
        }

        [Test]
        public void QualityAppreciatesByTwoAfterSellInDate()
        {
            QualityAppreciates qualityAppreciates = new QualityAppreciates {Name = "foo", Quality = 34, SellIn = 0};
            qualityAppreciates.UpdateQuality();
            Assert.AreEqual(36, qualityAppreciates.Quality);
            Assert.AreEqual(-1, qualityAppreciates.SellIn);
        }

        [Test]
        public void QualityIsNeverGreaterThanFifty()
        {
            QualityAppreciates qualityAppreciates = new QualityAppreciates {Name = "foo", Quality = 50, SellIn = 0};
            qualityAppreciates.UpdateQuality();
            Assert.AreEqual(50, qualityAppreciates.Quality);
            Assert.AreEqual(-1, qualityAppreciates.SellIn);
        }
    }
}