using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    internal class Math : Discipline, IHaveFinalControl, IHaveAngryTeacher
    {
        public int PassingScore { get; set; };
        
        /// <summary>
        /// Проверка на достаточное количство тестовых баллов для автомата
        /// </summary>
        /// <param name="score">Баллы</param>
        /// <returns>Достаточность баллов</returns>
        public bool Check(int score)
        {
            return score >= PassingScore;
        }

        public Math(int passingScore)
        {
            PassingScore = passingScore;
        }
    }
}
