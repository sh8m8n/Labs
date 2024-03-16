using System.Collections.Generic;

namespace Lab9
{
    internal class Student
    {
        public string Name { get; set; }

        private Dictionary<IHavePractice, int> PracticesCount { get; set; } = new Dictionary<IHavePractice, int>();
        private Dictionary<IHaveFinalControl, int> FinalControlsResults { get; set; } = new Dictionary<IHaveFinalControl, int>();

        public Student(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Записывает/перезаписывает количество посещенных практик по дисциплине
        /// </summary>
        /// <param name="discipline"></param>
        /// <param name="count">Количество практик</param>
        public void AddResult(IHavePractice discipline, int count)
        {
            if (PracticesCount.ContainsKey(discipline))
            {
                PracticesCount[discipline] = count;
            }
            else
            {
                PracticesCount.Add(discipline, count);
            }
        }
        /// <summary>
        /// Записывает/перезаписывает количество баллов по дисциплине
        /// </summary>
        /// <param name="discipline"></param>
        /// <param name="result">Количество баллов</param>
        public void AddResult(IHaveFinalControl discipline, int result)
        {
            if (FinalControlsResults.ContainsKey(discipline))
            {
                FinalControlsResults[discipline] = result;
            }
            else
            {
                FinalControlsResults.Add(discipline, result);
            }
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
            if (discipline is IHaveAngryTeacher)
            {
                report += "Автомат невозможен, учитель is злой";
                return report;
            }

            if (discipline is IHavePractice practiceDiscipline && PracticesCount.ContainsKey(practiceDiscipline))
            {
                if (practiceDiscipline.Check(PracticesCount[practiceDiscipline]))
                {
                    report += "Практик достаточно";
                }
                else
                {
                    report += "Практик недостаточно";
                    pass = false;
                }
                report += $"({PracticesCount[practiceDiscipline]} / {practiceDiscipline.PracticeCount}), ";
            }

            if (discipline is IHaveFinalControl controlDiscipline && FinalControlsResults.ContainsKey(controlDiscipline))
            {
                if (controlDiscipline.Check(FinalControlsResults[controlDiscipline]))
                {
                    report += "Баллов достаточно";
                }
                else
                {
                    report += "Баллов недостаточно";
                    pass = false;
                }
                report += $"({FinalControlsResults[controlDiscipline]} / {controlDiscipline.PassingScore}), ";
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
