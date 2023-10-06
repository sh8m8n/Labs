using System;

namespace Labs
{
    internal class Program
    {
        static void Task1()
        {
            Console.WriteLine("Как вас зовут?");
            string name = Console.ReadLine();

            Console.WriteLine("Какой язык программирования вы изучали раньше?");
            string language = Console.ReadLine();

            Console.WriteLine($"Я {name}, я уже знаю {language}");
        }
        static void Task2()
        {
            Console.WriteLine("Введите Х:");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите Y:");
            double y = double.Parse(Console.ReadLine());

            double angle = Math.Atan(y / x);
            Console.WriteLine($"Угол прямой на плоскости равен {angle * 57.2958d}°");
        }
        static void Task3()
        {
            int lenght = 163;

            Console.WriteLine("Введите скорость автомобиля (км/ч):");
            int v = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите время движения (ч):");
            int t = int.Parse(Console.ReadLine());

            int s = v * t;

            Console.WriteLine($"Через {t} часов автомобиль проедет {s / lenght} полных кругов и " +
                $" остановиться на отметке {s % lenght}");
        }
        static void Task4()
        {
            Console.WriteLine("Введите 1 число:");
            int firstValue = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите 2 число:");
            int secondValue = int.Parse(Console.ReadLine());

            Random random = new Random();
            Console.WriteLine(random.Next(firstValue, secondValue));
        }
        static void Task5()
        {
            Console.WriteLine("Введите значение а");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение b");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение c");
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение d");
            double d = double.Parse(Console.ReadLine());

            double Z = (a / c) * (b / d) - ((a * b - c) / (c * d)) + Math.Sqrt(d);
            Console.WriteLine(Z);
        }
        static void Task6()
        {
            Console.WriteLine("Введите первую сторону треугольника:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите вторую сторону треугольника:");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите третью сторону треугольника:");
            int c = int.Parse(Console.ReadLine());

            double p = (a + b + c) / 2d;

            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine(S);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1:");
            Task1();

            Console.WriteLine("\nЗадание 2:");
            Task2();

            Console.WriteLine("\nЗадание 3:");
            Task3();

        }
    }
}
