using System;
using System.Text;

namespace StudentRegister
{
    public class Department<T>
    {
        public string Title { get; set; }
        public string Supervisor { get; set; }

        private T[] Students;
        private int counter;

        public Department(string title, string supervisor)
        {
            Title = title;
            Supervisor = supervisor;
            Students = new T[8];
        }

        /// <summary>
        /// Добавляет студента в список
        /// </summary>
        /// <param name="student"></param>
        public void EnrollStudent(T student)
        {
            if (counter == Students.Length)
            {
                T[] temp = new T[Students.Length * 2];

                for (int i = 0; i < counter; i++)
                {
                    temp[i] = Students[i];
                }

                Students = temp;
            }

            Students[counter] = student;
            counter++;
        }

        /// <summary>
        /// Удаляет студента из списка
        /// </summary>
        /// <param name="student"></param>
        public void ExpelStudent(T student)
        {
            int index = Array.IndexOf(Students, student);

            if (index != -1)
            {
                if(counter - 1 == Students.Length / 2)
                {
                    T[] temp = new T[Students.Length / 2];

                    for (int i = 0; i < counter - 1; i++)
                    {
                        if (i < index)
                            temp[i] = Students[i];
                        else
                            temp[i] = Students[i + 1];
                    }
                    Students = temp;
                }
                else
                {
                    for (int i = 0; i < counter - 1; i++)
                    {
                        if (i >= index)
                            Students[i] = Students[i + 1];
                    }
                    Students[counter - 1] = default;
                }
                counter--;
            }
        }

        public T[] GetStudentsList()
        {
            return (T[])Students.Clone();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder($"Название: {Title}, Ответственный: {Supervisor}\n --- \n");

            for (int i = 0;i < counter;i++)
            {
                sb.Append($"{Students[i]}\n");
            }
            return sb.ToString();
        }
    }
}
