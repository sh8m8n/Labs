using System.Collections.Generic;

namespace Lab2._1_old_
{
    public abstract class Item
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public List<Tag> Tags { get; protected set; }

        public Item(string name, int price)
        {
            Name = name;
            Price = price;
            Tags = new List<Tag>();
        }

        public override string ToString()
        {
            return $"{Name}, Цена: {Price}";
        }
    }
}
