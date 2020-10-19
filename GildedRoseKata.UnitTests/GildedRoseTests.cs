using System;
using System.Collections.Generic;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace GildedRoseKata.UnitTests
{
    public class GildedRoseTests
    {
        [Test]
        public void QualityDecreasesByOneBeforeSellInDate()
        {
            List<IItem> item = new List<IItem>() {new QualityDepreciates {Name = "foo", Quality = 10, SellIn = 10}};
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(9, item[0].Quality);
            Assert.AreEqual(9, item[0].SellIn);
        }

        [Test]
        public void QualityDecreasesByTwoAfterSellInDate()
        {
            List<IItem> item = new List<IItem>() {new QualityDepreciates {Name = "foo", Quality = 4, SellIn = 0}};
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(2, item[0].Quality);
            Assert.AreEqual(-1, item[0].SellIn);
        }

        [Test]
        public void QualityIsNeverNegative()
        {
            List<IItem> item = new List<IItem>() {new QualityDepreciates {Name = "foo", Quality = 0, SellIn = 0}};
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(0, item[0].Quality);
            Assert.AreEqual(-1, item[0].SellIn);
        }

        [Test]
        public void QualityIncreasedByOneBeforeSellInDate()
        {
            List<IItem> item = new List<IItem>() {new QualityAppreciates {Name = "Aged Brie", Quality = 15, SellIn = 4}};
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(16, item[0].Quality);
            Assert.AreEqual(3, item[0].SellIn);
        }

        [Test]
        public void QualityIncreasesByTwoAfterSellInDate()
        {
            List<IItem> item = new List<IItem>() {new QualityAppreciates {Name = "Aged Brie", Quality = 34, SellIn = 0}};
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(36, item[0].Quality);
            Assert.AreEqual(-1, item[0].SellIn);
        }

        [Test]
        public void QualityIsNeverGreaterThanFifty()
        {
            List<IItem> item = new List<IItem>() {new QualityAppreciates {Name = "Aged Brie", Quality = 50, SellIn = 0}};
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(50, item[0].Quality);
            Assert.AreEqual(-1, item[0].SellIn);
        }

        [Test]
        public void SulfurasQualityAndSellInDateNeverChanges()
        {
            List<IItem> item = new List<IItem>() {new FixedQuality {Name = "Sulfuras, Hand of Ragnaros", Quality = 40, SellIn = 10}};
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(40, item[0].Quality);
            Assert.AreEqual(10, item[0].SellIn);
        }

        [Test]
        public void ConcertTicketQualityIncreasesByOneTenDayLeft()
        {
            List<IItem> item = new List<IItem>() {new ConcertTicketQuality {Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 14, SellIn = 11}};
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(15, item[0].Quality);
            Assert.AreEqual(10, item[0].SellIn);
        }

        [Test]
        public void ConcertTicketQualityIncreasesByTwoLessThanTenDaysLeft()
        {
            List<IItem> item = new List<IItem>() {new ConcertTicketQuality {Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 16, SellIn = 10} };
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(18, item[0].Quality);
            Assert.AreEqual(9, item[0].SellIn);
        }

        [Test]
        public void ConcertTicketQualityIncreasesByThreeLessThanFiveDaysLeft()
        {
            List<IItem> item = new List<IItem>() {new ConcertTicketQuality {Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 20, SellIn = 1} };
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(23, item[0].Quality);
            Assert.AreEqual(0, item[0].SellIn);
        }

        [Test]
        public void ConcertTicketQualityIsNeverGreaterThanFifty()
        {
            List<IItem> item = new List<IItem>() {new ConcertTicketQuality {Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 50, SellIn = 3} };
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(50, item[0].Quality);
            Assert.AreEqual(2, item[0].SellIn);
        }

        [Test]
        public void ConcertTicketQualityIsZeroAfterSellInDate()
        {
            List<IItem> item = new List<IItem>() {new ConcertTicketQuality {Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 43, SellIn = 0} };
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(0, item[0].Quality);
            Assert.AreEqual(-1, item[0].SellIn);
        }
    }
}
