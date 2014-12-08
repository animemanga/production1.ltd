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
using System.Data;
using System.Data.SqlClient;

namespace ProductionLtd
{
    /// <summary>
    /// Interaction logic for Admin_Site.xaml
    /// </summary>
    public partial class Admin_Site : Window
    {
        public Admin_Site()
        {
            InitializeComponent();
        }

        private void LogOut_Click(object sender, RoutedEventArgs e)
        {
            LoginScreen LS = new LoginScreen();
            this.Close();
            LS.Visibility = Visibility.Visible;
        }

        private void AddEmployee_Click(object sender, RoutedEventArgs e)
        {

            Controller.addEmployee();
            
        }
    }
}
