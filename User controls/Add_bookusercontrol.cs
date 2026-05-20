using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace d_labdemo
{
    public partial class Add_bookusercontrol : UserControl
    {
        private bool dragg = false;
        private Point dragCursor;
        private Point dragControl;

        public Add_bookusercontrol()
        {
            InitializeComponent();
            this.MouseDown += Control_MouseDown;
            this.MouseMove += Control_MouseMove;
            this.MouseUp += Control_MouseUp;
        }

        private void Control_MouseDown(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (this.Dock != DockStyle.None)
                {
                    this.Dock = DockStyle.None;
                }

                dragg = true;
                dragCursor = Cursor.Position;
                dragControl = this.Location;
                this.BringToFront();
            }
        }

        private void Control_MouseMove(object? sender, MouseEventArgs e)
        {
            if (dragg)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursor));
                Point newLoc = Point.Add(dragControl, new Size(diff));

                if (this.Parent != null)
                {
                    Rectangle parentRect = this.Parent.ClientRectangle;
                    int x = Math.Max(0, Math.Min(newLoc.X, parentRect.Width - this.Width));
                    int y = Math.Max(0, Math.Min(newLoc.Y, parentRect.Height - this.Height));
                    this.Location = new Point(x, y);
                }
                else
                {
                    this.Location = newLoc;
                }
            }
        }

        private void Control_MouseUp(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragg = false;
            }
        }

    }
}
