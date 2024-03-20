using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_3
{
    public class Address : Coordinates
    {
        public string Street { get; set; }
        public int House { get; set; }

        public Address(double XCoordinate, double YCoordinate, string street, int house) :
            base(XCoordinate, YCoordinate)
        {
            Street = street;
            House = house;
        }
    }
}
