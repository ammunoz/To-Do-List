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
    /// Interaction logic for AddTaskWindow.xaml
    /// </summary>
    public partial class AddTaskWindow : Window
    {
        public AddTaskWindow()
        {
            InitializeComponent();
        }

        public string TaskName
        {
            get { return addTaskBox.Text; }
        }

        private void addTaskBox_GotFocus(object sender, RoutedEventArgs e)
        {
            addTaskBox.Text = "";
        }

        private void description_GotFocus(object sender, RoutedEventArgs e)
        {
            description.Text = "";
        }

        private void description_LostFocus(object sender, RoutedEventArgs e)
        {
            if (description.Text == "") description.Text = "Description";
        }

        private void addTaskBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (addTaskBox.Text == "") addTaskBox.Text = "Task Name";
        }
    }
}
