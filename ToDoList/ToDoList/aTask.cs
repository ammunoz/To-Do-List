using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    class aTask
    {
        string taskName;
        DateTime due; // TODO Change if needed
        HashSet<string> members = new HashSet<string>();
        String description;


        public aTask(string s, DateTime d)
        {
            taskName = s;
            due = d;
        }

        public bool AddMember(string member)
        {
            if (!members.Contains(member))
            {
                members.Add(member);
                return true;
            }
            else return false;
        }

        
    }
}
