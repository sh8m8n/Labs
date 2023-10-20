namespace Lab6
{
    enum Speciality
    {
        Electrician,
        Mechanic,
        Mathematician,
        Programmer,
        Lawyer
    }

    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Speciality PersonSpeciality { get; set; }
        public double Score { get; set; }
    }
}
