using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson5
{
    public class ToDo
    {
        public string title;
        public bool isDone;

        public ToDo()
        {
            title = "";
            isDone = false;
        }
        public ToDo(string title)
        {
            this.title = title;
            this.isDone = false;
        }
        public ToDo(string title, bool isDone)
        {
            this.title = title;
            this.isDone = isDone;
        }

        public void Print()
        {
            Console.Write("[" + (isDone ? "x" : " ") + "] ");
            Console.WriteLine(title);
        }
    }
}
