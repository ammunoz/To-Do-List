using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    public class aTask
    {
        string taskName;
        string month, day, year; // TODO Change if needed
        HashSet<string> members = new HashSet<string>();
        String description;


        public aTask(string s, string m, string d, string y, string desc)
        {
            taskName = s;
            month = m;
            day = d;
            year = y;
            description = desc;
        }

        public void ModifyTask(string m, string d, string y, string desc)
        {
            month = m;
            day = d;
            year = y;
            description = desc;
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

        public string[] GetInfo()
        {
            string[] s = new string[4];
            s[0] = month;
            s[1] = day;
            s[2] = year;
            s[3] = description;
            return s;
        }
    }
}
