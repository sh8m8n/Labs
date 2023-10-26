using System.Collections.Generic;
using System.Linq;

namespace Lab6
{
    internal class InformDepartment : Department
    {
        /// <summary>
        /// Добавляет к сотрудникам математиков и программистов старше 22 лет с средним баллом выше 4.8 пока не закончатся вакансии 
        /// (Преимущество по среднему баллу)
        /// </summary>
        /// <param name="Candidates"></param>
        public override void StaffSelection(List<Person> Candidates)
        {
            var sortCandidates = Candidates.OrderByDescending(x => x.Score).ToList();

            foreach (Person person in sortCandidates)
            {
                if (NumberOfVacancies == 0)
                {
                    break;
                }

                if (person.Score > 4.8d &&
                    (person.PersonSpeciality == Speciality.Mathematician || person.PersonSpeciality == Speciality.Programmer) &&
                    person.Age >= 22)
                {
                    Employees.Add(person);
                    NumberOfVacancies -= 1;
                    Candidates.Remove(person);
                }
            }
        }

        /// <summary>
        /// Возвращает строкой список сотрудников департамента (Имя, Специальность, Возраст)
        /// </summary>
        /// <returns></returns>
        new public string PrintEmployees()
        {
            string result = "==Список сотрудников департамента " + Title + "==\n";
            foreach (Person person in Employees)
            {
                result += "Имя: " + person.Name + " || Специальность: " + person.PersonSpeciality + " || Возраст: " + person.Age + "\n";
            }
            result += "-------------------\n";
            return result;
        }
    }
}
