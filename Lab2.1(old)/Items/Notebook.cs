namespace Lab2._1_old_
{
    internal class Notebook : Item
    {
        public Notebook(string name, int price) : base(name, price)
        {
            Tags.Add(Tag.Electronics);
            Tags.Add(Tag.Notebook);
        }
    }
}
