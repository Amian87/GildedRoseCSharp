using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata
{
    public class QualityAppreciates : AbstractItem
    {
        public override void UpdateQuality() 
        {
            Quality += 1;
            SellIn -= 1;

            if(SellIn < 0)
            {
                Quality += 1;
            }
            if (Quality >= 50)
            {
                Quality = 50;
            }
        }

    }
}
