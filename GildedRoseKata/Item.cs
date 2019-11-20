using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata
{
    public abstract class Item : IUpdateQuality
    {
        public string Name { get; set; }
        public int Quality { get; set; }
        public int SellIn { get; set; }

        public abstract void UpdateQuality();
    }
}
