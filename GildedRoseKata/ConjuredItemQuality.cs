using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata
{
    public class ConjuredItemQuality : AbstractItem
    {
        public override void UpdateQuality()
        {
            SellIn -= 1;
            Quality -= 2;
        }
    }
}
