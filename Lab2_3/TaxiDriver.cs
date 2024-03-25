using System;
using System.Collections.Generic;

namespace Lab2_3
{
    public class TaxiDriver : Human
    {
        public static double AccessDistance { get; set; }

        public Car Car { get; set; }
        public Dictionary<string, Coordinates> Map { get; set; }
        public double Rating { get; private set; }
        public bool isFree { get; private set; }

        private Coordinates CurrentLocation;

        public event EventHandler<RespondedOrderArgs> OrderResponded;

        public TaxiDriver(Coordinates currentLocation, Car car, string name) : base(name)
        {
            CurrentLocation = currentLocation;
            Car = car;
            Rating = 0;
            isFree = true;
        }

        public void OrderHandler(object sender, OrderArgs e)
        {
            if(isFree == false) // Занятость
                return;
            if(Car.ChildSeat == false && e.Order.ChildSeat == true) //Наличие детского кресла
                return;

            double distanceToDestination = CurrentLocation.GetDistance(Map[e.Order.Destination.ToString()]);
                        
            if (distanceToDestination > AccessDistance) //Дистанция доступа
                return;

            //на самом деле тут должно быть расстояние которое проедет водитель вместе с пассажиром
            double path = Map[e.Order.Destination.ToString()].GetDistance(Map[e.Order.Departure.ToString()]);

            OrderResponded?.Invoke(this, new RespondedOrderArgs(e.Order, distanceToDestination, path));
        }

        /// <summary>
        /// Начисляет очки водителю
        /// </summary>
        /// <param name="ratingPoints"></param>
        public void AddRatingPoints(double ratingPoints)
        {
            if (ratingPoints > 0)
                Rating += ratingPoints;
        }
    }
}
