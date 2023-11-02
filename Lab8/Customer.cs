using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    internal class Customer
    {
        public GentleSmartphone Smartphone { get; set; }
        public string Name { get; set; }
        public int Tenderness { get; set; }

        public Customer(string name, int tenderness, GentleSmartphone smartphone)
        {
            Name = name;
            Tenderness = tenderness;
            Smartphone = smartphone;
        }
    }
}
