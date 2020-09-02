using NUnit.Framework;

namespace GildedRoseKata.Tests
{
    public class ConcertTicketTest
    {
        [Test]
        public void ConcertTicketQualityIncreasesByOneTenDaysBeforeConcert()
        {
            ConcertTicket concertTicket = new ConcertTicket {Name = "foo", Quality = 10, SellIn = 15};
            concertTicket.UpdateQuality();
            Assert.AreEqual(11, concertTicket.Quality);
            Assert.AreEqual(14, concertTicket.SellIn);
        }

        [Test]
        public void ConcertTicketQualityIncreasesByTwoLessThanTenDaysBeforeConcert()
        {
            ConcertTicket concertTicket = new ConcertTicket {Name = "foo", Quality = 40, SellIn = 10};
            concertTicket.UpdateQuality();
            Assert.AreEqual(42, concertTicket.Quality);
            Assert.AreEqual(9, concertTicket.SellIn);
        }

        [Test]
        public void ConcertTicketQualityIncreasesByThreeLessFiveDaysBeforeConcert()
        {
            ConcertTicket concertTicket = new ConcertTicket {Name = "foo", Quality = 47, SellIn = 5};
            concertTicket.UpdateQuality();
            Assert.AreEqual(50, concertTicket.Quality);
            Assert.AreEqual(4, concertTicket.SellIn);
        }

        [Test]
        public void ConcertTicketQualityNeverGreaterThanFifty()
        {
            ConcertTicket concertTicket = new ConcertTicket {Name = "foo", Quality = 50, SellIn = 6};
            concertTicket.UpdateQuality();
            Assert.AreEqual(50, concertTicket.Quality);
            Assert.AreEqual(5, concertTicket.SellIn);
        }

        [Test]
        public void ConcertTicketQualityDropsToZeroAfterConcert()
        {
            ConcertTicket concertTicket = new ConcertTicket {Name = "foo", Quality = 50, SellIn = 0};
            concertTicket.UpdateQuality();
            Assert.AreEqual(0, concertTicket.Quality);
            Assert.AreEqual(-1, concertTicket.SellIn);
        }


    }
}