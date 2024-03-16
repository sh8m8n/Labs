namespace Lab2._1_old_
{
    public class Cheburek : Food
    {
        public Cheburek(string name, int price, int proteins, int fats, int carbohydrates) :
            base(name, price, proteins, fats, carbohydrates)
        {
            Tags.Add(Tag.SemiFinished);
        }
    }
}
