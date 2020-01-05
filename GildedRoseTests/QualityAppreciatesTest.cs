using System;
using GildedRoseKata;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace GildedRoseTests
{
    class QualityAppreciatesTest
    {
        [Test]
        public void QualityAppreciatesByOneBeforeSellIn()
        {
            QualityAppreciates item = new QualityAppreciates { Name = "foo", Quality = 10, SellIn = 10 };
            item.UpdateQuality();
            Assert.AreEqual(11, item.Quality);
            Assert.AreEqual(9, item.SellIn);

        }

        [Test]
        public void QualityAppreciatedByTwoAfterSellIn()
        {
            QualityAppreciates item = new QualityAppreciates { Name = "foo", Quality = 14, SellIn = 0 };
            item.UpdateQuality();
            Assert.AreEqual(16, item.Quality);
            Assert.AreEqual(-1, item.SellIn);
        }

        [Test]
        public void QualityIsNeverGreaterThanFifty()
        {
            QualityAppreciates item = new QualityAppreciates { Name = "foo", Quality = 50, SellIn = 0 };
            item.UpdateQuality();
            Assert.AreEqual(50, item.Quality);
            Assert.AreEqual(-1, item.SellIn);
        }

    }
}
