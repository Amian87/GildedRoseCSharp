using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata
{
    public class ConcertTicketValue : IUpdateQuality
    {
        public string Name { get; set; }
        public int Quality { get; set; }
        public int SellIn { get; set; }

        public void UpdateQuality()
        {
            SellIn -= 1;
            Quality += 1;
      
            if(SellIn < 0)
            {
                Quality = 0;
            }
            else if (SellIn < 5)
            {
                Quality += 2;
            }
            else if (SellIn < 10)
            {
                Quality += 1;
            }
            if(Quality >= 50)
            {
                Quality = 50;
            }

        }
    }
}
