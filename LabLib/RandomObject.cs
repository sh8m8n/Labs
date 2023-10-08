using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabLib
{
    internal class RandomObject
    {
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
            Random rnd = new Random();
            int[] numbers = new int[rnd.Next(minElementCount, maxElementCount)];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(minElementValue, maxElementValue);
            }
            return numbers;
        }
    }
}
