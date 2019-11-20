using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata
{
    public class FixQualityItem : IItem
    {
        public string Name { get; set; }
        public int Quality { get; set; }
        public int SellIn { get; set; }

        public void UpdateQuality()
        {
            
        }

    }
}
