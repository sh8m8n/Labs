using System;
using System.Collections.Generic;

namespace Lab9
{
    internal class Program
    {
        static public string[] names = {"Торин", "Глоин", "Оин", "Балин", "Двалин", "Бофур", "Бифур", "Кили", "Фили",
        "Дори", "Нори", "Ори", "Бомбур" };
            
        static public List<Discipline> disciplines;
        static public List<Student> students;

        static void Main(string[] args)
        {
            //Инициализация дисциплин
            disciplines = new List<Discipline>()
            {
                new Math("Математика", 60),
                new History("История", 50, 5),
                new Programming("Программирование", 10),
                new Informatics("Информатика"),
                new English("Английский язык")
            };

            //Инициализация студентов
            students = new List<Student>();
            for (int i = 0; i < names.Length; i++)
            {
                students.Add(new Student(names[i]));
            }

            //Имитация сдачи всех работ и практик каждым студентом
            Random random = new Random();
            foreach (Student student in students)
            {
                foreach(Discipline discipline in disciplines)
                {
                    if(discipline is IHavePractice practiceDiscipline)
                    {
                        student.AddResult(practiceDiscipline, random.Next(0, 15));
                    }

                    if(discipline is IHaveFinalControl controlDiscipline)
                    {
                        student.AddResult(controlDiscipline, random.Next(20, 101));
                    }
                }
            }

            //Вывод результатов в консоль
            foreach(Student student in students)
            {
                Console.WriteLine($"\n\t{student.Name}:");
                foreach (Discipline discipline in disciplines)
                {
                    Console.WriteLine(student.Check(discipline));
                }
            }
        }
    }
}
