using NUnit.Framework;

namespace GildedRoseKata.Tests
{
    public class SpecialItemTests
    {
        [Test]
        public void SpecialItemQualityDegradesTwiceAsFastAsNormalItems()
        {
            SpecialItem specialItem = new SpecialItem {Name = "foo", Quality = 50, SellIn = 10};
            specialItem.UpdateQuality();
            Assert.AreEqual(48, specialItem.Quality);
            Assert.AreEqual(9, specialItem.SellIn);
        }

    }
}