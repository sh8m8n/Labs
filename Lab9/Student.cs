using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    internal class Student
    {
        public string Name { get; set; }

        private Dictionary<IHavePractice, int> Practices { get; set; }
        private Dictionary<IHaveFinalControl, int> FinalControls { get; set; }

        public Student(string name)
        {
            Name = name;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="discipline"></param>
        /// <param name="result"></param>
        public void AddResult(IHaveFinalControl discipline, int result)
        {

        }

        /// <summary>
        /// Формирует отчет о автомате определенной дисциплины
        /// </summary>
        /// <param name="discipline"></param>
        /// <returns>Отчет</returns>
        public string Check(Discipline discipline)
        {
            bool pass = true;
            string report = $"{discipline.Title}: ";
            if(discipline is IHaveAngryTeacher)
            {
                report += "Автомат невозможен, учитель is злой";
                return report;
            }

            if(discipline is IHavePractice practiceDiscipline && Practices.ContainsKey(practiceDiscipline))
            {
                if(practiceDiscipline.Check(Practices[practiceDiscipline]))
                {
                    report += "Практик достаточно, ";
                }
                else
                {
                    report += "Практик недостаточно, ";
                    pass = false;
                }
            }

            if (discipline is IHaveFinalControl controlDiscipline && FinalControls.ContainsKey(controlDiscipline))
            {
                if (controlDiscipline.Check(FinalControls[controlDiscipline]))
                {
                    report += "Баллов достаточно, ";
                }
                else
                {
                    report += "Баллов недостаточно, ";
                    pass = false;
                }
            }

            if (pass)
            {
                report += "Автомат будет";
            }
            else
            {
                report += "Автомата не будет";
            }

            return report;
        }
    }
}
