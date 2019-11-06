using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata
{
    public class ConstantQualityItem : IItem
    {
        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }

        public void Update(){ }
    }
}
