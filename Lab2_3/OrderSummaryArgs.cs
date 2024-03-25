namespace Lab2_3
{
    public class OrderSummaryArgs : RespondedOrderArgs
    {
        public bool taxiSent { get; set; }
        public string DriverName { get; set; }
        public string CarBrand { get; set; }
        public string CarNumber { get; set; }
        public OrderSummaryArgs(RespondedOrderArgs args, TaxiDriver driver) : base(args.Order, args.DistanceToDestination, args.Path)
        {
            taxiSent = true;
            DriverName = driver.Name;
            CarBrand = driver.Car.Brand;
            CarNumber = driver.Car.Number;
        }
        /// <summary>
        /// Используется для того чтобы указать что такси не приедет
        /// </summary>
        public OrderSummaryArgs() : base(null, -1, -1)
        {
            taxiSent = false;
        }
    }
}
