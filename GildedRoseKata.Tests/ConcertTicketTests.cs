using NUnit.Framework;
using NUnit.Framework.Internal;

namespace GildedRoseKata.Tests
{
    public class ConcertTicketTests
    {
        [Test]
        public void ConcertTicketQualityIncreasesByOneWhenThereAreGreaterThanTenDaysLeft()
        {
            ConcertTicket concertTicket = new ConcertTicket() { Name = "foo", Quality = 30, SellIn = 11};
            concertTicket.UpdateQuality();
            Assert.AreEqual(31, concertTicket.Quality);
            Assert.AreEqual(10, concertTicket.SellIn);
        }

        [Test]
        public void ConcertTicketQualityIncreasesByTwoWhenThereAreLessThanTenDaysLeft()
        {
            ConcertTicket concertTicket = new ConcertTicket() {Name = "foo", Quality = 25, SellIn = 10};
            concertTicket.UpdateQuality();
            Assert.AreEqual(27, concertTicket.Quality);
            Assert.AreEqual(9, concertTicket.SellIn);
        }

        [Test]
        public void ConcertTicketQualityIncreasesByThreeWhenThereAreLessThanFiveDaysLeft()
        {
            ConcertTicket concertTicket = new ConcertTicket() {Name = "foo", Quality = 40, SellIn = 5};
            concertTicket.UpdateQuality();
            Assert.AreEqual(43, concertTicket.Quality);
            Assert.AreEqual(4, concertTicket.SellIn);
        }

        [Test]
        public void ConcertTicketQualityIsZeroAfterSellInDate()
        {
            ConcertTicket concertTicket = new ConcertTicket() {Name = "foo", Quality = 45, SellIn = 0};
            concertTicket.UpdateQuality();
            Assert.AreEqual(0, concertTicket.Quality);
            Assert.AreEqual(-1, concertTicket.SellIn);
        }

        [Test]
        public void ConcertTicketQualityIsNeverGreaterThanFifty()
        {
            ConcertTicket concertTicket = new ConcertTicket() {Name = "foo", Quality = 49, SellIn = 4};
            concertTicket.UpdateQuality();
            Assert.AreEqual(50, concertTicket.Quality);
            Assert.AreEqual(3, concertTicket.SellIn);
        }
        

    }
}