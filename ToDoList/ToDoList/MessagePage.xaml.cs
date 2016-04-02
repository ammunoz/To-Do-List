﻿using System;
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
        List<String> messages;
        string curClass;
        public string CurClass
        {
            get { return this.curClass; }
            set { this.curClass = value; }
        }


        public MessagePage()
        {
            InitializeComponent();
            messages = new List<String>();
            messages.Add("Okay!");
            messages.Add("I'm just about done!");
            messages.Add("Uhh.. Later");
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow w = Window.GetWindow(this) as MainWindow;
            w.ShowPrevPage();
        }

        private bool RefersToTask(string st) {

            // future use? 	Substring(Int32, Int32) (start, end)
            MainWindow w = Window.GetWindow(this) as MainWindow;

           string check = "";

            bool a = false;

            for(int i = 0; i < st.Length; i++)
            {
                if (st[i] == '@' && !a)
                {
                    a = true;
                }
                else if (a && st[i] != ' ') {
                    check += st[i];
                }else if(a && st[i] == ' ')
                {
                    break;
                }

            }

            Title.Text = check;
            return w.ContainsTask(check);


            /*
            string[] ss = st.Split(' ');
            foreach (string s in ss) {
                if (s[0] != '@') { continue; }
                else
                {
                    if (w.ContainsTask(s.Substring(1)))
                    {
                        return true;
                    }
                }
            }
            return false;*/
        }

        private string PickMessage() {
            Random r = new Random();
            return messages[r.Next(0, messages.Count)];
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

            Border mBorder = new Border
            {
                BorderBrush = Brushes.Black,
                Background = Brushes.White,
                BorderThickness = new Thickness(1),
                CornerRadius = new CornerRadius(10),
            };
            Label label = new Label
            {
                Content = PickMessage(),
                HorizontalAlignment = HorizontalAlignment.Left,
                FontSize = 14
            };
            mBorder.Child = label;
            MessagePanel.Children.Add(mBorder);

            if (RefersToTask(MessageBox.Text)) Title.Text = "TRUE";

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
