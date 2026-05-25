using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace D_lab.User_controls
{
    public partial class Profile_updateucontrol : UserControl
    {
        public Profile_updateucontrol()
        {
            InitializeComponent();
        }

        private void profileedtitclosebtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            var parentPanel = this.Parent as Panel;
            if (parentPanel != null && parentPanel.Name == "Editprofilepnl")
            {
                parentPanel.Visible = false;
            }
        }
    }
}
