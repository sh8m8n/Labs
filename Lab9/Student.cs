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

        /// <summary>
        /// Формирует отчет о автомате определенной дисциплины
        /// </summary>
        /// <param name="discipline"></param>
        /// <returns>Отчет</returns>
        public string Check(Discipline discipline)
        {

        }
    }
}
