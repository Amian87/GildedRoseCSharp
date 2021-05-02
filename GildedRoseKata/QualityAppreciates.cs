namespace GildedRoseKata
{
    public class QualityAppreciates : AbsractItem 
    {
        public override void UpdateQuality()
        {
            Quality += 1;
            SellIn -= 1;

            if (SellIn < 0)
            {
                Quality += 1;
            }

            if (Quality >= 50)
            {
                Quality = 50;
            }
        }
    }
}