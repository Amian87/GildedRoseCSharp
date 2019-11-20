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
            List<IItem> item = new List<IItem> { new QualityAppreciates { Name = "Aged Brie", Quality = 0, SellIn = 0 } };
            var app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(-1, item[0].SellIn);
            Assert.AreEqual(2, item[0].Quality);
            Assert.AreEqual("Aged Brie", item[0].Name);
        }

        [Test]
        public void AgedBrieIncreasesInQualityTheOlderItGets()
        {
            List<IItem> item = new List<IItem> { new QualityAppreciates { Name = "Aged Brie", Quality = 10, SellIn = 0 } };
            var app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(12, item[0].Quality);
        }

        [Test]
        public void QualityOfAnItemIsNeverNegative()
        {
            List<IItem> item = new List<IItem> { new Item { Name = "foo", Quality = 0, SellIn = 0 } };
            var app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(0, item[0].Quality);

        }


        [Test]
        public void QualityOfAnItemDecrementsByOne()
        {
            List<IItem> item = new List<IItem> { new Item { Name = "foo", Quality = 10, SellIn = 10 } };
            var app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(9, item[0].Quality);
            Assert.AreEqual(9, item[0].SellIn);
        }


        [Test]
        public void QualityNeverDegradesForSulfuras()
        {
            List<IItem> item = new List<IItem> { new FixQualityItem { Name = "Sulfuras, Hand of Ragnaros", Quality = 10, SellIn = 2 } };
            var app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(10, item[0].Quality);
        }

        [Test]
        public void QualityIsNeverGreaterThan50()
        {
            List<IItem> item = new List<IItem> { new QualityAppreciates { Name = "Aged Brie", Quality = 50, SellIn = 2 } };
            var app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(50, item[0].Quality);
        }

        [Test]
        public void BackstagePassQualityDropsToZeroAfterConcert()
        {
            List<IItem> item = new List<IItem> { new ConcertTicketValue { Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 10, SellIn = 0}};
            var app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(0, item[0].Quality);
        }

        [Test]
        public void BackstagePassQualityIncreaseByTwoWhenThereAreLessThanTenDaysRemaining()
        {
            List<IItem> item = new List<IItem> { new ConcertTicketValue { Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 10, SellIn = 10 } };
            var app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(12, item[0].Quality);
        }

        [Test]
        public void BackstagePassQualityIncreaseByThreeWhenThereAreLessThanFiveDaysRemaining()
        {
            List<IItem> item = new List<IItem> { new ConcertTicketValue { Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 10, SellIn = 5 } };
            var app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(13, item[0].Quality);
        }


    }
}
