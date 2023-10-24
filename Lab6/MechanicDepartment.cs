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
            var Candidates1 = Candidates.OrderByDescending(x => x.Score).ToList();

            foreach (Person person in Candidates1)
            {
                if (NumberOfVacancies == 0)
                {
                    break;
                }

                if (person.Score > 4d && person.PersonSpeciality == Speciality.Mechanic && person.Age <= 35)
                {
                    Employees.Add(person);
                    NumberOfVacancies -= 1;
                    Candidates.Remove(person);
                }
            }
        }
    }
}
