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
    /// Interaction logic for MessagePage.xaml
    /// </summary>
    public partial class MessagePage : UserControl
    {

        MainWindow w;

        public MessagePage()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow w = Window.GetWindow(this) as MainWindow;
            w.ShowPrevPage();
        }

        private void SendButton_Click(object sender, RoutedEventArgs e)
        {
			Border myBorder = new Border{
				BorderBrush = Brushes.Black,
				Background = Brushes.White,
				BorderThickness = new Thickness(1),
				CornerRadius = new CornerRadius(10),
				
			};
			Label myLabel = new Label{
                Content = MessageBox.Text,
                HorizontalAlignment = HorizontalAlignment.Right,
				FontSize = 14,
				
            };
			
			myBorder.Child = myLabel;
			
			MessagePanel.Children.Add(myBorder);
			
            /*MessagePanel.Children.Add(new Label
            {
                Content = MessageBox.Text,
                HorizontalAlignment = HorizontalAlignment.Right,
				FontSize = 30,
				
            });*/
            MessageBox.Text = "";
            MessageBox.Focus();
        }
    }
}
