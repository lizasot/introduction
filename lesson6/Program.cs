using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson6
{
    class Program
    {
        static void PrintProcesses(Process[] processes)
        {
            int centerConsole = Console.WindowWidth / 2;
            for (int i = 0; i < processes.Length; i++)
            {
                Console.SetCursorPosition(1, Console.CursorTop);
                if (i % 2 == 1)
                {
                    Console.SetCursorPosition(centerConsole, Console.CursorTop);
                }
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(processes[i].Id);
                for (int j = 0; j < (8 - string.Concat(processes[i].Id).Length); j++)
                {
                    Console.Write(" ");
                }
                Console.ResetColor();
                Console.Write(processes[i].ProcessName);
                if (i % 2 == 1)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.SetCursorPosition(0, Console.CursorTop);
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                PrintProcesses(Process.GetProcesses());
                Console.WriteLine("Введите -1, чтобы выйти из программы");
                Console.WriteLine("Введите айди или имя процесса, который хотите завершить:");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int id))
                {
                    if (id == -1)
                    {
                        Console.WriteLine("Выход из программы. . .");
                        Console.ReadKey(true);
                        return;
                    }
                    try
                    {
                        Process process = Process.GetProcessById(id);
                        Console.WriteLine("Завершается процесс " + process.ProcessName);
                        process.Kill();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadKey(true);
                    }
                }
                else
                {
                    try
                    {
                        Process[] processes = Process.GetProcessesByName(input);
                        if (processes.Length != 0)
                        {
                            foreach (var process in processes)
                            {
                                Console.WriteLine("Завершается процесс " + process.ProcessName + " #" + process.Id);
                                process.Kill();
                            }
                            Console.ReadKey(true);
                        }
                        else
                        {
                            throw new Exception("Процессов с таким именем не существует.");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadKey(true);
                    }
                }
            }
        }
    }
}
