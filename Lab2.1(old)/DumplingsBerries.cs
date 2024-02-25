namespace Lab2._1_old_
{
    internal class DumplingsBerries : Product, IFood
    {
        public EnergyValue EnergyValue { get; }
        public FoodType FoodType { get; } = FoodType.SemiFinished;

        public DumplingsBerries(string name, int price, int proteins, int fats, int carbohydrates) : base(name, price)
        {
            EnergyValue = new EnergyValue(proteins, fats, carbohydrates);
        }
    }
}
