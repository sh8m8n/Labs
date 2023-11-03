using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    internal class Factory
    {
        public List<Customer> Customers { get; set; }
        private List<GentleSmartphone> Smartphones;

        public Factory()
        {
            Customers = new List<Customer>();
            Smartphones = new List<GentleSmartphone>();
        }

        /// <summary>
        /// Возвращает количество смартфонов на складе
        /// </summary>
        /// <returns></returns>
        public int GetCountOfSmartphones()
        {
            return Smartphones.Count;
        }

        /// <summary>
        /// Производит смартфоны и добавляет на склад
        /// </summary>
        /// <param name="count">необходимое количество смартфонов</param>
        public void ProduceSmartphones(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Smartphones.Add(new GentleSmartphone());
            }
        }

        public void SaleSmartphones()
        {
            foreach (var customer in Customers)
            {
                foreach(var smartphone in Smartphones)
                {
                    if ((smartphone.GetSensorSensetivity() / customer.GentleRate <= 1.5) && 
                        (customer.GentleRate / smartphone.GetSensorSensetivity() <= 2))
                    {
                        customer.Smartphone = smartphone;
                        Smartphones.Remove(smartphone);
                    }
                }
            }
        }
    }
}
