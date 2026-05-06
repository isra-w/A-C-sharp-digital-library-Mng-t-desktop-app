using d.labdemo.DB;
using Microsoft.Data.SqlClient;
using System.Runtime.Intrinsics.X86;



namespace d.labdemo
{
    public partial class d_lab : Form
    {
        bool sidebarexpand;
        private string Catagory;

        public string? Role { get; private set; }

        public d_lab()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            if (sidebarexpand)
            {
                sidebar.Width = MaximumSize.Width;

            }
        }

        private void logibtn_Click(object sender, EventArgs e)
        {


            string query = $"SELECT Role FROM Admins UNION SELECT Role FROM Librarian" +
                $" UNION SELECT Role FROM Member WHERE Username = '{namebx.Text}' AND Password = '{passbx.Text}';";

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
                memberpnl.Visible = false;
                adminpnl.Visible = true;
                librarianpnl.Visible = false;
            }
            else if (Role == "member")
            {
                loginpnl.Visible = false;
                memberpnl.Visible = true;
                adminpnl.Visible = false;
                librarianpnl.Visible = false;
            }
            else if (Role == "librarian")
            {
                loginpnl.Visible = false;
                memberpnl.Visible = false;
                adminpnl.Visible = false;
                librarianpnl.Visible = true;
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

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void member_shelfbtn_Click(object sender, EventArgs e)
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
    }
}
