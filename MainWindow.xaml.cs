﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HCI12
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            progressBar1.Value -= 5;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            progressBar1.Value += 5;
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void progressBar1_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            progressBar1.Value += e.Delta/100;
        }
    }
}
