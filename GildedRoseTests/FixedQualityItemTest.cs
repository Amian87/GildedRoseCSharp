using GildedRoseKata;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseTests
{
    class FixedQualityItemTest
    {
        [Test]
        public void QualityRemainsTheSame()
        {
            FixQualityItem fixQualityItem = new FixQualityItem { Name = "foo", Quality = 10, SellIn = 4 };
            fixQualityItem.UpdateQuality();
            Assert.AreEqual(10, fixQualityItem.Quality);
        }

    }
}
