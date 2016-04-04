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
        MainWindow w;
        BrushConverter bc = new BrushConverter();
        public HomePage()
        {
            InitializeComponent();
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

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            w = Window.GetWindow(this) as MainWindow;
            w.ShowLogin();
        }

        private void MenuItem_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void addClassButton_Click(object sender, RoutedEventArgs e)
        {
            w = Window.GetWindow(this) as MainWindow;
            AddClassWindow addClassWindow = new AddClassWindow();
            addClassWindow.Owner = w;
            addClassWindow.ShowInTaskbar = false;
            addClassWindow.ResizeMode = ResizeMode.NoResize;

            if (addClassWindow.ShowDialog() == true)
            {
                if (w.AddClass(addClassWindow.ClassName))
                {
                    Button button = new Button
                    {
                        Content = addClassWindow.ClassName,
                        FontSize = 30,
                        HorizontalAlignment = HorizontalAlignment.Stretch,
                        FontWeight = FontWeights.Bold,
                        Background = Brushes.White,
                        BorderThickness = new System.Windows.Thickness(2),
                        BorderBrush = (Brush)bc.ConvertFrom("#FF8EE3FC"),
                        Foreground = (Brush)bc.ConvertFrom("#FF8EE3FC"),
                        Height = 75
                    };
                    button.Click += new RoutedEventHandler(classButton_Click);
                    classStackPanel.Children.Add(button);

                    w.GetClass(addClassWindow.ClassName).Members = addClassWindow.Members;
                    w.initializeMessage(addClassWindow.ClassName);
                }
                
            }
        }

        // Click event handler for created class buttons
        private void classButton_Click(object sender, RoutedEventArgs e)
        {
            w = Window.GetWindow(this) as MainWindow;
            string title = (sender as Button).Content.ToString();
            w.SetClassTitle(title);
            w.ShowClassPage();
        }

        // edit
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
    }
}
