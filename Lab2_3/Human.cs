namespace Lab2_3
{
    abstract public class Human
    {
        public string Name { get; set; }

        public Human(string name)
        {
            Name = name;
        }

        public Human()
        {
            Name = "миньон";
        }
    }
}
