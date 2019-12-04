using GildedRoseKata;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseTests
{
    class ConjuredItemsTest
    {
        [Test]
        public void QualityDegradesTwiceAsFastAsNormalItems()
        {
            ConjuredItems conjuredItems = new ConjuredItems { Name = "Aged Brie", Quality = 10, SellIn = 5 };
            conjuredItems.UpdateQuality();
            Assert.AreEqual(8, conjuredItems.Quality);
            Assert.AreEqual(4, conjuredItems.SellIn);
        }

        [Test]
        public void QualityCannotBeNegative()
        {
            ConjuredItems conjuredItems = new ConjuredItems { Name = "Aged Brie", Quality = 0, SellIn = 5 };
            conjuredItems.UpdateQuality();
            Assert.AreEqual(0, conjuredItems.Quality);
            Assert.AreEqual(4, conjuredItems.SellIn);
        }

    }
}
