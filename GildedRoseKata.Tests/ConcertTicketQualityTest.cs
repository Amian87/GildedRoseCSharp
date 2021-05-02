using NUnit.Framework;

namespace GildedRoseKata.Tests
{
    public class ConcertTicketQualityTest
    {
        [Test]
        public void ConcertTicketQualityIncreasesByOneBeforeTenDays()
        {
            ConcertTicketQuality item = new ConcertTicketQuality(){Name = "foo", Quality = 14, SellIn = 11};
            item.UpdateQuality();
            Assert.AreEqual(15, item.Quality);
            Assert.AreEqual(10, item.SellIn);
        }

        [Test]
        public void TestConcertTicketQualityIncreasesByTwoGreaterThanFiveDays()
        {
            ConcertTicketQuality item = new ConcertTicketQuality(){Name = "foo", Quality = 17, SellIn = 10};
            item.UpdateQuality();
            Assert.AreEqual(19, item.Quality);
            Assert.AreEqual(9, item.SellIn);
        }

        [Test]
        public void TestConcertTicketQualityIncreasesByThreeLessThanFiveDays()
        {
            ConcertTicketQuality item = new ConcertTicketQuality(){Name = "foo", Quality = 25, SellIn = 5};
            item.UpdateQuality();
            Assert.AreEqual(28, item.Quality);
            Assert.AreEqual(4, item.SellIn);
        }

        [Test]
        public void TestConcertTicketQualityIsZeroAfterSellInDate()
        {
            ConcertTicketQuality item = new ConcertTicketQuality() {Name = "foo", Quality = 27, SellIn = 0};
            item.UpdateQuality();
            Assert.AreEqual(0, item.Quality);
            Assert.AreEqual(-1, item.SellIn);
        }

        [Test]
        public void TestConcertTicketQualityIsNotGreaterThanFifty()
        {
            ConcertTicketQuality item = new ConcertTicketQuality(){Name = "foo", Quality = 50, SellIn = 5};
            item.UpdateQuality();
            Assert.AreEqual(50, item.Quality);
            Assert.AreEqual(4, item.SellIn);
        }
    }
}