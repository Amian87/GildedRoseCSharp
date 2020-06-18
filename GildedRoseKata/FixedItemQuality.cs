namespace GildedRoseKata
{
    public class FixedItemQuality : IItem
    {
        public string Name { get; set; }
        public int Quality { get; set; }
        public int SellIn { get; set; }
        public void UpdateQuality(){}

    }
}