using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace GildedRoseKata.Tests
{
    public class GildedRoseTests
    {
        [Test]
        public void QualityOfAnItemIsNeverNegative()
        {
            List<IItem>item = new List<IItem>(){new QualityDepreciates {Name = "foo", Quality = 0, SellIn = 5 }};
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(0, item[0].Quality);
            Assert.AreEqual(4, item[0].SellIn);
        }

        [Test]
        public void QualityOfAnItemDegradesByTwoAfterSellInDate()
        {
            List<IItem>item = new List<IItem>{new QualityDepreciates {Name = "foo", Quality = 10, SellIn = 0}};
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(8, item[0].Quality);
            Assert.AreEqual(-1, item[0].SellIn);
        }

        [Test]
        public void QualityOfAnItemDegradesByOneBeforeSellInDate()
        {
            List<IItem>item = new List<IItem>{ new QualityDepreciates { Name = "foo", Quality = 10, SellIn = 4 } };
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(9, item[0].Quality);
            Assert.AreEqual(3, item[0].SellIn);
        }

        [Test]
        public void QualityOfAnItemIsNeverGreaterThanFifty()
        {
            List<IItem>item = new List<IItem>{new QualityAppreciates {Name = "Aged Brie", Quality = 50, SellIn = 4}};
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(50, item[0].Quality);
            Assert.AreEqual(3, item[0].SellIn);
        }

        [Test]
        public void AgedBrieQualityIncreasesByOneBeforeSellIn()
        {
            List<IItem>item = new List<IItem>{new QualityAppreciates {Name = "Aged Brie", Quality = 30, SellIn = 5}};
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(31, item[0].Quality);
            Assert.AreEqual(4, item[0].SellIn);
        }

        [Test]
        public void AgedBrieQualityIncreasesByTwoAfterSellIn()
        {
            List<IItem>item = new List<IItem>{ new QualityAppreciates { Name = "Aged Brie", Quality = 30, SellIn = 0 } };
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(32, item[0].Quality);
            Assert.AreEqual(-1, item[0].SellIn);
        }

        [Test]
        public void SulfurasQualityAndSellInNeverChanges()
        {
            List<IItem>item = new List<IItem>{new FixedQuality {Name = "Sulfuras, Hand of Ragnaros", Quality = 20, SellIn = 10} };
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(20, item[0].Quality);
            Assert.AreEqual(10, item[0].SellIn);
        }

        [Test]
        public void BackstagePassQualityIncreasesByOneWhenThereAreGreaterThanTenDaysLeft()
        {
            List<IItem>item = new List<IItem>{new ConcertTicket {Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 15, SellIn = 11} };
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(16, item[0].Quality);
            Assert.AreEqual(10, item[0].SellIn);
        }

        [Test]
        public void BackstagePassQualityIncreasesByTwoWhenThereAreLessThanTenDaysLeft()
        {
            List<IItem>item = new List<IItem>{ new ConcertTicket { Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 20, SellIn = 10 } };
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(22, item[0].Quality);
            Assert.AreEqual(9, item[0].SellIn);
        }

        [Test]
        public void BackstagePassQualityIncreasesByThreeWhenThereAreLessThanFiveDaysLeft()
        {
            List<IItem>item = new List<IItem>{ new ConcertTicket { Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 25, SellIn = 5 } };
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(28, item[0].Quality);
            Assert.AreEqual(4, item[0].SellIn);
        }

        [Test]
        public void BackstagePassQualityIsZeroAfterSellInDate()
        {
            List<IItem>item = new List<IItem>{ new ConcertTicket { Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 20, SellIn = 0 } };
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(0, item[0].Quality);
            Assert.AreEqual(-1, item[0].SellIn);
        }


    }
}
