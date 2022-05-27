using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson4
{
    class Program
    {
        /// <summary>
        /// ФИО в трёх аргументах преобразовывается в одну строку.
        /// </summary>
        /// <param name="firstName">Имя</param>
        /// <param name="lastName">Фамилия</param>
        /// <param name="patronymic">Отчество</param>
        /// <returns>Строка с объединённым ФИО</returns>
        static string GetFullName(string firstName, string lastName, string patronymic)
        {
            return firstName + " " + lastName + " " + patronymic;
        }
        /// <summary>
        /// Выводит 4 заготовленных ФИО череез метод GetFullName
        /// </summary>
        static void Task1()
        {
            Console.WriteLine(GetFullName("firstName", "lastName", "patronymic"));
            Console.WriteLine(GetFullName("firstName", "lastName", "patronymic"));
            Console.WriteLine(GetFullName("firstName", "lastName", "patronymic"));
            Console.WriteLine(GetFullName("firstName", "lastName", "patronymic"));
        }

        /// <summary>
        /// Считывает со строки числа и считает их сумму.
        /// </summary>
        /// <param name="str">Произвольная строка</param>
        /// <param name="symb">Разделитель чисел</param>
        /// <param name="result">Получившаяся сумма чисел</param>
        /// <returns>Вовзвращает, получилось ли преобразовать строку к числам</returns>
        static bool StrToSummInt(string str, char symb, out double result)
        {
            string[] numbs = str.Split(symb);
            result = 0;
            foreach (var word in numbs)
            {
                if (Double.TryParse(word, out double number))
                    result += number;
                else
                    return false;
            }
            return true;
        }
        /// <summary>
        /// Принимает строку чисел, вводимую пользователем и выводит на экран сумму чисел
        /// </summary>
        static void Task2()
        {
            Console.WriteLine("Введите строку чисел через пробел:");
            if (StrToSummInt(Console.ReadLine(), ' ', out double summ))
                Console.WriteLine($"Получившаяся сумма: {summ}");
            else
                Console.WriteLine("Строка введена неверно.");
        }

        enum Season
        {
            //Числа обозначают порядковый номер месяца, являющийся серединой сезона
            Winter = 0,
            Spring = 3,
            Summer = 6,
            Autumn = 9
        }
        /// <summary>
        /// Определяет сезон по указанному месяцу
        /// </summary>
        /// <param name="month">Порядковый номер месяца (от 0 до 11)</param>
        /// <returns></returns>
        static string WhichSeason(int month)
        {
            //P.S. Методы найдены и изучены исключительно по методичке Microsoft
            if (month >= 0 && month <= 10)
                foreach (int i in Enum.GetValues(typeof(Season)))
                {
                    if (Math.Abs(month - i) <= 1)
                    {
                        return Enum.GetName(typeof(Season), i);
                    }
                }
            if (month == 11)
                return Enum.GetName(typeof(Season), 0);

            return "NaN";
        }
        /// <summary>
        /// По порядковому номеру месяца, выводится сезон, к которому он относится
        /// </summary>
        static void Task3()
        {
            Console.WriteLine("Введите порядковый номер месяца, сезон которого необходимо определить (от 1 до 12):");
            int month = -1;
            while (!int.TryParse(Console.ReadLine(), out month) || !(month >= 1 && month <= 12))
            {
                Console.WriteLine("Ошибка: введите число от 1 до 12");
            }
            Console.WriteLine(WhichSeason(month - 1));
        }

        /// <summary>
        /// Вычисление числа Фибоначчи для индекса n
        /// </summary>
        /// <param name="n">Индекс числа Фибоначчи</param>
        /// <returns>Возвращает найденное число Фибоначчи</returns>
        static int Fi(int n)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;
            if (n == -1)
                return 1;
            if (n > 0)
                return Fi(n - 1) + Fi(n - 2);
            else
                return Fi(n + 2) - Fi(n + 1);
        }

        static void Task4()
        {
            Console.Write("Введите целое число n, для которого будет вычислена последовательность чисел Фибоначчи: ");
            int n = 0;
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Строка введена неверно, повторите снова.");
            }

            if (n > 0)
                for (int i = 0; i <= n; i++)
                {
                    Console.Write(Fi(i) + " ");
                }
            else
                for (int i = 0; i >= n; i--)
                {
                    Console.Write(Fi(i) + " ");
                }

        }

        static void Main(string[] args)
        {
            bool repeat = true;
            while (repeat)
            {
                int choice = 0;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("[1]");
                Console.ResetColor();
                Console.WriteLine(" Вывод заготовленных ФИО методом, объединяющий разные строки");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("[2]");
                Console.ResetColor();
                Console.WriteLine(" Ввести строку чисел, чтобы получить их сумму");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("[3]");
                Console.ResetColor();
                Console.WriteLine(" Определить сезон по порядковому номеру месяца");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("[4]");
                Console.ResetColor();
                Console.WriteLine(" Вычислить число Фибоначчи для индекса n и вывести их последовательность");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("[0]");
                Console.ResetColor();
                Console.WriteLine(" Выход из программы");

                Console.WriteLine("Введите номер задачи, которую хотите просмотреть:");
                choice = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (choice)
                {
                    case 1:
                        Task1();
                        Console.WriteLine();
                        break;

                    case 2:
                        Task2();
                        Console.WriteLine();
                        break;

                    case 3:
                        Task3();
                        Console.WriteLine();
                        break;

                    case 4:
                        Task4();
                        Console.WriteLine();
                        break;

                    case 0:
                        Console.WriteLine("Выход из программы ...");
                        repeat = false;
                        break;

                    default:
                        Console.WriteLine("Получено некорректное значение. Повторите ввод снова.");
                        break;

                }
            }
            Console.ReadKey();
        }
    }
}
