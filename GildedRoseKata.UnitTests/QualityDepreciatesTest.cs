using NUnit.Framework;

namespace GildedRoseKata.UnitTests
{
    public class QualityDepreciatesTest
    {
        [Test]
        public void QualityDepreciatesByOneBeforeSellInDate()
        {
            QualityDepreciates qualityDepreciates = new QualityDepreciates { Name = "foo", Quality = 30, SellIn = 1};
            qualityDepreciates.UpdateQuality();
            Assert.AreEqual(29, qualityDepreciates.Quality);
            Assert.AreEqual(0, qualityDepreciates.SellIn);
        }

        [Test]
        public void QualityDepreciatesByTwoAfterSellInDate()
        {
            QualityDepreciates qualityDepreciates = new QualityDepreciates {Name = "foo", Quality = 40, SellIn = 0};
            qualityDepreciates.UpdateQuality();
            Assert.AreEqual(38, qualityDepreciates.Quality);
            Assert.AreEqual(-1, qualityDepreciates.SellIn);
        }

        [Test]
        public void QualityIsNeverNegative()
        {
            QualityDepreciates qualityDepreciates = new QualityDepreciates {Name = "foo", Quality = 0, SellIn = 0};
            qualityDepreciates.UpdateQuality();
            Assert.AreEqual(0, qualityDepreciates.Quality);
            Assert.AreEqual(-1, qualityDepreciates.SellIn);
        }
    }
}