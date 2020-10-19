using System;

namespace GildedRoseKata
{
    public class SpecialItemQuality : IItem
    {
        public string Name { get; set; }
        public int Quality { get; set; }
        public int SellIn { get; set; }
        public void UpdateQuality()
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