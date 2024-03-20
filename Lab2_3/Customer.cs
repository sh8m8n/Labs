using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_3
{
    public class Customer : Human
    {
        public Order TempOrder { get; set; }
        public event OrderHandler IWantToTakeTaxi;

        public void TakeATaxi(double destinationX, double destinationY,string destinationStreet, int destinationHome,
            double departureX, double departureY, departureStreet, 
            bool childSeat)
        {
            Order order = new Order(new Address(destinationX, destinationY,"shish", 25),
                new Address(departureX, departureY,"jaja", 18), childSeat);
            IWantToTakeTaxi(this, new ArgsOfTaxiOrder(TempOrder));
        }
    }
}
