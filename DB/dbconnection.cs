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
               // if(checkConnection = !)
                checkConnection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"unable to connect database\n {ex.Message} ", "DB ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public static int ExecuteNonQuery(string query)
        {
            /*throw new NotImplementedException();*/
            SqlCommand sqlCommand = new SqlCommand(query, checkConnection);// it's used to send the query commands to the database
            return sqlCommand.ExecuteNonQuery();
        }
    }
}
