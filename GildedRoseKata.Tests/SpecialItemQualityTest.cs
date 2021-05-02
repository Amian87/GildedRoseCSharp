using NUnit.Framework;

namespace GildedRoseKata.Tests
{
    public class SpecialItemQualityTest
    {
        [Test]
        public void TestSpecialItemDegradesTwiceAsFast()
        {
            SpecialItemQuality item = new SpecialItemQuality(){Name = "foo", Quality = 10, SellIn = 9};
            item.UpdateQuality();
            Assert.AreEqual(8, item.Quality);
            Assert.AreEqual(8, item.SellIn);
        }

        [Test]
        public void TestSpecialItemQualityIsNeverNegative()
        {
            SpecialItemQuality item = new SpecialItemQuality(){Name = "foo", Quality = 0, SellIn = 0};
            item.UpdateQuality();
            Assert.AreEqual(0, item.Quality);
            Assert.AreEqual(-1, item.SellIn);
        }
    }
}