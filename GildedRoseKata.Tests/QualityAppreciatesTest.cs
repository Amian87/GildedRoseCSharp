using NuGet.Frameworks;
using NUnit.Framework;

namespace GildedRoseKata.Tests
{
    public class QualityAppreciatesTest
    {
        [Test]
        public void QualityIsNeverGreaterThanFifty()
        {
            QualityAppreciates qualityAppreciates = new QualityAppreciates { Name = "foo", Quality = 50, SellIn = 15 };
            qualityAppreciates.UpdateQuality();
            Assert.AreEqual(50, qualityAppreciates.Quality);
            Assert.AreEqual(14, qualityAppreciates.SellIn);
        }

        [Test]
        public void QualityAppreciatesByOneBeforeSellInDate()
        {
            QualityAppreciates qualityAppreciates = new QualityAppreciates {Name = "foo", Quality = 10, SellIn = 14};
            qualityAppreciates.UpdateQuality();
            Assert.AreEqual(11, qualityAppreciates.Quality);
            Assert.AreEqual(13, qualityAppreciates.SellIn);
        }

        [Test]
        public void QualityAppreciatesByTwoAfterSellInDate()
        {
            QualityAppreciates qualityAppreciates = new QualityAppreciates {Name = "foo", Quality = 40, SellIn = 0};
            qualityAppreciates.UpdateQuality();
            Assert.AreEqual(42, qualityAppreciates.Quality);
            Assert.AreEqual(-1, qualityAppreciates.SellIn);
        }
    }
}