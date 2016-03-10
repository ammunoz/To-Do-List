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
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : UserControl
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void usernameBox_GotFocus(object sender, RoutedEventArgs e)
        {
            usernameBox.Text = "";
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

        private void usernameBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (usernameBox.Text == "") usernameBox.Text = "Username";
        }

        private void passwordBox_LostFocus(object sender, RoutedEventArgs e)
        {
        }
    }
}
