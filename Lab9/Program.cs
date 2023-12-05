﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    internal class Program
    {
        static public List<Discipline> disciplines;
        static public List<Student> students;

        static void Main(string[] args)
        {
            disciplines = new List<Discipline>()
            {
                new Math(60),
                new History(50, 5),
                new Programming(10)
            };
        }
    }
}
