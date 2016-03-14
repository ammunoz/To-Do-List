using System;
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
        ClassPage classPage = new ClassPage();
        TaskWindow taskPage = new TaskWindow();
        UserControl currentPage;

        Stack<UserControl> pageStack = new Stack<UserControl>();
        Dictionary<string, string> accounts = new Dictionary<string, string>();
        Dictionary<string, aClass> classes = new Dictionary<string, aClass>();
        Dictionary<string, aTask> tasks  = new Dictionary<string, aTask>();


        public MainWindow()
        {
            InitializeComponent();
            ShowLogin();
            accounts.Add("asd", "asd");
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

        public void SetTaskTitle(String title)
        {
            taskPage.SetTitle(title);
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
                accounts.Add(username, password);
                return true;
            }
        }

        public bool AddClass(string className)
        {
            if (!classes.ContainsKey(className))
            {
                aClass c = new aClass(className);
                classes.Add(className, c);
                return true;
            }
            else return false;
        }
    }
}
