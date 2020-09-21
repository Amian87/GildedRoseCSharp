namespace GildedRoseKata
{
    public class ConcertTicket : IItem
    {
        public string Name { get; set; }
        public int Quality { get; set; }
        public int SellIn { get; set; }
        public void UpdateQuality()
        {
            Quality += 1;
            SellIn -= 1;

            if (SellIn < 10)
            {
                Quality += 1;
            }

            if (SellIn < 5)
            {
                Quality += 1;
            }

            if (Quality > 50)
            {
                Quality = 50;
            }

            if (SellIn < 0)
            {
                Quality = 0;
            }
        }
    }
}