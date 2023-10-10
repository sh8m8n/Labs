namespace Lab5__.NET_Core_
{
    internal class Student
    {
        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                if (name == null)
                {
                    name = value;
                }
            }
        }

        private string speciality;

        public string Speciality
        {
            get { return speciality; }
            set
            {
                if (speciality == null)
                {
                    speciality = value;
                }
            }
        }

        public int ScholarshipAmount { get; init; }

        public int Check { get; set; }
        public bool Warning
        {
            get
            {
                if (Check > 100)
                    return false;
                else return true;
            }
        }

        public void GetScholarship()
        {
            if (DateTime.Now.Day == 20)
            {
                Check += ScholarshipAmount;
            }
        }

        public string SpendScholarship(int money, string itemOfExpenditure)
        {
            if ( !Warning && Check - money > 0)
            {
                Check -= money;
                return $"Вы потратили {money} на {itemOfExpenditure}";
            }
            return "На счете недостаточно денег";
        }
    }
}
