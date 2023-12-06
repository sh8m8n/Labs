namespace Lab9
{
    internal interface IHavePractice
    {
        int PracticeCount { get; set; }

        bool Check(int count);
    }
}
