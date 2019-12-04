using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata
{
    public class ConjuredItems : AbstractItem
    {
        public ConjuredItems(string name, int sellIn, int quality)
        {
            this.Name = name;
            this.SellIn = sellIn;
            this.Quality = quality;
        }

        public override void UpdateQuality()
        {
            Quality -= 2;
            SellIn -= 1;
            
            if(Quality < 0)
            {
                Quality = 0;
            }
        }

    }
}
