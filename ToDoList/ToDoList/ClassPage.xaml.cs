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
    /// Interaction logic for ClassPage.xaml
    /// </summary>
    public partial class ClassPage : UserControl
    {

        MainWindow w;
		BrushConverter bc = new BrushConverter();
        string month, day, year, d, mem;
        
        // class data


        public ClassPage()
        {

            InitializeComponent();
           
        }

        public void SetTitle(String title) {
            Title.Text = title;
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            w = Window.GetWindow(this) as MainWindow;
            w.ShowPrevPage();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            NotImplementedWindow addTaskWindow = new NotImplementedWindow();

            if (addTaskWindow.ShowDialog() == true)
            {

            }
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            NotImplementedWindow addTaskWindow = new NotImplementedWindow();

            if (addTaskWindow.ShowDialog() == true)
            {

            }
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

        private void addClassButton_Click(object sender, RoutedEventArgs e)
        {
            w = Window.GetWindow(this) as MainWindow;
            AddTaskWindow addTaskWindow = new AddTaskWindow();
            addTaskWindow.Owner = w;
            addTaskWindow.ShowInTaskbar = false;
            addTaskWindow.ResizeMode = ResizeMode.NoResize;
            
            if (addTaskWindow.ShowDialog() == true)
            {
                if (w.GetClass(Title.Text).AddTask(addTaskWindow.TaskName, addTaskWindow.Month.Text,
                    addTaskWindow.Day.Text, addTaskWindow.Year.Text,
                    addTaskWindow.description.Text))
                {
                    month = addTaskWindow.Month.Text;
                    day = addTaskWindow.Day.Text;
                    year = addTaskWindow.Year.Text;
                    d = addTaskWindow.description.Text;
                    
                    Button button = new Button
                    {
						
                        Content = addTaskWindow.TaskName,
						FontSize = 30,
                        HorizontalAlignment = HorizontalAlignment.Stretch,
                        FontWeight = FontWeights.Bold,
                        Background = Brushes.White,
                        BorderThickness = new System.Windows.Thickness(2),
                        BorderBrush = (Brush)bc.ConvertFrom("#FF8EE3FC"),
                        Foreground = (Brush)bc.ConvertFrom("#FF8EE3FC"),
                        Height = 75
                    };
                    button.Click += new RoutedEventHandler(taskButton_Click);

                    classStackPanel.Children.Add(button);
                }
            }
        }

        private void taskButton_Click(object sender, RoutedEventArgs e)
        {
            w = Window.GetWindow(this) as MainWindow;
            string title = (sender as Button).Content.ToString();
            w.SetCurClass(Title.Text);
            w.PopulateInfo(title, Title.Text, month, day, year, d);
            w.ShowTaskPage();
            
            // 1. Open Task create page - e.g., AddClassWindow
            // 2. Create aTask object with info from Task create page - aTask constructor takes string. e.g., aTask task = new aTask("task name");
            // 3. Add any members to aTask. e.g., task.AddMember(member1)
            // 4. Add created aTask object to selected aClass. i.e., class.AddTask(aTask)
        }

        private void member_Click(object sender, RoutedEventArgs e)
        {
            w = Window.GetWindow(this) as MainWindow;
            w.SetCurClass(Title.Text);
            w.ShowMember(Title.Text);
        }
    }

}
