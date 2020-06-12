namespace GildedRoseKata
{
    public class QualityDepreciates : Item
    {
        public override void UpdateItemQuality()
        {
            SellIn -= 1;
            Quality -= 1;
            if (SellIn < 0)
            {
                Quality -= 1;
            }
            if (Quality < 0)
            {
                Quality = 0;
            }

        }

    }
}