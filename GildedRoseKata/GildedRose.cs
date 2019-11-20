using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata
{
    public class GildedRose
    {
        IList<IUpdateQuality> Items;
        public GildedRose(IList<IUpdateQuality> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            foreach(var item in Items)
            {
                item.UpdateQuality();
            }
        }


    }
}