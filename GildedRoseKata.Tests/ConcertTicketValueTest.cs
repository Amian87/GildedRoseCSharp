using NUnit.Framework;

namespace GildedRoseKata.Tests
{
    public class ConcertTicketValueTest
    {
        [Test]
        public void ConcertTicketValueIncreasesByOneWhenThereAreMoreThanTenDaysLeft()
        {
            ConcertTicketValue concertTicket = new ConcertTicketValue {Name = "foo", Quality = 10, SellIn = 11};
            concertTicket.UpdateItemQuality();
            Assert.AreEqual(11, concertTicket.Quality);

        }

        [Test]
        public void ConcertTicketQualityIncreasesByTwoWhenThereAreTenDaysOrLess()
        {
            ConcertTicketValue concertTicket = new ConcertTicketValue { Name = "foo", Quality = 13, SellIn = 9 };
            concertTicket.UpdateItemQuality();
            Assert.AreEqual(15, concertTicket.Quality);

        }

        [Test]
        public void ConcertTicketQualityIncreasesByThreeWhenThereAreFiveDaysOrLess()
        {
            ConcertTicketValue concertTicket = new ConcertTicketValue { Name = "foo", Quality = 15, SellIn = 4 };
            concertTicket.UpdateItemQuality();
            Assert.AreEqual(18, concertTicket.Quality);

        }


        [Test]
        public void ConcertTicketQualityFallsToZeroAfterSellIn()
        {
            ConcertTicketValue concertTicket = new ConcertTicketValue { Name = "foo", Quality = 15, SellIn = -1 };
            concertTicket.UpdateItemQuality();
            Assert.AreEqual(0, concertTicket.Quality);

        }

        [Test]
        public void ConcertTicketQualityIsNeverGreaterThanFifty()
        {
            ConcertTicketValue concertTicket = new ConcertTicketValue { Name = "foo", Quality = 15, SellIn = -1 };
            concertTicket.UpdateItemQuality();
            Assert.AreEqual(0, concertTicket.Quality);

        }

        [Test]
        public void ConcertTicketSellInDecreasesByOne()
        {
            ConcertTicketValue concertTicket = new ConcertTicketValue { Name = "foo", Quality = 15, SellIn = 5 };
            concertTicket.UpdateItemQuality();
            Assert.AreEqual(4, concertTicket.SellIn);

        }

    }
}