namespace D_lab.User_controls
{
    public partial class Profile_updateucontrol : UserControl
    {
        public Profile_updateucontrol()
        {
            InitializeComponent();
        }

        private void profileedditclosebtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            var parentPanel = this.Parent as Panel;
            if (parentPanel != null && parentPanel.Name == "Editprofilepnl")
            {
                parentPanel.Visible = false;
            }

        }

        private void Updateprofile_updatebtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Updateprofile_firstnamebx.Text) ||
                string.IsNullOrWhiteSpace(Updateprofile_lastnamebx.Text))
            {
                MessageBox.Show("First Name and Last Name are required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var userUpdate = new
                {
                    FirstName = Updateprofile_firstnamebx.Text.Trim(),
                    LastName = Updateprofile_lastnamebx.Text.Trim(),
                    Password = string.IsNullOrWhiteSpace(Updateprofile_passwordbx.Text) ? null : Updateprofile_passwordbx.Text
                };


                if (userUpdate != null)
                {
                    MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // to hide after edit
                    this.Visible = false;
                    var parentPanel = this.Parent as Panel;
                    if (parentPanel != null && parentPanel.Name == "Editprofilepnl")
                    {
                        parentPanel.Visible = false;
                    }
                }
                else
                {
                    MessageBox.Show(" Failed to update profile.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Cursor = Cursors.Default;
            Updateprofile_updatebtn.Enabled = true;

        }

    }
}

