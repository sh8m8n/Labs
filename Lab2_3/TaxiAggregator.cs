using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab2_3
{
    public class TaxiAggregator
    {
        public readonly Dictionary<string, Coordinates> Map = new Dictionary<string, Coordinates>()
        {
            {new Address("Елены Стасовой", 1).ToString(), new Coordinates(56.02319, 92.752024)},
            {new Address("Николаевка", 2).ToString(), new Coordinates(56.008639, 92.799896)},
            {new Address("Демьяна Белого", 3).ToString(), new Coordinates(56.025049, 92.826508)},
            {new Address("ИКИТ", 666).ToString(), new Coordinates(55.994637, 92.798755)},
            {new Address("ГОС", 0).ToString(), new Coordinates(56.004256, 92.772263)}
        };

        private List<Customer> customers;
        private List<TaxiDriver> taxiDrivers;
            
        private Dictionary<TaxiDriver, RespondedOrderArgs> DriverResponds;

        public event EventHandler<OrderArgs> OrderRecieved;
        public event EventHandler<OrderSummaryArgs> TaxiSent;

        public TaxiAggregator(int AccessDistance)
        {
            TaxiDriver.AccessDistance = AccessDistance;

            customers = new List<Customer>();
            taxiDrivers = new List<TaxiDriver>();
            DriverResponds = new Dictionary<TaxiDriver, RespondedOrderArgs>();
        }

        private void OrderHandler(object sender, OrderArgs e)
        {
            OrderRecieved?.Invoke(sender, e);

            var respond = FindBestRespond();

            if(respond.Key == null)
            {
                TaxiSent?.Invoke(this, new OrderSummaryArgs());
                return;
            }

            respond.Key.AddRatingPoints(respond.Value.Path);

            TaxiSent?.Invoke(this, new OrderSummaryArgs(respond.Value, respond.Key));
        }

        private void RespondedDriverHandler(object sender, RespondedOrderArgs e)
        {
            DriverResponds.Add(sender as TaxiDriver, e);
        }

        public void AddCustomer(Customer customer)
        {
            TaxiSent += customer.AnswerHandler;
            customer.TaxiCalled += OrderHandler;
            customers.Add(customer);
        }
        
        public void RemoveCustomer(Customer customer)
        {
            TaxiSent -= customer.AnswerHandler;
            customer.TaxiCalled -= OrderHandler;
            customers.Remove(customer);
        }

        public void AddDriver(TaxiDriver driver)
        {
            driver.Map = Map;
            OrderRecieved += driver.OrderHandler;
            driver.OrderResponded += RespondedDriverHandler;

            taxiDrivers.Add(driver);
        }

        public void RemoveDriver(TaxiDriver driver)
        {
            driver.Map = null;
            OrderRecieved -= driver.OrderHandler;
            driver.OrderResponded -= RespondedDriverHandler;

            taxiDrivers.Remove(driver);
        }

        /// <summary>
        /// Выбирает наиболее подходящий ответ водителя из DriverResponds
        /// </summary>
        /// <returns>Водитель, описание поездки</returns>
        private KeyValuePair<TaxiDriver,RespondedOrderArgs> FindBestRespond()
        {
            var bestRespond = DriverResponds.FirstOrDefault();

            foreach(var driverRespond in DriverResponds)
            {
                if (driverRespond.Key.Rating > bestRespond.Key.Rating)
                    bestRespond = driverRespond;
                else if (driverRespond.Key.Rating == bestRespond.Key.Rating)
                {
                    if (driverRespond.Value.DistanceToDestination < bestRespond.Value.DistanceToDestination)
                        bestRespond = driverRespond;
                }
            }

            DriverResponds.Clear();
            return bestRespond;
        }
    }
}
