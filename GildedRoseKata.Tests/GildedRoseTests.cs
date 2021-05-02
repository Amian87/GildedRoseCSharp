using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace GildedRoseKata.Tests
{
    public class GildedRoseTests
    {
        [Test]
        public void TestQualityDegradesTwiceAsFastAfterSellInDate()
        {
            List<Item> item = new List<Item> {new Item(){Name = "foo", Quality = 10, SellIn = 0}};
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(8, item[0].Quality);
            Assert.AreEqual(-1, item[0].SellIn);
        }

        [Test]
        public void TestQualityOfAnItemIsNeverNegative()
        {
            List<Item> item = new List<Item>() {new Item() {Name = "foo", Quality = 0, SellIn = 5}};
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(0, item[0].Quality);
            Assert.AreEqual(4, item[0].SellIn);
        }

        [Test]
        public void TestAgedBrieQualityIncreasesByOneBeforeSellInDate()
        {
            List<Item> item = new List<Item>() {new Item{Name = "Aged Brie", Quality = 15, SellIn = 10}};
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(16, item[0].Quality);
            Assert.AreEqual(9, item[0].SellIn);
        }

        [Test]
        public void TestQualityIsNeverGreaterThanFifty()
        {
            List<Item> item = new List<Item>() {new Item(){Name = "Aged Brie", Quality = 50, SellIn = 13}};
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(50, item[0].Quality);
            Assert.AreEqual(12, item[0].SellIn);
        }

        [Test]
        public void TestAgedBrieQualityIncreasesByTwoAfterSellInDate()
        {
            List<Item> item = new List<Item>() {new Item() {Name = "Aged Brie", Quality = 40, SellIn = 0}};
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(42, item[0].Quality);
            Assert.AreEqual(-1, item[0].SellIn);
        }

        [Test]
        public void TestSulfurasQualityAndSellInRemainsTheSame()
        {
            List<Item> item = new List<Item>() {new Item() {Name = "Sulfuras, Hand of Ragnaros", Quality = 10, SellIn = 10}};
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(10, item[0].Quality);
            Assert.AreEqual(10, item[0].SellIn);
        }

        [Test]
        public void TestBackstagePassQualityIncreasesByOneBeforeTenDays()
        {
            List<Item> item = new List<Item>() {new Item() {Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 40, SellIn = 11} };
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(41, item[0].Quality);
            Assert.AreEqual(10, item[0].SellIn);
        }

        [Test]
        public void TestBackstagePassQualityIncreasesByTwoBeforeFiveDays()
        {
            List<Item> item = new List<Item>() {new Item() {Name = "Backstage passes to a TAFKAL80ETC concert" , Quality = 35, SellIn = 10} };
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(37, item[0].Quality);
            Assert.AreEqual(9, item[0].SellIn);
        }

        [Test]
        public void TestBackStagePassQualityIncreasesByThreeLessThanFiveDays()
        {
            List<Item> item = new List<Item>() {new Item() {Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 37, SellIn = 5} };
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(40, item[0].Quality);
            Assert.AreEqual(4, item[0].SellIn);
        }

        [Test]
        public void TestBackstagePassQualityIsZeroAfterSellInDate()
        {
            List<Item> item = new List<Item>() {new Item() {Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 50, SellIn = 0} };
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(0, item[0].Quality);
            Assert.AreEqual(-1, item[0].SellIn);
        }
    }
}
