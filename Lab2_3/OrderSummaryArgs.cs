using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_3
{
    public class OrderSummaryArgs : OrderArgs
    {
        public double DistanceToDestination { get; set; }
        public double Path { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="order"></param>
        /// <param name="distanceToDestination">Дистанция от текущего места водителя до старта маршрута</param>
        /// <param name="path">Путь который водитель проедет с пассажиром</param>
        public OrderSummaryArgs(Order order, double distanceToDestination, double path) : base(order)
        {
            DistanceToDestination = distanceToDestination;
            Path = path;
        }
    }
}
