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
    /// Interaction logic for Workingplan.xaml
    /// </summary>
    public partial class Workingplan : Window
    {
        public Workingplan()
        {
            InitializeComponent();            
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            Admin_Site AS = new Admin_Site();
            AS.ShowDialog();
        }
    }
}
