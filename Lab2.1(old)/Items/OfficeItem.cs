namespace Lab2._1_old_.Items
{
    [Unreadable]
    public class OfficeItem : Item
    {
        public OfficeItem(string Name, int price) : base(Name, price)
        {
            Tags.Add(Tag.Office);
        }
    }
}
