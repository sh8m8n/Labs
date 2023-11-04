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

        public override string ToString()
        {
            return $"номер: {SerialNumber}, сенсор: {sensor.Sensetivity}";
        }
    }
}
