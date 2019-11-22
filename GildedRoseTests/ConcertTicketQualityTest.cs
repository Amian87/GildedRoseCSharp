using NUnit.Framework;
using GildedRoseKata;
using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseTests
{
    class ConcertTicketQualityTest
    {
        [Test]
        public void ConcertTicketQualityIncreasesByTwoWhenLessThanDaysLeft()
        {
            ConcertTicketQuality concertTicketQuality = new ConcertTicketQuality { Name = "foo", Quality = 10, SellIn = 9 };
            concertTicketQuality.UpdateQuality();
            Assert.AreEqual(12, concertTicketQuality.Quality);
        }

        [Test]
        public void ConcertTicketQualityIncreasesByThreeWhenLessThanFiveDaysLeft()
        {
            ConcertTicketQuality concertTicketQuality = new ConcertTicketQuality { Name = "foo", Quality = 10, SellIn = 4 };
            concertTicketQuality.UpdateQuality();
            Assert.AreEqual(13, concertTicketQuality.Quality);
        }

        [Test]
        public void ConcertTicketQualityIncreasesByOneTenDaysBeforeConcert()
        {
            ConcertTicketQuality concertTicketQuality = new ConcertTicketQuality { Name = "foo", Quality = 10, SellIn = 12 };
            concertTicketQuality.UpdateQuality();
            Assert.AreEqual(11, concertTicketQuality.Quality);
        }

        [Test]
        public void ConcertTicketQualityCannotExceedFifty()
        {
            ConcertTicketQuality concertTicketQuality = new ConcertTicketQuality { Name = "foo", Quality = 50, SellIn = 9 };
            concertTicketQuality.UpdateQuality();
            Assert.AreEqual(50, concertTicketQuality.Quality);
        }

        [Test]
        public void ConcertTicketQualityCannotDropBelowZero()
        {
            ConcertTicketQuality concertTicketQuality = new ConcertTicketQuality { Name = "foo", Quality = 0, SellIn = 0 };
            concertTicketQuality.UpdateQuality();
            Assert.AreEqual(0, concertTicketQuality.Quality);
        }
    }
}
