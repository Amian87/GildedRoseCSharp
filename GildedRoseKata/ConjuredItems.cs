using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata
{
    public class ConjuredItems : IItem
    {
        public string Name { get; set; }
        public int Quality { get; set; }
        public int SellIn { get; set; }

        public void UpdateQuality()
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
