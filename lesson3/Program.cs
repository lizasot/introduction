using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson3
{
    internal class Program
    {
        /// <summary>
        /// Генерирует массив указанной размерности и присваивает его элементам случайные числа
        /// </summary>
        /// <param name="x">Количество строк</param>
        /// <param name="y">Количество столбцов</param>
        /// <returns>Возвращает получившийся массив</returns>
        static int[,] GenerateBivariateArray(int x, int y)
        {
            Random random = new Random();
            int[,] arr = new int[x, y];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = random.Next(-99,100);
                }
            }
            return arr;
        }

        /// <summary>
        /// Выводит двумерный массив чисел
        /// </summary>
        /// <param name="arr">Массив целых чисел</param>
        static void PrintBiArray(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j]}\t");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Выводит двумерный массив строк
        /// </summary>
        /// <param name="arr">Массив строк</param>
        static void PrintBiArray(string[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j]}\t");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Выводит элементы двухмерного массива, расположенных по диагонали
        /// </summary>
        static void Task1()
        {
            Console.Write("Введите размерность массива (через перенос строки): ");
            int[,] array = GenerateBivariateArray(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            Console.WriteLine("Получившийся массив:");
            PrintBiArray(array);
            Console.WriteLine();
            Console.WriteLine("Вывод массива по диагонали");
            int minSize = array.GetLength(0);
            if (minSize > array.GetLength(1))
                minSize = array.GetLength(1);
            for (int i = 0; i < minSize; i++)
            {
                Console.Write($"{array[i,i]}\t");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Выводит заготовленный двумерный массив-справочник
        /// </summary>
        static void Task2()
        {
            string[,] directory = new string[5,2];
            directory[0, 0] = "Krist"; directory[0, 1] = "88005553535";
            directory[1, 0] = "Mona"; directory[1, 1] = "88005553536";
            directory[2, 0] = "Lisa"; directory[2, 1] = "88005553537";
            directory[3, 0] = "Isaac"; directory[3, 1] = "88005553538";
            directory[4, 0] = "Arseny"; directory[4, 1] = "88005553539";
            PrintBiArray(directory);
        }

        /// <summary>
        /// Вывод строки в обратном порядке
        /// </summary>
        static void Task3()
        {
            Console.WriteLine("Введите строку, которую необходимо отразить в обратном порядке:");
            string str = Console.ReadLine();
            for (int i = str.Length - 1; i >= 0; i--)
                Console.Write(str[i]);
            Console.WriteLine();
        }

        /// <summary>
        /// Выводит поле Морского боя.
        /// </summary>
        /// <param name="field"></param>
        static void PrintSeaBattle(bool[,] field)
        {
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    if (field[i, j])
                    {
                        Console.Write('X');
                    }
                    else
                    {
                        Console.Write('O');
                    }
                    Console.Write(' ');
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Генерирует поле Морского боя случайным образом и выводит его
        /// </summary>
        static void Task4()
        {
            Random random = new Random();
            bool[,] field = new bool[10,10];
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    if (random.Next(0, 2) > 0)
                    {
                        field[i, j] = true;
                        // По правилам морского боя, корабли не могут находиться друг от друга по диагонали
                        if (i > 0)
                        {
                            if (j > 0 && field[i - 1, j - 1])
                            {
                                field[i, j] = false;
                            }
                            if (j < field.GetLength(1) - 1 && field[i - 1, j + 1])
                            {
                                field[i, j] = false;
                            }
                        }
                        if (i < field.GetLength(0) - 1)
                        {
                            if (j > 0 && field[i + 1, j - 1])
                            {
                                field[i, j] = false;
                            }
                            if (j < field.GetLength(1) - 1 && field[i + 1, j + 1])
                            {
                                field[i, j] = false;
                            }
                        }
                    }
                    else
                    {
                        field[i, j] = false;
                    }
                }
            }
            PrintSeaBattle(field);
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
                Console.WriteLine(" Вывод элементов двухмерного массива по диагонали");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("[2]");
                Console.ResetColor();
                Console.WriteLine(" Вывод заготовленного справочника");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("[3]");
                Console.ResetColor();
                Console.WriteLine(" Вывод введённой строки в обратном порядке");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("[4]");
                Console.ResetColor();
                Console.WriteLine(" Генерация поля Морского боя и его вывод");

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
