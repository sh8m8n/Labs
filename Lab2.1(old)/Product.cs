namespace Lab2._1_old_
{
    public abstract class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public Product(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Name}, Цена: {Price}";
        }
    }
}
