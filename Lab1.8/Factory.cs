using System;
using System.Collections.Generic;

namespace Lab8
{
    internal class Factory
    {
        public List<Customer> Customers { get; set; }
        private List<GentleSmartphone> smartphones;

        public Factory()
        {
            Customers = new List<Customer>();
            smartphones = new List<GentleSmartphone>();
        }

        /// <summary>
        /// Возвращает количество смартфонов на складе
        /// </summary>
        /// <returns></returns>
        public int GetCountOfSmartphones()
        {
            return smartphones.Count;
        }

        /// <summary>
        /// Производит смартфоны и добавляет на склад
        /// </summary>
        /// <param name="count">необходимое количество смартфонов</param>
        public void ProduceSmartphones(int count)
        {
            Random r = new Random();
            for (int i = 0; i < count; i++)
            {
                var smartphone = new GentleSmartphone(r);
                smartphones.Add(smartphone);
            }
        }

        /// <summary>
        /// Продает смартфоны со склада покупателям, оставшиеся смартфоны ликвидируются
        /// </summary>
        public void SaleSmartphones()
        {
            foreach (var customer in Customers)
            {
                foreach (var smartphone in smartphones)
                {
                    if ((smartphone.GetSensorSensetivity() / customer.GentleRate <= 1.5) &&
                        (customer.GentleRate / smartphone.GetSensorSensetivity() <= 2))
                    {
                        customer.Smartphone = smartphone;
                        smartphones.Remove(smartphone);
                        break;
                    }
                    else if (((smartphone.GetSensorSensetivity() / 2) / customer.GentleRate <= 1.5) &&
                        (customer.GentleRate / (smartphone.GetSensorSensetivity() / 2) <= 2))
                    {
                        customer.Smartphone = smartphone;
                        customer.TransformModule = new Transformator(TransformatorType.less);
                        smartphones.Remove(smartphone);
                        break;
                    }
                    else if (((smartphone.GetSensorSensetivity() * 2) / customer.GentleRate <= 1.5) &&
                        (customer.GentleRate / (smartphone.GetSensorSensetivity() * 2) <= 2))
                    {
                        customer.Smartphone = smartphone;
                        customer.TransformModule = new Transformator(TransformatorType.more);
                        smartphones.Remove(smartphone);
                        break;
                    }
                }
            }
            smartphones.Clear(); //Ликвидация
        }
    }
}
