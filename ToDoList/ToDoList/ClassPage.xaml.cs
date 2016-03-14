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
    /// Interaction logic for ClassPage.xaml
    /// </summary>
    public partial class ClassPage : UserControl
    {

        MainWindow w;

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

        private void calendar_Click(object sender, RoutedEventArgs e)
        {
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
                Button button = new Button
                {

                    Content = addTaskWindow.TaskName,
                    HorizontalAlignment = HorizontalAlignment.Stretch,
                    FontWeight = FontWeights.Bold,
                    Background = Brushes.White,
                    BorderThickness = new System.Windows.Thickness(0)
                };
                //button.Click += new RoutedEventHandler(classButton_Click);

                classStackPanel.Children.Add(button);
            }
        }
    }
}