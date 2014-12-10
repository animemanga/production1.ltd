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
using System.Data;
using System.Data.SqlClient;

namespace ProductionLtd
{
    /// <summary>
    /// Interaction logic for ChangeOrder.xaml
    /// </summary>
    public partial class ChangeOrder : Window
    {
        public ChangeOrder()
        {
            InitializeComponent();
            refreshDisplayData();
        }

        private void refreshDisplayData()
        {
            for (int i = 0; i < 10; i++)
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
                        SqlCommand cmd = new SqlCommand("PrintAllOrders", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("ID", i));
                        SqlDataReader rdr = cmd.ExecuteReader();
                        while (rdr.HasRows && rdr.Read())
                        {
                            OrderListePrintTextBox.Text += rdr["ID"].ToString() + ": " + rdr["Name"].ToString() + ", " + rdr["DeadLine"].ToString() + rdr["Pris"].ToString() + ", " + rdr["RistType"].ToString() + ", " + rdr["Antal"].ToString() + ", " + "\n";
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
    }
}
