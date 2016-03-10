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
    /// Interaction logic for RegisterPage.xaml
    /// </summary>
    public partial class RegisterPage : UserControl
    {
        MainWindow w;
        public RegisterPage()
        {
            InitializeComponent();
        }
        private void usernameBox_GotFocus(object sender, RoutedEventArgs e)
        {
            usernameBox.Text = "";
        }
        private void usernameBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (usernameBox.Text == "") usernameBox.Text = "Username";
        }

        private void passwordLabel_GotFocus(object sender, RoutedEventArgs e)
        {
            passwordLabel.Visibility = Visibility.Hidden;
            passwordLabel.IsEnabled = false;
        }

        private void passwordLabel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            passwordLabel.Visibility = Visibility.Hidden;
            passwordLabel.IsEnabled = false;
            passwordBox.Focus();
        }

        private void passwordBox_GotFocus(object sender, RoutedEventArgs e)
        {
            passwordLabel.Visibility = Visibility.Hidden;
            passwordLabel.IsEnabled = false;
        }

        
        private void passwordBox_LostFocus(object sender, RoutedEventArgs e)
        {
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            w = Window.GetWindow(this) as MainWindow;
            w.ShowLogin();
        }

        private void firstNameBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (firstNameBox.Text == "First Name") firstNameBox.Text = "";
        }

        private void firstNameBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (firstNameBox.Text == "") firstNameBox.Text = "First Name";
        }

        private void lastNameBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (lastNameBox.Text == "Last Name") lastNameBox.Text = "";
        }
        private void lastNameBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (lastNameBox.Text == "") lastNameBox.Text = "Last Name";
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            w = Window.GetWindow(this) as MainWindow;
            if (usernameBox.Text != "Username" && passwordBox.Password != "")
            {
                firstNameBox.Text = "ASDASDASD";
                if (w.CreateAccount(usernameBox.Text, passwordBox.Password)) w.ShowLogin();
            }
        }

        

        
    }
}
