using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata
{
    public class GildedRose
    {
        private IIO iO;
        
        IList<AbstractItem> Items;
        public GildedRose(IList<AbstractItem> Items, IIO io)
        {
            this.Items = Items;
            iO = io;
        }

        public void UpdateQuality()
        {
            foreach(var item in Items)
            {
                iO.ConsoleWrite(item.PrintOut());
                item.UpdateQuality();

            }
        }

        public void  PrintToConsole()
        {
            for (var i = 0; i < 31; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("name, sellIn, quality");
                UpdateQuality();
                Console.WriteLine("");
            }
        }

    }
}