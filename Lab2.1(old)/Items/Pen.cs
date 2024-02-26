namespace Lab2._1_old_
{
    internal class Pen : Item
    {
        public Pen(string name, int price) : base(name, price)
        {
            Tags.Add(Tag.Office);
            Tags.Add(Tag.Pen);
        }
    }
}
