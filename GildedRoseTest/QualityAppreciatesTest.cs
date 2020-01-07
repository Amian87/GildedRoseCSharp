using System;
using System.Collections.Generic;
using System.Text;
using GildedRoseKata;
using NUnit.Framework;

namespace GildedRoseTest
{
    public class QualityAppreciatesTest
    {
        [Test]
        public void QualityNeverExceedsFifty()
        {
            QualityAppreciates item = new QualityAppreciates() {Name = "foo", Quality = 50, SellIn = 10};
            item.UpdateQuality();
            Assert.AreEqual(50, item.Quality);
        }

        [Test]
        public void QualityIncrementsByOneAndSellInDecrementsByOne()
        {
            QualityAppreciates item = new QualityAppreciates() {Name = "foo", Quality = 40, SellIn = 10};
            item.UpdateQuality();
            Assert.AreEqual(41,item.Quality);
            Assert.AreEqual(9, item.SellIn);
        }

        [Test]
        public void QualityIncrementsByTwoAfterSellIn()
        {
            QualityAppreciates item = new QualityAppreciates() { Name = "foo", Quality = 40, SellIn = 0 };
            item.UpdateQuality();
            Assert.AreEqual(42, item.Quality);
            Assert.AreEqual(-1, item.SellIn);
        }
    }
}
