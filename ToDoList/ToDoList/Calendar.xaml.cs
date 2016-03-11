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
    /// Interaction logic for Calendar.xaml
    /// </summary>
    public partial class Calendar : UserControl
    {
        MainWindow w;

        String[] Months = new String[12] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };


        public Calendar()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            w = Window.GetWindow(this) as MainWindow;
            w.ShowHome();
        }

        private void calendar_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            String date = "";
            w = Window.GetWindow(this) as MainWindow;

            // set up date
            date += Months[calendar.SelectedDate.Value.Month];
            date += " " + calendar.SelectedDate.Value.Day.ToString();            
            w.SetDate(date);

            w.ShowCalendarDay();
        }

        private void Members_Click(object sender, RoutedEventArgs e)
        {
            w = Window.GetWindow(this) as MainWindow;
            w.ShowMember();
        }

     

    }
}
