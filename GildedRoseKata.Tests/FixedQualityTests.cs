using NUnit.Framework;

namespace GildedRoseKata.Tests
{
    public class FixedQualityTests
    {
        [Test]
        public void QualityAndSellInDateNeverChanges()
        {
            FixedQuality fixedQuality = new FixedQuality() {Name = "foo", Quality = 30, SellIn = 10};
            fixedQuality.UpdateQuality();
            Assert.AreEqual(30, fixedQuality.Quality);
            Assert.AreEqual(10, fixedQuality.SellIn);
        }
    }
}