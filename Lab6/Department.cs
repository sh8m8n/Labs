using System.Collections.Generic;
using System.Linq;

namespace Lab6
{
    internal class Department
    {
        public string Title { get; set; }
        public List<Person> Employees { get; protected set; }
        private int numberOfVacancies;

        public int NumberOfVacancies
        {
            get { return numberOfVacancies; }
            set 
            {
                if (value > 0)
                {
                    numberOfVacancies = value;
                }
                else
                {
                    numberOfVacancies = 0;
                }
            }
        }
        public Department()
        {
            Employees = new List<Person>();
        }

        /// <summary>
        /// Добавляет к сотрудникам кандидатов с средним баллом выше 3 пока не закончатся вакансии (Преимущество по среднему баллу)
        /// </summary>
        /// <param name="Candidates"></param>
        public virtual void StaffSelection(List<Person> Candidates)
        {
            Candidates = Candidates.OrderByDescending(x => x.Score).ToList();

            foreach (Person person in Candidates) 
            {
                if (NumberOfVacancies == 0)
                {
                    break;
                }
                if (person.Score > 3d)
                {
                    Employees.Add(person);
                    NumberOfVacancies -= 1;
                    Candidates.Remove(person);
                }
            }
        }

        /// <summary>
        /// Возвращает строкой список сотрудников департамента (Имя)
        /// </summary>
        /// <returns></returns>
        public string PrintEmployees()
        {
            string result = "==Список сотрудников департамента " + Title + "==\n";
            foreach (Person person in Employees)
            {
                result += person.Name + "\n";
            }
            result += "-------------------";
            return result;
        }
    }
}
