using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class Student
    {
        public string Name { get; init; }
        public string Speciality { get; set; }
        public int ScholarshipAmount { get; set; }
        public int Check { get; set; }
        public bool Warning { get; }

        public void GetScholarship()
        {
            if (DateTime.Now.Day == 20 )
            {
                Check += ScholarshipAmount;
            }
        }

        public string SpendScholarship(int money, string itemOfExpenditure)
        {
            if (Warning == true && Check - money > 0)
            {
                Check -= money;
                return $"Вы потратили {money} на {itemOfExpenditure}";
            }
            return "На счете недостаточно денег";
        }
    }
}
