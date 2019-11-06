using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata
{
    public class QualityAppreicatesItem : IItem
    {
        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }

        public void Update()
        {
            Quality += 2;

            if (Quality > 50 )
            {
                Quality = 50;
            }
        }
    }
}
