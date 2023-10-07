using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabLib
{
    public static class Durak
    {
        /// <summary>
        /// Возвращает первое верное введенное в консоль число
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public static int GetInt(string request)
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
                    Console.WriteLine("Не удалось преобразовать строку в число, попробуйте еще раз.");
            } while (!success);

            return number;
        }

        /// <summary>
        /// Возвращает первое верное введенное в консоль число
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public static double GetDouble(string request)
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
                    Console.WriteLine("Не удалось преобразовать строку в число, попробуйте еще раз.");
            } while (!success);

            return number;
        }

        /// <summary>
        /// Возвращает массив случайной длинны со случайными значениями в заданных пределах
        /// </summary>
        /// <param name="minElementCount"></param>
        /// <param name="maxElementCount"></param>
        /// <param name="minElementValue"></param>
        /// <param name="maxElementValue"></param>
        /// <returns></returns>
        public static int[] GetRandomArray(int minElementCount, int maxElementCount, int minElementValue, int maxElementValue)
        {
            Random rnd = new Random();
            int[] numbers = new int[rnd.Next(minElementCount, maxElementCount)];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(minElementValue, maxElementValue);
            }
            return numbers;
        }

        /// <summary>
        /// Печатает массив в консоль
        /// </summary>
        /// <param name="array"></param>
        public static void WriteArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                if (i != array.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }
        public static void WriteArray(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                if (i != array.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }
    }
}
