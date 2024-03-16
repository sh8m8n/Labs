using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Department dep = new ElectricianDepartment();
            //Генерация списка кандидатов
            Random random = new Random();

            List<Person> people = new List<Person>();

            for (int i = 0; i < 20; i++)
            {
                string name = File.ReadLines("C:\\C# Projects\\Labs\\Lab6\\names.txt").Skip(random.Next(0, 1299)).Take(1).First();
                int age = random.Next(14, 50);
                Speciality speciality = (Speciality)random.Next(0, 5);
                double score = random.NextDouble() * 1.5d + 3.5;
                people.Add(new Person { Name = name, Age = age, PersonSpeciality = speciality, Score = score });
            }

            //Инициализация производства
            ElectricianDepartment electricianDepartment = new ElectricianDepartment()
            { Title = "Электрическое подразделение", NumberOfVacancies = 100 };

            MechanicDepartment mechanicDepartment = new MechanicDepartment()
            { Title = "Механическое подразделение", NumberOfVacancies = 100 };

            InformDepartment informDepartment = new InformDepartment()
            { Title = "Информационное подразделение", NumberOfVacancies = 100 };

            Factory factory = new Factory()
            { Candidates = people, Departments = new List<Department>() { electricianDepartment, mechanicDepartment, informDepartment } };

            //Отбор сотрудников
            foreach (Department department in factory.Departments)
            {
                department.StaffSelection(factory.Candidates);
            }

            //Вывод информации в консоль
            Console.WriteLine("Принятые сотрудники:");
            foreach (Department department in factory.Departments)
            {
                if (department is ElectricianDepartment electrician)
                {
                    Console.WriteLine(electrician.PrintEmployees());
                }
                else if (department is MechanicDepartment mechanic)
                {
                    Console.WriteLine(mechanic.PrintEmployees());
                }
                else if (department is InformDepartment inform)
                {
                    Console.WriteLine(inform.PrintEmployees());
                }
                else
                {
                    Console.WriteLine(department.PrintEmployees());
                }
            }

            Console.WriteLine("Отклоненные кандидаты:");
            foreach (Person person in factory.Candidates)
            {
                Console.WriteLine($"\t{person.ToString()}");
            }

            Console.WriteLine("Нажмите любую клавишу чтобы выйти...");
            Console.ReadKey();
        }
    }
}
