using NUnit.Framework;

namespace GildedRoseKata.Tests
{
    public class SpecialItemTests
    {
        [Test]
        public void QualityDegradesTwiceAsNormal()
        {
            SpecialItem specialItem = new SpecialItem {Name = "foo", Quality = 30, SellIn = 10};
            specialItem.UpdateQuality();
            Assert.AreEqual(28, specialItem.Quality);
            Assert.AreEqual(9, specialItem.SellIn);
        }

        [Test]
        public void QualityIsNeverNegative()
        {
            SpecialItem specialItem = new SpecialItem { Name = "foo", Quality = 0, SellIn = 10 };
            specialItem.UpdateQuality();
            Assert.AreEqual(0, specialItem.Quality);
            Assert.AreEqual(9, specialItem.SellIn);
        }
    }
}