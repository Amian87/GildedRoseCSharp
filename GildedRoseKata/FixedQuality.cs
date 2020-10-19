namespace GildedRoseKata
{
    public class FixedQuality : IItem
    {
        public string Name { get; set; }
        public int Quality { get; set; }
        public int SellIn { get; set; }
        public void UpdateQuality() {}
    }
}