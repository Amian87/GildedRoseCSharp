using NUnit.Framework;

namespace GildedRoseKata.Tests
{
    public class QualityDepreciatesTest
    {
        [Test]
        public void QualityDepreciatesByOneBeforeSellInDate()
        {
            QualityDepreciates item = new QualityDepreciates() { Name = "foo", Quality = 40, SellIn = 20 };
            item.UpdateQuality();
            Assert.AreEqual(39, item.Quality);
            Assert.AreEqual(19, item.SellIn);
        }

        [Test]
        public void QualityDepreciatesByTwoAfterSellInDate()
        {
            QualityDepreciates item = new QualityDepreciates(){Name = "foo", Quality = 30, SellIn = 0};
            item.UpdateQuality();
            Assert.AreEqual(28, item.Quality);
            Assert.AreEqual(-1, item.SellIn);
        }

        [Test]
        public void TestQualityIsNeverNegative()
        {
            QualityDepreciates item = new QualityDepreciates(){Name = "foo", Quality = 1, SellIn = 0};
            item.UpdateQuality();
            Assert.AreEqual(0, item.Quality);
            Assert.AreEqual(-1, item.SellIn);
        }
    }
}