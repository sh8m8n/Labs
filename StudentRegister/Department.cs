using System;
using System.Text;

namespace StudentRegister
{
    public class Department<T>
    {
        public string Title { get; set; }
        public string Supervisor { get; set; }

        private T[] students;
        private int counter;

        public Department(string title, string supervisor)
        {
            Title = title;
            Supervisor = supervisor;
            students = new T[8];
        }

        /// <summary>
        /// Добавляет студента в список
        /// </summary>
        /// <param name="student"></param>
        public void EnrollStudent(T student)
        {
            if (counter == students.Length)
            {
                T[] temp = new T[students.Length * 2];

                for (int i = 0; i < counter; i++)
                {
                    temp[i] = students[i];
                }

                students = temp;
            }

            students[counter] = student;
            counter++;
        }

        /// <summary>
        /// Удаляет студента из списка
        /// </summary>
        /// <param name="student"></param>
        public void ExpelStudent(T student)
        {
            int index = Array.IndexOf(students, student);

            if (index != -1)
            {
                if (counter - 1 == students.Length / 2)
                {
                    T[] temp = new T[students.Length / 2];

                    for (int i = 0; i < counter - 1; i++)
                    {
                        if (i < index)
                            temp[i] = students[i];
                        else
                            temp[i] = students[i + 1];
                    }
                    students = temp;
                }
                else
                {
                    for (int i = 0; i < counter - 1; i++)
                    {
                        if (i >= index)
                            students[i] = students[i + 1];
                    }
                    students[counter - 1] = default;
                }
                counter--;
            }
        }

        public T[] GetStudentsList()
        {
            T[] temp = new T[counter];

            for (int i = 0; i < counter; i++)
            {
                temp[i] = students[i];
            }
            return temp;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder($"Название: {Title}, Ответственный: {Supervisor}\n --- \n");

            for (int i = 0; i < counter; i++)
            {
                sb.Append($"{students[i]}\n");
            }
            return sb.ToString();
        }
    }
}
