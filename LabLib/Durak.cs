using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LabLib
{
    public static class Durak
    {
        /// <summary>
        /// Возвращает не пустую введенную в консоль строку
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public static string GetString(string request)
        {
            string str;
            do
            {
                Console.WriteLine(request);
                str = Console.ReadLine();
                if (str == null)
                {
                    Console.WriteLine("Строка не должна быть пустой");
                }
            } while (str == null);
            return str;
        }

        /// <summary>
        /// Возвращает первое верно введенное в консоль число
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
        /// Возвращает первое верно введенное в консоль число
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
    }
}
