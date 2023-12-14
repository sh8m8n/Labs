namespace Lab9
{
    abstract internal class Discipline
    {
        public string Title { get; set; }

        public Discipline(string title)
        {
            Title = title;
        }
    }
}
