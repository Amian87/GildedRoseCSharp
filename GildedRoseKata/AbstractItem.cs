using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata
{
    public abstract class AbstractItem : IItem 
    {
        

        public string Name { get; set; }
        public int Quality { get; set; }
        public int SellIn { get; set; }

        public abstract void UpdateQuality();

        public void PrintOut() 
        {
            System.Console.WriteLine(Name + ", " + SellIn + ", " + Quality);
        }

    }
}
