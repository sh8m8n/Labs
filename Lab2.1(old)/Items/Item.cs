using System.Collections.Generic;

namespace Lab2._1_old_
{
    public abstract class Item
    {
        public string Name { get; set; }
        public int Price { get; set; }

        protected List<Tag> Tags;

        public Item(string name, int price)
        {
            Name = name;
            Price = price;
            Tags = new List<Tag>();
        }

        public void AddTag(Tag tag)
        {
            Tags.Add(tag);
        }
        public bool ContainstTag(Tag tag)
        {
            return Tags.Contains(tag);
        }

        public override string ToString()
        {
            return $"{Name}, Цена: {Price}";
        }
    }
}
