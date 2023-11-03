using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    internal class GentleSmartphone
    {
        private static int countOfSmartphones = 0;
        public int SerialNumber { get; }
        private TactileSensor sensor;

        public GentleSmartphone()
        {
            SerialNumber = ++countOfSmartphones;
            sensor = new TactileSensor();
        }
        
        /// <summary>
        /// Возвращает чувствительность датчика нежности
        /// </summary>
        /// <returns></returns>
        public double GetSensorSensetivity()
        {
            return sensor.Sensetivity;
        }
    }
}
