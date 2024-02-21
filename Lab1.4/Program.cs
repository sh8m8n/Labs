using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab4
{
    internal class Program
    {

        static void Task1(List<int> list)
        {
            int len = list.Count;
            int min = list.Min();
            int max = list.Max();
            int mul = Multiply(min, max);
            Console.WriteLine($"Длина последовательности = {len}");
            Console.WriteLine($"Произведение минимамального и максимального члена последовательности = " +
                $"{min} * {max} = {mul}");
        }

        static int Multiply(int a, int b)
        {
            return a * b;
        }

        static void Task2()
        {
            Dictionary<string, int> people = new Dictionary<string, int>()
            {
                {"Маша", 10000 },
                {"Петя", 30000 },
                {"Вася", 100000 }
            };
            Console.WriteLine("Введите имя:");
            string name = Console.ReadLine();
            int sum = GetInt("Введите сумму:");
            if (sum < 0)
            {
                Console.WriteLine("Вы не можете пополнить баланс или создать счет с отрицательной суммой");
                return;
            }

            if (people.ContainsKey(name))
            {
                people[name] = people[name] + sum;
                Console.WriteLine($"{name}, ваш баланс счета изменен! Текущий баланс {people[name]} рублей");
            }
            else
            {
                people.Add(name, sum);
                Console.WriteLine($"Благодарим, что вы стали клиентом нашего банка! {name}, ваш баланс счета изменен!" +
                    $" Текущий баланс {people[name]} рублей");
            }

            Console.WriteLine($"Вы можете воспользоваться стандартным вкладом нашего банка! Вложив сумму " +
                $"остатка {people[name]} на 3 года под 17% годовых вы получите прибыль {Profit(people[name])}." +
                $"Для активации вклада войдите в мобильное приложение!");
        }

        static int Profit(int sum)
        {
            int balance = sum;
            for (int i = 0; i < 3; i++)
            {
                balance += balance / 100 * 17;
            }
            return balance - sum;
        }

        //Задание 3
        static string GetLongestWord(string text)
        {
            string[] words = text.Split(new char[] { ' ', ',', '.', '!', '?', ':' }, StringSplitOptions.RemoveEmptyEntries);
            string longestWord = string.Empty;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > longestWord.Length)
                {
                    longestWord = words[i];
                }
            }
            return longestWord;
        }

        // задание 4
        static bool acceptablePassword(string password)
        {
            bool Lower = false;
            bool Number = false;
            bool Upper = false;
            bool symbol = false;
            bool length = false;
            char[] numbers = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            char[] symbols = { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '_', '-', '+', '=',
            '`', '~', '[', '{', ']', '}', ';', ':', '"', ',', '<', '.', '>', '/', '?', '.', '|'};

            if (password.Length >= 6 && password.Length <= 12)
            {
                length = true;
            }

            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsLower(password[i]))
                {
                    Lower = true;
                }
                if (char.IsUpper(password[i]))
                {
                    Upper = true;
                }
                if (numbers.Contains(password[i]))
                {
                    Number = true;
                }
                if (symbols.Contains(password[i]))
                {
                    symbol = true;
                }
            }
            if (Lower && Number && Upper && symbol && length)
            {
                return true;
            }
            return false;
        }

        static void Main(string[] args)
        {
            while (true)
            {
                int number = GetInt("\nВведите номер задачи ( 1-4 )");
                switch (number)
                {
                    case 1:
                        Random random = new Random();
                        List<int> numbers = new List<int>();
                        for (int i = 0; i < random.Next(5, 10); i++)
                        {
                            numbers.Add(random.Next(-10, 10));
                        }

                        Console.WriteLine("Сгенерированный массив:");
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            Console.Write(numbers[i] + " ");
                        }
                        Console.WriteLine();

                        Task1(numbers);
                        break;
                    case 2:
                        Task2();
                        break;
                    case 3:
                        Console.WriteLine("Напишите предложение:");
                        string text = Console.ReadLine();
                        Console.WriteLine($"Самое длинное слово в предложении: {GetLongestWord(text)}");
                        break;
                    case 4:
                        Console.WriteLine("Введите пароль");
                        string password = Console.ReadLine();
                        if (acceptablePassword(password))
                        {
                            Console.WriteLine("Допустимый пароль");
                        }
                        else
                        {
                            Console.WriteLine("Пароль неверный");
                        }
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
