using System;
using System.Collections.Generic;
using System.Text;
using GildedRoseKata;
using NUnit.Framework;

namespace GildedRoseTests
{
    class QualityDepreciatesTest
    {
        [Test]
        public void QualityIsNeverNegative()
        {
            QualityDepreciates item = new QualityDepreciates { Name = "foo", Quality = 0, SellIn = 10 };
            item.UpdateQuality();
            Assert.AreEqual(0, item.Quality);
        }
    }
}
