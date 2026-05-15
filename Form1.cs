using d.labdemo.DB;
using Microsoft.Data.SqlClient;
using System.Data;



namespace d.labdemo
{
    public partial class d_lab : Form
    {
        public string? Role { get; private set; }
        public object? Full_Name { get; private set; }


        public d_lab()
        {
            InitializeComponent();
            Wellcome_page.Visible = true;
            Wellcome_page.BringToFront();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void Logibtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(namebx.Text) || string.IsNullOrWhiteSpace(passbx.Text))
            {
                MessageBox.Show("Please enter your username and password.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DBConnection.intiate();
            string query = "SELECT Password, Role FROM Users WHERE Username = @Username;";

            using (SqlCommand cmd = new SqlCommand(query, DBConnection.checkConnection))
            {
                try
                {
                    cmd.Parameters.AddWithValue("@Username", namebx.Text);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            MessageBox.Show("Record not found.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        string storedHash = reader["Password"].ToString().Trim();
                        string role = reader["Role"].ToString().Trim();

                        bool passwordVerified = BCrypt.Net.BCrypt.EnhancedVerify(passbx.Text, storedHash);

                        if (!passwordVerified)
                        {
                            MessageBox.Show("Invalid username or password.", "Error",
                                MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                            return;
                        }
                        loginpnl.Visible = false;
                        signuppnl.Visible = false;
                        Homepagepnl.Visible = true;

                        if (role == "Admin")
                        {
                            Homepagepnl.Visible = true;
                            loginpnl.Visible = false;
                            signuppnl.Visible = false;
                            Study_assistbtn.Visible = false;
                            Studypnl.Visible = false;
                        }
                        else if (role == "User")
                        {
                            Homepagepnl.Visible = true;
                            loginpnl.Visible = false;
                            signuppnl.Visible = false;
                            Admin_userspnl.Visible = false;
                            Usersbtn.Visible = false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    DBConnection.checkConnection.Close();
                }
            }
        }

        private void loginpnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void User_shelfbtn_Click(object sender, EventArgs e)
        {
            /* string query = $"SELECT Catagory FROM Book WHERE Catagory = '{Catagory}';";
             DBConnection.intiate();
             SqlCommand cmd = new SqlCommand(query, DBConnection.checkConnection);
             var Role = cmd.ExecuteScalar().ToString().Trim();
             if (Role == null)
             {
                 MessageBox.Show($"Record not found", "db error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }

             else if (Catagory == "Programming")
             {
                 Programmingtab.Visible = true;
                 Noveltab.Visible = false;
                 Medicinetab.Visible = false;
             }
             else if (Catagory == "Medicine")
             {
                 Programmingtab.Visible = false;
                 Noveltab.Visible = false;
                 Medicinetab.Visible = true;
             }
             else if (Catagory == "novel")
             {
                 Programmingtab.Visible = false;
                 Noveltab.Visible = true;
                 Medicinetab.Visible = false;
             }
             else
             {
                 MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
             }*/
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Homepagepnl.Visible = false;
            loginpnl.Visible = false;
            Book_catagorypnl.Visible = false;
            signuppnl.Visible = true;
            Wellcome_page.Visible = false;
            profilepnl.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void signupbtn_Click(object sender, EventArgs e)
        {
            DBConnection.intiate();
            string First_Name = Signup_firstnamebx.Text;
            string Last_Name = Signup_lastnamebx.Text;
            string Username = Signup_usernamebx.Text;
            string password = Signup_passbx.Text;

            string hashedPassword = BCrypt.Net.BCrypt.EnhancedHashPassword(password);

            string query = "INSERT INTO Users(First_Name, Last_Name, Username, Password) VALUES(@FirstName, @LastName, @Username, @Password)";
            SqlCommand cmd = new SqlCommand(query, DBConnection.checkConnection);
            cmd.Parameters.AddWithValue("@FirstName", First_Name);
            cmd.Parameters.AddWithValue("@LastName", Last_Name);
            cmd.Parameters.AddWithValue("@Username", Username);
            cmd.Parameters.AddWithValue("@Password", hashedPassword);
            cmd.ExecuteNonQuery();
            loginpnl.Visible = true;
            Book_catagorypnl.Visible = false;
            signuppnl.Visible = false;
            profilepnl.Visible = false;
            Homepagepnl.Visible = false;
            DBConnection.checkConnection.Close();

        }

        private void namebx_TextChanged(object sender, EventArgs e)
        {

        }

        private void Wellcome_loginbtn_Click(object sender, EventArgs e)
        {
            Homepagepnl.Visible = false;
            loginpnl.Visible = true;
            profilepnl.Visible = false;
            Book_catagorypnl.Visible = false;
            signuppnl.Visible = false;
            Wellcome_page.Visible = false;
            profilepnl.Visible = false;
        }

        private void Wellcome_page_Paint(object sender, PaintEventArgs e)
        {
            Homepagepnl.Visible = false;
            loginpnl.Visible = false;
            Book_catagorypnl.Visible = false;
            signuppnl.Visible = false;
            Wellcome_page.Visible = true;
            profilepnl.Visible = false;
        }

        private void Signup_loginlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Homepagepnl.Visible = false;
            loginpnl.Visible = true;
            Book_catagorypnl.Visible = false;
            signuppnl.Visible = false;
            Wellcome_page.Visible = false;
            profilepnl.Visible = false;

        }

        private void Wellcome_signupbtn_Click(object sender, EventArgs e)
        {
            Homepagepnl.Visible = false;
            loginpnl.Visible = false;
            Book_catagorypnl.Visible = false;
            signuppnl.Visible = true;
            Wellcome_page.Visible = false;
            profilepnl.Visible = false;

        }

        private void Booksbtn_Click(object sender, EventArgs e)
        {
            Book_catagorypnl.Visible = true;
            Book_catagorypnl.BringToFront();
        }

        private void Usersbtn_Click(object sender, EventArgs e)
        {
            Admin_userspnl.BringToFront();
        }

        private void fetch_databtn_Click(object sender, EventArgs e)
        {
            try
            {
                DBConnection.checkConnection.Open();
                SqlCommand cmd = new SqlCommand("SELECT UserId, First_Name, Last_Name, Username, Role FROM Users", DBConnection.checkConnection);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                Admin_useresdatagrid.DataSource = dt;
                AddRoleComboBoxColumn();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fetch error: " + ex.Message);
            }
            DBConnection.checkConnection.Close();

        }

        private void AddRoleComboBoxColumn()
        {
            Admin_useresdatagrid.Columns.Remove("Role");
            DataGridViewComboBoxColumn RoleCombo = new DataGridViewComboBoxColumn();
            RoleCombo.Name = "Role";
            RoleCombo.HeaderText = "Role";
            RoleCombo.DataPropertyName = "Role";
            RoleCombo.Items.Add("Admin");
            RoleCombo.Items.Add("User");

            Admin_useresdatagrid.Columns.Insert(4, RoleCombo);
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                Admin_useresdatagrid.EndEdit();
                DataGridViewRow row = Admin_useresdatagrid.CurrentRow;

                int userId = Convert.ToInt32(row.Cells["UserId"].Value);
                string Role = row.Cells["Role"].Value?.ToString();

                DBConnection.checkConnection.Open();

                string query = "UPDATE Users SET Role = @Role WHERE UserId = @UserId";
                SqlCommand cmd = new SqlCommand(query, DBConnection.checkConnection);
                cmd.Parameters.AddWithValue("@Role", Role);
                cmd.Parameters.AddWithValue("@UserId", userId);
                int rowsAffected = cmd.ExecuteNonQuery();
                MessageBox.Show($"Updated {rowsAffected} row(s) successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update error: " + ex.Message);
            }

                DBConnection.checkConnection.Close();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*this.Close();
            adminpnl back = new adminpnl();
            back.Show();*/
        }

        private void profilelnk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            profilepnl.Visible = true;
            profilepnl.BringToFront();
        }

        private void signup_wellcomebx_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Study_assistbtn_Click(object sender, EventArgs e)
        {
            Studypnl.BringToFront();

        }

        private void Homebtn_Click(object sender, EventArgs e)
        {
            Homepnl.BringToFront();
        }

    }
}
