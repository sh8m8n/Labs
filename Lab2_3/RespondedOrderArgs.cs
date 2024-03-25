namespace Lab2_3
{
    public class RespondedOrderArgs : OrderArgs
    {
        public double DistanceToDestination { get; set; }
        public double Path { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="order"></param>
        /// <param name="distanceToDestination">Дистанция от текущего места водителя до старта маршрута</param>
        /// <param name="path">Путь который водитель проедет с пассажиром</param>
        public RespondedOrderArgs(Order order, double distanceToDestination, double path) : base(order)
        {
            DistanceToDestination = distanceToDestination;
            Path = path;
        }
    }
}
