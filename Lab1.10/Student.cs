using System;
using System.Collections.Generic;

namespace Lab10
{
    internal struct Student : IComparable
    {
        private static int CountOfStudents = 0;
        public int Number { get; set; }
        public int CountPhone { get; set; }
        public int CountLunch { get; set; }
        public Position Position { get; set; }

        /// <summary>
        /// 片口人认丩仨匚丅乃口 闩认乃口卄口乃 认 冂口弓认凵认牙 匚人丫丩闩认卄辷, 10 爪认匚口片 卩认匚闩 乃匚仨爪
        /// </summary>
        /// <param name="random"></param>
        public Student(Random random)
        {
            Number = ++CountOfStudents;
            CountPhone = random.Next(5, 10);
            CountLunch = 10;
            Position = (Position)random.Next(3);
        }

        /// <summary>
        /// 冂仨卩仨乃仨匚丅认 亼卩丫厂-匚丅卩口片丫 乃 卩口亼卄口认-匚丅卩口片丫
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
        public string TranslateLine(string line)
        {
            Dictionary<Char, Char> alphabet = new Dictionary<Char, Char>()
            {
                { 'а', '闩' },
                { 'б', '石' },
                { 'в', '乃' },
                { 'г', '厂' },
                { 'д', '亼' },
                { 'е', '仨' },
                { 'ё', '仨' },
                { 'ж', '水' },
                { 'з', '弓' },
                { 'и', '认' },
                { 'й', '认' },
                { 'к', '片' },
                { 'л', '人' },
                { 'м', '爪' },
                { 'н', '卄' },
                { 'о', '口' },
                { 'п', '冂' },
                { 'р', '卩' },
                { 'с', '匚' },
                { 'т', '丅' },
                { 'у', '丫' },
                { 'ф', '中' },
                { 'х', '乂' },
                { 'ц', '凵' },
                { 'ч', '丩' },
                { 'ш', '山' },
                { 'щ', '山' },
                { 'ъ', '乙' },
                { 'ы', '辷' },
                { 'ь', '乙' },
                { 'э', '彐' },
                { 'ю', '扣' },
                { 'я', '牙' },
            };

            foreach (var symbol in alphabet)
            {
                line = line.Replace(symbol.Key, symbol.Value);
            }

            return line;
        }

        public int CompareTo(object obj)
        {
            if (obj is Student student)
            {
                if (CountPhone == student.CountPhone)
                    return (int)Position - (int)student.Position;
                else
                    return CountPhone - student.CountPhone;
            }
            else
            {
                throw new ArgumentException("Некорректное значение параметра");
            }
        }

        public static bool operator ==(Student student1, Student student2)
        {
            if (student1.Number == student2.Number)
            {
                return true;
            }
            else
                return false;
        }
        public static bool operator !=(Student student1, Student student2)
        {
            return !(student1 == student2);
        }
    }
}
