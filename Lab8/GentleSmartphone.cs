using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    internal class GentleSmartphone
    {
        public int Number { get; set; }
        private TactileSensor sensor = new TactileSensor();
    }
}
