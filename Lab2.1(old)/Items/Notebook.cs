namespace Lab2._1_old_
{
    public class Notebook : Electronics
    {
        public Notebook(string name, int price) : base(name, price)
        {
            Tags.Add(Tag.Notebook);
        }
    }
}
