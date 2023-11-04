using System;
using System.Linq;
using System.IO;

namespace LabLib
{
    public class RandomObject
    {
        private static Random _random = new Random();

        /// <summary>
        /// Возвращает массив случайной длинны со случайными значениями в заданных пределах
        /// </summary>
        /// <param name="minElementCount"></param>
        /// <param name="maxElementCount"></param>
        /// <param name="minElementValue"></param>
        /// <param name="maxElementValue"></param>
        /// <returns></returns>
        public static int[] GetRandomIntArray(int minElementCount, int maxElementCount, int minElementValue, int maxElementValue)
        {
            int[] numbers = new int[_random.Next(minElementCount, maxElementCount)];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = _random.Next(minElementValue, maxElementValue);
            }
            return numbers;
        }

        public static string GetRandomName()
        {
            return File.ReadLines("C:\\C#\\Labs\\LabLib\\names.txt").Skip(_random.Next(0, 1299)).Take(1).First();
        }
    }
}
