using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson7
{
    class Program
    {
        static void Test1()
        {
            Console.WriteLine("Сколько чисел необходимо вывести?");
            int m = int.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Сколько чисел необходимо вывести?");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"Выведено {n} чисел");
            Console.WriteLine("Выведено " + n + " чисел");
            Console.WriteLine("Выведено {0} чисел", n);
        }
        static string Test2()
        {
            return Console.ReadLine();
        }
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
        static void Test3()
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
        static void Test4()
        {
            int n;
            double d;
            string s;
            decimal c;
            float f;
        }
        static void Main(string[] args)
        {

            bool repeat = true;
            while (repeat)
            {
                Console.Clear();
                int choice = 0;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("[1-3]");
                Console.ResetColor();
                Console.WriteLine(" Введите номер задачи, которую хотите просмотреть:");
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Необходимо ввести число, а вы ввели строку");
                    choice = -1;
                }
                finally
                {
                    Console.WriteLine();
                }
                switch (choice)
                {
                    case 1:
                        Test1();
                        Console.WriteLine();
                        Console.ReadKey(true);
                        break;

                    case 2:
                        Console.WriteLine(Test2());
                        Console.WriteLine();
                        Console.ReadKey(true);
                        break;

                    case 3:
                        Test3();
                        Console.WriteLine();
                        Console.ReadKey(true);
                        break;

                    case 4:
                        Console.WriteLine();
                        Console.ReadKey(true);
                        break;

                    case 5:
                        Console.WriteLine();
                        Console.ReadKey(true);
                        break;

                    case 0:
                        Console.WriteLine("Выход из программы ...");
                        repeat = false;
                        break;

                    default:
                        Console.WriteLine("Получено некорректное значение. Повторите ввод снова.");
                        Console.ReadKey(true);
                        break;

                }
            }
            Console.ReadKey(true);
        }
    }
}
