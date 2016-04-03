using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ToDoList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        LoginPage login = new LoginPage();
        RegisterPage register = new RegisterPage();
        HomePage home = new HomePage();
        Calendar calendar = new Calendar();
        CalendarDay calendarDay = new CalendarDay();
        MemberPage member = new MemberPage();
        MessagePage message = new MessagePage();
        ClassPage classPage = new ClassPage();
        TaskWindow taskPage = new TaskWindow();
        UserControl currentPage;

        string curMessage = " ";
        ConcurrentDictionary<string, MessagePage> messages = new ConcurrentDictionary<string, MessagePage>();

        Stack<UserControl> pageStack = new Stack<UserControl>();
        ConcurrentDictionary<string, string> accounts = new ConcurrentDictionary<string, string>();
        ConcurrentDictionary<string, aClass> classes = new ConcurrentDictionary<string, aClass>();

        public MainWindow()
        {
            InitializeComponent();
            ShowLogin();
            accounts.TryAdd("asd", "asd");
        }

        public void ShowRegister(){
            grid.Children.Clear();
            grid.Children.Add(register);
            pageStack.Push(register);
            currentPage = register;
        }

        public void ShowLogin(){
            grid.Children.Clear();
            grid.Children.Add(login);
            pageStack.Push(login);
            currentPage = login;
        }

        public void ShowHome()
        {
            grid.Children.Clear();
            grid.Children.Add(home);
            pageStack.Push(home);
            currentPage = home;
        }

        public void ShowCalendar()
        {
            grid.Children.Clear();
            grid.Children.Add(calendar);
            pageStack.Push(calendar);
            currentPage = calendar;
        }

        public void ShowCalendarDay()
        {
            grid.Children.Clear();
            grid.Children.Add(calendarDay);
            pageStack.Push(calendarDay);
            currentPage = calendarDay;
        }

        public void ShowMember()
        {
            grid.Children.Clear();
            grid.Children.Add(member);
            pageStack.Push(member);
            currentPage = member;
        }

        public void ShowMember(string className)
        {
            member.DisplayMembers(GetClass(className).Members);
            grid.Children.Clear();
            grid.Children.Add(member);
            pageStack.Push(member);
            currentPage = member;
        }

        public void ShowClassPage()
        {
            grid.Children.Clear();
            grid.Children.Add(classPage);
            pageStack.Push(classPage);
            currentPage = classPage;
        }

        public void ShowTaskPage()
        {
            grid.Children.Clear();
            grid.Children.Add(taskPage);
            pageStack.Push(taskPage);
            currentPage = taskPage;
        }

        public void ShowMessagePage()
        {
            grid.Children.Clear();
            grid.Children.Add(message);
            pageStack.Push(message);
            currentPage = message;
        }

        public void ShowMessagePage(string s)
        {
            /*if (!messages.ContainsKey(s))
            {
                curMessage = s;
                MessagePage test = message;
                
                string test2 = message.CurClass;
                message = new MessagePage();
                message.CurClass = test2;
                messages.TryAdd(s, test);
            }
            else
            {
                messages.TryGetValue(s, out message);
            }*/
            curMessage = s;

            if (messages.ContainsKey(s))
                messages.TryGetValue(s, out message);

            grid.Children.Clear();
            message.Title.Text = s;
            grid.Children.Add(message);
            pageStack.Push(message);
            currentPage = message;
        }
        public void ShowPrevPage()
        {
            if (pageStack.Count > 0)
            {
                grid.Children.Clear();
                if(pageStack.Peek().Equals(currentPage)) pageStack.Pop();
                currentPage = pageStack.Peek();
                grid.Children.Add(currentPage);
            }
        }

        // Sets the title in CalendayDay
        public void SetDate(String date)
        {
            calendarDay.SetDate(date);
        }

        // set class title
        public void SetClassTitle(String title)
        {
            classPage.SetTitle(title);
        }

        public void SetCurClass(String title)
        {
            message.CurClass = title;
            member.CurClass = title;
        }

        public void PopulateInfo(string taskTitle, string classTitle, string month, string day, string year, string d)
        {
            taskPage.PopulateInfo(taskTitle, classTitle, month, day, year, d);
        }



        public bool VerifyAccount(string username, string password)
        {
            if (accounts.ContainsKey(username) && accounts[username] == password) return true;
            else return false;
        }

        public bool CreateAccount(string username, string password)
        {
            if (accounts.ContainsKey(username)) return false;
            else
            {
                accounts.TryAdd(username, password);
                return true;
            }
        }

        public bool AddClass(string className)
        {
            if (!classes.ContainsKey(className))
            {
                aClass c = new aClass(className);
                classes.TryAdd(className, c);
                return true;
            }
            else return false;
        }

        public aClass GetClass(string className)
        {
            aClass aclass = new aClass("a");
            if (classes.TryGetValue(className, out aclass)) return aclass;
            else return aclass;
        }

        public bool ContainsTask(string s)
        {
            if (GetClass(message.CurClass).GetTask(s) != null) return true;
            else return false;
        }

        public void PokeMember(string task) {
            message.Add_Poke(task);
        }

        public void SetMessageState(Boolean a) {
            message.groupChat = a;
        }

        public void SaveMessage()
        {
            string test2 = message.CurClass;
            messages.TryAdd(curMessage, message);
            message = new MessagePage();
            message.CurClass = test2;
        }

    }
}
