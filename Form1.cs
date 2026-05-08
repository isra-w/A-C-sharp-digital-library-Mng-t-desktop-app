using d.labdemo.DB;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Drawing.Printing;
using System.Runtime.Intrinsics.X86;



namespace d.labdemo
{
    public partial class d_lab : Form
    {
        //private string Catagory;

        public string? Role { get; private set; }
        public object Last_name { get; private set; }
        public object First_name { get; private set; }

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
            //DBConnection.Initialte();
            string userName = namebx.Text;
            string password = passbx.Text;

            string query = $@"INSERT INTO Users(Userid,First_name,Last_name, UserName, Password) VALUES('{1}','{First_name}','{Last_name}','{userName}','{password}') ";
            DBConnection.ExecuteNonQuery(query);
            loginpnl.Visible = true;
            Userpnl.Visible = false;
            adminpnl.Visible = false;
            librarianpnl.Visible = false;
            signuppnl.Visible = false;
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
            SqlCommand cmd= new SqlCommand("SELECT * FROM Users", DBConnection.checkConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            User_tabeltbl.DataSource = dt;

        }
    }
}
