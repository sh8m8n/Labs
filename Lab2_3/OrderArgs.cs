using System;

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
