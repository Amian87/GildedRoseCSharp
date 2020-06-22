namespace GildedRoseKata
{
    public class QualityDepreciates : IUpdateQuality
    {

        public string Name { get; set; }
        public int Quality { get; set; }
        public int SellIn { get; set; }
        public void UpdateQuality()
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