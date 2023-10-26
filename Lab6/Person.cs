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

        public Speciality PersonSpeciality { get; set; }

        private int age;

        public int Age
        {
            get { return age; }
            set
            {
                if (value > 0)
                {
                    age = value;
                }
                else
                {
                    age = 0;
                }
            }
        }

        private double score;

        public double Score
        {
            get { return score; }
            set 
            {
                if (value > 0)
                {
                    score = value;
                }
                else
                {
                    score = 0;
                }
            }
        }

        /// <summary>
        /// Возвращает строку содержащую имя, возраст, специальность и средний балл
        /// </summary>
        /// <returns></returns>
        public string GetInfo()
        {
            return $"Имя: {Name}, Возраст: {Age}, Специальность: {PersonSpeciality}, Средний балл: {Score}";
        }
    }
}
