using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_3
{
    public class OrderSummaryArgs : OrderArgs
    {
        public double TraveledDistance { get; set; }

        public OrderSummaryArgs(Order order, double traveledDistance) : base(order)
        {
            TraveledDistance = traveledDistance;
        }
    }
}
