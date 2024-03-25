﻿using System;

namespace Lab2_3
{
    public class Customer : Human
    {
        public event EventHandler<OrderArgs> TaxiCalled;

        /// <summary>
        /// Вызвать такси
        /// </summary>
        /// <param name="destinationStreet">откуда улица</param>
        /// <param name="destinationHouse">откуда дом</param>
        /// <param name="departureStreet">куда улица</param>
        /// <param name="departureHouse">куда дом</param>
        /// <param name="childSeat">необходимость детского сиденья</param>
        public void TakeATaxi(string destinationStreet, int destinationHouse,
            string departureStreet, int departureHouse, bool childSeat)
        {
            Order order = new Order(new Address(destinationStreet, destinationHouse),
                new Address(departureStreet, departureHouse), childSeat);

            TaxiCalled?.Invoke(this, new OrderArgs(order));
        }

        public void RegisterAggregator(TaxiAggregator aggregator)
        {
            aggregator.TaxiSent += AnswerHandler;
        }

        public void UnregisterAggregator(TaxiAggregator aggregator)
        {
            aggregator.TaxiSent -= AnswerHandler;
        }

        private void AnswerHandler(object sender, OrderSummaryArgs e)
        {
            if (e.taxiSent)
            {
                Console.WriteLine($"Водитель {e.DriverName} на {e.CarBrand} - {e.CarNumber} принял заказ:\n" +
                    $"\t{e.Order.Destination.Street} {e.Order.Destination.House} - {e.Order.Departure.Street} {e.Order.Departure.House}");
            }
            else
                Console.WriteLine("Ответ я дам, такси я не дам");
        }
    }
}
