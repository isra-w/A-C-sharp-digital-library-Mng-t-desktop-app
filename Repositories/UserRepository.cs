using d.labdemo.DB;
using d.labdemo.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace d.labdemo.Repositories
{
    public class UserRepository
    {
        public DataTable GetUsersByRole(string role)
        {
            DBConnection.checkConnection.Open();
            string query = "SELECT UserId, First_Name, Last_Name, Username, ISNULL(Role, 'Pending') as Role FROM Users";

            if (role == "Pending")
            {
                query += " WHERE Role IS NULL OR Role = ''";
            }
            else if (role != "All")
            {
                query += " WHERE Role = @Role";
            }

            using (SqlCommand cmd = new SqlCommand(query, DBConnection.checkConnection))
            {
                if (role != "All" && role != "Pending")
                {
                    cmd.Parameters.AddWithValue("@Role", role);
                }

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    return dt;
                }
            }
        }

        public (string? PasswordHash, string? Role) GetUserCredentialsByUsername(string username)
        {
            DBConnection.checkConnection.Open();
            string query = "SELECT Password, Role FROM Users WHERE Username = @Username";
            using (SqlCommand cmd = new SqlCommand(query, DBConnection.checkConnection))
            {
                cmd.Parameters.AddWithValue("@Username", username);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string pass = reader["Password"]?.ToString();
                        string role = reader["Role"]?.ToString();
                        return (pass, role);
                    }
                }
            }

            return (null, null);
        }

        public int UpdateUserRole(int userId, string role)
        {
            DBConnection.checkConnection.Open();
            string query = "UPDATE Users SET Role = @Role WHERE UserId = @UserId";
            using (SqlCommand cmd = new SqlCommand(query, DBConnection.checkConnection))
            {
                cmd.Parameters.AddWithValue("@Role", role);
                cmd.Parameters.AddWithValue("@UserId", userId);
                return cmd.ExecuteNonQuery();
            }
        }
    }
}