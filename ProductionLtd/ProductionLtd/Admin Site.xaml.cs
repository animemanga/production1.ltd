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

namespace ProductionLtd
{
    /// <summary>
    /// Interaction logic for Admin_Site.xaml
    /// </summary>
    public partial class Admin_Site : Window
    {
        Controller _controller;
        public Admin_Site()
        {
            InitializeComponent();
            _controller = new Controller();
        }


        private void LogOut_Click(object sender, RoutedEventArgs e)
        {
            LoginScreen LS = new LoginScreen();
            this.Close();
            LS.Visibility = Visibility.Visible;
        }


        private void PrintWorkplan_Click(object sender, RoutedEventArgs e)
        {
            //Change site by writing the name of the site you want to go to,- 
            //and then tell the program that you want to switch, by writting Showdialog.
            this.Visibility = Visibility.Hidden;
            Workingplan Wp = new Workingplan();
            Wp.ShowDialog();
        }

        private void ChangeOrder_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            ChangeOrder AC = new ChangeOrder();
            AC.ShowDialog();
        }

        private void MakeOrder_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            ChangeOrder AC = new ChangeOrder();
            AC.ShowDialog();
        }

        private void RemoveEmployee_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            EmployeeChange AC = new EmployeeChange();
            AC.ShowDialog();
        }

        private void AddEmployee_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            EmployeeChange AC = new EmployeeChange();
            AC.ShowDialog();
        }
    }
}
