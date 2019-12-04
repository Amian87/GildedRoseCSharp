using System;
using System.Collections.Generic;

namespace GildedRoseKata
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("OMGHAI!");
            IList<AbstractItem> Items = new List<AbstractItem>{
                new Item("+5 Dexterity Vest", 10, 20),
                new QualityAppreciates ("Aged Brie", 2, 0),
                new Item ("Elixir of the Mongoose", 5,7),
                new FixedQuality ("Sulfuras, Hand of Ragnaros", 0, 80),
                new FixedQuality ("Sulfuras, Hand of Ragnaros", -1, 80),
                new ConcertTicketQuality("Backstage passes to a TAFKAL80ETC concert", 15, 20),
                new ConcertTicketQuality("Backstage passes to a TAFKAL80ETC concert", 10, 49),
                new ConcertTicketQuality("Backstage passes to a TAFKAL80ETC concert", 5, 49),
                new ConjuredItems("Conjured Shirt", 5, 49)
            };
    
            var app = new GildedRose(Items);

            for (var i = 0; i < 31; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("name, sellIn, quality");
                for (var j = 0; j < Items.Count; j++)
                {
                    Console.WriteLine(Items[j].PrintOut());
                }
                Console.WriteLine("");
                app.UpdateQuality();
            }
        }
    }
}