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

        public void PopulateInfo(string taskTitle, string classTitle, string month, string day, string year, string d)
        {
            Title.Text = taskTitle;
            className = classTitle;

            w = Window.GetWindow(this) as MainWindow;
            Month.SelectedItem = month;
            Month.Text = month;
            Day.Text = day; 
            Year.Text = year; 
            description.Text = d;

        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            w = Window.GetWindow(this) as MainWindow;
            w.ShowPrevPage();
        }

        private void calendar_Click(object sender, RoutedEventArgs e)
        {
            CalendarWarning addTaskWindow = new CalendarWarning();

            if (addTaskWindow.ShowDialog() == true)
            {

            }

            w = Window.GetWindow(this) as MainWindow;
            w.ShowCalendar();
        }

        private void member_Click(object sender, RoutedEventArgs e)
        {
            w = Window.GetWindow(this) as MainWindow;
            w.ShowMember(className);
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

        private void Poke_Click(object sender, RoutedEventArgs e)
        {
            w = Window.GetWindow(this) as MainWindow;
            w.PokeMember(Title.Text);

            PokeWindow addTaskWindow = new PokeWindow();
            addTaskWindow.Owner = w;
            addTaskWindow.ShowInTaskbar = false;
            addTaskWindow.ResizeMode = ResizeMode.NoResize;

            if (addTaskWindow.ShowDialog() == true)
            {

            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            CalendarWarning addTaskWindow = new CalendarWarning();

            if (addTaskWindow.ShowDialog() == true)
            {

            }
        }
    }
}
