using System.Collections.Generic;
using NUnit.Framework;

namespace GildedRoseKata.Tests
{
    public class FixedItemQualityTests
    {
        [Test]
        public void QualityRemainsTheSame()
        {
            FixQualityUpdateQuality fixQualityUpdateQuality = new FixQualityUpdateQuality {Name = "foo", Quality = 10, SellIn = 4};
            fixQualityUpdateQuality.UpdateItemQuality();
            Assert.AreEqual(10,fixQualityUpdateQuality.Quality);
        }
    }
}