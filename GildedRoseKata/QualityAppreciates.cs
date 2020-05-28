namespace GildedRoseKata
{
    public class QualityAppreciates : IItem
    {
        public void UpdateItemQuality()
        {
            Quality += 1;

            if (SellIn < 0)
            {
                Quality += 1;
            }

            if (Quality >= 50)
            {
                Quality = 50;
            }

        }

        public string Name { get; set; }
        public int Quality { get; set; }
        public int SellIn { get; set; }
    }
}