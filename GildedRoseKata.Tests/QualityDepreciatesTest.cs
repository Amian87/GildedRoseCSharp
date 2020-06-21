using NUnit.Framework;

namespace GildedRoseKata.Tests
{
    public class QualityDepreciatesTest
    {
        [Test]
        public void QualityOfAnItemIsNeverNegative()
        {
            QualityDepreciates qualityDepreciates = new QualityDepreciates {Name = "foo", Quality = 0, SellIn = 5};
            qualityDepreciates.UpdateQuality();
            Assert.AreEqual(0, qualityDepreciates.Quality);
            Assert.AreEqual(4, qualityDepreciates.SellIn);
        }

        [Test]
        public void QualityDegradesByTwoAfterSellInDate()
        {
            QualityDepreciates qualityDepreciates = new QualityDepreciates {Name = "foo", Quality = 10, SellIn = 0};
            qualityDepreciates.UpdateQuality();
            Assert.AreEqual(8,qualityDepreciates.Quality);
            Assert.AreEqual(-1, qualityDepreciates.SellIn);
        }

        [Test]
        public void QualityDegradesByOneBeforeSellInDate()
        {
            QualityDepreciates qualityDepreciates = new QualityDepreciates {Name = "foo", Quality = 15, SellIn = 4};
            qualityDepreciates.UpdateQuality();
            Assert.AreEqual(14, qualityDepreciates.Quality);
            Assert.AreEqual(3, qualityDepreciates.SellIn);
        }
    }
}