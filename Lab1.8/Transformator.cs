namespace Lab8
{
    internal class Transformator
    {
        private static int countOfTransformators = 0;
        public int SerialNumber { get; set; }
        public TransformatorType Type { get; set; }

        public Transformator(TransformatorType type)
        {
            SerialNumber = ++countOfTransformators;
            Type = type;
        }

        public override string ToString()
        {
            return $"Номер: {SerialNumber}, Тип: {Type}";
        }
    }
}
