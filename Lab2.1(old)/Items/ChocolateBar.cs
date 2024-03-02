namespace Lab2._1_old_
{
    public class ChocolateBar : Food
    {
        public ChocolateBar(string name, int price, int proteins, int fats, int carbohydrates) : 
            base(name, price, proteins, fats, carbohydrates)
        {
            Tags.Add(Tag.Snacks);
        }
    }
}
