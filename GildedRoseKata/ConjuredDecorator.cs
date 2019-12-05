using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata
{
    public class ConjuredDecorator : AbstractItem
    {
        private Item itemDecorator;

        public ConjuredDecorator(Item item)
        {
            itemDecorator = item;

        }


        public override void UpdateQuality()
        {
            itemDecorator.DecreaseQualityByTwo();
        }
    }
}
