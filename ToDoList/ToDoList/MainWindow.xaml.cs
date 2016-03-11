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

        // make a PREV variable in each .CS file?
        // then we just make a global switch case?
        // Switch.CS and we call functions in it which calls functions in MainWindow? ._.

        // HOW DO WE GO BACK TO THE RIGHT USER INTERFACE AS THE PROGRAM GETS BIGGER?
        // MY IDEA WAS A SWITCH CASE BUT WE HAVE TO MAKE IT FOR EACH .XAML
        // IF WE ONLY DO IT HERE WE CAN ONLY GO BACK 1 STEP
        /*
        // way to keep track of back
        int REGISTER = 0;
        int LOGIN = 1;
        int HOME = 2;
        // int CLASS = 3;
        // int TASK = 4;
        int CALENDAR = 5;
        int CALENDAR_DAY = 6;
        int MEMBER = 7;

        string PREV_PAGE = "home";
        */

        Dictionary<string, string> accounts = new Dictionary<string, string>();
        public MainWindow()
        {
            InitializeComponent();
            ShowLogin();
            accounts.Add("asd", "asd");
        }

        public void ShowRegister(){
            grid.Children.Clear();
            grid.Children.Add(register);
        }

        public void ShowLogin(){
            grid.Children.Clear();
            grid.Children.Add(login);
        }

        public void ShowHome()
        {
            grid.Children.Clear();
            grid.Children.Add(home);
        }

        public void ShowCalendar()
        {
            grid.Children.Clear();
            grid.Children.Add(calendar);
        }

        public void ShowCalendarDay()
        {
            grid.Children.Clear();
            grid.Children.Add(calendarDay);
            
        }

        public void ShowMember()
        {
            grid.Children.Clear();
            grid.Children.Add(member);

        }

        // Sets the title in CalendayDay
        public void SetDate(String date)
        {
            calendarDay.SetDate(date);
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
    }
}
