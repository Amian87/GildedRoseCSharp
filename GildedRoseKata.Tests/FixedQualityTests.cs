using NUnit.Framework;

namespace GildedRoseKata.Tests
{
    public class FixedQualityTests
    {
        [Test]
        public void TestQualityAndSellInDateRemainTheSame()
        {
            FixedQuality item = new FixedQuality() { Name = "foo", Quality = 10, SellIn = 5 };
            item.UpdateQuality();
            Assert.AreEqual(10, item.Quality);
            Assert.AreEqual(5, item.SellIn);
        }
    }
}