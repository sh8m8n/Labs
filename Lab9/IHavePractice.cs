using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    internal interface IHavePractice
    {
        int PracticeCount { get; set; }

        bool Check(int count);
    }
}
