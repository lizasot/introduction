using lesson8.MyUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson8
{
    class Program
    {
        static void Main(string[] args)
        {
            OutputHelper.PrintInfo(8, "Сотина Елизавета");
            Console.WriteLine(Properties.Settings.Default.GreetingMsg);
            Console.WriteLine();
            if (Properties.Settings.Default.Name == "UserName")
            {
                Console.Write("Укажите ваше имя: ");
                Properties.Settings.Default.Name = Console.ReadLine();
                Properties.Settings.Default.Save();
            }
            else
            {
                Console.WriteLine("Ваше имя: " + Properties.Settings.Default.Name);
            }

            if (Properties.Settings.Default.Age == 0)
            {
                Console.Write("Укажите ваш возраст: ");
                Properties.Settings.Default.Age = int.Parse(Console.ReadLine());
                Properties.Settings.Default.Save();
            }
            else
            {
                Console.WriteLine("Ваш возраст: " + Properties.Settings.Default.Age);
            }

            if (Properties.Settings.Default.Employment == "None")
            {
                Console.Write("Укажите ваш род деятельности: ");
                Properties.Settings.Default.Employment = Console.ReadLine();
                Properties.Settings.Default.Save();
            }
            else
            {
                Console.WriteLine("Ваш род деятельности: " + Properties.Settings.Default.Employment);
            }
            Console.ReadKey(true);
        }
    }
}
