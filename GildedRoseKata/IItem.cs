using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata
{
    public interface IItem
    {
        void UpdateItemQuality();

        string Name { get; set; }
        int Quality { get; set; } 
        int SellIn { get; set; }
    }
}
