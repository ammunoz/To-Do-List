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
using System.Windows.Shapes;

namespace ToDoList
{
    /// <summary>
    /// Interaction logic for AddClassWindow.xaml
    /// </summary>
    public partial class AddClassWindow : Window
    {
        public AddClassWindow()
        {
            InitializeComponent();
        }

        private void addClassBox_GotFocus(object sender, RoutedEventArgs e)
        {
            addClassBox.Text = "";
        }

        private void addClassBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (addClassBox.Text == "") addClassBox.Text = "Class Name";
        }

        private void doneButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void Window_ContentRendered(object sender, EventArgs e)
        {
            addClassBox.SelectAll();
            addClassBox.Focus();
        }

        public string ClassName
        {
            get { return addClassBox.Text; }
        }

        private void doneButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
    }
}
