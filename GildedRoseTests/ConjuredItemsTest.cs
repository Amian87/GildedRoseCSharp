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
            ConjuredItems conjuredItems = new ConjuredItems("foo", 5, 10 );
            conjuredItems.UpdateQuality();
            Assert.AreEqual("foo, 4, 8", conjuredItems.PrintOut());
        }

        [Test]
        public void QualityCannotBeNegative()
        {
            ConjuredItems conjuredItems = new ConjuredItems("foo", 5, 0 );
            conjuredItems.UpdateQuality();
            Assert.AreEqual("foo, 4, 0", conjuredItems.PrintOut());
        }

    }
}
