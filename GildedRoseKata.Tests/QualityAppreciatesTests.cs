using NUnit.Framework;

namespace GildedRoseKata.Tests
{
    public class QualityAppreciatesTests
    {
        [Test]
        public void QualityAppreciatesByOneBeforeSellInDate()
        {
            QualityAppreciates qualityAppreciates = new QualityAppreciates() { Name = "foo", Quality = 10, SellIn = 5 };
            qualityAppreciates.UpdateQuality();
            Assert.AreEqual(11, qualityAppreciates.Quality);
            Assert.AreEqual(4, qualityAppreciates.SellIn);
        }

        [Test]
        public void QualityAppreciatesByTwoAfterSellInDate()
        {
            QualityAppreciates qualityAppreciates = new QualityAppreciates() {Name = "foo", Quality = 15, SellIn = 0};
            qualityAppreciates.UpdateQuality();
            Assert.AreEqual(17, qualityAppreciates.Quality);
            Assert.AreEqual(-1, qualityAppreciates.SellIn);
        }

        [Test]
        public void QualityCannotBeGreaterThanFifty()
        {
            QualityAppreciates qualityAppreciates = new QualityAppreciates() {Name = "foo", Quality = 50, SellIn = 0};
            qualityAppreciates.UpdateQuality();
            Assert.AreEqual(50, qualityAppreciates.Quality);
            Assert.AreEqual(-1, qualityAppreciates.SellIn);
        }
    }
}