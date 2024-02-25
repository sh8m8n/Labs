using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2._1_old_
{
    internal class Cart
    {
        private List<Product> Products;
        private List<IFood> Foods;

        public Cart()
        {
            Products = new List<Product>();
            Foods = new List<IFood>();
        }

        public void AddProduct(Product product)
        {
            if (product is IFood food)
            {
                Foods.Add(food);
            }
            else
            {
                Products.Add(product);
            }
        }

        public List<Product> GetProducts()
        {
            List<Product> temp = new List<Product>(Products);
            temp.AddRange(Foods.Cast<Product>());

            return temp;
        }

        /// <summary>
        /// Поиск недостатка характеристик еды из корзины еды
        /// </summary>
        /// <param name="accuracyPercentage">допустимый процент неточности для каждой характеристики еды(белки жиры углеводы)</param>
        /// <returns>Данные о недостатке жиров и или белков и или углеводов</returns>
        private EnergyValue FindFoodDisbalance(int accuracyPercentage)
        {
            EnergyValue sumEnergy = new EnergyValue();
            foreach (IFood food in Foods)
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

        /// <summary>
        /// Добавляет в коллекцию продукты необходимые для сбалансированного набора
        /// </summary>
        /// <param name="foods">Ассортимент доступных продуктов</param>
        /// <param name="accuracyPercentage">Допустимый процент отклонения наименьшего питательного элемента от наибольшего</param>
        /// <returns>Набор необходимой еды</returns>
        public void BalanceFood(List<IFood> foods, int accuracyPercentage)
        {
            while(FindFoodDisbalance(accuracyPercentage) != null)
            {
                EnergyValue disbalance = FindFoodDisbalance(accuracyPercentage);
                IFood bestResult = foods[0];

                foreach (IFood food in foods)
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

        public override string ToString()
        {
            EnergyValue sumEnergy = new EnergyValue();
            foreach (IFood food in Foods)
            {
                sumEnergy = sumEnergy + food.EnergyValue;
            }

            StringBuilder sb = new StringBuilder($"{sumEnergy}\n");

            List<Product> temp = new List<Product>(Products);
            temp.AddRange(Foods.Cast<Product>());

            foreach (Product product in temp)
            { 
                sb.Append($"{product}\n");
            }

            return sb.ToString();
        }
    }
}
