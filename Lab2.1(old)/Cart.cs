using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2._1_old_
{
    internal class Cart
    {
        private List<Item> Items;
        private List<Food> Foods;

        public Cart()
        {
            Items = new List<Item>();
            Foods = new List<Food>();
        }

        public void AddItem(Item item)
        {
            if (item is Food food)
            {
                Foods.Add(food);
            }
            else
            {
                Items.Add(item);
            }
        }

        public List<Item> GetItems()
        {
            List<Item> temp = new List<Item>(Items);
            temp.AddRange(Foods.Cast<Item>());

            return temp;
        }

        /// <summary>
        /// Добавляет в коллекцию продукты необходимые для сбалансированного набора
        /// </summary>
        /// <param name="foods">Ассортимент доступных продуктов</param>
        /// <param name="accuracyPercentage">Допустимый процент отклонения наименьшего питательного элемента от наибольшего</param>
        /// <returns>Набор необходимой еды</returns>
        public void BalanceFood(List<Food> foods, int accuracyPercentage)
        {
            while(FindFoodDisbalance(accuracyPercentage) != null)
            {
                EnergyValue disbalance = FindFoodDisbalance(accuracyPercentage);
                Food bestResult = foods[0];

                foreach (Food food in foods)
                {
                    if (EnergyValue.GetOffset(food.EnergyValue, disbalance) <
                        EnergyValue.GetOffset(bestResult.EnergyValue, disbalance))
                    {
                        bestResult = food;
                    }
                }

                Foods.Add(bestResult);
            }
        }

        /// <summary>
        /// Поиск недостатка характеристик еды из корзины еды
        /// </summary>
        /// <param name="accuracyPercentage">допустимый процент неточности для каждой характеристики еды(белки жиры углеводы)</param>
        /// <returns>Данные о недостатке жиров и или белков и или углеводов</returns>
        private EnergyValue FindFoodDisbalance(int accuracyPercentage)
        {
            EnergyValue sumEnergy = new EnergyValue();
            foreach (Food food in Foods)
            {
                sumEnergy = sumEnergy + food.EnergyValue;
            }

            //Если корзина сбалансирована в пределах допустимого процента
            if (100d - (double)sumEnergy.Min() / (double)sumEnergy.Max() * 100d < accuracyPercentage)
                return null;

            //Иначе возвращается недостаток по необходимым питательным элементам
            int max = sumEnergy.Max();
            EnergyValue BalancedEnergy = new EnergyValue(max, max, max);
            return BalancedEnergy - sumEnergy;
        }

        public override string ToString()
        {
            EnergyValue sumEnergy = new EnergyValue();
            foreach (Food food in Foods)
            {
                sumEnergy = sumEnergy + food.EnergyValue;
            }

            StringBuilder sb = new StringBuilder($"Содержимое корзины:\nВсего: {sumEnergy}\n");

            List<Item> temp = new List<Item>(Items);
            temp.AddRange(Foods.Cast<Item>());

            foreach (Item item in temp)
            { 
                sb.Append($"{item}\n");
            }

            return sb.ToString();
        }
    }
}
