using GildedRoseKata;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseTests
{
    class ConcertTicketValueTest
    {
        [Test]
        public void BackstagePassQualityAppreciatesByTwoWhenThereAreTenOrLessDays()
        {
            ConcertTicketValue concertTicketValue = new ConcertTicketValue { Name = "Backstage Pass", Quality = 10, SellIn = 10 };
            concertTicketValue.UpdateQuality();
            Assert.AreEqual(12, concertTicketValue.Quality);
            Assert.AreEqual(9, concertTicketValue.SellIn);
        }

        [Test]
        public void BackstagePassQualityAppreciatesBy3WhenThereAreFiveDaysLeft()
        {
            ConcertTicketValue concertTicketValue = new ConcertTicketValue { Name = "Backstage Pass", Quality = 10, SellIn = 5 };
            concertTicketValue.UpdateQuality();
            Assert.AreEqual(13, concertTicketValue.Quality);
            Assert.AreEqual(4, concertTicketValue.SellIn);
        }

        [Test]
        public void BackstagePassQualityAppreciatesBy1WhenThereAreGreaterThanTenDaysLeft()
        {
            ConcertTicketValue concertTicketValue = new ConcertTicketValue { Name = "Backstage Pass", Quality = 10, SellIn = 15 };
            concertTicketValue.UpdateQuality();
            Assert.AreEqual(11, concertTicketValue.Quality);
            Assert.AreEqual(14, concertTicketValue.SellIn);
        }

        [Test]
        public void ConcertTicketValueIsZeroAfterSellInDate()
        {
            ConcertTicketValue concertTicketValue = new ConcertTicketValue { Name = "Backstage Pass", Quality = 10, SellIn = 0 };
            concertTicketValue.UpdateQuality();
            Assert.AreEqual(0, concertTicketValue.Quality);
            Assert.AreEqual(-1, concertTicketValue.SellIn);
        }

        [Test]
        public void ConcertTicketValueCannotBeGreaterThan50()
        {
            ConcertTicketValue concertTicketValue = new ConcertTicketValue { Name = "Backstage Pass", Quality = 49, SellIn = 5 };
            concertTicketValue.UpdateQuality();
            Assert.AreEqual(50, concertTicketValue.Quality);
            Assert.AreEqual(4, concertTicketValue.SellIn);
        }

    }
}
