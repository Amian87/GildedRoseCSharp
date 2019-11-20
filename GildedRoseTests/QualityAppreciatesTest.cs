using GildedRoseKata;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseTests
{
    class QualityAppreciatesTest
    {
        [Test]
        public void AgedBrieQualityAppreciatesByOneBeforeSellInDate()
        {
            QualityAppreciates qualityAppreciates = new QualityAppreciates { Name = "Aged Brie", Quality = 10, SellIn = 5 };
            qualityAppreciates.UpdateQuality();
            Assert.AreEqual(11, qualityAppreciates.Quality);
        }

        [Test]
        public void AgedBrieQualityAppreciatesByTwoAfterSellInDate()
        {
            QualityAppreciates qualityAppreciates = new QualityAppreciates { Name = "Aged Brie", Quality = 10, SellIn = -1 };
            qualityAppreciates.UpdateQuality();
            Assert.AreEqual(12, qualityAppreciates.Quality);
        }

        [Test]
        public void QualityIsNeverGreaterThan50()
        {
            QualityAppreciates qualityAppreciates = new QualityAppreciates { Name = "Aged Brie", Quality = 50, SellIn = -1 };
            qualityAppreciates.UpdateQuality();
            Assert.AreEqual(50, qualityAppreciates.Quality);
        }

    }
}
