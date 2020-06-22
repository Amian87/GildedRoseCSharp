using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace GildedRoseKata.Tests
{
    public class GildedRoseTests
    {
        [Test]
        public void QualityDecrementsByTwoAfterSellInDate()
        {
            List<Item> item = new List<Item> { new QualityDepreciates {Name = "foo", Quality = 10, SellIn = 0}};
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(8, item[0].Quality);
            Assert.AreEqual(-1, item[0].SellIn);
        }

        [Test]
        public void QualityOfAnItemIsNeverNegative()
        {
            List<Item> item = new List<Item> {new QualityDepreciates {Name = "foo", Quality = 0, SellIn = 10}};
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(0, item[0].Quality);
            Assert.AreEqual(9, item[0].SellIn);
        }

        [Test]
        public void AgedBrieQualityIncreasesByOneBeforeSellInDate()
        {
            List<Item> item = new List<Item> { new QualityAppreciates { Name = "Aged Brie", Quality = 5, SellIn = 10 } };
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(6, item[0].Quality);
            Assert.AreEqual(9, item[0].SellIn);
        }

        [Test]
        public void AgedBrieQualityIncreasesByTwoAfterSellInDate()
        {
            List<Item> item = new List<Item> {new QualityAppreciates { Name = "Aged Brie", Quality = 7, SellIn = 0}};
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(9, item[0].Quality);
            Assert.AreEqual(-1, item[0].SellIn);
        }

        [Test]
        public void QualityIsNeverGreaterThanFifty()
        {
            List<Item> item = new List<Item> {new QualityAppreciates { Name = "Aged Brie", Quality = 50, SellIn = 3}};
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(50, item[0].Quality);
            Assert.AreEqual(2, item[0].SellIn);
        }

        [Test]
        public void LegendaryItemsQualityAndSellInRemainsTheSame()
        {
            List<Item> item = new List<Item> {new FixedItemQuality {Name = "Sulfuras, Hand of Ragnaros", Quality = 40, SellIn = 5}};
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(40, item[0].Quality);
            Assert.AreEqual(5, item[0].SellIn);
        }

        [Test]
        public void ConcertPassQualityIncreasesByTwoWhenThereAreTenDaysLeft()
        {
            List<Item> item = new List<Item> {new ConcertTicket { Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 30, SellIn = 10}};
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(32, item[0].Quality);
            Assert.AreEqual(9, item[0].SellIn);
        }

        [Test]
        public void ConcertPassQualityIncreasesByThreeWhenThereAreFiveDaysLeft()
        {
            List<Item> item = new List<Item> { new ConcertTicket { Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 30, SellIn = 5 } };
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(33, item[0].Quality);
            Assert.AreEqual(4, item[0].SellIn);
        }

        [Test]
        public void ConcertPassQualityDropsToZeroAfterConcert()
        {
            List<Item> item = new List<Item> { new ConcertTicket { Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 30, SellIn = 0 } };
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(0, item[0].Quality);
            Assert.AreEqual(-1, item[0].SellIn);
        }

        [Test]
        public void ConcertPassQualityIncreasesByOneWhenThereAreMoreThanTenDaysLeft()
        {
            List<Item> item = new List<Item> { new ConcertTicket { Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 30, SellIn = 11 } };
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(31, item[0].Quality);
            Assert.AreEqual(10, item[0].SellIn);
        }
    }
}
