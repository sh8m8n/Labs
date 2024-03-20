using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_3
{
    public class OrderArgs : EventArgs
    {
        public Order Order { get; set; }
        public OrderArgs(Order order)
        {
            Order = order;
        }
    }
}
