using NUnit.Framework;

namespace GildedRoseKata.Tests
{
    public class SpecialItemTests
    {
        [Test]
        public void QualityDecreasesByOneBeforeSellInDate()
        {
            SpecialItem specialItem = new SpecialItem {Name = "foo", Quality = 40, SellIn = 10};
            specialItem.UpdateQuality();
            Assert.AreEqual(39, specialItem.Quality);
            Assert.AreEqual(9, specialItem.SellIn);
        }

        [Test]
        public void QualityDecreasesByTwoAfterSellInDate()
        {
            SpecialItem specialItem = new SpecialItem { Name = "foo", Quality = 40, SellIn = 0 };
            specialItem.UpdateQuality();
            Assert.AreEqual(38, specialItem.Quality);
            Assert.AreEqual(-1, specialItem.SellIn);
        }

        [Test]
        public void QualityIsNeverNegative()
        {
            SpecialItem specialItem = new SpecialItem { Name = "foo", Quality = 0, SellIn = 0 };
            specialItem.UpdateQuality();
            Assert.AreEqual(0, specialItem.Quality);
            Assert.AreEqual(-1, specialItem.SellIn);
        }
    }
}