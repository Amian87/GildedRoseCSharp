using System;
using System.Collections.Generic;
using System.Text;
using GildedRoseKata;
using NUnit.Framework;

namespace GildedRoseTest
{
    class ConcertTicketQualityTest
    {
        [Test]
        public void ConcertTicketQualityIncreasesByOneWhenThereAreMoreThanTenDaysLeft()
        {
            ConcertTicketQuality item = new ConcertTicketQuality(){Name = "foo", Quality = 15, SellIn = 12};
            item.UpdateQuality();
            Assert.AreEqual(16, item.Quality);
            Assert.AreEqual(11,item.SellIn);
        }

        [Test]
        public void ConcertTicketQualityIncreasesByTwoWhenThereAreLessThanTenDaysLeft()
        {
            ConcertTicketQuality item = new ConcertTicketQuality() {Name = "foo", Quality = 20, SellIn = 10};
            item.UpdateQuality();
            Assert.AreEqual(22, item.Quality);
            Assert.AreEqual(9,item.SellIn);
        }

        [Test]
        public void ConcertTicketQualityIncreasesByThreeWhenThereAreLessThanFiveDaysLeft()
        {
            ConcertTicketQuality item = new ConcertTicketQuality() { Name = "foo", Quality = 20, SellIn = 5 };
            item.UpdateQuality();
            Assert.AreEqual(23, item.Quality);
            Assert.AreEqual(4, item.SellIn);
        }

        [Test]
        public void ConcertTicketQualityZeroAfterSellIn()
        {
            ConcertTicketQuality item = new ConcertTicketQuality() { Name = "foo", Quality = 20, SellIn = 0 };
            item.UpdateQuality();
            Assert.AreEqual(0, item.Quality);
            Assert.AreEqual(-1, item.SellIn);
        }

        [Test]
        public void ConcertTicketQualityNeverEcxeedsFifty()
        {
            ConcertTicketQuality item = new ConcertTicketQuality() { Name = "foo", Quality = 50, SellIn = 10 };
            item.UpdateQuality();
            Assert.AreEqual(50, item.Quality);
            Assert.AreEqual(9, item.SellIn);
        }

    }
}
