using System.Collections.Generic;
using System.Text;

namespace Lab2._1_old_
{
    internal class U_Market
    {
        public List<Product> Products { get; set; }
        private Cart cart;
        private const int accuracyPercentage = 10;

        public U_Market(List<Product> products)
        {
            Products = products;
            cart = new Cart();
        }

        public void Buy(int index)
        {
            cart.AddProduct(Products[index]);
        }

        /// <summary>
        /// Добавляет в корзину продукты необходимые для сбалансированного набора
        /// </summary>
        /// <param name="foods">Ассортимент доступных продуктов</param>
        public void BalanceFoods(List<IFood> foods)
        {
            cart.BalanceFood(foods, accuracyPercentage);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>Список товаров магазина</returns>
        public string ShowProducts()
        {
            StringBuilder sb = new StringBuilder("Ассортимент товаров:\n");

            for (int i = 0; i < Products.Count; i++)
            {
                    sb.Append($"{i}: {Products[i]}\n");
            }
            return sb.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>Список еды находящихся в корзине</returns>
        public string ShowFood()
        {
            StringBuilder sb = new StringBuilder("Ассортимент съедобных товаров:\n");

            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i] is IFood)
                {
                    sb.Append($"{i}: {Products[i]}\n");
                }
            }
            return sb.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filter">необходимый тип еды</param>
        /// <returns>Список еды находящихся в корзине соответствующая фильтру</returns>
        public string ShowFood(FoodType filter)
        {
            StringBuilder sb = new StringBuilder("Ассортимент съедобных товаров:\n");

            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i] is IFood food && food.FoodType == filter)
                {
                    sb.Append($"{i}: {Products[i]}\n");
                }
            }
            return sb.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>Список продуктов находящихся в корзине</returns>
        public string ShowCart()
        {
            return cart.ToString();
        }
    }
}
