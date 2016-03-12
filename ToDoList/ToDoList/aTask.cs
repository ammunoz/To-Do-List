using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    class aTask
    {
        string name;
        DateTime due; // TODO update

        public aTask(string s, DateTime d)
        {
            name = s;
            due = d;
        }
    }
}
