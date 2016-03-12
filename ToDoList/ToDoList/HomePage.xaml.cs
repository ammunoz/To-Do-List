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

        public HomePage()
        {
            InitializeComponent();

        }


        private void calendar_Click(object sender, RoutedEventArgs e)
        {
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
            test.Content = "HELLO";
            w = Window.GetWindow(this) as MainWindow;
            AddClassWindow addClassWindow = new AddClassWindow();
            addClassWindow.Owner = w;
            addClassWindow.ShowInTaskbar = false;
            addClassWindow.ResizeMode = ResizeMode.NoResize;

            if (addClassWindow.ShowDialog() == true)
            {
                w.AddClass(addClassWindow.ClassName);
                classStackPanel.Children.Add(new Label { Content = addClassWindow.ClassName });
            }
        }

 



        

    }
}
