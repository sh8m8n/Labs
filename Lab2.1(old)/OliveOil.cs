namespace Lab2._1_old_
{
    internal class OliveOil : Product, IFood
    {
        public EnergyValue EnergyValue { get; }
        public FoodType FoodType { get; } = FoodType.Healthy;

        public OliveOil(string name, int price, int proteins, int fats, int carbohydrates) : base(name, price)
        {
            EnergyValue = new EnergyValue(proteins, fats, carbohydrates);
        }
    }
}
