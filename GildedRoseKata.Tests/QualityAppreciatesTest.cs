using NUnit.Framework;

namespace GildedRoseKata.Tests
{
    public class QualityAppreciatesTest
    {
        [Test]
        public void QualityAppreciateByOneBeforeSellInDate()
        {
             QualityAppreciates qualityAppreciates = new QualityAppreciates { Name = "foo", Quality = 10, SellIn = 3 };
             qualityAppreciates.UpdateItemQuality();
             Assert.AreEqual(11,qualityAppreciates.Quality);
        }

        [Test]
        public void QualityAppreciatesByTwoAfterSellInDate()
        {
            QualityAppreciates qualityAppreciates = new QualityAppreciates {Name = "foo", Quality = 11, SellIn = -1};
            qualityAppreciates.UpdateItemQuality();
            Assert.AreEqual(13, qualityAppreciates.Quality);
        }

        [Test]
        public void QualityIsNeverGreaterThanFifty()
        {
            QualityAppreciates qualityAppreciates = new QualityAppreciates {Name = "foo", Quality = 50, SellIn = 10};
            qualityAppreciates.UpdateItemQuality();
            Assert.AreEqual(50, qualityAppreciates.Quality);
        }

    }
}