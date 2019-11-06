using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata
{
    public abstract class IItem
    {
        public abstract void Update();

        public string Name { get; set; }
        public int Quality { get; set; }
        public int SellIn { get; set; }

    }
}
