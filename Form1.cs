using d.labdemo.DB;
using d_labdemo;
using Microsoft.Data.SqlClient;
using System.Data;



namespace d.labdemo
{
    public partial class d_lab : Form
    {
        private int totalSeconds;
        public string? Role { get; private set; }
        public object? Full_Name { get; private set; }
        public object Study_timebx { get; private set; }

        public d_lab()
        {
            InitializeComponent();
            Wellcome_page.Visible = true;
            Wellcome_page.BringToFront();

        }


        private readonly Services.AuthService _authService = new Services.AuthService();
        private readonly Services.UserService _userService = new Services.UserService();

        private void Logibtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(namebx.Text) || string.IsNullOrWhiteSpace(passbx.Text))
            {
                MessageBox.Show("Please enter your username and password.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = _authService.Login(namebx.Text, passbx.Text);
            if (!result.Success)
            {
                MessageBox.Show(result.Error ?? "Invalid username or password.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string role = result.Role ?? "Pending";

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
                Librarian_addbooktab.Visible = false;
                LibrarianAdd_bookbtn.Visible = false;
            }
            else if (role == "User")
            {
                Homepagepnl.Visible = true;
                loginpnl.Visible = false;
                signuppnl.Visible = false;
                Admin_userspnl.Visible = false;
                Usersbtn.Visible = false;
                Librarin_pnl.Visible = false;
                Librarian_addbooktab.Visible = false;
                LibrarianAdd_bookbtn.Visible = false;
            }
            else if (role == "Librarian")
            {
                Homepagepnl.Visible = true;
                loginpnl.Visible = false;
                signuppnl.Visible = false;
                Study_assistbtn.Visible = false;
                Studypnl.Visible = false;
                Librarian_addbooktab.Visible = true;
                LibrarianAdd_bookbtn.Visible = true;
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

        private void login_signup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Homepagepnl.Visible = false;
            loginpnl.Visible = false;
            Book_catagorypnl.Visible = false;
            signuppnl.Visible = true;
            Wellcome_page.Visible = false;
            profilepnl.Visible = false;
            Librarin_pnl.Visible = false;
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

        private void Wellcome_loginbtn_Click(object sender, EventArgs e)
        {
            Homepagepnl.Visible = false;
            loginpnl.Visible = true;
            profilepnl.Visible = false;
            Book_catagorypnl.Visible = false;
            signuppnl.Visible = false;
            Wellcome_page.Visible = false;
            profilepnl.Visible = false;
            Librarin_pnl.Visible = false;
        }

        private void Wellcome_page_Paint(object sender, PaintEventArgs e)
        {
            Homepagepnl.Visible = false;
            loginpnl.Visible = false;
            Book_catagorypnl.Visible = false;
            signuppnl.Visible = false;
            Wellcome_page.Visible = true;
            profilepnl.Visible = false;
            Librarin_pnl.Visible = false;
        }

        private void Signup_loginlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Homepagepnl.Visible = false;
            loginpnl.Visible = true;
            Book_catagorypnl.Visible = false;
            signuppnl.Visible = false;
            Wellcome_page.Visible = false;
            profilepnl.Visible = false;
            Librarin_pnl.Visible = false;

        }

        private void Wellcome_signupbtn_Click(object sender, EventArgs e)
        {
            Homepagepnl.Visible = false;
            loginpnl.Visible = false;
            Book_catagorypnl.Visible = false;
            signuppnl.Visible = true;
            Wellcome_page.Visible = false;
            profilepnl.Visible = false;
            Librarin_pnl.Visible = false;

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
                AdminFilter_datacombobx.Items.Clear();
                AdminFilter_datacombobx.Items.Add("All");
                AdminFilter_datacombobx.Items.Add("Admin");
                AdminFilter_datacombobx.Items.Add("User");
                AdminFilter_datacombobx.Items.Add("Librarian");
                AdminFilter_datacombobx.Items.Add("Pending");
                AdminFilter_datacombobx.SelectedIndex = 0;
                LoadUsersByRole("All");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fetch error: " + ex.Message);
            }
        }

        private void LoadUsersByRole(string role)
        {
            try
            {
                DataTable dt = _userService.LoadUsersByRole(role);
                Admin_useresdatagrid.DataSource = dt;
                AddRoleComboBoxColumn();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load users error: " + ex.Message);
            }
        }

        private void AdminFetch_datacombobx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AdminFilter_datacombobx.SelectedIndex >= 0)
            {
                string selectedRole = AdminFilter_datacombobx.SelectedItem.ToString();
                LoadUsersByRole(selectedRole);
            }
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
            RoleCombo.Items.Add("Librarian");

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

                int rowsAffected = _userService.UpdateUserRole(userId, Role ?? "");
                MessageBox.Show($"Updated {rowsAffected} row(s) successfully!");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Update error: " + ex.Message);
            }

        }

        private void profilelnk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            profilepnl.Visible = true;
            profilepnl.BringToFront();
        }

        private void Study_assistbtn_Click(object sender, EventArgs e)
        {
            Studypnl.BringToFront();

        }

        private void Homebtn_Click(object sender, EventArgs e)
        {
            Homepnl.BringToFront();
        }


        private void Timer_startbtn_Click(object sender, EventArgs e)
        {
            //to check if the timer is counting and to stop it
            if (Study_timer.Enabled)
            {
                Study_timer.Stop();
                Timer_startbtn.Text = "START";
                Timer_amountbx.Enabled = true;
            }
            else
            {
                int minutes = Convert.ToInt32(Timer_amountbx.Text);
                totalSeconds = minutes * 60;
                Study_timer.Interval = 1000;
                Timer_countdownlbl.Text = $"{minutes:D2} : 00";
                Timer_amountbx.Enabled = false;
                Timer_startbtn.Text = "STOP";
                Study_timer.Start();
            }
        }

        private void Study_timer_Tick(object sender, EventArgs e)
        {
            if (totalSeconds > 0)
            {
                totalSeconds--;
                // to calculate the remaining minut and second
                int currentMinutes = totalSeconds / 60;
                int currentSeconds = totalSeconds % 60;
                Timer_countdownlbl.Text = $"{currentMinutes} : {currentSeconds}";
            }
            else
            {
                Study_timer.Stop();
                Timer_startbtn.Text = "START";
                Timer_amountbx.Enabled = true;
                Timer_countdownlbl.Text = "00 : 00";
            }
        }

        private void profilepic_updatebtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select a Profile Photo";
                openFileDialog.Filter = "Image Files(*.jpg; *.jpeg;*.png;)|*.jpg; *.jpeg; *.png;";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Profilepic.Image = Image.FromFile(openFileDialog.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Could not load image: " + ex.Message);
                    }
                }
            }
        }

        private void Timer_countdownlbl_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserControl Add_bookcontrol = new UserControl();
            Homepagepnl.Controls.Add(Add_bookcontrol);

        }


    }
}

