namespace Lab8
{
    internal class Customer
    {
        public string Name { get; private set; }
        public double GentleRate { get; private set; }

        public GentleSmartphone Smartphone { get; set; }
        public Transformator TransformModule { get; set; }

        public Customer(string name, double gentleRate)
        {
            Name = name;
            GentleRate = gentleRate;
        }

        public override string ToString()
        {
            return $"{Name}, нежность: {GentleRate}, смартфон: {Smartphone?.ToString()}, " +
                $"Трансформатор: {TransformModule?.ToString()}";
        }
    }
}
