using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Lab8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            //Генерация рандомных покупателей
            List<Customer> customers = new List<Customer>();

            for (int i = 0; i < 10; i++)
            {
                string name = File.ReadLines("C:\\C#\\Labs\\Lab6\\names.txt").Skip(random.Next(0, 1299)).Take(1).First();
                double gentleRate = random.NextDouble() * 30;

                customers.Add(new Customer(name, gentleRate));
            }

            //Инициализация производства
            Factory factory = new Factory();
            factory.Customers = customers;
            factory.ProduceSmartphones(10);

            //Вывод на консоль информации до продажи
            Console.WriteLine("Желающие приобрести смартфон:");
            foreach (Customer customer in factory.Customers)
            {
                Console.WriteLine("\t" + customer.ToString());
            }
            Console.WriteLine($"\nКоличество смартфонов на складе:{factory.GetCountOfSmartphones()}");

            //Продажа
            factory.SaleSmartphones();
            Console.WriteLine("\n\n*продажа*\n\n");

            //Вывод информации на консоль после продажи
            Console.WriteLine("Счастливые обладатели:");
            foreach (var customer in factory.Customers)
            {
                if (customer.Smartphone != null)
                {
                    Console.WriteLine("\t" + customer.ToString());
                }
            }

            Console.WriteLine("\nНесчастливые необладатели:");
            foreach (var customer in factory.Customers)
            {
                if (customer.Smartphone == null)
                {
                    Console.WriteLine("\t" + customer.ToString());
                }
            }

            Console.ReadKey();
        }
    }
}
