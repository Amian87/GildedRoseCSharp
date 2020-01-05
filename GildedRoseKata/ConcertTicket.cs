namespace GildedRoseKata
{
    public class ConcertTicket : IItem
    {
        public void UpdateQuality()
        {
            throw new System.NotImplementedException();
        }

        public string Name { get; set; }
        public int Quality { get; set; }
        public int SellIn { get; set; }
    }
}