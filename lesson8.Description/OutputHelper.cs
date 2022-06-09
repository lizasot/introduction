using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson8.MyUtils
{
    public class OutputHelper
    {
        public static void PrintInfo(int numb, string fio)
        {
            Console.WriteLine("║ Урок " + numb + ".");
            Console.WriteLine("║ Студент: " + fio);
            Console.WriteLine();
        }
    }
}
