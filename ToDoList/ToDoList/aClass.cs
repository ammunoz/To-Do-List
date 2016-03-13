using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    class aClass
    {
        string name;
        HashSet<aTask> tasks;

        public aClass(string s)
        {
            name = s;
        }

        // Adds task to tasks. Returns true if successful
        public bool AddTask(aTask task)
        {
            if (!tasks.Contains(task))
            {
                tasks.Add(task);
                return true;
            }
            else return false;
        }
    }
}
