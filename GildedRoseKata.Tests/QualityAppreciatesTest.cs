using NUnit.Framework;

namespace GildedRoseKata.Tests
{
    public class QualityAppreciatesTest
    {
        [Test]
        public void QualityIncreasesByOneBeforeSellIn()
        {
            QualityAppreciates qualityAppreciates = new QualityAppreciates { Name = "foo", Quality = 49, SellIn = 10 };
            qualityAppreciates.UpdateQuality();
            Assert.AreEqual(50, qualityAppreciates.Quality);
            Assert.AreEqual(9, qualityAppreciates.SellIn);
        }

        [Test]
        public void QualityAppreciatesByTwoAfterSellIn()
        {
            QualityAppreciates qualityAppreciates = new QualityAppreciates {Name = "foo", Quality = 40, SellIn = 0};
            qualityAppreciates.UpdateQuality();
            Assert.AreEqual(42, qualityAppreciates.Quality);
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