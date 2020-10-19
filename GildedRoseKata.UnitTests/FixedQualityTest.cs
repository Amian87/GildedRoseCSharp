using NUnit.Framework;

namespace GildedRoseKata.UnitTests
{
    public class FixedQualityTest
    {
        [Test]
        public void QualityAndSellInDateNeverChange()
        {
            FixedQuality fixedQuality = new FixedQuality { Name = "foo", Quality = 15, SellIn = 15 };
            fixedQuality.UpdateQuality();
            Assert.AreEqual(15, fixedQuality.Quality);
            Assert.AreEqual(15, fixedQuality.SellIn);
        }
    }
}