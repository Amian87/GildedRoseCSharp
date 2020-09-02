using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace GildedRoseKata.Tests
{
    public class GildedRoseTests
    {
        [Test]
        public void QualityOfAnItemNeverGoesBelowZero()
        {
            List<IItem> item = new List<IItem> {new Item {Name =  "foo", Quality = 0, SellIn = 10 }};
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(0, item[0].Quality);
            Assert.AreEqual(9, item[0].SellIn);
        }

        [Test]
        public void AgedBrieQualityOfAnItemNeverExceedsFifty()
        {
            List<IItem> item = new List<IItem> {new Item {Name = "Aged Brie", Quality = 50, SellIn = 10}};
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(50, item[0].Quality);
            Assert.AreEqual(9, item[0].SellIn);
        }

        [Test]
        public void AgedBrieQualityIncreasesByTwoAfterSellIn()
        {
            List<IItem> item = new List<IItem> { new Item { Name = "Aged Brie", Quality = 48, SellIn = 0 } };
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(50, item[0].Quality);
            Assert.AreEqual(-1, item[0].SellIn);
        }

        [Test]
        public void QualityOfAnItemDegradesByTwoAfterSellIn()
        {
            List<IItem> item = new List<IItem> {new Item() {Name = "foo", Quality = 16, SellIn = 0}};
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(14, item[0].Quality);
            Assert.AreEqual(-1, item[0].SellIn);
        }

        [Test]
        public void QualityOfAnItemDegradesByOneBeforeSell()
        {
            List<IItem> item = new List<IItem> {new Item() {Name = "foo", Quality = 40, SellIn = 1}};
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(39, item[0].Quality);
            Assert.AreEqual(0, item[0].SellIn);
        }

        [Test]
        public void SulfurasQualityAndSellInRemainsTheSame()
        {
            List<IItem> item = new List<IItem> {new Item() {Name = "Sulfuras, Hand of Ragnaros", Quality = 50, SellIn = 50} };
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(50, item[0].Quality);
            Assert.AreEqual(50, item[0].SellIn);
        }

        [Test]
        public void ConcertTicketQualityIncreasesByOneWhenThereMoreThanTenDaysLeft()
        {
            List<IItem> item = new List<IItem> {new Item {Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 40, SellIn = 11} };
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(41, item[0].Quality);
            Assert.AreEqual(10, item[0].SellIn);
        }

        [Test]
        public void ConcertTicketQualityIncreasesByTwoWhenThereAreLessTenDaysLeft()
        {
            List<IItem> item = new List<IItem> {new Item{Name = "Backstage passes to a TAFKAL80ETC concert" , Quality = 45, SellIn = 10}};
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(47, item[0].Quality);
            Assert.AreEqual(9, item[0].SellIn);
        }

        [Test]
        public void ConcertTicketQualityIncreasesByThreeWhenThereAreFiveDaysLeft()
        {
            List<IItem> item = new List<IItem> {new Item {Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 47, SellIn = 5} };
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(50, item[0].Quality);
            Assert.AreEqual(4, item[0].SellIn);
        }

        [Test]
        public void ConcertTicketQualityDropsToZeroAfterSellIn()
        {
            List<IItem> item = new List<IItem> {new Item{Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 50, SellIn = 0 }};
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(0, item[0].Quality);
            Assert.AreEqual(-1, item[0].SellIn);
        }

    }
}
