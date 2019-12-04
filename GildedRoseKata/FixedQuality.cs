using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata
{
    public class FixedQuality : AbstractItem
    {
        public FixedQuality(string name, int sellIn, int quality)
        {
            this.Name = name;
            this.SellIn = sellIn;
            this.Quality = quality;
        }

        public override void UpdateQuality() { }
    }
}
