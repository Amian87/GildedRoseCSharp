using GildedRoseKata;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseTest
{
    class ConstantQualityItemTest
    {
        [Test]
        public void QualityNeverChange()
        {
            ConstantQualityItem item = new ConstantQualityItem { Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20 };
            Assert.AreEqual(20, item.Quality);
        }

        [Test]
        public void QualityNeverChangesOverAOneDayPeriod()
        {
            ConstantQualityItem item = new ConstantQualityItem { Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20 };
            item.Update();
            Assert.AreEqual(20, item.Quality);
        }

    }
}
