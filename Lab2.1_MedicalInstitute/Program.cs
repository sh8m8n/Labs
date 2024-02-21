using StudentRegister;
using System;

namespace MedicalInstitute
{
    public class MedicalStudent
    {
        public string Name { get; set; }
        public string Specialization { get; set; }

        public MedicalStudent(string name, string specialization)
        {
            Name = name;
            Specialization = specialization;
        }

        static void Main()
        {
            //Инициализация студентов и отделения
            MedicalStudent s1 = new MedicalStudent("Шэдоухарт", "Домен жизни");
            MedicalStudent s2 = new MedicalStudent("Mercy", "Support");
            MedicalStudent s3 = new MedicalStudent("Медик", "Лечебная пушка");

            Department<MedicalStudent> department = new Department<MedicalStudent>("Академия Красного Креста", "Н. И. Пирогов");

            //Зачисление студентов
            department.EnrollStudent(s1);
            department.EnrollStudent(s2);
            department.EnrollStudent(s3);

            Console.WriteLine(department.ToString());

            //Отчисление студентов
            department.ExpelStudent(s1);

            Console.WriteLine("Отчисление 1 студента\n");
            Console.WriteLine(department.ToString());

            Console.ReadKey();
        }

        public override string ToString()
        {
            return Name + " " + Specialization;
        }
    }
}
