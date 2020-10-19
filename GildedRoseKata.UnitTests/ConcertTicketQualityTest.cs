using System.Runtime.InteropServices.ComTypes;
using NUnit.Framework;

namespace GildedRoseKata.UnitTests
{
    public class ConcertTicketQualityTest
    {
        [Test]
        public void ConcertTicketQualityIncreasesByOneBeforeTenDays()
        {
            ConcertTicketQuality concertTicket = new ConcertTicketQuality() {Name = "foo", Quality = 40, SellIn = 11};
            concertTicket.UpdateQuality();
            Assert.AreEqual(41, concertTicket.Quality);
            Assert.AreEqual(10, concertTicket.SellIn);
        }

        [Test]
        public void ConcertTicketQualityIncreaseByTwoLessThanTenDays()
        {
            ConcertTicketQuality concertTicket = new ConcertTicketQuality {Name = "foo", Quality = 15, SellIn = 10};
            concertTicket.UpdateQuality();
            Assert.AreEqual(17, concertTicket.Quality);
            Assert.AreEqual(9, concertTicket.SellIn);
        }

        [Test]
        public void ConcertTicketQualityIncreaseByThreeLessThanFiveDays()
        {
            ConcertTicketQuality concertTicket = new ConcertTicketQuality {Name = "foo", Quality = 30, SellIn = 5};
            concertTicket.UpdateQuality();
            Assert.AreEqual(33, concertTicket.Quality);
            Assert.AreEqual(4, concertTicket.SellIn);
        }

        [Test]
        public void ConcertTicketQualityIsNeverGreaterThanFifty()
        {
            ConcertTicketQuality concertTicket = new ConcertTicketQuality {Name = "foo", Quality = 50, SellIn = 1};
            concertTicket.UpdateQuality();
            Assert.AreEqual(50, concertTicket.Quality);
            Assert.AreEqual(0, concertTicket.SellIn);
        }

        [Test]
        public void ConcertTicketQualityIsZeroAfterSellInDate()
        {
            ConcertTicketQuality concertTicket = new ConcertTicketQuality {Name = "foo", Quality = 10, SellIn = 0};
            concertTicket.UpdateQuality();
            Assert.AreEqual(0, concertTicket.Quality);
            Assert.AreEqual(-1, concertTicket.SellIn);
        }

    }
}