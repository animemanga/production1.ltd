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
    /// Interaction logic for MakeOrder.xaml
    /// </summary>
    public partial class MakeOrder : Window
    {
        public MakeOrder()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            Admin_Site AS = new Admin_Site();
            AS.ShowDialog();
        }

        private void AddOrderButtom_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection conn = new SqlConnection(
                "Server=ealdb1.eal.local;" +
            "Database=EJL09_DB;" +
            "User Id=ejl09_usr;" +
            "Password=Baz1nga9;");
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("AddOrder", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@Name", OrderTextBox.Text));
                cmd.Parameters.Add(new SqlParameter("@DeadLine", SlutDatoTextBox.Text));
                cmd.Parameters.Add(new SqlParameter("@Pris", PrisTextBox.Text));
                cmd.Parameters.Add(new SqlParameter("@RistType", ValgtRistTextBox.Text));
                cmd.Parameters.Add(new SqlParameter("@Antal", AntalTextBox.Text));


                cmd.ExecuteNonQuery();
            }
            catch (Exception k)
            {
                string kk = k.ToString();
                System.Windows.MessageBox.Show(kk);
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }

        private void Type1Button_Click(object sender, RoutedEventArgs e)
        {
            ValgtRistTextBox.Text = "Rist type 1";
        }

        private void Type2Button_Click(object sender, RoutedEventArgs e)
        {
            ValgtRistTextBox.Text = "Rist type 2";
        }

        private void Type3Button_Click(object sender, RoutedEventArgs e)
        {
            ValgtRistTextBox.Text = "Rist type 3";
        }

        private void KundebestemtButton_Click(object sender, RoutedEventArgs e)
        {
            ValgtRistTextBox.Text = "Special bestilt";
        }

    }
}
