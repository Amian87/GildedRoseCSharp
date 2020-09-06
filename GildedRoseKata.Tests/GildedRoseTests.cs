using System.Collections.Generic;
using NUnit.Framework;

namespace GildedRoseKata.Tests
{
    public class GildedRoseTests
    {
        [Test]
        public void QualityOfAnItemIsNeverNegative()
        {
            List<IItem> item = new List<IItem>(){new QualityDepreciates{Name = "foo", Quality = 0, SellIn = 2}};
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(0, item[0].Quality);
        }

        [Test]
        public void QualityDegradesTwiceAsFastAfterSellInDate()
        {
            List<IItem> item = new List<IItem>(){new QualityDepreciates{Name = "foo", Quality = 15, SellIn = 0}};
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(13, item[0].Quality);
            Assert.AreEqual(-1, item[0].SellIn);
        }

        [Test]
        public void QualityOfAnItemDegradesByOneBeforeSellInDate()
        {
            List<IItem> item = new List<IItem>(){new QualityDepreciates {Name = "foo", Quality = 10, SellIn = 3}};
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(9, item[0].Quality);
            Assert.AreEqual(2, item[0].SellIn);
        }

        [Test]
        public void QualityOfAgedBrieIncreasesByOneBeforeSellInDate()
        {
            List<IItem> item = new List<IItem>(){new QualityAppreciates{Name = "Aged Brie", Quality = 10, SellIn = 15}};
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(11, item[0].Quality);
            Assert.AreEqual(14, item[0].SellIn);
        }

        [Test]
        public void QualityOfAgedBrieIncreasesByTwoAfterSellInDate()
        {
            List<IItem> item = new List<IItem>(){new QualityAppreciates{Name = "Aged Brie", Quality = 15, SellIn = 0}};
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(17, item[0].Quality);
            Assert.AreEqual(-1, item[0].SellIn);
        }

        [Test]
        public void QualityOfAnItemIsNeverGreaterThanFifty()
        {
            List<IItem> item = new List<IItem>(){new QualityAppreciates {Name = "Aged Brie", Quality = 50, SellIn = -2}};
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(50, item[0].Quality);
            Assert.AreEqual(-3, item[0].SellIn);
        }

        [Test]
        public void QualityAndSellInDateOfSulfurasRemainsTheSame()
        {
            List<IItem> item = new List<IItem>(){new FixedQuality {Name = "Sulfuras, Hand of Ragnaros", Quality = 40, SellIn = 40} };
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(40, item[0].Quality);
            Assert.AreEqual(40, item[0].SellIn);
        }

        [Test]
        public void BackStagePassQualityIncreasesByOneWhenSellInDayIsGreaterThanTen()
        {
            List<IItem> item = new List<IItem>(){new ConcertTicket {Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 30, SellIn = 11} };
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(31, item[0].Quality);
            Assert.AreEqual(10, item[0].SellIn);
        }

        [Test]
        public void BackStagePassQualityIncreasesByTwoWhenSellInDayIsTenDaysOrLess()
        {
            List<IItem> item = new List<IItem>(){new ConcertTicket {Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 40, SellIn = 10} };
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(42, item[0].Quality);
            Assert.AreEqual(9, item[0].SellIn);
        }

        [Test]
        public void BackStagePassQualityIncreasesByThreeWhenSellInDayIsFiveDaysOrLess()
        {
            List<IItem> item = new List<IItem>() { new ConcertTicket { Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 45, SellIn = 5 } };
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(48, item[0].Quality);
            Assert.AreEqual(4, item[0].SellIn);
        }

        [Test]
        public void BackStagePassQualityIsZeroAfterSellInDate()
        {
            List<IItem> item = new List<IItem>() { new ConcertTicket { Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 45, SellIn = 0 } };
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(0, item[0].Quality);
            Assert.AreEqual(-1, item[0].SellIn);
        }
    }
}
