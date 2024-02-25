namespace Lab2._1_old_
{
    internal class ChocolateBar : Product, IFood
    {
        public EnergyValue EnergyValue { get; }
        public FoodType FoodType { get; } = FoodType.Snacks;

        public ChocolateBar(string name, int price, int proteins, int fats, int carbohydrates) : base(name, price)
        {
            EnergyValue = new EnergyValue(proteins, fats, carbohydrates);
        }
    }
}
