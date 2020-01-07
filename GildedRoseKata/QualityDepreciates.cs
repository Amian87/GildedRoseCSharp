using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata
{
    public class QualityDepreciates : IItem
    {
        public string Name { get; set; }
        public int Quality { get; set; }
        public int SellIn { get; set; }

        public void UpdateQuality()
        {
            Quality -= 1;
            SellIn -= 1;

            if (Quality < 0)
            {
                Quality = 0;
            }

            if (SellIn < 0)
            {
                Quality -= 1;
            }
        }
    }
}
