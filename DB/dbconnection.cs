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
        public static string connectionString
        {
            get
            {
                return @"Data Source=HP-ELITE;Initial Catalog=d_lab;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
            }
        }

        public static SqlConnection checkConnection = new SqlConnection(connectionString);

        public static void Initiate()  // Fixed spelling: intiate → Initiate
        {
            try
            {
                if (checkConnection.State != System.Data.ConnectionState.Open)
                {
                    checkConnection.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to connect to database\n{ex.Message}",
                               "DB ERROR",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
            }
        }

        public static int ExecuteNonQuery(string query)
        {
            try
            {
                if (checkConnection.State != System.Data.ConnectionState.Open)
                    checkConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand(query, checkConnection))
                {
                    return sqlCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Query Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        internal static IEnumerable<object> GetAllBooks()
        {
            throw new NotImplementedException();
        }
    }
}
