using System;
using System.Collections.Generic;
using System.Text;
using GildedRoseKata;
using NUnit.Framework;

namespace GildedRoseTests
{
    class ConcertTicketTest
    {
        [Test]
        public void ConcertTicketQualityIncreasesByOnesBeforeTenDays()
        {
            ConcertTicket item = new ConcertTicket() {Name = "foo", Quality = 10, SellIn = 12};
            item.UpdateQuality();
            Assert.AreEqual(11, item.Quality);
        }

    }

}
