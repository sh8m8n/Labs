namespace Lab2._1_old_
{
    public abstract class Food : Item
    {
        public EnergyValue EnergyValue { get; set; }

        public Food(string name, int price, int proteins, int fats, int carbohydrates) : base(name, price)
        {
            EnergyValue = new EnergyValue(proteins, fats, carbohydrates);
            Tags.Add(Tag.Food);
        }
    }
}
