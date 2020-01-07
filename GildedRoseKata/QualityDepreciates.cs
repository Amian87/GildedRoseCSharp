using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata
{
    public class QualityDepreciates : AbstractItem
    {
        public override void UpdateQuality()
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
