using GildedRoseKata;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseTests
{
    class ConjuredDecoratorTest
    {
        [Test]
        public void QualityDegradesTwiceAsFastAsNormalItems()
        {
            ConjuredItems conjuredItem = new ConjuredItems { Name = "Aged Brie", Quality = 50, SellIn = 5 };
            ConjuredDecorator conjuredDecorator = new ConjuredDecorator(conjuredItem);
            conjuredDecorator.UpdateQuality();
            Assert.AreEqual(48, conjuredDecorator.Quality);
            Assert.AreEqual(4, conjuredDecorator.SellIn);
        }

        [Test]
        public void QualityCannotBeNegative()
        {
            ConjuredItems conjuredItem = new ConjuredItems { Name = "Aged Brie", Quality = 0, SellIn = 5 };
            ConjuredDecorator conjuredDecorator = new ConjuredDecorator(conjuredItem);
            conjuredDecorator.UpdateQuality();
            Assert.AreEqual(0, conjuredDecorator.Quality);
            Assert.AreEqual(4, conjuredDecorator.SellIn);
        }
    }
}
