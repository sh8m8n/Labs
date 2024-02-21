using System;

namespace Lab2
{
    internal class Program
    {
        static void Task1()
        {
            int number = GetInt("Введите число N (номер Сережи)");

            if (number > 0)
            {
                if (number % 2 == 0)
                    Console.WriteLine("При расчете Сережа скажет - второй");
                else
                    Console.WriteLine("При расчете Сережа скажет - первый");
            }
            else
            {
                Console.WriteLine("У Сережи не может быть такой номер");
            }

        }
        static void Task2()
        {
            double a = GetInt("Введите первую сторону треугольника");
            double b = GetInt("Введите вторую сторону треугольника");
            double c = GetInt("Введите третью сторону треугольника");

            if (a < 0 || b < 0 || c < 0)
            {
                Console.WriteLine("Длина не может быть отрицательным числом");
                return;
            }

            if ((a + b > c) && (b + c > a) && (a + c > b))
            {
                double angleA = Math.Acos((Math.Pow(a, 2d) - Math.Pow(b, 2d) - Math.Pow(c, 2d)) /
                    (-2 * b * c)) * 180 / Math.PI;
                double angleB = Math.Acos((Math.Pow(b, 2d) - Math.Pow(a, 2d) - Math.Pow(c, 2d)) /
                    (-2 * a * c)) * 180 / Math.PI;
                double angleC = Math.Acos((Math.Pow(c, 2d) - Math.Pow(a, 2d) - Math.Pow(b, 2d)) /
                    (-2 * a * b)) * 180 / Math.PI;

                if (angleA == 90d || angleB == 90d || angleC == 90)
                {
                    Console.WriteLine($"Треугольник прямоугольный \n Угол A = {angleA} \n Угол B = {angleB}" +
                        $"\n Угол С = {angleC}");
                }
                else
                {
                    Console.WriteLine($"Треугольник не прямоугольный \n Угол A = {angleA} \n Угол B = {angleB}" +
                        $"\n Угол С = {angleC}");
                }
            }
            else
            {
                Console.WriteLine("Треугольник не существует");
            }
        }
        static void Task3()
        {
            int maxClientCount = 50;
            int number = GetInt("Введите номер Сергея в очереди");

            if (number < 0)
            {
                Console.WriteLine("Номер не может быть отрицательным");
                return;
            }

            if (number <= maxClientCount)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine($"Сергею стоит стоять в очереди, он простит {(number - 1) / 2 * 20} минут");
                }
                else
                {
                    Console.WriteLine($"Сергею стоит стоять в очереди, он простоит {number / 2 * 20} минут");
                }
            }
            else
            {
                Console.WriteLine("Сергею не стоит стоять в очереди");
            }

        }
        static void Task4()
        {
            int type = GetInt("Введите вид вклада \n 1. Вклад на 1 год под 7% годовых" +
                "\n 2. Вклад на 3 года под 8% годовых\n 3. Вклад на 5 лет под 10% годовых");
            if (type < 1 || type > 3)
            {
                Console.WriteLine("Такого вклада не существует");
                return;
            }
            double startSum = GetInt("Введите сумму вклада");
            if (startSum < 0)
            {
                Console.WriteLine("К сожалению долги не принимаются");
                return;
            }

            double sum = startSum;
            double profit = 0;
            switch (type)
            {
                case 1:
                    profit = startSum / 100 * 7;
                    break;
                case 2:
                    for (int i = 0; i < 3; i++)
                    {
                        sum += (sum / 100 * 8);
                    }
                    profit = sum - startSum;
                    break;
                case 3:
                    for (int i = 0; i < 5; i++)
                    {
                        sum += (sum / 100 * 10);
                    }
                    profit = sum - startSum;
                    break;
                default:
                    break;
            }
            Console.WriteLine($"Ваша прибыль {profit}");
        }
        static void Task5()
        {
            int maxSpeed = 90;
            int speed = Math.Abs(GetInt("Введите скорость автомобиля"));
            int difference = speed - maxSpeed;

            if (difference < 21)
                Console.WriteLine("Скорость автомобиля допустима на данном участке");
            else if (difference > 20 && difference < 40)
                Console.WriteLine("500 рублей");
            else if (difference > 39 && difference < 60)
                Console.WriteLine("1500 рублей");
            else if (difference > 59 && difference < 80)
                Console.WriteLine("2500 рублей или лишение прав на 4 месяца");
            else
                Console.WriteLine("5000 рублей или лишение прав на полгода");
        }

        static void Main(string[] args)
        {
            while (true)
            {
                int number = GetInt("\nВведите номер задачи ( 1-5 )");
                switch (number)
                {
                    case 1:
                        Task1();
                        break;
                    case 2:
                        Task2();
                        break;
                    case 3:
                        Task3();
                        break;
                    case 4:
                        Task4();
                        break;
                    case 5:
                        Task5();
                        break;
                    default:
                        Console.WriteLine("Такой задачи нет");
                        break;
                }
            }
        }

        static int GetInt(string request)
        {
            string str;
            bool success;
            int number;

            do
            {
                Console.WriteLine(request);
                str = Console.ReadLine();
                success = int.TryParse(str, out number);
                if (success == false)
                    Console.WriteLine("Не удалось преобразовать строку в число");
            } while (!success);

            return number;
        }
    }
}
