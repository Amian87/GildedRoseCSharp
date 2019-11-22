using System;
using GildedRoseKata;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace GildedRoseTests
{
    class FixedQualityTest
    {
        [Test]
        public void QualityAndSellInDateRemainUnchanged()
        {
            FixedQuality fixedQuality = new FixedQuality { Name = "foo", Quality = 10, SellIn = 10 };
            fixedQuality.UpdateQuality();
            Assert.AreEqual(10, fixedQuality.Quality);
            Assert.AreEqual(10, fixedQuality.SellIn);
        }

    }
}
