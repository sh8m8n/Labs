namespace Lab9
{
    internal class Math : Discipline, IHaveFinalControl
    {
        public int PassingScore { get; set; }
        
        /// <summary>
        /// Проверка на достаточное количство тестовых баллов для автомата
        /// </summary>
        /// <param name="score">Баллы</param>
        /// <returns>Достаточность баллов</returns>
        public bool Check(int score)
        {
            return score >= PassingScore;
        }

        public Math(string name, int passingScore) : base(name)
        {
            PassingScore = passingScore;
        }
    }
}
