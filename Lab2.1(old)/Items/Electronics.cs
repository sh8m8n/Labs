namespace Lab2._1_old_
{
    public class Electronics : Item
    {
        public Electronics(string Name, int price) : base(Name, price)
        {
            Tags.Add(Tag.Electronics);
        }
    }
}
