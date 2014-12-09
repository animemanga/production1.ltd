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
    /// Interaction logic for EmployeeChange.xaml
    /// </summary>
    public partial class EmployeeChange : Window
    {
        string EmployeeType;
        string LaserCutterYN;
        string CNCFræserYN;
        string RemoveEmployeeID;
        int i;
        string EmployeeList;

        public EmployeeChange()
        {
            InitializeComponent();

            for (int i = 0; i < 100; i++)
            {
                {
                    SqlConnection conn = new SqlConnection(
                        "Server=ealdb1.eal.local;" +
                    "Database=EJL09_DB;" +
                    "User Id=ejl09_usr;" +
                    "Password=Baz1nga9;");
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("PrintAllEmployees", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("ID", i));
                        SqlDataReader rdr = cmd.ExecuteReader();
                        while (rdr.HasRows && rdr.Read())
                        {
                            EmployeeListeTextBlock.Text += rdr["ID"].ToString() + ": " + rdr["Name"].ToString() + ", " + rdr["EmployeeType"].ToString() + "\n";
                        }
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
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
             {
                 SqlConnection conn = new SqlConnection(
                
                     "Server=ealdb1.eal.local;" +
                     "Database=EJL09_DB;" +
                     "User Id=ejl09_usr;" +
                     "Password=Baz1nga9;");
                 try
                 {
                     conn.Open();


                     SqlCommand cmd = new SqlCommand("AddEmployee", conn);
                     cmd.CommandType = CommandType.StoredProcedure;
                     
                     cmd.Parameters.Add(new SqlParameter("@EmployeeTypen", EmployeeType));
                     cmd.Parameters.Add(new SqlParameter("@Name", NameTextBox.Text));
                     cmd.Parameters.Add(new SqlParameter("@LaserCutter", LaserCutterYN));
                     cmd.Parameters.Add(new SqlParameter("@CNCFræser", CNCFræserYN));

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
        }

        private void AdminButton_Click(object sender, RoutedEventArgs e)
        {
            EmployeeType = "Admin";
        }

        private void ProduktionsarbejderButton_Click(object sender, RoutedEventArgs e)
        {
            EmployeeType = "Produktionarbejder";
        }

        private void SælgerButton_Click(object sender, RoutedEventArgs e)
        {
            EmployeeType = "Sælger";
        }

        private void AndetButton_Click(object sender, RoutedEventArgs e)
        {
            EmployeeType = "Andet";
        }

        private void LaserCutterYesbutton_Click(object sender, RoutedEventArgs e)
        {
            LaserCutterYN = "Yes";
        }

        private void LaserCutterNobutton_Click(object sender, RoutedEventArgs e)
        {
            LaserCutterYN = "No";
        }

        private void CNCFræserYesbutton_Click(object sender, RoutedEventArgs e)
        {
            CNCFræserYN = "Yes";
        }

        private void CNCFræserNobutton_Click(object sender, RoutedEventArgs e)
        {
            CNCFræserYN = "No";
        }

        private void RemoveEmployeeButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                RemoveEmployeeID = RemovedEmployeeNumberTextbox.Text;
                i = int.Parse(RemoveEmployeeID);
            }
            catch (Exception l)
            {
                string ll = l.ToString();
                System.Windows.MessageBox.Show(ll);
            }
            {
                SqlConnection conn = new SqlConnection(
                    "Server=ealdb1.eal.local;" +
                "Database=EJL09_DB;" +
                "User Id=ejl09_usr;" +
                "Password=Baz1nga9;");
                try
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("RemoveEmployee", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@ID", i));

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
        }

        private void ReturnButton_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            Admin_Site AS = new Admin_Site();
            AS.ShowDialog();
        }

    }
}
