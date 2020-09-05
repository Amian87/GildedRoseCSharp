using NUnit.Framework;

namespace GildedRoseKata.Tests
{
    public class QualityDepreciatesTests
    {
        [Test]
        public void QualityDepreciatesByOneBeforeSellInDate()
        {
            QualityDepreciates qualityDepreciates = new QualityDepreciates(){Name = "foo", Quality = 40, SellIn = 10};
            qualityDepreciates.UpdateQuality();
            Assert.AreEqual(39, qualityDepreciates.Quality);
            Assert.AreEqual(9, qualityDepreciates.SellIn);
        }

        [Test]
        public void QualityDepreciatesByTwoAfterSellInDate()
        {
            QualityDepreciates qualityDepreciates = new QualityDepreciates() {Name = "foo", Quality = 35, SellIn = 0};
            qualityDepreciates.UpdateQuality();
            Assert.AreEqual(33, qualityDepreciates.Quality);
            Assert.AreEqual(-1, qualityDepreciates.SellIn);
        }

        [Test]
        public void QualityOfAnItemIsNeverNegative()
        {
            QualityDepreciates qualityDepreciates = new QualityDepreciates() {Name = "foo", Quality = 0, SellIn = 0};
            qualityDepreciates.UpdateQuality();
            Assert.AreEqual(0, qualityDepreciates.Quality);
            Assert.AreEqual(-1, qualityDepreciates.SellIn);
        }
    }
}