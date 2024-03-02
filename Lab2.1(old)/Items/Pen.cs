using Lab2._1_old_.Items;

namespace Lab2._1_old_
{
    public class Pen : OfficeItem
    {
        public Pen(string name, int price) : base(name, price)
        {
            Tags.Add(Tag.Pen);
        }
    }
}
