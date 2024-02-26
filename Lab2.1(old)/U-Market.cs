using System.Collections.Generic;
using System.Text;

namespace Lab2._1_old_
{
    internal class U_Market
    {
        public List<Item> Items { get; set; }
        private Cart cart;
        private const int accuracyPercentage = 10;

        public U_Market(List<Item> products)
        {
            Items = products;
            cart = new Cart();
        }

        public void Buy(int index)
        {
            cart.AddItem(Items[index]);
        }

        /// <summary>
        /// Добавляет в корзину продукты необходимые для сбалансированного набора
        /// </summary>
        /// <param name="foods">Ассортимент доступных продуктов</param>
        public void BalanceFoods(List<Food> foods)
        {
            cart.BalanceFood(foods, accuracyPercentage);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>Список товаров магазина</returns>
        public string ShowItems()
        {
            StringBuilder sb = new StringBuilder("Ассортимент товаров:\n");

            for (int i = 0; i < Items.Count; i++)
            {
                    sb.Append($"{i}: {Items[i]}\n");
            }
            return sb.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>Список товаров магазина подходящих под фильр</returns>
        public string ShowItems(Tag filter)
        {
            StringBuilder sb = new StringBuilder("Ассортимент товаров:\n");

            for (int i = 0; i < Items.Count; i++)
            {
                if (Items[i].Tags.Contains(filter))
                {
                    sb.Append($"{i}: {Items[i]}\n");
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
