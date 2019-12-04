using NUnit.Framework;
using GildedRoseKata;
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
            QualityAppreciates qualityAppreciates = new QualityAppreciates("foo", 5, 10);
            qualityAppreciates.UpdateQuality();
            Assert.AreEqual("foo, 4, 11", qualityAppreciates.PrintOut());

        }

        [Test]
        public void AgedBrieQualityAppreciatesByTwoAfterSellInDate()
        {
            QualityAppreciates qualityAppreciates = new QualityAppreciates("foo", -1, 10);
            qualityAppreciates.UpdateQuality();
            Assert.AreEqual("foo, -2, 12", qualityAppreciates.PrintOut());
        }

        [Test]
        public void QualityIsNeverGreaterThanFifty()
        {
            QualityAppreciates qualityAppreciates = new QualityAppreciates("foo", -1, 50);
            qualityAppreciates.UpdateQuality();
            Assert.AreEqual("foo, -2, 50", qualityAppreciates.PrintOut());
        }

    }
}
    