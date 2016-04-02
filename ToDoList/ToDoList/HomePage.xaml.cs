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
                }

                // add the members
                w.GetClass(addClassWindow.ClassName).members = addClassWindow.Members;

                // test member
                Title.Text = w.GetClass(addClassWindow.ClassName).members[1];
            }
        }

        // Click event handler for created class buttons
        private void classButton_Click(object sender, RoutedEventArgs e)
        {
            w = Window.GetWindow(this) as MainWindow;
            string title = (sender as Button).Content.ToString();
            w.SetClassTitle(title);
            w.ShowClassPage();
            // 1. Open Task create page - e.g., AddClassWindow
            // 2. Create aTask object with info from Task create page - aTask constructor takes string. e.g., aTask task = new aTask("task name");
            // 3. Add any members to aTask. e.g., task.AddMember(member1)
            // 4. Add created aTask object to selected aClass. i.e., class.AddTask(aTask)
        }

    }
}
