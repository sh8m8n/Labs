namespace Lab2._1_old_
{
    internal class U_Market
    {
        private DataBase data;
        private Cart cart;
        private const int accuracyPercentage = 10;

        public U_Market()
        {
            data = new DataBase();
            cart = new Cart();
        }

        public void Buy(int index)
        {
            cart.AddItem(data.GetObject<Item>(index));
        }

        /// <summary>
        /// Добавляет в корзину продукты необходимые для сбалансированного набора
        /// </summary>
        public void BalanceFoods()
        {
            cart.BalanceFood(data.GetData<Food>(), accuracyPercentage);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>Ассортимент товаров</returns>
        public string GetAssortment()
        {
            return "Ассортимент:\n" + data.GetDataString<Item>();
        }

        /// <summary>
        /// Возвращает ассортимент товаров подходящих под тег
        /// </summary>
        /// <param name="tag">Тег необходимых товаров</param>
        /// <returns>Ассортимент товаров</returns>
        public string GetAssortment(Tag tag)
        {
            return "Ассортимент:\n" + data.GetDataString<Food>(tag);
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
