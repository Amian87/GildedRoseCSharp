using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata
{
    public class GenericItem : Item
    {
        public override string ToString()
        {
            return this.Name + ", " + this.SellIn + ", " + this.Quality;
        }

        public override void UpdateQuality()
        {
            SellIn = SellIn - 1;

            DecrementQuality();

            if (SellIn < 0)
            {
                DecrementQuality();

            }
        }

        private void DecrementQuality()
        {
            if (Quality > 0)
            {
                Quality = Quality - 1;
            }
        }
    }
}