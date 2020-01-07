using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata
{
    public interface IItem
    {
        string Name { get; set; }
        int Quality { get; set; }
        int SellIn { get; set; }
        
        void UpdateQuality();

    }
}
