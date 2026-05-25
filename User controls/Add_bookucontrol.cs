using d.labdemo.DB;
using System.Data.SqlClient;

namespace D_lab.User_controls
{
    public partial class Add_bookucontrol : UserControl
    {
        public event EventHandler CloseRequested;

        private bool isDragging = false;
        private Point startingCursorPosition;
        private Point startingPanelPosition = new Point(0, 0);

        public Add_bookucontrol()
        {
            InitializeComponent();
            this.MouseDown += Add_bookucontrol_MouseDown;
            this.MouseMove += Add_bookucontrol_MouseMove;
            this.MouseUp += Add_bookucontrol_MouseUp;
        }

        private void Add_bookucontrol_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                startingCursorPosition = Cursor.Position;
                startingPanelPosition = this.Parent?.Location ?? new Point(0, 0);

                this.Parent?.BringToFront();
            }
        }

        private void Add_bookucontrol_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging && this.Parent != null)
            {
                Point currentCursorPosition = Cursor.Position;

                int newx = currentCursorPosition.X - startingCursorPosition.X;
                int newy = currentCursorPosition.Y - startingCursorPosition.Y;

                this.Parent.Location = new Point(newx, newy);
            }
        }

        private void Add_bookucontrol_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void Add_bookucontrol_closebtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            var parentPanel = this.Parent as Panel;
            if (parentPanel != null && parentPanel.Name == "Book_addpnl")
            {
                parentPanel.Visible = false;
            }
        }

        private void Adducontrol_addbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Adducontrol_booktitleBX.Text) || string.IsNullOrWhiteSpace(Adducontrol_authornameBX.Text))
            {
                MessageBox.Show("Book Title and Author Name are required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Adducontrol_addbtn.Enabled = false;
                using (SqlConnection conn = new SqlConnection(DBConnection.connectionString))
                {
                    conn.Open();

                    string query = @"INSERT INTO Books (Title, Author, Category, Year, Format) VALUES (@Title, @Author, @Category, @Year, @Format)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Title", Adducontrol_booktitleBX.Text.Trim());
                        cmd.Parameters.AddWithValue("@Author", Adducontrol_authornameBX.Text.Trim());
                        cmd.Parameters.AddWithValue("@Category", Adducontrol_catagorycbx.Text);
                        cmd.Parameters.AddWithValue("@Year", Adducontrol_publicationyeardatepiker.Value.Year);
                        cmd.Parameters.AddWithValue("@Format", Adducontrol_formatcbx.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Book added successfully!","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);

                            ClearFields();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                Adducontrol_addbtn.Enabled = true;
            
        }
        private void ClearFields()
        {
            Adducontrol_booktitleBX.Clear();
            Adducontrol_authornameBX.Clear();
            Adducontrol_catagorycbx.SelectedIndex = -1;
            Adducontrol_formatcbx.SelectedIndex = -1;
            Adducontrol_publicationyeardatepiker.Value = DateTime.Now;
        }
    }
}