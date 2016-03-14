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
    /// Interaction logic for TaskWindow.xaml
    /// </summary>
    public partial class TaskWindow : UserControl
    {
        MainWindow w;
        string className;

        public TaskWindow()
        {
            InitializeComponent();
        }

        public void PopulateInfo(string taskTitle, string classTitle)
        {
            Title.Text = taskTitle;
            className = classTitle;

            w = Window.GetWindow(this) as MainWindow;
            aClass c = w.GetClass(classTitle);

            if (c != null)
            {
                aTask task = c.GetTask(Title.Text);
                if (task != null)
                {
                    string[] info = task.GetInfo();
                    Month.SelectedItem = info[0];
                    Day.SelectedItem = info[1];
                    Year.SelectedItem = info[2];
                    description.Text = info[3];
                }
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            w = Window.GetWindow(this) as MainWindow;
            w.ShowPrevPage();
        }

        private void calendar_Click(object sender, RoutedEventArgs e)
        {
            w = Window.GetWindow(this) as MainWindow;
            w.ShowCalendar();
        }

        private void member_Click(object sender, RoutedEventArgs e)
        {
            w = Window.GetWindow(this) as MainWindow;
            w.ShowMember(); ;
        }

        private void description_LostFocus(object sender, RoutedEventArgs e)
        {
            if (description.Text == "") description.Text = "Description";
        }

        private void description_GotFocus(object sender, RoutedEventArgs e)
        {
            if (description.Text == "Description") description.Text = "";
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            w = Window.GetWindow(this) as MainWindow;
            w.GetClass(className).GetTask(Title.Text).ModifyTask(Month.SelectedItem.ToString(), Day.SelectedItem.ToString(), Year.SelectedItem.ToString(), description.Text);
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            w = Window.GetWindow(this) as MainWindow;
            w.ShowPrevPage();
        }
    }
}
