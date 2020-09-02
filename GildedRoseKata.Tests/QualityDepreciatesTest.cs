using NUnit.Framework;

namespace GildedRoseKata.Tests
{
    public class QualityDepreciatesTest
    {
        [Test]
        public void QualityDepricatesByOneBeforeSellIn()
        {
            QualityDepreciates qualityDepreciates = new QualityDepreciates {Name = "foo", Quality = 50, SellIn = 10};
            qualityDepreciates.UpdateQuality();
            Assert.AreEqual(49, qualityDepreciates.Quality);
            Assert.AreEqual(9, qualityDepreciates.SellIn);
        }

        [Test]
        public void QualityDepciatesByTwoAfterSellIn()
        {
            QualityDepreciates qualityDepreciates = new QualityDepreciates {Name = "foo", Quality = 40, SellIn = 0};
            qualityDepreciates.UpdateQuality();
            Assert.AreEqual(38, qualityDepreciates.Quality);
            Assert.AreEqual(-1, qualityDepreciates.SellIn);
        }

        [Test]
        public void QualityIsNeverNegative()
        {
            QualityDepreciates qualityDepreciates = new QualityDepreciates {Name = "foo", Quality = 0, SellIn = 10};
            qualityDepreciates.UpdateQuality();
            Assert.AreEqual(0, qualityDepreciates.Quality);
            Assert.AreEqual(9, qualityDepreciates.SellIn);
        }
    }
}