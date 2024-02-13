using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegister
{
    public class Department<T>
    {
        public string Title { get; set; }
        public string Supervisor { get; set; }

        private T[] Students { get; set; }

        public Department(string title, string supervisor)
        {
            Title = title;
            Supervisor = supervisor;
            Students = new T[0];
        }

        public void EnrollStudent(T student)
        {
            T[] temp = new T[Students.Length + 1];

            for (int i = 0; i < Students.Length; i++)
            {
                temp[i] = Students[i];
            }

            temp[Students.Length] = student;
            Students = temp;
        }

        public void ExpelStudent(T student)
        {
            int index = Array.IndexOf(Students, student);

            if (index != -1)
            {
                for (int i = index; i < Students.Length - 1; i++)
                {
                    Students[i] = Students[i + 1];
                }
            }
        }

        public T[] GetStudentsList()
        {
            return (T[])Students.Clone();
        }
    }
}
