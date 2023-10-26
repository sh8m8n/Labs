using System.Collections.Generic;
using System.Linq;

namespace Lab6
{
    internal class MechanicDepartment : Department
    {
        /// <summary>
        /// Добавляет к сотрудникам механиков моложе 35 лет со средним баллом выше 4 пока не закончатся вакансии (Преимущество по среднему баллу)
        /// </summary>
        /// <param name="Candidates"></param>
        public override void StaffSelection(List<Person> Candidates)
        {
            Candidates = Candidates.OrderByDescending(x => x.Score).ToList();

            foreach (Person person in Candidates)
            {
                if (NumberOfVacancies == 0)
                {
                    break;
                }

                if (person.Score > 4d && person.PersonSpeciality == Speciality.Mechanic && person.Age <= 35)
                {
                    Employees.Add(person);
                    NumberOfVacancies -= 1;
                }
            }
        }

        /// <summary>
        /// Возвращает строкой список сотрудников департамента (Имя, Возраст)
        /// </summary>
        /// <returns></returns>
        new public string PrintEmployees()
        {
            string result = "==Список сотрудников департамента " + Title + "==\n";
            foreach (Person person in Employees)
            {
                result += "Имя: " + person.Name + " Возраст: " + person.Age + "\n";
            }
            result += "-------------------\n";
            return result;
        }
    }
}
