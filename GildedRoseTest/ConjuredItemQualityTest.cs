using System;
using System.Collections.Generic;
using System.Text;
using GildedRoseKata;
using NUnit.Framework;

namespace GildedRoseTest
{
    class ConjuredItemQualityTest
    {
        [Test]
        public void ConjuredItemDegradesTwiceAsFastAsNormalItems()
        {
            ConjuredItemQuality item = new ConjuredItemQuality {Name = "foo", Quality = 10, SellIn = 1};
            item.UpdateQuality();
            Assert.AreEqual(8,item.Quality);
            Assert.AreEqual(1, item.SellIn);
        }
    }
}
