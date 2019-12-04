using GildedRoseKata;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace GildedRoseTests
{
    public class GildedRoseTest
    {
        [Test]
        public void QualityOfAnItemIsNeverNegative()
        {
            IList<AbstractItem> Items = new List<AbstractItem> { new Item("foo", -1, 0) };
            var app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual("foo, -2, 0" , Items[0].PrintOut());
        }

        [Test]
        public void QualityAndSellInOfAnItemDecrementsByOne()
        {
            IList<AbstractItem> Items = new List<AbstractItem> { new Item("foo", 10, 10) };
            var app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual("foo, 9, 9", Items[0].PrintOut());
        }



    }
}
