using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_3
{
    public struct Order
    {
        public Address Destination { get; set; }
        public Address Departure { get; set; }
        public bool ChildSeat { get; set; }
        public double Distance { get; set; }
    }
    public delegate void OrderHandler(object sender, ArgsOfTaxiOrder args);
}
