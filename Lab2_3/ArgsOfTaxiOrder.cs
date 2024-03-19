using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_3
{
    public class ArgsOfTaxiOrder
    {
        public Order Order { get; set; }
        public ArgsOfTaxiOrder(Order order)
        {
            Order = order;
        }
    }
}
