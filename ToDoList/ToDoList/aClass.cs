using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    public class aClass
    {
        string name;
        Dictionary<string, aTask> tasks;

        public aClass(string s)
        {
            name = s;
            tasks = new Dictionary<string, aTask>();
        }

        // Adds task to tasks. Returns true if successful
        public bool AddTask(string taskName, string month, string day, string year, string description)
        {
            if (!tasks.ContainsKey(taskName))
            {
                aTask task = new aTask(taskName, month, day, year, description);
                tasks.Add(taskName, task);
                return true;
            }
            else return false;
        }

        public aTask GetTask(string taskName)
        {
            aTask task;
            if (tasks.TryGetValue(taskName, out task)) return task;
            else return null;
        }
    }
}
