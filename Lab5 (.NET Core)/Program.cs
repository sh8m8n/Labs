using LabLib;

namespace Lab5__.NET_Core_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student() { ScholarshipAmount = 1000}; // :(

            while (true)
            {
                Console.WriteLine("Нажмите на нужную цифру: " +
                    "\n1 - Вывести информацию о студенте" +
                    "\n2 - Получить деньги" +
                    "\n3 - Потратить деньги" +
                    "\n4 - Показать баланс" +
                    "\n5 - Ввести имя и специальность");
                ConsoleKey key = Console.ReadKey().Key;
                Console.WriteLine();

                switch (key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine($"Имя: {student.Name}\nСпециальность: {student.Speciality}\nСтипендия: {student.ScholarshipAmount}");
                        break;

                    case ConsoleKey.D2:
                        student.GetScholarship();
                        Console.WriteLine($"Информация о балансе обновлена. Текущий баланс: {student.Check}");
                        break;

                    case ConsoleKey.D3:
                        int money = Durak.GetInt("Сколько денег вы хотите потратить?");
                        string itemOfExpenditure = Durak.GetString("На что вы хотите потратить деньги?");
                        Console.WriteLine(student.SpendScholarship(money, itemOfExpenditure));
                        break;

                    case ConsoleKey.D4:
                        Console.WriteLine($"Баланс = {student.Check}");
                        break;
                    
                    case ConsoleKey.D5:
                        Console.WriteLine("Введите имя:");
                        student.Name = Console.ReadLine();
                        Console.WriteLine("Введите специальность");
                        student.Speciality = Console.ReadLine();
                        break;

                    default: 
                        Console.WriteLine("Такой команды нет");
                        break;
                }
                Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                Console.ReadKey();
                Console.Clear();


            }
        }
    }
}