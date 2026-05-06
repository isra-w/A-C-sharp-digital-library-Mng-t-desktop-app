using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;

namespace d.labdemo.DB
{
    static class DBConnection
    {
        static string connectionString = @"Data Source=HP-ELITE;Initial Catalog=d_lab;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        public static SqlConnection checkConnection = new SqlConnection(connectionString);
        public static void intiate()
        {
            try
            {
                checkConnection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"unable to connect to database: \n{ex.Message}", "db error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
