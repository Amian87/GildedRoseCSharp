using NUnit.Framework;

namespace GildedRoseKata.Tests
{
    public class QualityAppreciatesTest
    {
        [Test]
        public void TestQualityAppreciatesByOneBeforeSellInDate()
        {
            QualityAppreciates item = new QualityAppreciates() { Name = "foo", Quality = 40, SellIn = 10 };
            item.UpdateQuality();
            Assert.AreEqual(41, item.Quality);
            Assert.AreEqual(9, item.SellIn);
        }

        [Test]
        public void TestQualityAppreciatesByTwoAfterSellInDate()
        {
            QualityAppreciates item = new QualityAppreciates(){Name = "foo", Quality = 34, SellIn = 0};
            item.UpdateQuality();
            Assert.AreEqual(36, item.Quality);
            Assert.AreEqual(-1, item.SellIn);
        }

        [Test]
        public void TestQualityIsNeverGreaterThanFifty()
        {
            QualityAppreciates item = new QualityAppreciates() {Name = "foo", Quality = 50, SellIn = 0};
            item.UpdateQuality();
            Assert.AreEqual(50, item.Quality);
            Assert.AreEqual(-1, item.SellIn);
        }
    }
}