using GildedRoseKata;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace GildedRoseTest
{
    public class GuildedRoseTest
    {



        private static void UpdateItemQualityThirtyTimes(GildedRose app)
        {
            for (int i = 0; i < 31; i++)
            {
                app.UpdateQuality();
            }
        }


        [Test]
        public void foo()
        {
            IList<IItem> Items = new List<IItem> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual("foo", Items[0].Name);
        }

        [Test]
        public void TestAgedBrie()
        {
            IList<IItem>Items = new List<IItem>{ new Item { Name = "Aged Brie", SellIn = 0, Quality = 0 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual("Aged Brie", Items[0].Name);
            Assert.AreEqual(2, Items[0].Quality);
            Assert.AreEqual(-1, Items[0].SellIn);
        }

        [Test]
        public void TestBackstagePass()
        {
            IList<IItem>Items = new List<IItem>{ new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 0 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual("Backstage passes to a TAFKAL80ETC concert", Items[0].Name);
            Assert.AreEqual(0, Items[0].Quality);
            Assert.AreEqual(-1, Items[0].SellIn);
        }

        [Test]
        public void TestSulfurasHandOfRagnaros()
        {
            IList<IItem>Items = new List<IItem>{ new ConstantQualityItem { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80} };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual("Sulfuras, Hand of Ragnaros", Items[0].Name);
            Assert.AreEqual(80, Items[0].Quality);
            Assert.AreEqual(0, Items[0].SellIn);
        }

        [Test]
        public void TestDexterityVest()
        {
            IList<IItem>Items = new List<IItem>{ new Item { Name = "+5 Dexterity Vest", SellIn = 100, Quality = 50 } };
            GildedRose app = new GildedRose(Items);
            UpdateItemQualityThirtyTimes(app);
            Assert.AreEqual("+5 Dexterity Vest", Items[0].Name);
            Assert.AreEqual(19, Items[0].Quality);
            Assert.AreEqual(69, Items[0].SellIn);
        }

        [Test]
        public void TestElixirOfTheMongoose()
        {
            IList<IItem>Items = new List<IItem>{ new Item { Name = "Elixir of the Mongoose", SellIn = 100, Quality = 50 } };
            GildedRose app = new GildedRose(Items);
            UpdateItemQualityThirtyTimes(app);
            Assert.AreEqual("Elixir of the Mongoose", Items[0].Name);
            Assert.AreEqual(19, Items[0].Quality);
            Assert.AreEqual(69, Items[0].SellIn);
        }

        [Test]
        public void SulfurasDoesNotDecreaseInQuality()
        {
            IList<IItem>Items = new List<IItem>{ new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 10, Quality = 80 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual("Sulfuras, Hand of Ragnaros", Items[0].Name);
            Assert.AreEqual(80, Items[0].Quality);
            Assert.AreEqual(10, Items[0].SellIn);
        }

        [Test]
        public void AgedBrieIncreasesInQualityTheOlderItGets()
        {
            IList<IItem>Items = new List<IItem>{ new Item { Name = "Aged Brie", SellIn = 10, Quality = 10 } };
            GildedRose app = new GildedRose(Items);
            UpdateItemQualityThirtyTimes(app);
            Assert.AreEqual("Aged Brie", Items[0].Name);
            Assert.AreEqual(50, Items[0].Quality);
            Assert.AreEqual(-21, Items[0].SellIn);
        }

        [Test]
        public void QualityOfAnItemIsNeverMoreThanFiftyAndIsNeverNegative()
        {
            IList<IItem>Items = new List<IItem>();
            Items.Add(new Item { Name = "Aged Brie", SellIn = 2, Quality = 1 });
            Items.Add(new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 10, Quality = 80 });
            Items.Add(new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 20, Quality = 50 });
            Items.Add(new Item { Name = "Elixir of the Mongoose", SellIn = 20, Quality = 50 });
            Items.Add(new Item { Name = "+5 Dexterity Vest", SellIn = 20, Quality = 50 });


            GildedRose app = new GildedRose(Items);
            UpdateItemQualityThirtyTimes(app);


            Assert.AreNotEqual(51, Items[0].Quality);
            Assert.AreNotEqual(-1, Items[0].Quality);
            Assert.AreEqual(50, Items[0].Quality);


            Assert.AreNotEqual(51, Items[1].Quality);
            Assert.AreNotEqual(-1, Items[1].Quality);
            Assert.AreEqual(80, Items[1].Quality);

            Assert.AreNotEqual(51, Items[2].Quality);
            Assert.AreNotEqual(-1, Items[2].Quality);
            Assert.AreEqual(0, Items[2].Quality);

            Assert.AreNotEqual(51, Items[3].Quality);
            Assert.AreNotEqual(-1, Items[3].Quality);
            Assert.AreEqual(8, Items[3].Quality);

            Assert.AreNotEqual(51, Items[4].Quality);
            Assert.AreNotEqual(-1, Items[4].Quality);
            Assert.AreEqual(8, Items[4].Quality);
        }

        [Test]
        public void OnceTheSellDateHasPassedQualityDegradesTwiceAsFast()
        {
            IList<IItem>Items = new List<IItem>{ new Item { Name = "+5 Dexterity Vest", SellIn = 28, Quality = 50 } };
            GildedRose app = new GildedRose(Items);
            UpdateItemQualityThirtyTimes(app);
            Assert.AreEqual(16, Items[0].Quality);
            Assert.AreEqual(-3, Items[0].SellIn);
        }

    }
}
