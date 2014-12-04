using ProductionLtd;
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

namespace Projekt_Produktion__GUI_ex_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Controller _controller;
        public MainWindow()
        {
            InitializeComponent();
            _controller = new Controller();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            Admin_Site AS = new Admin_Site();
            AS.Show();
            this.Close();
        }
    }
}