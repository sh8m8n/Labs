﻿using System.Collections.Generic;
using System.Linq;

namespace Lab6
{
    internal class ElectricianDepartment : Department
    {
        /// <summary>
        /// Добавляет к сотрудникам электриков с средним баллом выше 4.5 пока не закончатся вакансии (Преимущество по среднему баллу)
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

                if (person.Score > 4.5d && person.PersonSpeciality == Speciality.Electrician)
                {
                    Employees.Add(person);
                    NumberOfVacancies -= 1;
                    Candidates.Remove(person);
                }
            }
        }
    }
}
