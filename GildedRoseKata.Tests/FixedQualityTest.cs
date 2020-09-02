using NUnit.Framework;

namespace GildedRoseKata.Tests
{
    public class FixedQualityTest
    {
        [Test]
        public void ItemQualityAndSellInRemainsTheSame()
        {
            FixedQuality fixedQuality = new FixedQuality {Name = "foo", Quality = 50, SellIn = 10};
            fixedQuality.UpdateQuality();
            Assert.AreEqual(50, fixedQuality.Quality);
            Assert.AreEqual(10, fixedQuality.SellIn);
        }
    }
}