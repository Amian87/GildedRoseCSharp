using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata
{
    public class GildedRose
    {
        IList<AbsractItem> Items;
        public GildedRose(IList<AbsractItem> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                item.UpdateQuality();
            }
        }
    }
}