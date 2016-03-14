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

        public TaskWindow()
        {
            InitializeComponent();
        }

        public void SetTitle(String title)
        {
            Title.Text = title;
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            w = Window.GetWindow(this) as MainWindow;
            w.ShowPrevPage();
        }

        private void calendar_Click(object sender, RoutedEventArgs e)
        {
            w = Window.GetWindow(this) as MainWindow;
            w.ShowCalendar(); ;
        }
    }
}
