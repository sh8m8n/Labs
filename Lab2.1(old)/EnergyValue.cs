using System;

namespace Lab2._1_old_
{
    public class EnergyValue
    {
        public int Proteins { get; }
        public int Fats { get; }
        public int Carbohydrates { get; }

        public EnergyValue()
        {
            Proteins = 0;
            Fats = 0;
            Carbohydrates = 0;
        }

        public EnergyValue(int proteins, int fats, int carbohydrates)
        {
            Proteins = proteins;
            Fats = fats;
            Carbohydrates = carbohydrates;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>Сумма всех характеристик энергетической ценнности (белки жиры углеводы)</returns>
        public int Sum()
        {
            return Proteins + Fats + Carbohydrates;
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns>значение наибольшей характеристики</returns>
        /// 
        public int Max()
        {
            int max = Fats;

            if (Proteins > Fats)
                max = Proteins;
            if (Carbohydrates > max)
                max = Carbohydrates;

            return max;
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns>Значение наименьшей характеристики</returns>
        public int Min()
        {
            int min = Fats;
            if (Proteins < Fats)
                min = Proteins;
            if (Carbohydrates < min)
                min = Carbohydrates;

            return min;
        }

        /// <summary>
        /// Находит сумму всех недостающих или избыточных составляющих энергетической ценности, необходимых для желаемого результата
        /// </summary>
        /// <param name="realValue">Имеющиеся характеристики</param>
        /// <param name="requiredResult">Желаемые характеристики</param>
        /// <returns>Недостаток/Переизбыток энергетической ценности</returns>
        public static int GetOffset(EnergyValue realValue, EnergyValue requiredResult)
        {
            int offset = 0;
            offset += Math.Abs(requiredResult.Proteins - realValue.Proteins);
            offset += Math.Abs(requiredResult.Fats - realValue.Fats);
            offset += Math.Abs(requiredResult.Carbohydrates - realValue.Carbohydrates);

            return offset;
        }

        public override string ToString()
        {
            return $"Белки:{Proteins} Жиры: {Fats} Углеводы: {Carbohydrates}";
        }

        public override bool Equals(object obj)
        {
            if (obj is EnergyValue energyValue)
            {
                if (Proteins == energyValue.Proteins && Fats == energyValue.Fats
                    && Carbohydrates == energyValue.Carbohydrates)
                    return true;
            }
            return false;
        }

        public static EnergyValue operator +(EnergyValue val1, EnergyValue val2)
        {
            return new EnergyValue(val1.Proteins + val2.Proteins, val1.Fats + val2.Fats, val1.Carbohydrates + val2.Carbohydrates);
        }

        public static EnergyValue operator -(EnergyValue val2, EnergyValue val1)
        {
            return new EnergyValue(val2.Proteins - val1.Proteins, val2.Fats - val1.Fats, val2.Carbohydrates - val1.Carbohydrates);
        }
    }
}
