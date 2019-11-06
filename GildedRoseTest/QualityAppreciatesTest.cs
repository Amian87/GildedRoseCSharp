using GildedRoseKata;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseTest
{
    class QualityAppreciatesTest
    {
        [Test]
        public void QualityAppreciatesOverOneDayPeriod()
        {
            QualityAppreicatesItem item = new QualityAppreicatesItem { Name = "Aged Brie", SellIn = 10, Quality = 20 };
            item.Update();
            Assert.AreEqual(22, item.Quality);
        }

        [Test]
        public void QualityNeverExceedsFifty()
        {
            QualityAppreicatesItem item = new QualityAppreicatesItem { Name = "Aged Brie", SellIn = 10, Quality = 50 };
            item.Update();
            Assert.AreEqual(50, item.Quality);
        }

        [Test]
        public void QualityNeverExceedsFiftyWhenFortyNine()
        {
            QualityAppreicatesItem item = new QualityAppreicatesItem { Name = "Aged Brie", SellIn = 10, Quality = 49 };
            item.Update();
            Assert.AreEqual(50, item.Quality);
        }

    }
}
