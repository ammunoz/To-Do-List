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
    /// Interaction logic for MemberPage.xaml
    /// </summary>
    public partial class MemberPage : UserControl
    {
        public string CurClass;

        public MemberPage()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow w = Window.GetWindow(this) as MainWindow;
            w.ShowPrevPage();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            string st = button.Content.ToString();
            MainWindow w = Window.GetWindow(this) as MainWindow;
            if (st == "Class Chat")
            {
                w.SetMessageState(true);
            }
            else
            {
                w.SetMessageState(false);
            }

           
            Button b = (Button)sender;
            w.ShowMessagePage(b.Content.ToString());
        }

        public void DisplayMembers()
        {
            var bc = new BrushConverter();
            Button b = new Button
            {
                Content = "Class Chat",
                HorizontalAlignment = HorizontalAlignment.Left,
                VerticalAlignment = VerticalAlignment.Top,
                Width = 280,
                Height = 75,
                FontSize = 33,
                Background = Brushes.White,
            };

            b.Click += new RoutedEventHandler(button_Click);
            stack.Children.Add(b);

        }

        public void DisplayMembers(List<string> members)
        {
            stack.Children.Clear();
            var bc = new BrushConverter();
            Button b = new Button
            {
                Content = "Class Chat",
                HorizontalAlignment = HorizontalAlignment.Left,
                VerticalAlignment = VerticalAlignment.Top,
                Width = 280,
                Height = 75,
                FontSize = 33,
                Background = Brushes.White,
            };
            b.Click += new RoutedEventHandler(button_Click);
            stack.Children.Add(b);
            foreach (string member in members)
            {
                b = new Button {
                    Content = member,
                    HorizontalAlignment = HorizontalAlignment.Left,
                    VerticalAlignment = VerticalAlignment.Top,
                    Width = 280,
                    Height = 75,
                    FontSize = 33,
                    Background = Brushes.White,
                    Foreground = (Brush)bc.ConvertFrom("#FFA0E6FB"),

                };
                b.Click += new RoutedEventHandler(button_Click);
                stack.Children.Add(b);
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            NotImplementedWindow addTaskWindow = new NotImplementedWindow();

            if (addTaskWindow.ShowDialog() == true)
            {

            }
        }
    }
}
