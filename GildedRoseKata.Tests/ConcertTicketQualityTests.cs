using NUnit.Framework;

namespace GildedRoseKata.Tests
{
    public class ConcertTicketQualityTests
    {
        [Test]
        public void ConcertTicketQualityIncreasesByOneBeforeTenDays()
        {
            ConcertTicketQuality concertTicket = new ConcertTicketQuality {Name = "foo", Quality = 10, SellIn = 11};
            concertTicket.UpdateQuality();
            Assert.AreEqual(11, concertTicket.Quality);
            Assert.AreEqual(10, concertTicket.SellIn);
        }

        [Test]
        public void ConcertTicketQualityIncreasesByTwoLessThanTenDaysLeft()
        {
            ConcertTicketQuality concertTicketQuality = new ConcertTicketQuality
                {Name = "foo", Quality = 14, SellIn = 10};
            concertTicketQuality.UpdateQuality();
            Assert.AreEqual(16, concertTicketQuality.Quality);
            Assert.AreEqual(9, concertTicketQuality.SellIn);
        }

        [Test]
        public void ConcertTicketQualityIncreasesByThreeLessThanFiveDaysLeft()
        {
            ConcertTicketQuality concertTicketQuality = new ConcertTicketQuality {Name = "foo", Quality = 40, SellIn = 10};
            concertTicketQuality.UpdateQuality();
            Assert.AreEqual(42, concertTicketQuality.Quality);
            Assert.AreEqual(9, concertTicketQuality.SellIn);
        }

        [Test]
        public void ConcertTicketQualityIsZeroAfterSellInDate()
        {
            ConcertTicketQuality concertTicketQuality = new ConcertTicketQuality
                {Name = "foo", Quality = 45, SellIn = 0};
            concertTicketQuality.UpdateQuality();
            Assert.AreEqual(0, concertTicketQuality.Quality);
            Assert.AreEqual(-1, concertTicketQuality.SellIn);
        }

        [Test]
        public void ConcertTicketQualityIsNeverGreaterThanFifty()
        {
            ConcertTicketQuality concertTicketQuality = new ConcertTicketQuality {Name = "foo", Quality = 50, SellIn = 2};
            concertTicketQuality.UpdateQuality();
            Assert.AreEqual(50, concertTicketQuality.Quality);
            Assert.AreEqual(1, concertTicketQuality.SellIn);
        }
    }
}