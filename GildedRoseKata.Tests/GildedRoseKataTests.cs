using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace GildedRoseKata.Tests
{
    [TestClass]
    public class GildedRoseKataTests
    {
        [TestMethod]
        public void QualityDegradesTwiceAsFastAfterSellInDate()
        {
            IList<Item> item = new List<Item> { new Item { Name = "foo", Quality = 10, SellIn = 0 } };
            var app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(8, item[0].Quality);
            Assert.AreEqual(-1, item[0].SellIn);
        }

        [TestMethod]
        public void QualityIsNeverNegative()
        {
            IList<Item> item = new List<Item> { new Item { Name = "foo", Quality = 0, SellIn = 2 } };
            var app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(0, item[0].Quality);
            Assert.AreEqual(1, item[0].SellIn);
        }

        [TestMethod]
        public void AgedBrieQualityIncreasesByOne()
        {
            IList<Item> item = new List<Item> { new Item { Name = "Aged Brie", Quality = 12, SellIn = 1 } };
            var app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(13, item[0].Quality);
            Assert.AreEqual(0, item[0].SellIn);
        }

        [TestMethod]
        public void QualityIsNeverGreaterThanFifty()
        {
            IList<Item> item = new List<Item> { new Item { Name = "Aged Brie", Quality = 50, SellIn = 2 } };
            var app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(50, item[0].Quality);
            Assert.AreEqual(1, item[0].SellIn);
        }

        [TestMethod]
        public void SulfurasQualityAndSellInDoesNotChange()
        {
            IList<Item> item = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", Quality = 15, SellIn = 13 } };
            var app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(15, item[0].Quality);
            Assert.AreEqual(13, item[0].SellIn);
        }

        [TestMethod]
        public void BackstagePassQualityIncreasesByOneBeforeTenDays()
        {
            IList<Item> item = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 20, SellIn = 11 } };
            var app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(21, item[0].Quality);
            Assert.AreEqual(10, item[0].SellIn);
        }

        [TestMethod]
        public void BackstagePassQualityIncreaseByTwoLessThanTenDays()
        {
            IList<Item> item = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 25, SellIn = 6 } };
            var app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(27, item[0].Quality);
            Assert.AreEqual(5, item[0].SellIn);
        }

        [TestMethod]
        public void BackstagePassQualityIncreasesByThreeLessThanFiveDays()
        {
            IList<Item> item = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 30, SellIn = 5 } };
            var app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(33, item[0].Quality);
            Assert.AreEqual(4, item[0].SellIn);
        }

        [TestMethod]
        public void BackstagePassQualityIsZeroAfterSellInDate()
        {
            IList<Item> item = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 9, SellIn = 0} };
            var app = new GildedRose(item);  
            app.UpdateQuality();
            Assert.AreEqual(0, item[0].Quality);
            Assert.AreEqual(-1, item[0].SellIn);
        }

    }
}
