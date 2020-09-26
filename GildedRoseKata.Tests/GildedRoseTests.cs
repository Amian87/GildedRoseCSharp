using System.Collections.Generic;
using NUnit.Framework;

namespace GildedRoseKata.Tests
{
    public class GildedRoseTests
    {
        [Test]
        public void ItemQualityIsNeveNegative()
        {
            List<Item> item = new List<Item> {new Item {Name= "foo", Quality = 0, SellIn = 4}};
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(0, item[0].Quality);
            Assert.AreEqual(3, item[0].SellIn);
        }

        [Test]
        public void ItemQualityDegradedByOneBeforeSellInDate()
        {
            List<Item> item = new List<Item> {new Item {Name = "foo", Quality = 50, SellIn = 5}};
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(49, item[0].Quality);
            Assert.AreEqual(4, item[0].SellIn);
        }

        [Test]
        public void ItemQualityDegradesByTwoAfterSellInDate()
        {
            List<Item> item = new List<Item> {new Item {Name = "foo", Quality = 30, SellIn = 0}};
            GildedRose  app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(28, item[0].Quality);
            Assert.AreEqual(-1, item[0].SellIn);
        }

        [Test]
        public void AgedBrieQualityIncreasesByOneBeforeSellInDate()
        {
            List<Item> item = new List<Item> {new Item {Name = "Aged Brie", Quality = 30, SellIn = 4}};
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(31, item[0].Quality);
            Assert.AreEqual(3, item[0].SellIn);
        }

        [Test]
        public void AgedBrieQualityIncreasesByTwoAfterSellInDate()
        {
            List<Item> item = new List<Item> {new Item {Name = "Aged Brie", Quality = 35, SellIn = 0}};
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(37, item[0].Quality);
            Assert.AreEqual(-1, item[0].SellIn);
        }

        [Test]
        public void AgedBrieQualityIsNeverGreaterThanFifty()
        {
            List<Item> item = new List<Item> {new Item {Name = "Aged Brie", Quality = 50, SellIn = 0}};
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(50, item[0].Quality);
            Assert.AreEqual(-1, item[0].SellIn);
        }

        [Test]
        public void SulfurasQualityAndSellInDateNeverChanges()
        {
            List<Item> item = new List<Item> {new Item {Name = "Sulfuras, Hand of Ragnaros", Quality = 40, SellIn = 20 } };
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(40, item[0].Quality);
            Assert.AreEqual(20, item[0].SellIn);
        }

        [Test]
        public void ConcertTicketQualityIncreasesByOneBeforeTenDays()
        {
            List<Item> item = new List<Item> {new Item {Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 14, SellIn = 11} };
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(15, item[0].Quality);
            Assert.AreEqual(10, item[0].SellIn);
        }

        [Test]
        public void ConcertTicketQualityIncreasesByTwoLessThanTenDaysLeft()
        {
            List<Item> item = new List<Item> {new Item {Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 18, SellIn = 10} };
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(20, item[0].Quality);
            Assert.AreEqual(9, item[0].SellIn);
        }

        [Test]
        public void ConcertTicketQualityIncreasesByThreeLessThanFiveDaysLeft()
        {
            List<Item> item = new List<Item> {new Item {Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 24, SellIn = 5} };
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(27, item[0].Quality);
            Assert.AreEqual(4, item[0].SellIn);
        }

        [Test]
        public void ConcertTicketQualityIsZeroAfterSellInDate()
        {
            List<Item> item = new List<Item> {new Item {Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 50, SellIn = 0} };
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(0, item[0].Quality);
            Assert.AreEqual(-1,item[0].SellIn);
        }

        [Test]
        public void ConcertTicketQualityIsNeverGreaterThanFifty()
        {
            List<Item> item = new List<Item> {new Item {Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 50, SellIn = 5} };
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(50, item[0].Quality);
            Assert.AreEqual(4, item[0].SellIn);
        }
    }
}
