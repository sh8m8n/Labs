using System;
using System.Linq;

namespace Lab3
{
    internal class Program
    {

        static void Task1()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 11);
            int attemptCount = 1;
            while (true)
            {
                int attemptNumber = GetInt("Поробуйте отгадать число:");
                if (attemptNumber == randomNumber)
                {
                    Console.WriteLine($"Вы отгадали число. Попытки: {attemptCount}");
                    break;
                }
                else if (attemptNumber > randomNumber)
                {
                    Console.WriteLine("Загаданное число меньше вашего.");
                    attemptCount++;
                }
                else if (attemptNumber < randomNumber)
                {
                    Console.WriteLine("Загаданное число больше вашего.");
                    attemptCount++;
                }
            }

        }
        static void Task2()
        {
            int N = GetInt("Введите число N (N > 10)");

            if (N <= 10)
            {
                Console.WriteLine("Необходимо ввести число больше 10");
                return;
            }

            double sum = 0;
            double squareSum = 0;

            for (double i = 1; i < N; i++)
            {
                sum += i;
                squareSum += Math.Pow(i, 2d);
                if (squareSum > 500)
                    break;
            }
            Console.WriteLine($"Сумма всех чисел последовательности = {sum}");
            Console.WriteLine($"Сумма всех квадратов чисел последовательнсоти = {squareSum}");
        }
        static void Task3()
        {
            Random random = new Random();
            int studentCount = random.Next(10, 20);
            int[] students = new int[studentCount];
            for (int i = 0; i < students.Length; i++)
            {
                students[i] = random.Next(0, 20);
            }

            Console.WriteLine($"Количество человек в группе: {studentCount}");
            Console.WriteLine("Количество подтягиваний:");
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i]);
            }

            int o3 = 0, o4 = 0, o5 = 0;
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i] >= 16)
                {
                    o5 += 1;
                }
                else if (students[i] >= 14)
                {
                    o4 += 1;
                }
                else if (students[i] >= 12)
                {
                    o3 += 1;
                }
            }

            Console.WriteLine($"Количество студентов, сдавших зачет на: \n3 - {o3}\n4 - {o4}\n5 - {o5}" +
                $"\nМаксимальное количество подтягиваний - {students.Max()}" +
                $"\nМинимальное количество подтягиваний - {students.Min()}");
        }
        static void Task4()
        {
            double a = GetDouble("Введите число А");
            double b = GetDouble("Введите число B");
            double c = GetDouble("Введите число C");
            double d = GetDouble("Введите число D");

            double sum = 0;
            double posSum = 0;

            for (double x = 1, result; x < 11; x++)
            {
                result = a * Math.Sqrt(b * x + d) - c * x;

                sum += result;
                if (result > 0)
                {
                    posSum += result;
                }
            }

            Console.WriteLine($"Сумма положительных значений: {posSum}\nСреднее значение функции: {sum / 10d}");
        }
        static void Task5()
        {
            int length = GetInt("Введите количество элементов массива");
            int[] numbers = new int[length];
            for (int i = 0; i < length; i++)
            {
                numbers[i] = GetInt($"Введите {i} элемент");
            }

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]} ");
            }
            Console.WriteLine();

            int max = numbers.Max();
            int maxCount = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == max)
                {
                    maxCount += 1;
                }
            }

            for (int j = 0; j < maxCount; j++)
            {
                bool flag = false;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] == max)
                    {
                        flag = true;
                    }
                    if (flag == true && i + 1 < numbers.Length)
                    {
                        numbers[i] = numbers[i + 1];
                    }
                }
                numbers[numbers.Length - 1] = max;
            }

            Console.WriteLine("Преобразованный массив:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]} ");
            }
            Console.WriteLine();
        }
        static void Task6()
        {
            int radius = GetInt("Введите радиус окружности:");
            double x, y;
            Random random = new Random();
            int ans = 0;
            Console.WriteLine("Точки:");
            for (int i = 0; i < 12; i++)
            {
                double length = 0;
                x = random.Next(-radius * 3, radius * 3);
                y = random.Next(-radius * 3, radius * 3);
                Console.WriteLine($"x = {x}, y = {y}");

                length = Math.Sqrt(Math.Pow(x, 2d) + Math.Pow(y, 2d));

                if (length <= radius * 2)
                {
                    ans += 1;
                }
            }
            Console.WriteLine($"Количество пересечений: {ans}");
        }

        static void Main(string[] args)
        {
            while (true)
            {
                int number = GetInt("\nВведите номер задачи ( 1-6 )");
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
                    case 6:
                        Task6();
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
        static double GetDouble(string request)
        {
            string str;
            bool success;
            double number;

            do
            {
                Console.WriteLine(request);
                str = Console.ReadLine();
                success = double.TryParse(str, out number);
                if (success == false)
                    Console.WriteLine("Не удалось преобразовать строку в число");
            } while (!success);

            return number;
        }
    }
}
