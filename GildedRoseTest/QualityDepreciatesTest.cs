using System;
using System.Collections.Generic;
using System.Text;
using GildedRoseKata;
using NUnit.Framework;

namespace GildedRoseTest
{
    class QualityDepreciatesTest
    {
        [Test]
        public void QualityAndSellInDecrementsByOne()
        {
            QualityDepreciates item = new QualityDepreciates() { Name = "foo", Quality = 55, SellIn = 10 };
            item.UpdateQuality();
            Assert.AreEqual(54,item.Quality);
            Assert.AreEqual(9,item.SellIn);
        }

        [Test]
        public void QualityIsNeverNegative()
        {
            QualityDepreciates item = new QualityDepreciates() {Name = "foo", Quality = 0, SellIn = 5};
            item.UpdateQuality();
            Assert.AreEqual(0, item.Quality);
        }

        [Test]
        public void ItemQualityDegradesTwiceAsFastAfterSellIn()
        {
            QualityDepreciates item = new QualityDepreciates() {Name = "foo", Quality = 10, SellIn = 0};
            item.UpdateQuality();
            Assert.AreEqual(8, item.Quality);
            Assert.AreEqual(-1, item.SellIn);
        }
    }
}
