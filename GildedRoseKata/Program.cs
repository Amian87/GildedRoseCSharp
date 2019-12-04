﻿using System;
using System.Collections.Generic;

namespace GildedRoseKata
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("OMGHAI!");
            IList<IItem> Items = new List<IItem>{
                new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                new QualityAppreciates {Name = "Aged Brie", SellIn = 2, Quality = 0},
                new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                new FixedQuality {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                new FixedQuality {Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80},
                new ConcertTicketQuality
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 15,
                    Quality = 20
                },
                new ConcertTicketQuality
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 10,
                    Quality = 49
                },
                new ConcertTicketQuality
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 5,
                    Quality = 49
                },
                new ConjuredItems
                {
                    Name = "Conjured Shirt",
                    SellIn = 5,
                    Quality = 49
                }
            };
    
            var app = new GildedRose(Items);

            for (var i = 0; i < 31; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("name, sellIn, quality");
                for (var j = 0; j < Items.Count; j++)
                {
                    Items[j].PrintOut();
                }
                Console.WriteLine("");
                app.UpdateQuality();
            }
        }
    }
}