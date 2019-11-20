using GildedRoseKata;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace GildedRoseTests
{
    public class GildedRoseTest
    {
        [Test]
        public void AgedBrieWhenSellInAndQualityAreZero()
        {
            List<Item> item = new List<Item> { new Item { Name = "Aged Brie", Quality = 0, SellIn = 0 } };
            var app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(-1, item[0].SellIn);
            Assert.AreEqual(2, item[0].Quality);
            Assert.AreEqual("Aged Brie", item[0].Name);
        }

        [Test]
        public void AgedBrieIncreasesInQualityTheOlderItGets()
        {
            List<Item> item = new List<Item> { new Item { Name = "Aged Brie", Quality = 10, SellIn = 0 } };
            var app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(12, item[0].Quality);
        }

        [Test]
        public void QualityOfAnItemIsNeverNegative()
        {
            List<Item> item = new List<Item> { new Item { Name = "foo", Quality = 0, SellIn = 0 } };
            var app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(0, item[0].Quality);

        }

        [Test]
        public void QualityNeverDegradesForSulfuras()
        {
            List<Item> item = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", Quality = 10, SellIn = 2 } };
            var app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(10, item[0].Quality);
        }

        [Test]
        public void QualityIsNeverGreaterThan50()
        {
            List<Item> item = new List<Item> { new Item { Name = "Aged Brie", Quality = 50, SellIn = 2 } };
            var app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(50, item[0].Quality);
        }

        [Test]
        public void BackstagePassQualityDropsToZeroAfterConcert()
        {
            List<Item> item = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 10, SellIn = 0}};
            var app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(0, item[0].Quality);
        }

        [Test]
        public void BackstagePassQualityIncreaseByTwoWhenThereAreLessThanTenDaysRemaining()
        {
            List<Item> item = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 10, SellIn = 10 } };
            var app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(12, item[0].Quality);
        }

        [Test]
        public void BackstagePassQualityIncreaseByThreeWhenThereAreLessThanFiveDaysRemaining()
        {
            List<Item> item = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 10, SellIn = 5 } };
            var app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(13, item[0].Quality);
        }


    }
}
