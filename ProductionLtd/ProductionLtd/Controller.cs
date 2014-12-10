using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProductionLtd
{
    class Controller
    {
        static List<Employee> employeeListe;
        public Controller()
        {
            employeeListe = new List<Employee>();

            // code that add employee from database to the employee class
        }
        public static void HandleWorkplan()
        {
            GetEmployeesfromDatabase();
            GetordersfromDatabase();

            buildWorkplan();
        }
        public static void buildWorkplan()
        {

            /*
             * vælg en mængde ansatte med alle som standard
             * se liste af ordre igennem 
             * vælg den med nærmest deadline
             * se på orderens process
             * set dene process øverst på en kvalificeret ansats workplan
             * gennegå førnævnte trin med næste odres nærmeste deadline
             * 
            */
        }
        public static void GetordersfromDatabase()
        {

            SqlConnection conn = new SqlConnection(
                "Server=ealdb1.eal.local;" +
                "Database=EJL09_DB;" +
                "User Id=ejl09_usr;" +
                "Password=Baz1nga9;");

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("PrintAllOrders", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.HasRows && rdr.Read())
                {
                    string ID = rdr["ID"].ToString();
                    string Name = rdr["Name"].ToString();
                    string DeadLine = rdr["DeadLine"].ToString();
                    string Pris = rdr["Pris"].ToString();
                    string Risttype = rdr["RistType"].ToString();
                    string Antal = rdr["Antal"].ToString();
                    Order Order = new Order(int.Parse(ID), Name, DeadLine, int.Parse(Pris), Risttype, Antal);
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



        public static void GetEmployeesfromDatabase()
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
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.HasRows && rdr.Read())
                {
                    string ID = rdr["ID"].ToString();
                    string Name = rdr["Name"].ToString();
                    string EmployeeType = rdr["EmployeeType"].ToString();
                    string LaserCutter = rdr["LaserCutter"].ToString();
                    string CNCFræser = rdr["CNCFræser"].ToString();

                    Employee employee = new Employee(int.Parse(ID), Name , EmployeeType, LaserCutter, CNCFræser);
                    employeeListe.Add(employee);
                    
                }
                //for (int i = 0; i < employeeListe.Count; i++)
                //{
                //    System.Windows.MessageBox.Show(employeeListe[i].Name);
                //}
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
