namespace Lab9
{
    internal interface IHaveFinalControl
    {
        int PassingScore { get; set; }

        bool Check(int score);
    }
}
