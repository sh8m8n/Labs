namespace Lab9
{
    internal interface IHavePractice
    {
        int PracticeCount { get; set; }

        /// <summary>
        /// Проверка на достаточность практик для зачета
        /// </summary>
        /// <param name="count">Количество практик</param>
        /// <returns></returns>
        bool Check(int count);
    }
}
