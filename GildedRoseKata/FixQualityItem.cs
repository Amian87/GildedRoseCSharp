namespace GildedRoseKata
{
    public class FixQualityItem : IItem
    {
        public void UpdateItemQuality() { }

        public string Name { get; set; }
        public int Quality { get; set; } 
        public int SellIn { get; set; }
    }
}