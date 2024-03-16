using System;
namespace Lab8
{
    internal class TactileSensor
    {
        public double Sensetivity { get; }

        public TactileSensor(Random r)
        {

            Sensetivity = r.NextDouble() * 10 + 10; // (10,20)
        }
    }
}
