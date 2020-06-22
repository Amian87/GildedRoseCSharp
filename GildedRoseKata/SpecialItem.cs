namespace GildedRoseKata
{
    public class SpecialItem : Item
    {
        public override void UpdateQuality()
        {
            SellIn -= 1;
            Quality -= 2;
        }
    }
}