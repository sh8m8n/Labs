namespace Lab9
{
    internal class History : Discipline, IHaveFinalControl, IHavePractice
    {
        public int PassingScore { get; set; }
        public int PracticeCount { get; set; }

        /// <summary>
        /// Проверка на достаточное количество тестовых баллов для автомата
        /// </summary>
        /// <param name="score">Баллы</param>
        /// <returns>Достаточность баллов</returns>
        bool IHaveFinalControl.Check(int score)
        {
            return score >= PassingScore;
        }

        /// <summary>
        /// Проверка на достаточное количество практик для автомата
        /// </summary>
        /// <param name="count">Количество практик</param>
        /// <returns>Достаточность практик</returns>
        bool IHavePractice.Check(int count)
        {
            { return count >= PracticeCount; }
        }

        public History(string name, int passingScore, int practiceCount) : base(name)
        {
            PassingScore = passingScore;
            PracticeCount = practiceCount;
        }
    }
}
