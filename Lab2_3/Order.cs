namespace Lab2_3
{
    public class Order
    {
        public Address Destination { get; set; }
        public Address Departure { get; set; }
        public bool ChildSeat { get; set; }

        public Order(Address destination, Address departure, bool childSeat)
        {
            Destination = destination;
            Departure = departure;
            ChildSeat = childSeat;
        }
    }
}
