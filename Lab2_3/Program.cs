using System;

namespace Lab2_3
{
    public class Program
    {
        static void Main(string[] args)
        {
            TaxiAggregator taxi = new TaxiAggregator(1);

            Customer customer = new Customer();
            taxi.AddCustomer(customer);

            Car car1 = new Car("RJ234K", "Рено логан черного цвета 20 века", true);
            TaxiDriver driver1 = new TaxiDriver(new Coordinates(56.02319, 92.752024), car1, "Константин1");
            taxi.AddDriver(driver1);
            Car car2 = new Car("RJ235K", "Рено логан черного цвета 20 века", true);
            TaxiDriver driver2 = new TaxiDriver(new Coordinates(56.008639, 92.799896), car2, "Константин2");
            taxi.AddDriver(driver2);
            Car car3 = new Car("RJ236K", "Рено логан черного цвета 20 века", true);
            TaxiDriver driver3 = new TaxiDriver(new Coordinates(56.025049, 92.826508), car3, "Константин3");
            taxi.AddDriver(driver3);

            customer.TakeATaxi("ИКИТ", 666, "ГОС", 0, false);

            Console.ReadKey();
        }
    }
}
