namespace Lab2._1_old_
{
    internal class OliveOil : Food
    {
        public OliveOil(string name, int price, int proteins, int fats, int carbohydrates) : 
            base(name, price, proteins, fats, carbohydrates)
        {
            Tags.Add(Tag.Healthy);
        }
    }
}
