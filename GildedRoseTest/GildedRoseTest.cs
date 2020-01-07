using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using GildedRoseKata;
using NUnit.Framework;

namespace GildedRoseTest
{
    public class GildedRoseTest
    {
      
        [Test]
        public void QualityOfAnItemIsNeverNegative()
        {
            List<IItem> item = new List<IItem>() {new QualityDepreciates(){Name = "foo", Quality = 0, SellIn = 3}};
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();

            Assert.AreEqual(0,item[0].Quality);
        }

        [Test]
        public void ItemQualityDegradesTwiceAsFastAfterSellIn()
        {
            List<IItem> item = new List<IItem>() { new QualityDepreciates() { Name = "foo", Quality = 5, SellIn = 0 } };
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();

            Assert.AreEqual(3, item[0].Quality);
            Assert.AreEqual(-1, item[0].SellIn);
        }

        [Test]
        public void ItemQualityNeverExceedsFifty()
        {
            List<IItem> item = new List<IItem>() { new QualityDepreciates() { Name = "foo", Quality = 50, SellIn = 11 } };
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();

            Assert.AreEqual(49, item[0].Quality);
        }

        [Test]
        public void AgedBrieIncreasesInQualityAsItAges()
        {
            List<IItem> item = new List<IItem>() { new QualityAppreciates() { Name = "Aged Brie", Quality = 10, SellIn = 5 } };
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();

            Assert.AreEqual(11, item[0].Quality);
        }

        [Test]
        public void SulfurasQualityAndSellInNeverChanges()
        {
            List<IItem> item = new List<IItem>() { new SpecialItemQuality() { Name = "Sulfuras, Hand of Ragnaros", Quality = 100, SellIn = 10 } };
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();

            Assert.AreEqual(100, item[0].Quality);
            Assert.AreEqual(10, item[0].SellIn);
        }

        [Test]
        public void BackStagePassQualityIncreasesByOneWhenThereAreMoreThanTenDaysLeft()
        {
            List<IItem> item = new List<IItem>() { new ConcertTicketQuality() { Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 10, SellIn = 12 } };
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(11, item[0].Quality);
        }

        [Test]
        public void BackStagePassQualityIncreasesByTwoWhenThereAreLessThanTenDaysLeft()
        {
            List<IItem> item = new List<IItem>() { new ConcertTicketQuality() { Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 12, SellIn = 10 } };
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(14, item[0].Quality);
            Assert.AreEqual(9, item[0].SellIn);
        }

        [Test]
        public void BackStagePassQualityIncreasesByThreeWhenThereAreLessThanFiveDaysLeft()
        {
            List<IItem> item = new List<IItem>() { new ConcertTicketQuality() { Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 12, SellIn = 5 } };
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(15, item[0].Quality);
            Assert.AreEqual(4, item[0].SellIn);
        }

        [Test]
        public void BackStagePassQualityIsZeroAfterConcert()
        {
            List<IItem> item = new List<IItem>() { new ConcertTicketQuality() { Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 12, SellIn = 0 } };
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(0, item[0].Quality);
            Assert.AreEqual(-1, item[0].SellIn);
        }

    }
}
