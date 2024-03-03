using Lab2._1_old_;
using System.Collections.Generic;
using System;
namespace Lab2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataBase data = new DataBase();

            string test1 = data.HalturaCompare(new List<object>
            {
                new Pen("Pilot", 100),
                new Notebook("Honor magicbook 14", 50000),
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
            });
            Console.WriteLine($"Тест 1:\n{test1}");

            string test2 = data.HalturaCompare(new List<object>
            {
                new Pen("Pilot", 100),
                //new Notebook("Honor magicbook 14", 50000),
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
            });
            Console.WriteLine($"\nТест 2:\n{test2}");

            string test3 = data.HalturaCompare(new List<object>
            {
                new Notebook("Honor magicbook 14", 50000),
                new ChocolateBar("RitterSport", 199, 10, 35, 50),
                new Crisps("Lays дай краба", 99, 7, 30, 53),
                new ChocolateBar("Milka", 182, 8, 37, 51), //Замена
                //new DumplingsBerries("пельмени с ягодами", 299, 1, 0, 70),
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
            });
            Console.WriteLine($"\nТест 3:\n{test3}");

            string test4 = data.HalturaCompare(new List<object>
            {
                new Notebook("Honor magicbook 14", 50000),
                new ChocolateBar("RitterSport", 199, 10, 35, 50),
                new Crisps("Lays дай краба", 99, 7, 30, 53),
                new DumplingsBerries("пельмени с ягодами", 299, 1, 0, 70),
                new DumplingsMeat("пельмени", 499, 12, 12, 29),
                new Cheburek("huh?бурек", 256, 12, 20, 29),
                new BalykCheese("балыксыр", 319, 19, 23, 2),
                new Fruit("яблоко", 120, 1, 1, 10),
                new Fruit("банан", 180,  4, 1, 78),
                new OliveOil("масло оливковое", 299, 0, 100, 0), //Замена
                //new OliveOil("сасло маливковое", 299, 0, 100, 0),
                new RawMeat("говядина", 234, 22 * 2, 7 * 2, 0 * 2),
                new RawMeat("курица", 230, 19, 12, 1),
                new RawMeat("свин", 232, 19, 7, 0),
                new RawMeat("красная икра", 500, 25, 18, 4)
            });
            Console.WriteLine($"\nТест 4:\n{test4}");

            string test5 = data.HalturaCompare(new List<object>
            {
                new Notebook("Honor magicbook 14", 50000),
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
            });
            Console.WriteLine($"\nТест 5:\n{test5}");

            Console.ReadLine();
        }
    }
}
