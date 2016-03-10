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
