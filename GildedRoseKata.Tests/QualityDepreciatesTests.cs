using NUnit.Framework;

namespace GildedRoseKata.Tests
{
    public class QualityDepreciatesTests
    {
        [Test]
        public void QualityAndSellInDecreasesByOne()
        {
            QualityDepreciates qualityDepreciates = new QualityDepreciates {Name = "foo", SellIn = 10, Quality = 4};
            qualityDepreciates.UpdateItemQuality();
            Assert.AreEqual(9, qualityDepreciates.SellIn);
            Assert.AreEqual(3, qualityDepreciates.Quality);
        }

        [Test]
        public void QualityIsNeverBelowZero()
        {
            QualityDepreciates qualityDepreciates = new QualityDepreciates { Name = "foo", SellIn = 10, Quality = 0 };
            qualityDepreciates.UpdateItemQuality();
            Assert.AreEqual(9, qualityDepreciates.SellIn);
            Assert.AreEqual(0, qualityDepreciates.Quality);
        }

        [Test]
        public void QualityDegradesByTwoAfterSellIn()
        {
            QualityDepreciates qualityDepreciates = new QualityDepreciates { Name = "foo", SellIn = 0, Quality = 10 };
            qualityDepreciates.UpdateItemQuality();
            Assert.AreEqual(-1, qualityDepreciates.SellIn);
            Assert.AreEqual(8, qualityDepreciates.Quality);
        }
    }
}