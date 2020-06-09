﻿namespace GildedRoseKata
{
    public class ConcertTicketValue : IItem
    {
        public void UpdateItemQuality()
        {
            Quality += 1;

            if (SellIn < 5)
            {
                Quality += 1;
            }

            if (SellIn < 10)
            {
                Quality += 1;
            }

            if (Quality > 50)
            {
                Quality = 50;
            }

            if (SellIn < 0)
            {
                Quality = 0;
            }
   
        }

        public string Name { get; set; }
        public int Quality { get; set; }
        public int SellIn { get; set; }
    }
}