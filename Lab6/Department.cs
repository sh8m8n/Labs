using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal class Department
    {
        public string Title { get; set; }
        public List<Person> Employees { get; set; }
        public int NumberOfVacancies { get; set; }
    }
}
