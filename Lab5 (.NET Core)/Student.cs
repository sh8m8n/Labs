namespace Lab5__.NET_Core_
{
    internal class Student
    {
        public string Name { get; init; }
        public string Speciality { get; init; }

        private int scholarshipAmount = 1000; // :(

        public int ScholarshipAmount
        {
            get { return scholarshipAmount; }
            set
            {
                if (value >= 0)
                {
                    scholarshipAmount = value;
                } 
            }
        }

        private int check;

        public int Check
        {
            get { return check; }
            set { check = value; }
        }
        public bool Warning
        {
            get
            {
                if (check > 100)
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
