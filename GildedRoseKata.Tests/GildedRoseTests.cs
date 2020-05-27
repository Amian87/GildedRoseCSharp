using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

namespace GildedRoseKata.Tests
{
    public class GildedRoseTests
    {

        [Test]
        public void QualityDegradesTwiceAsFastAfterSellInDate()
        {
            IList<Item> item = new List<Item> {new Item() {Name = "foo", SellIn = 0, Quality = 100}};
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(98,item[0].Quality);
            Assert.AreEqual(-1,item[0].SellIn);
        }

        [Test]
        public void QualityOfAnItemIsNeverNegative()
        {
            IList<Item> item = new List<Item> {new Item {Name = "foo", SellIn = 0, Quality = 0}};
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(0, item[0].Quality);
        }

        [Test]
        public void AgedBrieQualityIncreasesByOneBeforeSellIn()
        {
            IList<Item> item = new List<Item>{new Item {Name = "Aged Brie", SellIn = 5, Quality = 10}};
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(11, item[0].Quality);
            Assert.AreEqual(4, item[0].SellIn);
        }

        [Test]
        public void AgedBrieQualityIncreasesByTwoAfterSellIn()
        {
            IList<Item> item = new List<Item> {new Item {Name = "Aged Brie", SellIn = 0, Quality = 10}};
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(12,item[0].Quality);
            Assert.AreEqual(-1, item[0].SellIn);
        }

        [Test]
        public void QualityOfAnItemNeverGreaterThanFifty()
        {
            IList<Item> item = new List<Item> {new Item {Name = "Aged Brie", SellIn = 0, Quality = 50}};
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(50, item[0].Quality);
            Assert.AreEqual(-1, item[0].SellIn);
        }

        [Test]
        public void SulfurasQualityAndSellInNeverChanges()
        {
            IList<Item> item = new List<Item> {new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 15}};
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(15,item[0].Quality);
            Assert.AreEqual(0,item[0].SellIn);
        }

        [Test]
        public void BackStagePassQualityIncreasesByTwoWhenThereAreTenDaysOrLess()
        {
            IList<Item> item = new List<Item> {new Item {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 20}};
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(22,item[0].Quality);
            Assert.AreEqual(9,item[0].SellIn);
        }

        [Test]
        public void BackStagePassQualityIncreasesByThreeWhenThereAreFiveDaysOrLess()
        {
            IList<Item> item = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 20 } };
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(23, item[0].Quality);
            Assert.AreEqual(4, item[0].SellIn);
        }

        [Test]
        public void BackStagePassQualityFallsToZeroAfterSellIn()
        {
            IList<Item> item = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 20 } };
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(0, item[0].Quality);
            Assert.AreEqual(-1, item[0].SellIn);
        }


    }
}
