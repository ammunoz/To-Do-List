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
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : UserControl
    {
        public HomePage()
        {
            InitializeComponent();
            menuBorder.Visibility = Visibility.Hidden;
            addBorder.Visibility = Visibility.Hidden;

        }

        private void Menu_MouseEnter(object sender, MouseEventArgs e)
        {
            
        }

        private void Menu_MouseLeave(object sender, MouseEventArgs e)
        {

            menuBorder.Visibility = Visibility.Hidden;
        }

        private void menuLabel_MouseEnter(object sender, MouseEventArgs e)
        {
            menuBorder.Visibility = Visibility.Visible;
        }

        private void createLabel_MouseEnter(object sender, MouseEventArgs e)
        {
            addBorder.Visibility = Visibility.Visible;
        }

        private void addBorder_MouseLeave(object sender, MouseEventArgs e)
        {
            addBorder.Visibility = Visibility.Hidden;
        }

 



        

    }
}
