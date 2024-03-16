namespace Lab2._1_old_
{
    public class DumplingsMeat : Food
    {
        public DumplingsMeat(string name, int price, int proteins, int fats, int carbohydrates) :
            base(name, price, proteins, fats, carbohydrates)
        {
            Tags.Add(Tag.SemiFinished);
        }
    }
}
