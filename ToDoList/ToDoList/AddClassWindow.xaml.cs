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
    /// Interaction logic for AddClassWindow.xaml
    /// </summary>
    public partial class AddClassWindow : Window
    {
        List<string> members;
        public AddClassWindow()
        {
            InitializeComponent();
            members = new List<string>();
        }

        private void addClassBox_GotFocus(object sender, RoutedEventArgs e)
        {
            addClassBox.Text = "";
        }

        private void addClassBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (addClassBox.Text == "") addClassBox.Text = "Class Name";
        }

        private void doneButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void Window_ContentRendered(object sender, EventArgs e)
        {
            addClassBox.SelectAll();
            addClassBox.Focus();
        }

        //returns class name
        public string ClassName
        {
            get { return addClassBox.Text; }
        }

        //returns members
        public List<string> Members
        {
            get
            {
                return members;
            }
        }

        private void doneButton_Click(object sender, RoutedEventArgs e)
        {
            StackPanel stack = (StackPanel)this.FindName("memberList");
            foreach (CheckBox c in stack.Children)
            {
                TextBlock t = (TextBlock)c.Content;
                if (c.IsChecked == true) members.Add(t.Text);
            }
            this.DialogResult = true;
        }
    }
}
