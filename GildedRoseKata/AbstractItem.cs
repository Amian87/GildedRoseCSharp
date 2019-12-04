using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata
{
    public abstract class AbstractItem
    {
        protected string Name;
        protected int Quality;
        protected int SellIn;
        
        public abstract void UpdateQuality();

        public string PrintOut() 
        {
            return Name + ", " + SellIn + ", " + Quality;
        }

    }
}
