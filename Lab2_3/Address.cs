namespace Lab2_3
{
    public class Address
    {
        public string Street { get; set; }
        public int House { get; set; }

        public Address(string street, int house)
        {
            Street = street;
            House = house;
        }

        public override string ToString()
        {
            return $"{Street}-{House}";
        }
    }
}
