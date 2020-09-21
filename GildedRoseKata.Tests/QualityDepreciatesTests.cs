using NUnit.Framework;

namespace GildedRoseKata.Tests
{
    public class QualityDepreciatesTests
    {
        [Test]
        public void QualityDepreciatesByOneBeforeSellInDate()
        {
            QualityDepreciates qualityDepreciates = new QualityDepreciates() { Name = "foo", Quality = 30, SellIn = 10};
            qualityDepreciates.UpdateQuality();
            Assert.AreEqual(29, qualityDepreciates.Quality);
            Assert.AreEqual(9, qualityDepreciates.SellIn);
        }

        [Test]
        public void QualityDepreciatesByTwoAfterSellInDate()
        {
            QualityDepreciates qualityDepreciates = new QualityDepreciates() {Name = "foo", Quality = 20, SellIn = 0};
            qualityDepreciates.UpdateQuality();
            Assert.AreEqual(18, qualityDepreciates.Quality);
            Assert.AreEqual(-1, qualityDepreciates.SellIn);
        }

        [Test]
        public void QualityIsNeverNegative()
        {
            QualityDepreciates qualityDepreciates = new QualityDepreciates() {Name = "foo", Quality = 0, SellIn = 0};
            qualityDepreciates.UpdateQuality();
            Assert.AreEqual(0, qualityDepreciates.Quality);
            Assert.AreEqual(-1, qualityDepreciates.SellIn);
        }
    }
}