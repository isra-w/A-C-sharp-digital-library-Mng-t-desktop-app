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
                        profilepnl.Visible = false;

                        if (role == "Admin")
                        {
                            Homepagepnl.Visible = true;
                            loginpnl.Visible = false;
                            signuppnl.Visible = false;
                        }
                        else if (role == "User")
                        {
                            Homepagepnl.Visible = true;
                            loginpnl.Visible = false;
                            signuppnl.Visible = false;
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

        private void User_favoritebtn_Click(object sender, EventArgs e)
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
            Userpnl.Visible = false;
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

            string query1 = $@"INSERT INTO Users(First_Name, Last_Name, Username, Password) VALUES('{First_Name}','{Last_Name}','{Username}','{password}') ";
            DBConnection.ExecuteNonQuery(query1);
            loginpnl.Visible = true;
            Userpnl.Visible = false;
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
            Userpnl.Visible = false;
            signuppnl.Visible = false;
            Wellcome_page.Visible = false;
            profilepnl.Visible = false;
        }

        private void Wellcome_page_Paint(object sender, PaintEventArgs e)
        {
            Homepagepnl.Visible = false;
            loginpnl.Visible = false;
            Userpnl.Visible = false;
            signuppnl.Visible = false;
            Wellcome_page.Visible = true;
            profilepnl.Visible = false;
        }

        private void Signup_loginlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Homepagepnl.Visible = false;
            loginpnl.Visible = true;
            Userpnl.Visible = false;
            signuppnl.Visible = false;
            Wellcome_page.Visible = false;
            profilepnl.Visible = false;

        }

        private void Wellcome_signupbtn_Click(object sender, EventArgs e)
        {
            Homepagepnl.Visible = false;
            loginpnl.Visible = false;
            Userpnl.Visible = false;
            signuppnl.Visible = true;
            Wellcome_page.Visible = false;
            profilepnl.Visible = false;

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Homepagepnl.Visible = true;
            Book_catagorytab.Visible = false;
            Admin_userspnl.Visible = false;
            profilepnl.Visible = false;

        }

        private void Shelfbtn_Click(object sender, EventArgs e)
        {
            Homepagepnl.Visible = false;
            Book_catagorytab.Visible = true;
            Admin_userspnl.Visible = false;
            profilepnl.Visible = false;
        }

        private void Usersbtn_Click(object sender, EventArgs e)
        {
            Homepagepnl.Visible = false;
            Book_catagorytab.Visible = false;
            Admin_userspnl.Visible = true;
            profilepnl.Visible = false;
        }

        private void fetch_databtn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT Userid, First_Name, Last_Name, Username, Role from Users", DBConnection.checkConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Admin_useresdatagrid.DataSource = dt;
            DBConnection.checkConnection.Close();

        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= Admin_useresdatagrid.Rows.Count; i++)
            {
                try
                {
                    SqlCommand cmd2 = new SqlCommand("update Users set Role=@Role WHERE UserId = @userId", DBConnection.checkConnection);
                    DBConnection.checkConnection.Open();
                    cmd2.ExecuteReader();
                    DBConnection.checkConnection.Close();

                    MessageBox.Show("Role has updated successfully");
                }
                catch (Exception ex1)
                {

                    MessageBox.Show(ex1.Message);
                }
                ;
                DBConnection.checkConnection.Close();

            }

            /*private void button3_Click(object sender, EventArgs e)
            {
                this.Close();
                adminpnl back = new adminpnl();
                back.Show();
            }*/
        }

        private void profilelnk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {


        }

        private void signup_wellcomebx_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
