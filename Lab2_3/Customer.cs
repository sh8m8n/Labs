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

        public void TakeATaxi()
        {
            IWantToTakeTaxi(this, new ArgsOfTaxiOrder(TempOrder));
        }
    }
}
