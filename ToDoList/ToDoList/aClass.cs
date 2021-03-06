﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    public class aClass
    {
        string name;
        ConcurrentDictionary<string, aTask> tasks;
        List<string> members;

        public aClass(string s)
        {
            name = s;
            tasks = new ConcurrentDictionary<string, aTask>();
            members = new List<string>();
        }

        // Adds task to tasks. Returns true if successful
        public bool AddTask(string taskName, string month, string day, string year, string description)
        {
            if (!tasks.ContainsKey(taskName))
            {
                aTask task = new aTask(taskName, month, day, year, description);
                tasks.TryAdd(taskName, task);
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

        public bool ContainsTask(string taskName)
        {
            return tasks.ContainsKey(taskName);
        }

        public List<string> Members{
            get{ return members;}
            set{ members = value;}
        }

    }
}
