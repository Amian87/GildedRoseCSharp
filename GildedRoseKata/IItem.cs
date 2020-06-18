namespace GildedRoseKata
{
    public interface IItem
    {
        string Name { get; set; }
        int Quality { get; set; }
        int SellIn { get; set; }

        public void UpdateQuality();
    }
}