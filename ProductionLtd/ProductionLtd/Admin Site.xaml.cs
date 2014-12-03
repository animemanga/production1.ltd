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
using Sælger;

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

        private void LogOff_Click(object sender, RoutedEventArgs e)
        {
            MainWindow MW = new MainWindow();
            MW.Show();
            this.Close();
        }
    }
}
