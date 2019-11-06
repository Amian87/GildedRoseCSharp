using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata
{
    public class QualityAppreicatesItem : IItem
    {
        public override void Update()
        {
            Quality += 2;

            if (Quality > 50 )
            {
                Quality = 50;
            }
        }
    }
}
