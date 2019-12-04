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
            FixedQuality fixedQuality = new FixedQuality("foo", 10, 10);
            fixedQuality.UpdateQuality();
            Assert.AreEqual("foo, 10, 10", fixedQuality.PrintOut());
        }

    }
}
