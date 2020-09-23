using System;

namespace GildedRoseKata
{
    public class SpecialItem : AbstractItem
    {
        public override void UpdateQuality()
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