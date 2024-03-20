using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_3
{
    public class Coordinates
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Coordinates(double x, double y)
        {
            X = x;
            Y = y;
        }
        
        /// <summary>
        /// Вычисляет расстояние между координатами
        /// </summary>
        /// <param name="coordinates"></param>
        /// <returns></returns>
        public double GetDistance(Coordinates coordinates)
        {
            return Math.Sqrt(Math.Pow(X - coordinates.X, 2) + Math.Pow(Y - coordinates.Y, 2));
        }
    }
}
