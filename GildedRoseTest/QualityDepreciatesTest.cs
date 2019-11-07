using GildedRoseKata;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseTest
{
    class QualityDepreciatesTest
    {
        [Test]
        public void QualityIsNeverNegative()
        {
            QualityDepreciatesItem item = new QualityDepreciatesItem { Name = "Aged Brie", SellIn = 10, Quality = 0 };
            item.Update();
            Assert.AreEqual(0, item.Quality);
        }

        [Test]
        public void QualityDepreciatesByOne()
        {
            QualityDepreciatesItem item = new QualityDepreciatesItem { Name = "Aged Brie", SellIn = 10, Quality = 10 };
            item.Update();
            Assert.AreEqual(9, item.Quality);
        }

        [Test]
        public void QualityDepreciatesTwiceAsFastAfterSellin()
        {
            QualityDepreciatesItem item = new QualityDepreciatesItem { Name = "Aged Brie", SellIn = -1, Quality = 10 };
            item.Update();
            Assert.AreEqual(8, item.Quality);
        }

        [Test]
        public void QualityRemainsAtZero()
        {
            QualityDepreciatesItem item = new QualityDepreciatesItem { Name = "Aged Brie", SellIn = -1, Quality = 0 };
            item.Update();
            Assert.AreEqual(0, item.Quality);
        }

        [Test]
        public void DecrementSellInByOne()
        {
            QualityDepreciatesItem item = new QualityDepreciatesItem { Name = "Aged Brie", SellIn = 1, Quality = 0 };
            item.Update();
            Assert.AreEqual(0, item.SellIn);
        }

        [Test]
        public void WhenQualityIsNine()
        {
            QualityDepreciatesItem item = new QualityDepreciatesItem { Name = "Aged Brie", SellIn = 0, Quality = 10 };
            item.Update();
            Assert.AreEqual(8, item.Quality);
        }
    }
}
