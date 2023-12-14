using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    internal class School
    {
        private Student[] Students;

        public School(int countOfStudents)
        {
            Students = new Student[countOfStudents];
            Random random = new Random();
            for (int i = 0; i < countOfStudents; i++)
            {
                Students[i] = new Student(random);
            }
        }

        public (Student, Student) FindMinMaxEmployee()
        {
        }
    }
}
