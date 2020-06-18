using System;
using NUnit.Framework;

namespace GildedRoseKata.Tests
{
    public class FixedItemQualityTests
    {
        [Test]
        public void ItemQualityAndSellInRemainsTheSame()
        {
            FixedItemQuality fixedItemQuality = new FixedItemQuality {Name = "foo", Quality = 15, SellIn= 10};
            fixedItemQuality.UpdateQuality();
            Assert.AreEqual(15, fixedItemQuality.Quality);
            Assert.AreEqual(10, fixedItemQuality.SellIn);
        }
    }
}