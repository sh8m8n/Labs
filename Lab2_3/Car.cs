namespace Lab2_3
{
    public class Car
    {
        public string Number { get; set; }
        public string Brand { get; set; }
        public bool ChildSeat { get; set; }

        public Car(string number, string brand, bool childSeat)
        {
            Number = number;
            Brand = brand;
            ChildSeat = childSeat;
        }
    }
}
