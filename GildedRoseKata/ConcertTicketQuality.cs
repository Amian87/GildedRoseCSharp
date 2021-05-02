namespace GildedRoseKata
{
    public class ConcertTicketQuality : AbsractItem
    {
        public override void UpdateQuality()
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

            if (SellIn < 0)
            {
                Quality = 0;
            }

            if (Quality >= 50)
            {
                Quality = 50;
            }

        }
    }
}