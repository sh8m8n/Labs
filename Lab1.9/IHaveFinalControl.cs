namespace Lab9
{
    internal interface IHaveFinalControl
    {
        int PassingScore { get; set; }

        /// <summary>
        /// Проверка на достаточность тестовых баллов для зачета
        /// </summary>
        /// <param name="score">количество тестовых баллов</param>
        /// <returns></returns>
        bool Check(int score);
    }
}
