using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata
{
    public interface IUpdateQuality
    {
        public void UpdateQuality();

        public string Name { get; set; }
        public int Quality { get; set; }
        public int SellIn { get; set; }

    }
}
