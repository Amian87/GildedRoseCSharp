using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GildedRoseKata.Tests
{
    [TestClass]
    public class ConcertTicketQualityTests
    {
        [TestMethod]
        public void ConcertTicketQualityIncreasesByOneBeforeTenDays()
        {
            ConcertTicketQuality item = new ConcertTicketQuality { Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 20, SellIn = 11 };
            item.UpdateQuality();
            Assert.AreEqual(21, item.Quality);
            Assert.AreEqual(10, item.SellIn);
        }

        [TestMethod]
        public void ConcertTicketQualityIncreaseByTwoLessThanTenDays()
        {
            ConcertTicketQuality item = new ConcertTicketQuality { Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 25, SellIn = 6 };
            item.UpdateQuality();
            Assert.AreEqual(27, item.Quality);
            Assert.AreEqual(5, item.SellIn);
        }

        [TestMethod]
        public void ConcertTicketQualityIncreasesByThreeLessThanFiveDays()
        {
            ConcertTicketQuality item = new ConcertTicketQuality {Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 30, SellIn = 5 };
            item.UpdateQuality();
            Assert.AreEqual(33, item.Quality);
            Assert.AreEqual(4, item.SellIn);
        }

        [TestMethod]
        public void ConcertTicketQualityIsZeroAfterSellInDate()
        {
            ConcertTicketQuality item = new ConcertTicketQuality {Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 9, SellIn = 0 };
            item.UpdateQuality();
            Assert.AreEqual(0, item.Quality);
            Assert.AreEqual(-1, item.SellIn);
        }

        [TestMethod]
        public void ConcertTicketQualityIsNeverGreaterThanFifty()
        {
            ConcertTicketQuality item = new ConcertTicketQuality { Name = "Backstage passes to a TAFKAL80ETC concert", Quality = 50, SellIn = 2 };
            item.UpdateQuality();
            Assert.AreEqual(50, item.Quality);
            Assert.AreEqual(1, item.SellIn);
        }
    }
}
