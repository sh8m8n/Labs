using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace Lab2._1_old_
{
    internal class Program
    {
        static void Main()
        {
            //Инициализация ассортимента товаров
            List<Item> items = new List<Item>
            {
                new Pen("Pilot", 100),
                new Notebook("Honor magicbook 14", 50000)
            };
            List<Food> foods = new List<Food>
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

            items.AddRange(foods.Cast<Item>());

            //Инициализация магазина
            U_Market market = new U_Market(items);


            //Имитация интерфейса 
            Console.WriteLine("Чтобы добавить товар в корзину или применить фильтр введите его номер\n\n" +
                    "Список Фильтров:\n" +
                    "-1 Food:\n" +
                    "   -2 Snacks\n" +
                    "   -3 Healthy\n" +
                    "   -4 SemiFinished\n" +
                    "-5 Electronic:\n" +
                    "   -6 Notebook\n" +
                    "-7 Office:\n" +
                    "   -8 Pen\n" +
                    "-9 Сбалансировать корзину\n\n" +
                    "Список доступных товаров:\n" +
                    market.ShowItems());
            while (true)
            {
                int result = int.Parse(Console.ReadLine());

                switch (result)
                {
                    case -9:
                        market.BalanceFoods(foods);
                        Console.WriteLine(market.ShowCart());
                        break;
                    case  -1:
                        Console.WriteLine(market.ShowItems(Tag.Food));
                        Console.WriteLine(market.ShowCart());
                        break;
                    case -2:
                        Console.WriteLine(market.ShowItems(Tag.Snacks));
                        Console.WriteLine(market.ShowCart());
                        break;
                    case -3:
                        Console.WriteLine(market.ShowItems(Tag.Healthy));
                        Console.WriteLine(market.ShowCart());
                        break;
                    case -4:
                        Console.WriteLine(market.ShowItems(Tag.SemiFinished));
                        Console.WriteLine(market.ShowCart());
                        break;
                    case -5:
                        Console.WriteLine(market.ShowItems(Tag.Electronics));
                        Console.WriteLine(market.ShowCart());
                        break;
                    case -6:
                        Console.WriteLine(market.ShowItems(Tag.Notebook));
                        Console.WriteLine(market.ShowCart());
                        break;
                    case -7:
                        Console.WriteLine(market.ShowItems(Tag.Office));
                        Console.WriteLine(market.ShowCart());
                        break;
                    case -8:
                        Console.WriteLine(market.ShowItems(Tag.Pen));
                        Console.WriteLine(market.ShowCart());
                        break;
                    default:
                        market.Buy(result);
                        Console.WriteLine(market.ShowCart());
                        break;
                }
            }
        }
    }
}
