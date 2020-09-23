namespace GildedRoseKata
{
    public abstract class AbstractItem
    {
        public string Name { get; set; }
        public int Quality { get; set; }
        public int SellIn { get; set; }

        public abstract void UpdateQuality();
    }
}