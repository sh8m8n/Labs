using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Student student = new Student(rnd);
            Student student2 = new Student(rnd);
            Console.WriteLine(student.Number);
            Console.WriteLine(student2.Number);
        }
    }
}
