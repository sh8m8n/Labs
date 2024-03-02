using Lab2._1_old_.Items;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Lab2._1_old_
{
    public class DataBase
    {
        private List<object> objects;

        public DataBase()
        {
            AddData();
        }

        /// <summary>
        /// Затычка
        /// </summary>
        private void AddData()
        {
            objects = new List<object>
            {
                //new Pen("Pilot", 100),
                new Notebook("Honor magicbook 14", 50000),
                new ChocolateBar("RitterSport", 199, 10, 35, 50),
                new Crisps("Lays дай краба", 99, 7, 30, 53),
                new DumplingsBerries("пельмени с ягодами", 299, 1, 0, 70),
                new DumplingsMeat("пельмени", 499, 12, 12, 29),
                new Cheburek("huh?бурек", 256, 12, 20, 29),
                new BalykCheese("балыксыр", 319, 19, 23, 2),
                new Fruit("яблоко", 120, 1, 1, 10),
                new Fruit("банан", 180,  4, 1, 78),
                new OliveOil("сасло маливковое", 299, 0, 100, 0),
                new RawMeat("говядина", 234, 22 * 2, 7 * 2, 0 * 2),
                new RawMeat("курица", 230, 19, 12, 1),
                new RawMeat("свин", 232, 19, 7, 0),
                new RawMeat("красная икра", 500, 25, 18, 4)
            };
        }

        public string Compare(List<object> list)
        {
            //Проверка на количество обьектов
            if (objects.Count != list.Count)
                return "Количество обьектов в списках не равно";

            //Подготовительные действия для следующих проверок
            Type[] oldTypes = new Type[objects.Count];
            Type[] newTypes = new Type[objects.Count];

            for (int i = 0; i < objects.Count; i++)
            {
                oldTypes[i] = objects[i].GetType();
                newTypes[i] = list[i].GetType();
            }

            //Проверка на читаемость обьектов
            for (int i = 0; i < newTypes.Length; i++)
            {
                if (newTypes[i].GetCustomAttribute<UnreadableAttribute>() != null)
                    return $"Обнаружен нечитаемый тип: {newTypes[i].Name}\n" +
                        $"Позиция: {i}";
            }

            //Попарное сравнение типов
            for (int i = 0; i < oldTypes.Length; i++)
            {
                //Если тип несравниваемый или типы равны
                if (oldTypes[i].GetCustomAttribute<NotComparableAttribute>() != null || (oldTypes[i] == newTypes[i]))
                    continue;
                else
                    return $"Обнаружено расхождение в типах\n" +
                        $"Позиция: {i}\n" +
                        $"Получено: {newTypes[i].Name}\n" +
                        $"Ожидалось: {oldTypes[i].Name}\n";
            }

            //Попарное сравнение значений полей и свойств
            for (int i = 0; i < oldTypes.Length; i++)
            {
                FieldInfo[] oldfields =
                    oldTypes[i].GetFields(BindingFlags.Instance | BindingFlags.NonPublic 
                        | BindingFlags.Public | BindingFlags.Static);

                FieldInfo[] newfields =
                    newTypes[i].GetFields(BindingFlags.Instance | BindingFlags.NonPublic 
                        | BindingFlags.Public | BindingFlags.Static);

                for (int j = 0; j < oldfields.Length; j++)
                {
                    var oldValue = oldfields[j].GetValue(objects[i]);
                    var newValue = newfields[j].GetValue(list[i]);

                    if (oldValue is IEnumerable oldEn && newValue is IEnumerable newEn)
                    {
                        //
                    }
                }
            }

            return "Коллекции равны";
        }

        // Все что дальше не относится к 2 лабе

        /// <summary>
        /// Даункастит и возвращает обьект по индексу
        /// </summary>
        /// <typeparam name="T">тип до которого нужно даункастить</typeparam>
        /// <param name="index"></param>
        /// <returns></returns>
        public T GetObject<T>(int index) where T : class
        {
            if (objects[index] is T t) return t;
            else return null;
        }

        /// <summary>
        /// Находит все обьекты определенного типа
        /// </summary>
        /// <typeparam name="T">тип необходимых обьектов</typeparam>
        /// <returns>Список всех найденных элементов</returns>
        public List<T> GetData<T>()
        {
            List<T> data = new List<T>();

            foreach (object obj in objects)
            {
                if (obj is T t)
                    data.Add(t);
            }

            return data;
        }
        
        /// <summary>
        /// Находит все предметы определенного типа подходящие под фильтр
        /// </summary>
        /// <typeparam name="T">тип необходимых предметов</typeparam>
        /// <param name="filter">тег необходимых предметов</param>
        /// <returns>Список всех найденных предметов</returns>
        public List<T> GetData<T>(Tag filter) where T : Item
        {
            List<T> data = new List<T>();

            foreach (object obj in objects)
            {
                if (obj is T t && t.ContainstTag(filter))
                    data.Add(t);
            }

            return data;
        }

        /// <summary>
        /// Возвращает необходимые обьекты в виде текста
        /// </summary>
        /// <typeparam name="T">ип необходимых обьектов</typeparam>
        /// <returns>Список необходимых оббектов в виде текста</returns>
        public string GetDataString<T>()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < objects.Count; i++)
            {
                if (objects[i] is T)
                    sb.Append($"{i}:{objects[i]}\n");
            }

            return sb.ToString();
        }

        /// <summary>
        /// Возвращает необходимые предметы в виде текста
        /// </summary>
        /// <typeparam name="T">Тип необходимых предметов</typeparam>
        /// <param name="filter">тег необходимых предметов</param>
        /// <returns>Список необходимых предметов в виде текста</returns>
        public string GetDataString<T>(Tag filter) where T : Item
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < objects.Count; i++)
            {
                if (objects[i] is T t && t.ContainstTag(filter))
                    sb.Append($"{i}:{objects[i]}\n");
            }

            return sb.ToString();
        }
    }
}
