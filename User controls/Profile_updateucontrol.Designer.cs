namespace D_lab.User_controls
{
    partial class Profile_updateucontrol
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Updateprofileucontrol = new Label();
            Updateprofile_firstnamelbl = new Label();
            Updateprofile_lastnamelbl = new Label();
            Updateprofile_passwordlbl = new Label();
            Updateprofile_firstnamebx = new TextBox();
            Updateprofile_lastnamebx = new TextBox();
            Updateprofile_passwordbx = new TextBox();
            Updateprofile_updatebtn = new Button();
            profileedtitclosebtn = new Button();
            SuspendLayout();
            // 
            // Updateprofileucontrol
            // 
            Updateprofileucontrol.AutoSize = true;
            Updateprofileucontrol.Font = new Font("Showcard Gothic", 17.855999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Updateprofileucontrol.Location = new Point(94, 51);
            Updateprofileucontrol.Name = "Updateprofileucontrol";
            Updateprofileucontrol.Size = new Size(427, 38);
            Updateprofileucontrol.TabIndex = 0;
            Updateprofileucontrol.Text = "✏️ Update your profile";
            // 
            // Updateprofile_firstnamelbl
            // 
            Updateprofile_firstnamelbl.AutoSize = true;
            Updateprofile_firstnamelbl.Location = new Point(66, 139);
            Updateprofile_firstnamelbl.Name = "Updateprofile_firstnamelbl";
            Updateprofile_firstnamelbl.Size = new Size(86, 21);
            Updateprofile_firstnamelbl.TabIndex = 1;
            Updateprofile_firstnamelbl.Text = "First Name";
            // 
            // Updateprofile_lastnamelbl
            // 
            Updateprofile_lastnamelbl.AutoSize = true;
            Updateprofile_lastnamelbl.Location = new Point(66, 200);
            Updateprofile_lastnamelbl.Name = "Updateprofile_lastnamelbl";
            Updateprofile_lastnamelbl.Size = new Size(84, 21);
            Updateprofile_lastnamelbl.TabIndex = 2;
            Updateprofile_lastnamelbl.Text = "Last Name";
            // 
            // Updateprofile_passwordlbl
            // 
            Updateprofile_passwordlbl.AutoSize = true;
            Updateprofile_passwordlbl.Location = new Point(66, 272);
            Updateprofile_passwordlbl.Name = "Updateprofile_passwordlbl";
            Updateprofile_passwordlbl.Size = new Size(76, 21);
            Updateprofile_passwordlbl.TabIndex = 3;
            Updateprofile_passwordlbl.Text = "Password";
            // 
            // Updateprofile_firstnamebx
            // 
            Updateprofile_firstnamebx.Location = new Point(213, 139);
            Updateprofile_firstnamebx.Name = "Updateprofile_firstnamebx";
            Updateprofile_firstnamebx.Size = new Size(238, 29);
            Updateprofile_firstnamebx.TabIndex = 4;
            // 
            // Updateprofile_lastnamebx
            // 
            Updateprofile_lastnamebx.Location = new Point(213, 200);
            Updateprofile_lastnamebx.Name = "Updateprofile_lastnamebx";
            Updateprofile_lastnamebx.Size = new Size(238, 29);
            Updateprofile_lastnamebx.TabIndex = 5;
            // 
            // Updateprofile_passwordbx
            // 
            Updateprofile_passwordbx.Location = new Point(213, 272);
            Updateprofile_passwordbx.Name = "Updateprofile_passwordbx";
            Updateprofile_passwordbx.Size = new Size(238, 29);
            Updateprofile_passwordbx.TabIndex = 6;
            // 
            // Updateprofile_updatebtn
            // 
            Updateprofile_updatebtn.FlatStyle = FlatStyle.Popup;
            Updateprofile_updatebtn.Location = new Point(191, 392);
            Updateprofile_updatebtn.Name = "Updateprofile_updatebtn";
            Updateprofile_updatebtn.Size = new Size(168, 54);
            Updateprofile_updatebtn.TabIndex = 7;
            Updateprofile_updatebtn.Text = "Update";
            Updateprofile_updatebtn.UseVisualStyleBackColor = true;
            Updateprofile_updatebtn.Click += Updateprofile_updatebtn_Click;
            // 
            // profileedtitclosebtn
            // 
            profileedtitclosebtn.BackColor = Color.DarkSeaGreen;
            profileedtitclosebtn.FlatAppearance.BorderSize = 0;
            profileedtitclosebtn.FlatStyle = FlatStyle.Flat;
            profileedtitclosebtn.ForeColor = Color.FromArgb(192, 0, 0);
            profileedtitclosebtn.Location = new Point(532, 13);
            profileedtitclosebtn.Name = "profileedtitclosebtn";
            profileedtitclosebtn.Size = new Size(55, 34);
            profileedtitclosebtn.TabIndex = 8;
            profileedtitclosebtn.Text = "❌";
            profileedtitclosebtn.UseVisualStyleBackColor = false;
            profileedtitclosebtn.Click += profileedditclosebtn_Click;
            // 
            // Profile_updateucontrol
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            Controls.Add(profileedtitclosebtn);
            Controls.Add(Updateprofile_updatebtn);
            Controls.Add(Updateprofile_passwordbx);
            Controls.Add(Updateprofile_lastnamebx);
            Controls.Add(Updateprofile_firstnamebx);
            Controls.Add(Updateprofile_passwordlbl);
            Controls.Add(Updateprofile_lastnamelbl);
            Controls.Add(Updateprofile_firstnamelbl);
            Controls.Add(Updateprofileucontrol);
            Name = "Profile_updateucontrol";
            Size = new Size(604, 488);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Updateprofileucontrol;
        private Label Updateprofile_firstnamelbl;
        private Label Updateprofile_lastnamelbl;
        private Label Updateprofile_passwordlbl;
        private TextBox Updateprofile_firstnamebx;
        private TextBox Updateprofile_lastnamebx;
        private TextBox Updateprofile_passwordbx;
        private Button Updateprofile_updatebtn;
        private Button profileedtitclosebtn;
    }
}
