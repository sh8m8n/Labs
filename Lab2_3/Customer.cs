using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
