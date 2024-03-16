using System;

namespace LabLib
{
    public static class Print
    {
        /// <summary>
        /// Печатает массив в консоль
        /// </summary>
        /// <param name="array"></param>
        public static void Array(int[] array)
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
        public static void Array(double[] array)
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
