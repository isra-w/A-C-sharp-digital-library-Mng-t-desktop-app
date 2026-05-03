namespace d.labdemo
{
    partial class d_lab
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(d_lab));
            loginpnl = new Panel();
            signuplbl = new LinkLabel();
            logibtn = new Button();
            passbx = new TextBox();
            namebx = new TextBox();
            passlbl = new Label();
            usernamelbl = new Label();
            welcome_labele = new Label();
            adminpnl = new Panel();
            Titlepnl = new Panel();
            profilelnk = new LinkLabel();
            sidebar = new FlowLayoutPanel();
            menubtn = new Button();
            Homebtn = new Button();
            Usersbtn = new Button();
            Shelfbtn = new Button();
            button2 = new Button();
            settignbtn = new Button();
            userpnl = new Panel();
            loginpnl.SuspendLayout();
            adminpnl.SuspendLayout();
            Titlepnl.SuspendLayout();
            sidebar.SuspendLayout();
            SuspendLayout();
            // 
            // loginpnl
            // 
            loginpnl.BackColor = Color.Black;
            loginpnl.Controls.Add(signuplbl);
            loginpnl.Controls.Add(logibtn);
            loginpnl.Controls.Add(passbx);
            loginpnl.Controls.Add(namebx);
            loginpnl.Controls.Add(passlbl);
            loginpnl.Controls.Add(usernamelbl);
            loginpnl.Controls.Add(welcome_labele);
            loginpnl.Dock = DockStyle.Fill;
            loginpnl.Location = new Point(0, 0);
            loginpnl.Name = "loginpnl";
            loginpnl.Size = new Size(859, 485);
            loginpnl.TabIndex = 0;
            loginpnl.Paint += panel1_Paint;
            // 
            // signuplbl
            // 
            signuplbl.AutoSize = true;
            signuplbl.BackColor = Color.Transparent;
            signuplbl.LinkColor = Color.LavenderBlush;
            signuplbl.Location = new Point(311, 363);
            signuplbl.Name = "signuplbl";
            signuplbl.Size = new Size(171, 42);
            signuplbl.TabIndex = 6;
            signuplbl.TabStop = true;
            signuplbl.Text = "Don't have an account?\r\nSign up";
            signuplbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // logibtn
            // 
            logibtn.BackColor = Color.LightYellow;
            logibtn.Font = new Font("Segoe UI", 9.216F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logibtn.Location = new Point(311, 305);
            logibtn.Name = "logibtn";
            logibtn.Size = new Size(168, 55);
            logibtn.TabIndex = 5;
            logibtn.Text = "LOGIN";
            logibtn.UseVisualStyleBackColor = false;
            logibtn.Click += logibtn_Click;
            // 
            // passbx
            // 
            passbx.BackColor = Color.LightYellow;
            passbx.Location = new Point(267, 238);
            passbx.Name = "passbx";
            passbx.Size = new Size(300, 29);
            passbx.TabIndex = 4;
            passbx.UseSystemPasswordChar = true;
            // 
            // namebx
            // 
            namebx.BackColor = Color.LightYellow;
            namebx.Location = new Point(267, 177);
            namebx.Name = "namebx";
            namebx.Size = new Size(300, 29);
            namebx.TabIndex = 3;
            // 
            // passlbl
            // 
            passlbl.AutoSize = true;
            passlbl.BackColor = Color.Transparent;
            passlbl.Font = new Font("Arial Narrow", 10.9439993F, FontStyle.Bold);
            passlbl.ForeColor = Color.LightYellow;
            passlbl.Location = new Point(127, 238);
            passlbl.Name = "passlbl";
            passlbl.Size = new Size(85, 23);
            passlbl.TabIndex = 2;
            passlbl.Text = "Password";
            // 
            // usernamelbl
            // 
            usernamelbl.AutoSize = true;
            usernamelbl.BackColor = Color.Transparent;
            usernamelbl.Font = new Font("Arial Narrow", 10.9439993F, FontStyle.Bold);
            usernamelbl.ForeColor = Color.LightYellow;
            usernamelbl.Location = new Point(127, 177);
            usernamelbl.Name = "usernamelbl";
            usernamelbl.Size = new Size(92, 23);
            usernamelbl.TabIndex = 1;
            usernamelbl.Text = "User Name";
            // 
            // welcome_labele
            // 
            welcome_labele.AutoSize = true;
            welcome_labele.Font = new Font("Ravie", 24.192F, FontStyle.Italic, GraphicsUnit.Point, 0);
            welcome_labele.ForeColor = Color.LightYellow;
            welcome_labele.Location = new Point(229, 54);
            welcome_labele.Name = "welcome_labele";
            welcome_labele.Size = new Size(338, 57);
            welcome_labele.TabIndex = 0;
            welcome_labele.Text = "WELLCOME";
            // 
            // adminpnl
            // 
            adminpnl.AutoSize = true;
            adminpnl.Controls.Add(Titlepnl);
            adminpnl.Controls.Add(sidebar);
            adminpnl.Dock = DockStyle.Fill;
            adminpnl.Location = new Point(0, 0);
            adminpnl.Name = "adminpnl";
            adminpnl.Size = new Size(859, 485);
            adminpnl.TabIndex = 7;
            // 
            // Titlepnl
            // 
            Titlepnl.BackColor = SystemColors.ActiveCaptionText;
            Titlepnl.Controls.Add(profilelnk);
            Titlepnl.Dock = DockStyle.Top;
            Titlepnl.Location = new Point(200, 0);
            Titlepnl.Name = "Titlepnl";
            Titlepnl.Size = new Size(659, 78);
            Titlepnl.TabIndex = 1;
            // 
            // profilelnk
            // 
            profilelnk.ActiveLinkColor = SystemColors.ActiveCaption;
            profilelnk.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            profilelnk.AutoSize = true;
            profilelnk.Font = new Font("Segoe UI Semibold", 12.096F, FontStyle.Bold, GraphicsUnit.Point, 0);
            profilelnk.LinkColor = Color.AliceBlue;
            profilelnk.Location = new Point(535, 15);
            profilelnk.Margin = new Padding(3, 3, 3, 0);
            profilelnk.Name = "profilelnk";
            profilelnk.Size = new Size(111, 30);
            profilelnk.TabIndex = 0;
            profilelnk.TabStop = true;
            profilelnk.Text = "👤 profile";
            profilelnk.VisitedLinkColor = Color.Blue;
            // 
            // sidebar
            // 
            sidebar.AutoSize = true;
            sidebar.BackColor = Color.FromArgb(30, 40, 45);
            sidebar.Controls.Add(menubtn);
            sidebar.Controls.Add(Homebtn);
            sidebar.Controls.Add(Usersbtn);
            sidebar.Controls.Add(Shelfbtn);
            sidebar.Controls.Add(button2);
            sidebar.Controls.Add(settignbtn);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.MaximumSize = new Size(200, 500);
            sidebar.MinimumSize = new Size(63, 485);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(200, 485);
            sidebar.TabIndex = 0;
            sidebar.Paint += flowLayoutPanel1_Paint;
            // 
            // menubtn
            // 
            menubtn.BackColor = Color.FromArgb(30, 40, 45);
            menubtn.FlatAppearance.CheckedBackColor = Color.White;
            menubtn.FlatAppearance.MouseOverBackColor = Color.Black;
            menubtn.FlatStyle = FlatStyle.Flat;
            menubtn.Font = new Font("Segoe UI", 9.792F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menubtn.ForeColor = Color.LightYellow;
            menubtn.Location = new Point(3, 3);
            menubtn.Name = "menubtn";
            menubtn.Size = new Size(197, 75);
            menubtn.TabIndex = 0;
            menubtn.Text = "☰   MENU";
            menubtn.UseVisualStyleBackColor = false;
            // 
            // Homebtn
            // 
            Homebtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Homebtn.BackColor = Color.FromArgb(30, 40, 45);
            Homebtn.FlatAppearance.CheckedBackColor = Color.White;
            Homebtn.FlatAppearance.MouseOverBackColor = Color.Black;
            Homebtn.FlatStyle = FlatStyle.Flat;
            Homebtn.ForeColor = Color.LightYellow;
            Homebtn.Location = new Point(3, 84);
            Homebtn.Name = "Homebtn";
            Homebtn.Size = new Size(194, 44);
            Homebtn.TabIndex = 1;
            Homebtn.Text = "🏠︎   Home";
            Homebtn.UseVisualStyleBackColor = false;
            // 
            // Usersbtn
            // 
            Usersbtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Usersbtn.BackColor = Color.FromArgb(30, 40, 45);
            Usersbtn.FlatAppearance.CheckedBackColor = Color.White;
            Usersbtn.FlatAppearance.MouseOverBackColor = Color.Black;
            Usersbtn.FlatStyle = FlatStyle.Flat;
            Usersbtn.ForeColor = Color.LightYellow;
            Usersbtn.Location = new Point(3, 134);
            Usersbtn.Name = "Usersbtn";
            Usersbtn.Size = new Size(194, 44);
            Usersbtn.TabIndex = 2;
            Usersbtn.Text = "👤  Users";
            Usersbtn.UseVisualStyleBackColor = false;
            // 
            // Shelfbtn
            // 
            Shelfbtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Shelfbtn.BackColor = Color.FromArgb(30, 40, 45);
            Shelfbtn.FlatAppearance.CheckedBackColor = Color.White;
            Shelfbtn.FlatAppearance.MouseOverBackColor = Color.Black;
            Shelfbtn.FlatStyle = FlatStyle.Flat;
            Shelfbtn.ForeColor = Color.LightYellow;
            Shelfbtn.Location = new Point(3, 184);
            Shelfbtn.Name = "Shelfbtn";
            Shelfbtn.Size = new Size(194, 44);
            Shelfbtn.TabIndex = 4;
            Shelfbtn.Text = "📊  Shelf";
            Shelfbtn.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button2.BackColor = Color.FromArgb(30, 40, 45);
            button2.FlatAppearance.CheckedBackColor = Color.White;
            button2.FlatAppearance.MouseOverBackColor = Color.Black;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.LightYellow;
            button2.Location = new Point(3, 234);
            button2.Name = "button2";
            button2.Size = new Size(194, 44);
            button2.TabIndex = 3;
            button2.Text = "Home";
            button2.UseVisualStyleBackColor = false;
            // 
            // settignbtn
            // 
            settignbtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            settignbtn.BackColor = Color.FromArgb(30, 40, 45);
            settignbtn.FlatAppearance.CheckedBackColor = Color.White;
            settignbtn.FlatAppearance.MouseOverBackColor = Color.Black;
            settignbtn.FlatStyle = FlatStyle.Flat;
            settignbtn.ForeColor = Color.LightYellow;
            settignbtn.Location = new Point(0, 441);
            settignbtn.Margin = new Padding(0, 160, 0, 3);
            settignbtn.Name = "settignbtn";
            settignbtn.Size = new Size(203, 44);
            settignbtn.TabIndex = 5;
            settignbtn.Text = "⚙️ Setting";
            settignbtn.UseVisualStyleBackColor = false;
            // 
            // userpnl
            // 
            userpnl.Dock = DockStyle.Fill;
            userpnl.Location = new Point(0, 0);
            userpnl.Name = "userpnl";
            userpnl.Size = new Size(859, 485);
            userpnl.TabIndex = 7;
            // 
            // d_lab
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 485);
            Controls.Add(loginpnl);
            Controls.Add(adminpnl);
            Controls.Add(userpnl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "d_lab";
            Text = "d_lab";
            loginpnl.ResumeLayout(false);
            loginpnl.PerformLayout();
            adminpnl.ResumeLayout(false);
            adminpnl.PerformLayout();
            Titlepnl.ResumeLayout(false);
            Titlepnl.PerformLayout();
            sidebar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel loginpnl;
        private Label welcome_labele;
        private Label passlbl;
        private Label usernamelbl;
        private TextBox namebx;
        private TextBox passbx;
        private Button logibtn;
        private LinkLabel signuplbl;
        private Panel adminpnl;
        private Panel Titlepnl;
        private LinkLabel profilelnk;
        private FlowLayoutPanel sidebar;
        private Button menubtn;
        private Button Homebtn;
        private Button Usersbtn;
        private Button Shelfbtn;
        private Button settignbtn;
        private Button button2;
        private Panel userpnl;
    }
}
