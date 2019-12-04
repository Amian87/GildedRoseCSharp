using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata
{
    public class Item : AbstractItem
    {
        public Item(string name, int sellIn, int quality)
        {
            this.Name = name;
            this.SellIn = sellIn;
            this.Quality = quality;
        }

        public override void UpdateQuality()
        {
            SellIn = SellIn - 1;

            if (Quality > 0)
            {

                Quality = Quality - 1;

            }
            
            if (SellIn < 0)
            {
         
              if (Quality > 0)
              {
                            
                    Quality = Quality - 1; 
              }
             
            }
        }
    }

}