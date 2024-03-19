using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_3
{
    public class TaxiDriver : Human
    {
        public (double, double) CurrentLocation { get; set; }
        public double Ball {  get; set; }
        public bool isFree { get; set; }
        public Car car { get; set; }
        public event OrderHandler RespondedToOrder;

    }
}
