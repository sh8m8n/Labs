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
            var Candidates1 = Candidates.OrderByDescending(person => person.Score).ToList();

            foreach (Person person in Candidates1)
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
    }
}
