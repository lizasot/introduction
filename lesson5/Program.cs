using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace lesson5
{
    class Program
    {
        /// <summary>
        ///Ввод с клавиатуры произвольный набор данных, который сохраняется в текстовый файл.
        /// </summary>
        static void Task1()
        {
            Console.WriteLine("Введите текст, который хотите сохранить");
            File.WriteAllText("filename.txt", Console.ReadLine());
        }

        /// <summary>
        /// Ввод с клавиатуры произвольный набор чисел (0...255) и записать их в бинарный файл.
        /// </summary>
        static void Task3()
        {
            Console.WriteLine("Введите числа от 0 до 255 через пробел");
            string str = Console.ReadLine();
            string[] numbers = str.Split(' ');

            byte[] arrBytes = new byte[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                //проверка, можно ли конвертировать
                if (!byte.TryParse(numbers[i], out arrBytes[i]))
                {
                    Console.WriteLine("Неправильный ввод строки.");
                    return;
                }
            }
            File.WriteAllBytes("bytes.bin", arrBytes);
            //Вывод какие байты по итогу записаны в файле
        }

        /// <summary>
        /// Вывод файла на экран в дереве каталогов и файлов
        /// </summary>
        /// <param name="file">FileInfo файла</param>
        /// <param name="indent">Отступ для текущего файла</param>
        /// <param name="lastFile">Является ли файл последним в текущей папке</param>
        static void PrintFile(FileInfo file, string indent, bool lastFile, string fileName)
        {
            Console.Write(indent);
            File.AppendAllText(fileName, indent);

            Console.Write(lastFile ? "└" : "├");
            File.AppendAllText(fileName, lastFile ? "└" : "├");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(file.Name);
            File.AppendAllText(fileName, file.Name + "\n");
            Console.ResetColor();
        }
        /// <summary>
        /// Выводит все файлы
        /// </summary>
        /// <param name="subFiles">Массив файлов в формате FileInfo</param>
        /// <param name="indent">Отступ перед выводом файлов</param>
        static void PrintAllFiles(FileInfo[] subFiles, string indent, string fileName)
        {
            for (int i = 0; i < subFiles.Length; i++)
            {
                PrintFile(subFiles[i], indent, (i == subFiles.Length - 1), fileName);
            }
        }
        /// <summary>
        /// Построение дерева каталогов и файлов
        /// </summary>
        /// <param name="dir"></param>
        /// <param name="indent"></param>
        /// <param name="lastDirectory"></param>
        static void PrintDir(DirectoryInfo dir, string indent, bool lastDirectory, string fileName)
        {
            Console.Write(indent);
            File.AppendAllText(fileName, indent);

            Console.Write(lastDirectory ? "└" : "├");
            File.AppendAllText(fileName, lastDirectory ? "└" : "├");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(dir.Name);
            File.AppendAllText(fileName, dir.Name + "\n");
            Console.ResetColor();

            DirectoryInfo[] subDirs = dir.GetDirectories();
            FileInfo[] subFiles = dir.GetFiles();
            indent += lastDirectory ? " " : "│ ";
            for (int i = 0; i < subDirs.Length; i++)
            {
                PrintDir(subDirs[i], indent, ((i == subDirs.Length - 1) && (subFiles.Length == 0)), fileName);
            }
            PrintAllFiles(subFiles, indent, fileName);
        }

        /// <summary>
        /// Сохранить дерево каталогов и файлов по заданному пути в текстовый файл с рекурсией.
        /// </summary>
        static void Task4()
        {
            string dir; // = "D:\\MyPr\\c#\\geekbrains\\introduction\\lesson5"; // D:\MyPr\c#\geekbrains\introduction\lesson5
            Console.WriteLine("Введите путь, к которому необходимо нарисовать дерево каталогов и файлов");
            dir = Console.ReadLine();
            string fileName = "tree.txt";
            Console.WriteLine("___________");
            File.WriteAllText(fileName, "");
            PrintDir(new DirectoryInfo(@dir), "", true, fileName);
        }

        public static ToDo[] LoadToDoFromXml(string fileName)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ToDo[]));
            FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            ToDo[] tasks = (ToDo[])xmlSerializer.Deserialize(fileStream);
            fileStream.Close();
            return tasks;
        }
        public static void SaveToDoToXml(string fileName, ToDo[] tasks)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ToDo[]));
            FileStream fileStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            xmlSerializer.Serialize(fileStream, tasks);
            fileStream.Close();
        }
        public static void CreateDefaultTasks(string fileName)
        {
            ToDo[] tasks = new ToDo[8];
            tasks[0] = new ToDo("Приготовить индейку", true);
            tasks[1] = new ToDo("Соорудить компаньона-ИИ");
            tasks[2] = new ToDo("Прибраться в комнате");
            tasks[3] = new ToDo("Слетать на марс");
            tasks[4] = new ToDo("Навестить Khlûl’hloo", true);
            tasks[5] = new ToDo("Много кодить", true);
            tasks[6] = new ToDo("Отправить домашку geekbrains", true);
            tasks[7] = new ToDo("Преисполниться");

            SaveToDoToXml(fileName, tasks);
        }
        /// <summary>
        /// Приложение для списка задач
        /// </summary>
        static void Task5()
        {
            string fileName = "tasks.xml";
            int taskNumber;
            if (!File.Exists(fileName))
            {
                CreateDefaultTasks(fileName);
            }
            while (true)
            {
                Console.Clear();
                ToDo[] tasks = LoadToDoFromXml(fileName);
                for (int i = 0; i < tasks.Length; i++)
                {
                    Console.Write((i + 1) + ". ");
                    tasks[i].Print();
                }
                Console.WriteLine("0. Выйти из списка задач");
                Console.Write("Введите номер задачи, отметку которой хотите изменить: ");
                while (!int.TryParse(Console.ReadLine(), out taskNumber) || (taskNumber > tasks.Length) || (taskNumber < 0))
                {
                    Console.WriteLine("Некорректный ввод, попробуйте снова.");
                }
                if (taskNumber != 0)
                {
                    taskNumber--;
                    tasks[taskNumber].isDone = !tasks[taskNumber].isDone;
                    SaveToDoToXml(fileName, tasks);
                }
                else
                    return;
            }
        }
        /// <summary>
        /// Дописывает текущее время в файл «startup.txt».
        /// </summary>
        static void Task2()
        {
            DateTime thisDay = DateTime.Now;
            File.AppendAllText("startup.txt", thisDay.ToString() + "\n");
        }
        static void Main(string[] args)
        {
            Task2();

            bool repeat = true;
            while (repeat)
            {
                Console.Clear();
                int choice = 0;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("[1]");
                Console.ResetColor();
                Console.WriteLine(" Ввести с клавиатуры произвольный набор данных и сохранить его в текстовый файл");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("[2]");
                Console.ResetColor();
                Console.WriteLine(" Дописать текущее время в файл");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("[3]");
                Console.ResetColor();
                Console.WriteLine(" Ввести с клавиатуры произвольный набор чисел (0...255) и записать их в бинарный файл");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("[4]");
                Console.ResetColor();
                Console.WriteLine(" Сохранить дерево каталогов и файлов по заданному пути в текстовый файл");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("[5]");
                Console.ResetColor();
                Console.WriteLine(" Открыть и отредактировать список задач");

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
                        Console.ReadKey(true);
                        break;

                    case 5:
                        Task5();
                        Console.WriteLine();
                        Console.ReadKey(true);
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
            Console.ReadKey(true);
        }
    }
}
