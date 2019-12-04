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