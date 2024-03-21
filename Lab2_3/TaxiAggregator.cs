using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_3
{
    public class TaxiAggregator
    {
        private List<Customer> customers;
        private List<TaxiDriver> taxiDrivers;
            
        private Dictionary<TaxiDriver, OrderSummaryArgs> respondedDrivers;

        public event EventHandler<OrderArgs> OrderRecieved;

        public void OrderHandler(object sender, OrderArgs args)
        {
            OrderRecieved?.Invoke(sender, args);


        }

        public void RespondedDriverHandler(object sender, OrderSummaryArgs args)
        {
            respondedDrivers.Add(sender as TaxiDriver, args);
        }

        public void AddCustomer(Customer customer)
        {
            customer.TaxiCalled += OrderHandler;
            customers.Add(customer);
        }
        
        public void AddDriver(TaxiDriver driver)
        {
            driver.RegisterAggregator(this);
            driver.OrderResponded += RespondedDriverHandler;

            taxiDrivers.Add(driver);
        }

        public void RemoveDriver(TaxiDriver driver)
        {
            driver.UnregisterAggregator(this);
            driver.OrderResponded -= RespondedDriverHandler;

            taxiDrivers.Remove(driver);
        }

        private void FindBestDriver()
        {
            TaxiDriver bestDriver = respondedDrivers.FirstOrDefault().Key;

            foreach(var driverRespond in respondedDrivers)
            {

            }
        }
    }
}
