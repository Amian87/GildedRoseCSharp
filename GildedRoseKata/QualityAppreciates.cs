namespace GildedRoseKata
{
    public class QualityAppreciates : IUpdateQuality
    {
        public string Name { get; set; }
        public int Quality { get; set; }
        public int SellIn { get; set; }
        public void UpdateQuality()
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