using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace d_labdemo.User_controls
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
    }
}