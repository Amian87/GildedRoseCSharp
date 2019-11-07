using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata
{
    public class QualityDepreciatesItem : IItem
    {
        public override void Update()
        {
            Quality -= 1;
            SellIn -= 1;

            if (SellIn < 0)
            {
                Quality -= 1;
            }
            if (Quality < 0)
            {
                Quality = 0;
            }

   
        }

    }
}
