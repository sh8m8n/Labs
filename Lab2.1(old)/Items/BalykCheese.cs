﻿namespace Lab2._1_old_
{
    internal class BalykCheese : Food
    {
        public BalykCheese(string name, int price, int proteins, int fats, int carbohydrates) : 
            base(name, price, proteins, fats, carbohydrates)
        {
            Tags.Add(Tag.Snacks);
        }
    }
}
