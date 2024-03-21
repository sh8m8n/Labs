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

            double distanceToDestination = CurrentLocation.GetDistance(Map[e.Order.Destination]);

            //на самом деле тут должно быть расстояние которое проедет водитель вместе с пассажиром
            double path = Map[e.Order.Destination].GetDistance(Map[e.Order.Departure]);

            if (distanceToDestination > AccessDistance) //Дистанция доступа
                return;

            OrderResponded?.Invoke(this, new OrderSummaryArgs(e.Order, distanceToDestination, path));
        }

        public void RegisterAggregator(TaxiAggregator aggregator)
        {
            aggregator.OrderRecieved += OrderHandler;
        }

        public void UnregisterAggregator(TaxiAggregator aggregator)
        {
            aggregator.OrderRecieved -= OrderHandler;
        }

    }
}
