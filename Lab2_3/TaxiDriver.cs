using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_3
{
    public class TaxiDriver : Human
    {
        private Coordinates CurrentLocation;

        public Car Car { get; set; }
        public Dictionary<Address, Coordinates> Map { get; set; }
        public static double AccessDistance { get; set; }
        public double Rating { get; set; }
        public bool isFree { get; set; }

        public event EventHandler<OrderSummaryArgs> OrderResponded;

        public void OrderHandler(object sender, OrderArgs e)
        {
            if(isFree == false) // Занятость
                return;
            if(Car.ChildSeat == false && e.Order.ChildSeat == true) //Наличие детского кресла
                return;
            double distance = CurrentLocation.GetDistance(Map[e.Order.Destination]);
            if (distance > AccessDistance) //Дистанция доступа
                return;

            OrderResponded?.Invoke(this, new OrderSummaryArgs(e.Order, distance));
        }

    }
}
