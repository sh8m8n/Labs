using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhysicalEducationInstitute
{
    public class PEStudent
    {
        public string FIO { get; set; }
        public string SportDiscipline { get; set; }

        static void Main()
        {

        }

        public override string ToString()
        {
            return FIO + " " + SportDiscipline;
        }
    }
}
