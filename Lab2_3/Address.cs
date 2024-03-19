using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_3
{
    public struct Address
    {
        public (double, double) Coordinates { get; set; }
        public string Street { get; set; }
        public int House { get; set; }
    }
}
