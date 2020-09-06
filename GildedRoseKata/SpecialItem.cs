using System;

namespace GildedRoseKata
{
    public class SpecialItem : AbsractItem
    {
        public override void UpdateQuality()
        {
            Quality -= 2;
            SellIn -= 1;

            if (Quality < 0)
            {
                Quality = 0;
            }
        }
    }
}