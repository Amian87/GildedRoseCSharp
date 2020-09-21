using NUnit.Framework;

namespace GildedRoseKata.Tests
{
    public class FixedQualityTests
    {
        [Test]
        public void QualityAndSellInDateNeverChanges()
        {
            FixedQuality fixedQuality = new FixedQuality(){Name = "foo", Quality = 40, SellIn = 20};
            fixedQuality.UpdateQuality();
            Assert.AreEqual(40, fixedQuality.Quality);
            Assert.AreEqual(20, fixedQuality.SellIn);
        }
    }
}