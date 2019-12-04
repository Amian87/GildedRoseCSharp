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
            ConcertTicketQuality concertTicketQuality = new ConcertTicketQuality("foo", 9, 10) ;
            concertTicketQuality.UpdateQuality();
            Assert.AreEqual("foo, 8, 12", concertTicketQuality.PrintOut());
        }

        [Test]
        public void ConcertTicketQualityIncreasesByThreeWhenLessThanFiveDaysLeft()
        {
            ConcertTicketQuality concertTicketQuality = new ConcertTicketQuality("foo", 4, 10);
            concertTicketQuality.UpdateQuality();
            Assert.AreEqual("foo, 3, 13", concertTicketQuality.PrintOut());
        }

        [Test]
        public void ConcertTicketQualityIncreasesByOneTenDaysBeforeConcert()
        {
            ConcertTicketQuality concertTicketQuality = new ConcertTicketQuality("foo", 12, 10);
            concertTicketQuality.UpdateQuality();
            Assert.AreEqual("foo, 11, 11", concertTicketQuality.PrintOut());
        }

        [Test]
        public void ConcertTicketQualityCannotExceedFifty()
        {
            ConcertTicketQuality concertTicketQuality = new ConcertTicketQuality("foo", 9, 50);
            concertTicketQuality.UpdateQuality();
            Assert.AreEqual("foo, 8, 50", concertTicketQuality.PrintOut());
        }

        [Test]
        public void ConcertTicketQualityCannotDropBelowZero()
        {
            ConcertTicketQuality concertTicketQuality = new ConcertTicketQuality("foo", 0, 0);
            concertTicketQuality.UpdateQuality();
            Assert.AreEqual("foo, -1, 0", concertTicketQuality.PrintOut());
        }
    }
}
