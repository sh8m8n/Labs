using System;
namespace Lab8
{
    internal class TactileSensor
    {
        public double Sensetivity { get; }

        public TactileSensor()
        {
            Random random = new Random();
            Sensetivity = new Random().NextDouble() * 10 + 10; // (10,20)
        }
    }
}
