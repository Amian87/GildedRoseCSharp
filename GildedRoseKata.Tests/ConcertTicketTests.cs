using NUnit.Framework;

namespace GildedRoseKata.Tests
{
    public class ConcertTicketTests
    {
        [Test]
        public void ConcertPassQualityIncreasesByTwoWhenThereAreTenDaysLeft()
        {
            ConcertTicket concertTicket = new ConcertTicket {Name = "foo", Quality = 90, SellIn = 10};
            concertTicket.UpdateQuality();
            Assert.AreEqual(92, concertTicket.Quality);
            Assert.AreEqual(9, concertTicket.SellIn);
        }

        [Test]
        public void ConcertPassQualityIncreasesByThreeWhenThereAreFiveDaysLeft()
        {
            ConcertTicket concertTicket = new ConcertTicket {Name = "foo", Quality = 97, SellIn = 5};
            concertTicket.UpdateQuality();
            Assert.AreEqual(100, concertTicket.Quality);
            Assert.AreEqual(4, concertTicket.SellIn);
        }

        [Test]
        public void ConcertPassQualityIncreasesByOneWhenThereAreMoreThanTenDaysLeft()
        {
            ConcertTicket concertTicket = new ConcertTicket {Name = "foo", Quality = 60, SellIn = 11};
            concertTicket.UpdateQuality();
            Assert.AreEqual(61, concertTicket.Quality);
            Assert.AreEqual(10, concertTicket.SellIn);
        }

        [Test]
        public void ConcertPassQualityDropsToZeroAfterConcert()
        {
            ConcertTicket concertTicket = new ConcertTicket {Name = "foo", Quality = 60, SellIn = 0};
            concertTicket.UpdateQuality();
            Assert.AreEqual(0, concertTicket.Quality);
            Assert.AreEqual(-1, concertTicket.SellIn);
        }

    }
}