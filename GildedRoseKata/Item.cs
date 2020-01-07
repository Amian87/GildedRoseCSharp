using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata
{
    public class Item : AbstractItem
    {
        public override string ToString()
        {
            return this.Name + ", " + this.SellIn + ", " + this.Quality;
        }

        public override void UpdateQuality()
        {
            Quality -=  1;

            SellIn -=  1;

        }
    }
}