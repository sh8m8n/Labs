using System;

namespace Lab2._1_old_
{
    internal class Program
    {
        static void Main()
        {
            //Инициализация магазина
            U_Market market = new U_Market();

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
                    market.GetAssortment());
            while (true)
            {
                int result = int.Parse(Console.ReadLine());

                switch (result)
                {
                    case -9:
                        market.BalanceFoods();
                        Console.WriteLine(market.ShowCart());
                        break;
                    case  -1:
                        Console.WriteLine(market.GetAssortment(Tag.Food));
                        Console.WriteLine(market.ShowCart());
                        break;
                    case -2:
                        Console.WriteLine(market.GetAssortment(Tag.Snacks));
                        Console.WriteLine(market.ShowCart());
                        break;
                    case -3:
                        Console.WriteLine(market.GetAssortment(Tag.Healthy));
                        Console.WriteLine(market.ShowCart());
                        break;
                    case -4:
                        Console.WriteLine(market.GetAssortment(Tag.SemiFinished));
                        Console.WriteLine(market.ShowCart());
                        break;
                    case -5:
                        Console.WriteLine(market.GetAssortment(Tag.Electronics));
                        Console.WriteLine(market.ShowCart());
                        break;
                    case -6:
                        Console.WriteLine(market.GetAssortment(Tag.Notebook));
                        Console.WriteLine(market.ShowCart());
                        break;
                    case -7:
                        Console.WriteLine(market.GetAssortment(Tag.Office));
                        Console.WriteLine(market.ShowCart());
                        break;
                    case -8:
                        Console.WriteLine(market.GetAssortment(Tag.Pen));
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
