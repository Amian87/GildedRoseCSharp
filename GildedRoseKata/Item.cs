﻿using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata
{
    public class Item : IItem
    {
        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }

        public override string ToString()
        {
            return this.Name + ", " + this.SellIn + ", " + this.Quality;
        }

        public void UpdateQuality() {}
    }
}