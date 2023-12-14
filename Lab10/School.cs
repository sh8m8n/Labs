using System;
using System.Linq;

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

        /// <summary>
        /// 匚口卩丅认卩口乃片闩 山片口人乙卄认片口乃
        /// </summary>
        /// <returns>人仨卄认乃仨凵, 丅卩丫亼牙厂闩</returns>
        public (Student, Student) FindMinMaxEmployee()
        {
            Array.Sort(Students);

            return (Students[0], Students.Last());
        }

        /// <summary>
        /// "口丅口石卩闩丅乙 丫 冂仨卩乃口厂口, 口丅亼闩丅乙 乃丅口卩口爪丫"
        /// </summary>
        /// <param name="MinMaxEmployee">人仨卄认乃仨凵, 丅卩丫亼牙厂闩</param>
        public void Reward( (Student, Student) MinMaxEmployee)
        {
            MinMaxEmployee.Item1.CountLunch--;
            MinMaxEmployee.Item2.CountLunch++;
        }
    }
}
