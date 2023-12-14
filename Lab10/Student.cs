using System;

namespace Lab10
{
    internal struct Student
    {
        private static int CountOfStudents = 0;
        public int Number { get; set; }
        public int CountPhone { get; set; }
        public int CountLunch { get; set; }
        public Position Position { get; set; }

        public Student(Random random)
        {
            Number = ++CountOfStudents;
            CountPhone = random.Next(5, 10);
            CountLunch = 10;
            Position = (Position)random.Next(3);
        }
    }
}
