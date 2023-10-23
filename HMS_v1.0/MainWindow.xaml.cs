﻿using System.Windows;
using System.Windows.Input;


namespace HMS_v1._0
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //InitializeComponent();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Registration registration = new();
            registration.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Appointment appointment = new();
            appointment.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Forms forms = new();
            forms.Show();
        }
    }
}
