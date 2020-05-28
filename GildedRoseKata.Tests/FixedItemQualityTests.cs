using System.Collections.Generic;
using NUnit.Framework;

namespace GildedRoseKata.Tests
{
    public class FixedItemQualityTests
    {
        [Test]
        public void QualityRemainsTheSame()
        {
            FixQualityItem fixQualityItem = new FixQualityItem {Name = "foo", Quality = 10, SellIn = 4};
            fixQualityItem.UpdateItemQuality();
            Assert.AreEqual(10,fixQualityItem.Quality);
        }
    }
}