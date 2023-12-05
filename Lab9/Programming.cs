using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    internal class Programming : Discipline, IHavePractice
    {
        public int PracticeCount { get; set; }

        /// <summary>
        /// Проверка на достаточное количество практик для автомата
        /// </summary>
        /// <param name="count">Количество практик</param>
        /// <returns>Достаточность практик</returns>
        public bool Check(int count)
        {
            return count >= PracticeCount;
        }

        public Programming(int practiceCount)
        {
            PracticeCount = practiceCount;
        }
    }
}
