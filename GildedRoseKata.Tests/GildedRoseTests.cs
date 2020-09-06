using System.Collections.Generic;
using NUnit.Framework;

namespace GildedRoseKata.Tests
{
    public class GildedRoseTests
    {
        [Test]
        public void QualityOfAnItemIsNeverNegative()
        {
            List<AbsractItem> item = new List<AbsractItem>(){new QualityDepreciates{Name = "foo", Quality = 0, SellIn = 2}};
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(0, item[0].Quality);
        }

        [Test]
        public void QualityDegradesTwiceAsFastAfterSellInDate()
        {
            List<AbsractItem> item = new List<AbsractItem>(){new QualityDepreciates{Name = "foo", Quality = 15, SellIn = 0}};
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(13, item[0].Quality);
            Assert.AreEqual(-1, item[0].SellIn);
        }

        [Test]
        public void QualityOfAnItemDegradesByOneBeforeSellInDate()
        {
            List<AbsractItem> item = new List<AbsractItem>(){new QualityDepreciates {Name = "foo", Quality = 10, SellIn = 3}};
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(9, item[0].Quality);
            Assert.AreEqual(2, item[0].SellIn);
        }

        [Test]
        public void QualityOfAgedBrieIncreasesByOneBeforeSellInDate()
        {
            List<AbsractItem> item = new List<AbsractItem>(){new QualityAppreciates{Name = "Aged Brie", Quality = 10, SellIn = 15}};
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(11, item[0].Quality);
            Assert.AreEqual(14, item[0].SellIn);
        }

        [Test]
        public void QualityOfAgedBrieIncreasesByTwoAfterSellInDate()
        {
            List<AbsractItem> item = new List<AbsractItem>(){new QualityAppreciates{Name = "Aged Brie", Quality = 15, SellIn = 0}};
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(17, item[0].Quality);
            Assert.AreEqual(-1, item[0].SellIn);
        }

        [Test]
        public void QualityOfAnItemIsNeverGreaterThanFifty()
        {
            List<AbsractItem> item = new List<AbsractItem>(){new QualityAppreciates {Name = "Aged Brie", Quality = 50, SellIn = -2}};
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(50, item[0].Quality);
            Assert.AreEqual(-3, item[0].SellIn);
        }

        [Test]
        public void QualityAndSellInDateOfSulfurasRemainsTheSame()
        {
            List<AbsractItem> item = new List<AbsractItem>(){new FixedQuality {Name = "Sulfuras, Hand of Ragnaros", Quality = 40, SellIn = 40} };
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(40, item[0].Quality);
            Assert.AreEqual(40, item[0].SellIn);
        }

        [Test]
        public void BackStagePassQualityIncreasesByOneWhenSellInDayIsGreaterThanTen()
        {
            List<AbsractItem> item = new List<AbsractItem>(){new ConcertTicket {Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 30, SellIn = 11} };
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(31, item[0].Quality);
            Assert.AreEqual(10, item[0].SellIn);
        }

        [Test]
        public void BackStagePassQualityIncreasesByTwoWhenSellInDayIsTenDaysOrLess()
        {
            List<AbsractItem> item = new List<AbsractItem>(){new ConcertTicket {Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 40, SellIn = 10} };
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(42, item[0].Quality);
            Assert.AreEqual(9, item[0].SellIn);
        }

        [Test]
        public void BackStagePassQualityIncreasesByThreeWhenSellInDayIsFiveDaysOrLess()
        {
            List<AbsractItem> item = new List<AbsractItem>() { new ConcertTicket { Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 45, SellIn = 5 } };
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(48, item[0].Quality);
            Assert.AreEqual(4, item[0].SellIn);
        }

        [Test]
        public void BackStagePassQualityIsZeroAfterSellInDate()
        {
            List<AbsractItem> item = new List<AbsractItem>() { new ConcertTicket { Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 45, SellIn = 0 } };
            GildedRose app = new GildedRose(item);
            app.UpdateQuality();
            Assert.AreEqual(0, item[0].Quality);
            Assert.AreEqual(-1, item[0].SellIn);
        }
    }
}
