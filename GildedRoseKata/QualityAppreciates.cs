namespace GildedRoseKata
{
    public class QualityAppreciates : Item
    {
        public override void UpdateQuality()
        {
            SellIn -= 1;
            Quality += 1;

            if (SellIn < 0)
            {
                Quality += 1;
            }

            if (Quality > 50)
            {
                Quality = 50;
            }
        }
    }
}