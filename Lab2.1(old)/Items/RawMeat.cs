namespace Lab2._1_old_
{
    internal class RawMeat : Food
    {
        public RawMeat(string name, int price, int proteins, int fats, int carbohydrates) : 
            base(name, price, proteins, fats, carbohydrates)
        {
            Tags.Add(Tag.Healthy);
        }
    }
}
