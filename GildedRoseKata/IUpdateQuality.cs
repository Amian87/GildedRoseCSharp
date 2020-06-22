namespace GildedRoseKata
{
    public interface IUpdateQuality
    {
        string Name { get; set; }
        int Quality { get; set; }
        int SellIn { get; set; }

        public void UpdateQuality();
    }
}