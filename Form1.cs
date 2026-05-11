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

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void logibtn_Click(object sender, EventArgs e)
        {


            string query = $"SELECT Role FROM Users WHERE Username = '{namebx.Text}' AND Password = '{passbx.Text}';";

            DBConnection.intiate();
            SqlCommand cmd = new SqlCommand(query, DBConnection.checkConnection);
            var Role = cmd.ExecuteScalar().ToString().Trim();
            if (Role == null)
            {
                MessageBox.Show($"Record not found", "db error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (Role == "Admin")
            {
                loginpnl.Visible = false;
                Userpnl.Visible = false;
                adminpnl.Visible = true;
                librarianpnl.Visible = false;
                signuppnl.Visible = false;
                            }
            else if (Role == "User")
            {
                loginpnl.Visible = false;
                Userpnl.Visible = true;
                adminpnl.Visible = false;
                librarianpnl.Visible = false;
                signuppnl.Visible = false;
            }
            else if (Role == "librarian")
            {
                loginpnl.Visible = false;
                Userpnl.Visible = false;
                adminpnl.Visible = false;
                librarianpnl.Visible = true;
                signuppnl.Visible = false;
            }
            else if (string.IsNullOrWhiteSpace(namebx.Text) || string.IsNullOrWhiteSpace(passbx.Text))
            {
                MessageBox.Show("Please enter your username and password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            DBConnection.checkConnection.Close();


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
            loginpnl.Visible = false;
            Userpnl.Visible = false;
            adminpnl.Visible = false;
            librarianpnl.Visible = false;
            signuppnl.Visible = true;
            Wellcome_page.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void signupbtn_Click(object sender, EventArgs e)
        {
            DBConnection.intiate();
            string Full_Name = signnfamebx.Text;
            string Username = Signup_usernamebx.Text;
            string password = Signup_passbx.Text;


            string query = $@"INSERT INTO Users(Full_Name, Username, Password) VALUES('{Full_Name}','{Username}','{password}') ";
            DBConnection.ExecuteNonQuery(query);
            loginpnl.Visible = true;
            Userpnl.Visible = false;
            adminpnl.Visible = false;
            librarianpnl.Visible = false;
            signuppnl.Visible = false;
            profilepnl.Visible = false;
            DBConnection.checkConnection.Close();

        }

        private void namebx_TextChanged(object sender, EventArgs e)
        {

        }

        private void Wellcome_loginbtn_Click(object sender, EventArgs e)
        {
            loginpnl.Visible = true;
            Userpnl.Visible = false;
            adminpnl.Visible = false;
            librarianpnl.Visible = false;
            signuppnl.Visible = false;
            Wellcome_page.Visible = false;
        }

        private void Wellcome_page_Paint(object sender, PaintEventArgs e)
        {
            loginpnl.Visible = false;
            Userpnl.Visible = false;
            adminpnl.Visible = false;
            librarianpnl.Visible = false;
            signuppnl.Visible = false;
            Wellcome_page.Visible = true;
        }

        private void Signup_loginlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loginpnl.Visible = true;
            Userpnl.Visible = false;
            adminpnl.Visible = false;
            librarianpnl.Visible = false;
            signuppnl.Visible = false;
            Wellcome_page.Visible = false;

        }

        private void Wellcome_signupbtn_Click(object sender, EventArgs e)
        {
            loginpnl.Visible = false;
            Userpnl.Visible = false;
            adminpnl.Visible = false;
            librarianpnl.Visible = false;
            signuppnl.Visible = true;
            Wellcome_page.Visible = false;

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin_homepnl.Visible = true;
            Admin_shelfpnl.Visible = false;
            Admin_userspnl.Visible = false;

        }

        private void Shelfbtn_Click(object sender, EventArgs e)
        {
            Admin_homepnl.Visible = false;
            Admin_shelfpnl.Visible = true;
            Admin_userspnl.Visible = false;
        }

        private void Usersbtn_Click(object sender, EventArgs e)
        {
            Admin_homepnl.Visible = false;
            Admin_shelfpnl.Visible = false;
            Admin_userspnl.Visible = true;
        }

        private void fetch_databtn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT Userid, Full_Name, Username, Role from Users", DBConnection.checkConnection);
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
                    SqlCommand cmd2 = new SqlCommand("update Users set Role=@rolw WHERE UserId = @userId" , DBConnection.checkConnection);

                    DBConnection.checkConnection.Open();
                    cmd2.ExecuteReader();
                    DBConnection.checkConnection.Close();

                    MessageBox.Show("Role has updated successfully");
                }
                catch (Exception ex1)
                {
                
                MessageBox.Show(ex1.Message);
                };
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
    }
}
