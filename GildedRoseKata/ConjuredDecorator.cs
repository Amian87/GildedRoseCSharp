using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata
{
    public class ConjuredDecorator : IItem
    {
        private IItem decoratedItem;

        public string Name { get; set; } 
        public int Quality { get; set; }
        public int SellIn { get; set; }

        public ConjuredDecorator(IItem item) 
        {
            decoratedItem = item;
        }

        public void UpdateQuality() 
        {
            decoratedItem.UpdateQuality();
            Quality -= 2;
        }

    }
}
