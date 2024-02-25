using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab2._1_old_
{
    internal class Program
    {
        static void Main()
        {
            //Инициализация ассортимента товаров
            List<Product> products = new List<Product>
            {
                new Pen("Pilot", 100),
                new Notebook("Honor magicbook 14", 50000)
            };
            List<IFood> foods = new List<IFood>
            {
                new ChocolateBar("RitterSport", 199, 10, 35, 50),
                new Crisps("Lays дай краба", 99, 7, 30, 53),
                new DumplingsBerries("пельмени с ягодами", 299, 1, 0, 70),
                new DumplingsMeat("пельмени", 499, 12, 12, 29),
                new Cheburek("huh?бурек", 256, 12, 20, 29),
                new BalykCheese("балыксыр", 319, 19, 23, 2),
                new Fruit("яблоко", 120, 1, 1, 10),
                new Fruit("банан", 180,  4, 1, 78),
                new OliveOil("сасло маливковое", 299, 0, 100, 0),
                new RawMeat("говядина", 234, 22 * 2, 7 * 2, 0 * 2),
                new RawMeat("курица", 230, 19, 12, 1),
                new RawMeat("свин", 232, 19, 7, 0),
                new RawMeat("красная икра", 500, 25, 18, 4)
            };

            products.AddRange(foods.Cast<Product>());

            //Инициализация магазина
            U_Market market = new U_Market(products);


            //Имитация интерфейса
            Console.WriteLine(market.ShowProducts());

            while (true)
            {
                Console.WriteLine("Применить фильтр:\n" +
                    "-1 - food\n" +
                    "-2 - snacks\n" +
                    "-3 - healthy\n" +
                    "-4 - semiFinished\n" +
                    "-5 - сбросить фильтры\n" +
                    "---\n" +
                    "Чтобы купить товар введите его номер\n" +
                    "Чтобы сбалансировать продукты введите 0\n");
                int result = int.Parse(Console.ReadLine());

                Console.WriteLine("\n\n\n");
                switch (result)
                {
                    case -1:
                        Console.WriteLine(market.ShowFood()); break;
                    case -2:
                        Console.WriteLine(market.ShowFood(FoodType.Snacks)); break;
                    case -3:
                        Console.WriteLine(market.ShowFood(FoodType.Healthy)); break;
                    case -4:
                        Console.WriteLine(market.ShowFood(FoodType.SemiFinished)); break;
                    case -5:
                        Console.WriteLine(market.ShowProducts()); break;
                    case 0: 
                        market.BalanceFoods(foods); break;
                    default: 
                        market.Buy(result); break;
                }
                Console.WriteLine(market.ShowCart());
            }
        }
    }
}
