namespace GildedRoseKata
{
    public class ConcertTicketValue : IItem
    {
        public void UpdateItemQuality()
        {
            throw new System.NotImplementedException();
        }

        public string Name { get; set; }
        public int Quality { get; set; }
        public int SellIn { get; set; }
    }
}