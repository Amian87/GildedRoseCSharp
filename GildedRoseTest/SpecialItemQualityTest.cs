using System;
using System.Collections.Generic;
using System.Text;
using GildedRoseKata;
using NUnit.Framework;

namespace GildedRoseTest
{
    class SpecialItemQualityTest
    {
        [Test]
        public void QualityAndSellInNeverChanges()
        {
            SpecialItemQuality item = new SpecialItemQuality() {Name = "foo", Quality = 50, SellIn = 40};
            item.UpdateQuality();
            Assert.AreEqual(50,item.Quality);
            Assert.AreEqual(40,item.SellIn);
        }
    }
}
