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
            List<IItem> item = new List<IItem> { new Item { Name = "foo", Quality = 0, SellIn = -1 } };
            var app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(0, item[0].Quality);
            Assert.AreEqual(-2, item[0].SellIn);
        }

        [Test]
        public void QualityAndSellInOfAnItemDecrementsByOne()
        {
            List<IItem> item = new List<IItem> { new Item { Name = "foo", Quality = 10, SellIn = 10 } };
            var app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(9, item[0].SellIn);
            Assert.AreEqual(9, item[0].Quality);
        }

        [Test]
        public void AgedBrieQualityIncreasesByOneBeforeSellInDate()
        {
            List<IItem> item = new List<IItem> { new Item { Name = "Aged Brie", Quality = 10, SellIn = 10 } };
            var app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(11, item[0].Quality);
            Assert.AreEqual(9, item[0].SellIn);
        }

        [Test]
        public void AgedBrieQualityIncreasesByTwoAfterSellInDate()
        {
            List<IItem> item = new List<IItem> { new Item { Name = "Aged Brie", Quality = 10, SellIn = 0 } };
            var app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(12, item[0].Quality);
            Assert.AreEqual(-1, item[0].SellIn);
        }

        [Test]
        public void BackstagePassQualityIncreasesByTwoWhenThereAreLessThanTenDaysLeft()
        {
            List<IItem> item = new List<IItem> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 10, SellIn = 10 } };
            var app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(12, item[0].Quality);
            Assert.AreEqual(9, item[0].SellIn);
        }

        [Test]
        public void BackstagePassQualityIncreasesByThreeWhenThereAreLessThanFiveDaysLeft()
        {
            List<IItem> item = new List<IItem> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 10, SellIn = 5 } };
            var app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(13, item[0].Quality);
            Assert.AreEqual(4, item[0].SellIn);
        }

        [Test]
        public void BackstagePassQualityIsZeroAfterSellInDay()
        {
            List<IItem> item = new List<IItem> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 10, SellIn = 0 } };
            var app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(0, item[0].Quality);
            Assert.AreEqual(-1, item[0].SellIn);
        }

        [Test]
        public void SulfurasQualityAndSellInDateNeverDecreases()
        {
            List<IItem> item = new List<IItem> { new Item { Name = "Sulfuras, Hand of Ragnaros", Quality = 10, SellIn = 10 } };
            var app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(10, item[0].Quality);
            Assert.AreEqual(10, item[0].SellIn);
        }


    }
}
