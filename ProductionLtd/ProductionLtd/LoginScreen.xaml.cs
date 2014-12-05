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
using System.Windows.Shapes;

namespace ProductionLtd
{
    /// <summary>
    /// Interaction logic for LoginScreen.xaml
    /// </summary>
    public partial class LoginScreen : Window
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        internal void LoginAdmin()
        {
            if ((UserName.Text.Length <= 4) || (PassWord.Text.Length <= 4))
            {
                MessageBox.Show("You have to type in the correct username and password", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
                if ((UserName.Text == "Admin") && (PassWord.Text == "1234Admin" ))
                {
                    this.Visibility = Visibility.Hidden;
                    Admin_Site AS = new Admin_Site();
                    AS.ShowDialog();
                }
                else
                    if ((UserName.Text == "Buisness") && (PassWord.Text == "1234Buisness"))
                    {
                        this.Visibility = Visibility.Hidden;
                        BuisnessSite BS = new BuisnessSite();
                        BS.ShowDialog();
                    }
                    else
                        if ((UserName.Text == "Employee") && (PassWord.Text == "1234Employee"))
                        {
                            this.Visibility = Visibility.Hidden;
                            WorkingPlan WP = new WorkingPlan();
                            WP.ShowDialog();
                        }

                    else
                    {
                        MessageBox.Show("DAMN!");
                    }
        }
        private void Login_Click(object sender, RoutedEventArgs e)
        {
            try { LoginAdmin(); }
            catch (Exception) { }
        }
    }
}