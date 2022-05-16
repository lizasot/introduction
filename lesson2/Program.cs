using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2
{
    class Program
    {
        /// <summary>
        /// Находит и выводит среднюю температуру между минимальным и максимальным значением, которые введёт пользователь.
        /// </summary>
        /// <returns>Возвращает найденное среднее значение</returns>
        static double Task1()
        {
            Console.WriteLine("Введите минимальную температуру за сутки:");
            double minTemp = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите максимальную температуру за сутки:");
            double maxTemp = double.Parse(Console.ReadLine());

            Console.WriteLine($"Средняя температура: {avarageValue(minTemp, maxTemp)}");
            return avarageValue(minTemp, maxTemp);
        }
        /// <summary>
        /// Находит среднее значение между двумя введёнными числами
        /// </summary>
        /// <param name="first">Первое произвольное значение</param>
        /// <param name="second">Второе произвольное значение</param>
        /// <returns>Среднее значение</returns>
        static double avarageValue(double first, double second)
        {
            return ((first + second) / 2);
        }

        /// <summary>
        /// Запрашивает у пользователя числовой порядок месяца, после чего выводит его название
        /// </summary>
        /// <returns>Возвращает номер месяца, который ввёл пользователь</returns>
        static int Task2()
        {
            Console.WriteLine("Введите порядковый номер месяца: ");
            int month = int.Parse(Console.ReadLine());
            if (month > 0)
            {
                month--;
            }
            Console.Write($"Ведённый месяц: ");
            WhatTheMonth(month);
            Console.WriteLine();

            return month;
        }
        /// <summary>
        /// Выводит на экран месяц, чей номер был введён
        /// </summary>
        /// <param name="number">Значение месяца, считая с 0</param>
        static void WhatTheMonth(int number)
        {
            switch (number)
            {
                case 0:
                    Console.Write("январь");
                    break;
                case 1:
                    Console.Write("февраль");
                    break;
                case 2:
                    Console.Write("март");
                    break;
                case 3:
                    Console.Write("апрель");
                    break;
                case 4:
                    Console.Write("май");
                    break;
                case 5:
                    Console.Write("июнь");
                    break;
                case 6:
                    Console.Write("июль");
                    break;
                case 7:
                    Console.Write("август");
                    break;
                case 8:
                    Console.Write("сентябрь");
                    break;
                case 9:
                    Console.Write("октябрь");
                    break;
                case 10:
                    Console.Write("ноябрь");
                    break;
                case 11:
                    Console.Write("декабрь");
                    break;
            }
        }

        /// <summary>
        /// Запрашивает у пользователя число и определяет, является ли оно чётным
        /// </summary>
        static void Task3()
        {
            Console.WriteLine("Введите целое число: ");
            int number = int.Parse(Console.ReadLine());
            if (IsEven(number))
            {
                Console.WriteLine($"Число {number} является чётным.");
            }
            else
            {
                Console.WriteLine($"Число {number} не является чётным.");
            }
        }
        /// <summary>
        /// Определяет, является ли введённое число чётным.
        /// </summary>
        /// <param name="number">Целое произвольное число</param>
        /// <returns>Возвращает true, если число чётное</returns>
        static bool IsEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Ради интереса дала названия по-русски, вроде работает.
        //Но, я так подозреваю, лучше всё равно привыкать писать всё по-английски
        public enum Products
        {
            Молоко = 70,
            Яйца = 120,
            Хлеб = 30,
            Мука = 300
        }
        /// <summary>
        /// Вывод заранее подготовленного чека на экран
        /// </summary>
        static void Task4()
        {
            string shopName = "Магазин магазинный";
            DateTime date = new DateTime(2015, 7, 20);
            int discount = 6; //Скидка в валюте (не процентах)

            Console.WriteLine();
            Console.WriteLine($"ООО \"{shopName}\"");
            Console.WriteLine();
            Console.WriteLine($" 1   {Products.Молоко}   =   {(int)(Products.Молоко)}");
            Console.WriteLine($" 2   {Products.Яйца}     =   {(int)(Products.Яйца)}");
            Console.WriteLine($" 3   {Products.Хлеб}     =   {(int)(Products.Хлеб)}");
            Console.WriteLine($" 4   {Products.Мука}     =   {(int)(Products.Мука)}");
            Console.WriteLine("======================");
            Console.WriteLine($" Скидка:          -{discount}");
            Console.WriteLine($" ИТОГ:            {(int)(Products.Молоко) + (int)(Products.Яйца) + (int)(Products.Хлеб) + (int)(Products.Мука) - discount}");
            Console.WriteLine($"Дата покупки: {date}");
        }

        static void Task5()
        {
            double avarTemp = Task1();
            int month = Task2();
            if ((avarTemp > 0) && (month == 0 || month == 1 || month == 11))
            {
                Console.WriteLine("Дождливая зима");
            }
            else
            {
                Console.WriteLine("НЕ_Дождливая зима");
            }
        }

        public enum Week
        {
            Monday = 0b_0000001,
            Tuesday = 0b_0000010,
            Wednesday = 0b_0000100,
            Thursday = 0b_0001000,
            Friday = 0b_0010000,
            Saturday = 0b_0100000,
            Sunday = 0b_1000000
        }
        static void Task6()
        {
            int ofice1 = 0 | 0b_0011110; //со вторника до пятницы
            int ofice2 = 0 | 0b_1111111; //со понедельника до воскресенья
            int ofice3 = 0 | 0b_1010101; //Дни чередуются: понедельник, среда, пятница, воскресенье
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Дни недели, когда работает офис 1:");
            Console.ResetColor();
            Schedule(ofice1);
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Дни недели, когда работает офис 2:");
            Console.ResetColor();
            Schedule(ofice2);
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Дни недели, когда работает офис 3:");
            Console.ResetColor();
            Schedule(ofice3);
        }
        /// <summary>
        /// Выводит дни недели, когда работает офис
        /// </summary>
        /// <param name="ofice">Расписание офиса, зашифрованное в битах</param>
        static void Schedule(int ofice)
        {
            if (((int)Week.Monday & ofice) > 0)
            {
                Console.WriteLine("Понедельник");
            }
            if (((int)Week.Tuesday & ofice) > 0)
            {
                Console.WriteLine("Вторник");
            }
            if (((int)Week.Wednesday & ofice) > 0)
            {
                Console.WriteLine("Среда");
            }
            if (((int)Week.Thursday & ofice) > 0)
            {
                Console.WriteLine("Четверг");
            }
            if (((int)Week.Friday & ofice) > 0)
            {
                Console.WriteLine("Пятница");
            }
            if (((int)Week.Saturday & ofice) > 0)
            {
                Console.WriteLine("Суббота");
            }
            if (((int)Week.Sunday & ofice) > 0)
            {
                Console.WriteLine("Воскресенье");
            }
        }

        static void Main(string[] args)
        {
            int choice = 0;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("[1]");
            Console.ResetColor();
            Console.WriteLine(" Определение средней температуры по максимальному и минимальному значению");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("[2]");
            Console.ResetColor();
            Console.WriteLine(" Вывод названия месяца по его порядковому номеру (отсчёт с 1)");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("[3]");
            Console.ResetColor();
            Console.WriteLine(" Является ли число чётным?");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("[4]");
            Console.ResetColor();
            Console.WriteLine(" Вывод чека с заготовленными значениями");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("[5]");
            Console.ResetColor();
            Console.WriteLine(" *Пункты [1] и [2], но проверка, дождливая ли зима?");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("[6]");
            Console.ResetColor();
            Console.WriteLine(" *Вывод расписаний офисов по побитовым маскам");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("[0]");
            Console.ResetColor();
            Console.WriteLine(" Выход из программы");

            Console.WriteLine("Введите номер задачи, которую хотите просмотреть:");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Task1();
                    break;

                case 2:
                    Task2();
                    break;

                case 3:
                    Task3();
                    break;

                case 4:
                    Task4();
                    break;

                case 5:
                    Task5();
                    break;

                case 6:
                    Task6();
                    break;

                case 0:
                    Console.WriteLine("Выход из программы ...");
                    break;

                default:
                    break;

            }
            Console.ReadKey();
        }
    }
}
