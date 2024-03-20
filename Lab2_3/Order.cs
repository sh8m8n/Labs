using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_3
{
    public class Order
    {
        public Address Destination { get; set; }
        public Address Departure { get; set; }
        public bool ChildSeat { get; set; }
        public double Distance { get; set; }

        public Order(Address destination, Address departure, bool childSeat)
        {
            Destination = destination;
            Departure = departure;
            ChildSeat = childSeat;
            Distance = destination.GetDistance(departure);
        }
    }
    public delegate void OrderHandler(object sender, ArgsOfTaxiOrder args);
}
