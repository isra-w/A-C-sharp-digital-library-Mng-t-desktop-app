using d.labdemo.DB;
using Microsoft.Data.SqlClient;



namespace d.labdemo
{
    public partial class d_lab : Form
    {
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


            string query = $"SELECT Role FROM Admins WHERE Username = '{namebx.Text}' AND Password = '{passbx.Text}';";
            //string query2 = string.Format("SELECT Role FROM Admins WHERE Username = '{0}' AND Password = '{1}';", namebx.Text,passbx.Text);
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
                userpnl.Visible = false;
                adminpnl.Visible = true;
            }
            else if (Role == "user")
            {
                loginpnl.Visible = false;
                userpnl.Visible = true;
                adminpnl.Visible = false;
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

    }
}
