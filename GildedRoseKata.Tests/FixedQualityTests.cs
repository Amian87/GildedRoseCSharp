using NUnit.Framework;

namespace GildedRoseKata.Tests
{
    public class FixedQualityTests
    {
        public void QualityAndSellInRemainTheSame()
        {
            FixedQuality fixedQuality = new FixedQuality() { Name = "foo", Quality = 15, SellIn = 12 };
            fixedQuality.UpdateQuality();
            Assert.AreEqual(15, fixedQuality.Quality);
            Assert.AreEqual(12, fixedQuality.SellIn);
        }
    }
}