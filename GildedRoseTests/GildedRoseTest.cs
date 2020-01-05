using GildedRoseKata;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace GildedRoseTests
{
    public class GildedRoseTest
    {
        [Test]
        public void ItemQualityNeverExceedsFifty()
        {
            List<Item> item = new List<Item> { new Item { Name = "Aged Brie", Quality = 50, SellIn = 10 } };
            var app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(50, item[0].Quality);

        }

        [Test]
        public void ItemQualityNeverNegative()
        {
            List<Item> item = new List<Item> { new Item { Name = "foo", Quality = 0, SellIn = 10 } };
            var app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(0, item[0].Quality);
            Assert.AreEqual(9, item[0].SellIn);
        }

        [Test]
        public void ItemQualityDecreasesByOne()
        {
            List<Item> item = new List<Item> { new Item { Name = "foo", Quality = 10, SellIn = 5 } };
            var app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(9, item[0].Quality);
            Assert.AreEqual(4, item[0].SellIn);
        }

        [Test]
        public void SulfurasQualityAndSellInNeverChanges()
        {
            List<Item> item = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", Quality = 100, SellIn = 10 } };
            var app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(100, item[0].Quality);
            Assert.AreEqual(10, item[0].SellIn);
        }

        [Test]
        public void AgedBrieQualityIncreasesByOneBeforeSellIn()
        {
            List<Item> item = new List<Item> { new Item { Name = "Aged Brie", Quality = 10, SellIn = 9 } };
            var app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(11, item[0].Quality);
            Assert.AreEqual(8, item[0].SellIn);
        }

        [Test]
        public void AgedBrieQualityIncreasesByTwoAfterSellIn()
        {
            List<Item> item = new List<Item> { new Item { Name = "Aged Brie", Quality = 10, SellIn = 0 } };
            var app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(12, item[0].Quality);
            Assert.AreEqual(-1, item[0].SellIn);
        }

        [Test]
        public void BackstagePassQualityIncreasesByOneTenDaysBeforeConcert()
        {
            List<Item> item = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 10, SellIn = 12 } };
            var app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(11, item[0].Quality);
            Assert.AreEqual(11, item[0].SellIn);
        }

        [Test]
        public void BackstagePassQualityIncreasesByTwoLessThanTensDaysBeforeConcert()
        {
            List<Item> item = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 10, SellIn = 10 } };
            var app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(12, item[0].Quality);
            Assert.AreEqual(9, item[0].SellIn);
        }

        [Test]
        public void BackstagePassQualityIncreasesByThreeLessThanFiveDaysBeforeConcert()
        {
            List<Item> item = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 10, SellIn = 5 } };
            var app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(13, item[0].Quality);
            Assert.AreEqual(4, item[0].SellIn);
        }

        [Test]
        public void BackstagePassQualityIsZeroAfterSellIn()
        {
            List<Item> item = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 10, SellIn = 0 } };
            var app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(0, item[0].Quality);
            Assert.AreEqual(-1, item[0].SellIn);
        }

    }
}
