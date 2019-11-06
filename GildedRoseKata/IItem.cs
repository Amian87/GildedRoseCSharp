using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata
{
    public interface IItem
    {
        public void Update();

        public string Name { get; set; }
        public int Quality { get; set; }
        public int SellIn { get; set; }

    }
}
