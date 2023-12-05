using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    internal interface IHaveFinalControl
    {
        int PassingScore { get; set; }

        bool Check(int score);
    }
}
