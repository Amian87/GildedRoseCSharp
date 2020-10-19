using NUnit.Framework;

namespace GildedRoseKata.UnitTests
{
    public class SpecialItemQualityTest
    {
        [Test]
        public void QualityDepreciatesByTwo()
        {
            SpecialItemQuality specialItem = new SpecialItemQuality() {Name = "foo", Quality = 43, SellIn = 2};
            specialItem.UpdateQuality();
            Assert.AreEqual(41, specialItem.Quality);
            Assert.AreEqual(1, specialItem.SellIn);
        }

        [Test]
        public void QualityIsNeverNegative()
        {
            SpecialItemQuality specialItem = new SpecialItemQuality() { Name = "foo", Quality = 0, SellIn = 2 };
            specialItem.UpdateQuality();
            Assert.AreEqual(0, specialItem.Quality);
            Assert.AreEqual(1, specialItem.SellIn);
        }
    }
}