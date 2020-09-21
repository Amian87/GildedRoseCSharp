using NUnit.Framework;

namespace GildedRoseKata.Tests
{
    public class QualityAppreciatesTests
    {
        [Test]
        public void QualityAppreciatesByOneBeforeSellInDate()
        {
            QualityAppreciates qualityAppreciates = new QualityAppreciates() { Name = "foo", Quality = 40, SellIn = 10 };
            qualityAppreciates.UpdateQuality();
            Assert.AreEqual(41, qualityAppreciates.Quality);
            Assert.AreEqual(9, qualityAppreciates.SellIn);
        }

        [Test]
        public void QualityAppreciatesByTwoAfterSellInDate()
        {
            QualityAppreciates qualityAppreciates = new QualityAppreciates() {Name = "foo", Quality = 34, SellIn = 0};
            qualityAppreciates.UpdateQuality();
            Assert.AreEqual(36, qualityAppreciates.Quality);
            Assert.AreEqual(-1, qualityAppreciates.SellIn);
        }

        [Test]
        public void QualityIsNeverGreaterThanFifty()
        {
            QualityAppreciates qualityAppreciates = new QualityAppreciates() {Name = "foo", Quality = 50, SellIn = 3};
            qualityAppreciates.UpdateQuality();
            Assert.AreEqual(50, qualityAppreciates.Quality);
            Assert.AreEqual(2, qualityAppreciates.SellIn);
        }
    }
}