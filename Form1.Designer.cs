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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(d_lab));
            Book_catagorytab = new TabControl();
            Programmingtab = new TabPage();
            Medicinetab = new TabPage();
            Noveltab = new TabPage();
            loginpnl = new Panel();
            login_signup = new LinkLabel();
            logibtn = new Button();
            passbx = new TextBox();
            namebx = new TextBox();
            passlbl = new Label();
            usernamelbl = new Label();
            welcome_labele = new Label();
            signuppnl = new Panel();
            Signip_rolecbx = new ComboBox();
            Signip_rolelbl = new Label();
            Signup_lastnamebx = new TextBox();
            Signup_Lastnamelbl = new Label();
            Signup_passbx = new TextBox();
            Signup_Usernamelbl = new Label();
            signpass = new Label();
            Signup_usernamebx = new TextBox();
            Signup_loginlink = new LinkLabel();
            signupbtn = new Button();
            Signup_firstnamebx = new TextBox();
            signup_Firstnamelbl = new Label();
            signup_wellcomebx = new Label();
            Wellcome_page = new Panel();
            Wellcome_signupbtn = new Button();
            Wellcome_loginbtn = new Button();
            sidebar = new Panel();
            Study_assistbtn = new Button();
            Usersbtn = new Button();
            Bookbtn = new Button();
            Homebtn = new Button();
            profile_sidebarpnl = new Panel();
            label1 = new Label();
            settignbtn = new Button();
            menuStrip1 = new MenuStrip();
            Admin_userspnl = new Panel();
            updatebtn = new Button();
            Admin_useresdatagrid = new DataGridView();
            fetch_databtn = new Button();
            profilepnl = new Panel();
            profilepic_updatebtn = new Button();
            Profile_lastnamebx = new TextBox();
            Profile_usernamebx = new TextBox();
            Profile_firstnamebx = new TextBox();
            Profile_usernamelbl = new Label();
            Profile_lastnamelbl = new Label();
            Profile_firstnamelbl = new Label();
            Profilepic = new PictureBox();
            Homepagepnl = new Panel();
            Homepnl = new Panel();
            Home_bookspnl = new Panel();
            Studypnl = new Panel();
            Study_timepnl = new Panel();
            Timer_countdownlbl = new Label();
            Timer_amountbx = new TextBox();
            Timer_typelbl = new Label();
            Timer_startbtn = new Button();
            Book_catagorypnl = new Panel();
            Study_timer = new System.Windows.Forms.Timer(components);
            Book_catagorytab.SuspendLayout();
            loginpnl.SuspendLayout();
            signuppnl.SuspendLayout();
            Wellcome_page.SuspendLayout();
            sidebar.SuspendLayout();
            profile_sidebarpnl.SuspendLayout();
            Admin_userspnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Admin_useresdatagrid).BeginInit();
            profilepnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Profilepic).BeginInit();
            Homepagepnl.SuspendLayout();
            Homepnl.SuspendLayout();
            Studypnl.SuspendLayout();
            Study_timepnl.SuspendLayout();
            Book_catagorypnl.SuspendLayout();
            SuspendLayout();
            // 
            // Book_catagorytab
            // 
            Book_catagorytab.Controls.Add(Programmingtab);
            Book_catagorytab.Controls.Add(Medicinetab);
            Book_catagorytab.Controls.Add(Noveltab);
            Book_catagorytab.Dock = DockStyle.Fill;
            Book_catagorytab.ItemSize = new Size(109, 50);
            Book_catagorytab.Location = new Point(0, 0);
            Book_catagorytab.Name = "Book_catagorytab";
            Book_catagorytab.Padding = new Point(11, 3);
            Book_catagorytab.RightToLeftLayout = true;
            Book_catagorytab.SelectedIndex = 0;
            Book_catagorytab.Size = new Size(985, 735);
            Book_catagorytab.TabIndex = 4;
            Book_catagorytab.Tag = "";
            // 
            // Programmingtab
            // 
            Programmingtab.AccessibleName = "";
            Programmingtab.AllowDrop = true;
            Programmingtab.BackColor = SystemColors.ActiveCaption;
            Programmingtab.BorderStyle = BorderStyle.Fixed3D;
            Programmingtab.Cursor = Cursors.Hand;
            Programmingtab.Font = new Font("Segoe UI Semibold", 9.216F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Programmingtab.Location = new Point(4, 54);
            Programmingtab.Name = "Programmingtab";
            Programmingtab.Padding = new Padding(3);
            Programmingtab.Size = new Size(977, 677);
            Programmingtab.TabIndex = 0;
            Programmingtab.Text = "Programming";
            // 
            // Medicinetab
            // 
            Medicinetab.BackColor = SystemColors.ActiveBorder;
            Medicinetab.BorderStyle = BorderStyle.Fixed3D;
            Medicinetab.Location = new Point(4, 54);
            Medicinetab.Name = "Medicinetab";
            Medicinetab.Padding = new Padding(3);
            Medicinetab.Size = new Size(977, 677);
            Medicinetab.TabIndex = 1;
            Medicinetab.Text = "Medicine";
            // 
            // Noveltab
            // 
            Noveltab.BorderStyle = BorderStyle.Fixed3D;
            Noveltab.Location = new Point(4, 54);
            Noveltab.Name = "Noveltab";
            Noveltab.Size = new Size(977, 677);
            Noveltab.TabIndex = 2;
            Noveltab.Text = "Novel tab";
            Noveltab.UseVisualStyleBackColor = true;
            // 
            // loginpnl
            // 
            loginpnl.AutoSize = true;
            loginpnl.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            loginpnl.BackgroundImage = d_labdemo.Properties.Resources.Bookshelf_Wallpaper_Desktop_HD__1_;
            loginpnl.BackgroundImageLayout = ImageLayout.Stretch;
            loginpnl.Controls.Add(login_signup);
            loginpnl.Controls.Add(logibtn);
            loginpnl.Controls.Add(passbx);
            loginpnl.Controls.Add(namebx);
            loginpnl.Controls.Add(passlbl);
            loginpnl.Controls.Add(usernamelbl);
            loginpnl.Controls.Add(welcome_labele);
            loginpnl.Dock = DockStyle.Fill;
            loginpnl.Location = new Point(0, 0);
            loginpnl.MaximumSize = new Size(1210, 735);
            loginpnl.MinimumSize = new Size(1210, 735);
            loginpnl.Name = "loginpnl";
            loginpnl.Size = new Size(1210, 735);
            loginpnl.TabIndex = 2;
            loginpnl.Paint += loginpnl_Paint;
            // 
            // login_signup
            // 
            login_signup.AutoSize = true;
            login_signup.BackColor = Color.Transparent;
            login_signup.LinkColor = Color.LightYellow;
            login_signup.Location = new Point(37, 569);
            login_signup.Name = "login_signup";
            login_signup.Size = new Size(166, 42);
            login_signup.TabIndex = 12;
            login_signup.TabStop = true;
            login_signup.Text = "Don' have an account?\r\nSIGN IP";
            login_signup.TextAlign = ContentAlignment.TopCenter;
            login_signup.LinkClicked += linkLabel1_LinkClicked;
            // 
            // logibtn
            // 
            logibtn.BackColor = Color.LightYellow;
            logibtn.Font = new Font("Segoe UI", 9.216F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logibtn.Location = new Point(448, 361);
            logibtn.Name = "logibtn";
            logibtn.Size = new Size(168, 55);
            logibtn.TabIndex = 11;
            logibtn.Text = "LOGIN";
            logibtn.UseVisualStyleBackColor = false;
            logibtn.Click += Logibtn_Click;
            // 
            // passbx
            // 
            passbx.BackColor = Color.LightYellow;
            passbx.Location = new Point(461, 289);
            passbx.Name = "passbx";
            passbx.PasswordChar = '.';
            passbx.PlaceholderText = "Password";
            passbx.Size = new Size(300, 29);
            passbx.TabIndex = 10;
            passbx.UseSystemPasswordChar = true;
            // 
            // namebx
            // 
            namebx.BackColor = Color.LightYellow;
            namebx.BorderStyle = BorderStyle.None;
            namebx.Location = new Point(461, 195);
            namebx.Multiline = true;
            namebx.Name = "namebx";
            namebx.PlaceholderText = "User name or email";
            namebx.Size = new Size(300, 33);
            namebx.TabIndex = 9;
            namebx.TextChanged += namebx_TextChanged;
            // 
            // passlbl
            // 
            passlbl.AutoSize = true;
            passlbl.BackColor = Color.Transparent;
            passlbl.Font = new Font("Arial Narrow", 16.128F, FontStyle.Bold);
            passlbl.ForeColor = Color.LightYellow;
            passlbl.Location = new Point(261, 289);
            passlbl.Name = "passlbl";
            passlbl.Size = new Size(124, 33);
            passlbl.TabIndex = 8;
            passlbl.Text = "Password";
            // 
            // usernamelbl
            // 
            usernamelbl.AutoSize = true;
            usernamelbl.BackColor = Color.Transparent;
            usernamelbl.Font = new Font("Arial Narrow", 16.128F, FontStyle.Bold);
            usernamelbl.ForeColor = Color.LightYellow;
            usernamelbl.Location = new Point(254, 193);
            usernamelbl.Name = "usernamelbl";
            usernamelbl.Size = new Size(136, 33);
            usernamelbl.TabIndex = 7;
            usernamelbl.Text = "User Name";
            // 
            // welcome_labele
            // 
            welcome_labele.AutoSize = true;
            welcome_labele.BackColor = Color.Transparent;
            welcome_labele.Font = new Font("Ravie", 24.192F, FontStyle.Italic, GraphicsUnit.Point, 0);
            welcome_labele.ForeColor = Color.LightYellow;
            welcome_labele.Location = new Point(393, 66);
            welcome_labele.Name = "welcome_labele";
            welcome_labele.Size = new Size(337, 65);
            welcome_labele.TabIndex = 6;
            welcome_labele.Text = "WELLCOME";
            welcome_labele.TextAlign = ContentAlignment.MiddleCenter;
            welcome_labele.UseCompatibleTextRendering = true;
            // 
            // signuppnl
            // 
            signuppnl.BackColor = Color.FromArgb(26, 26, 0);
            signuppnl.BackgroundImageLayout = ImageLayout.Stretch;
            signuppnl.Controls.Add(Signip_rolecbx);
            signuppnl.Controls.Add(Signip_rolelbl);
            signuppnl.Controls.Add(Signup_lastnamebx);
            signuppnl.Controls.Add(Signup_Lastnamelbl);
            signuppnl.Controls.Add(Signup_passbx);
            signuppnl.Controls.Add(Signup_Usernamelbl);
            signuppnl.Controls.Add(signpass);
            signuppnl.Controls.Add(Signup_usernamebx);
            signuppnl.Controls.Add(Signup_loginlink);
            signuppnl.Controls.Add(signupbtn);
            signuppnl.Controls.Add(Signup_firstnamebx);
            signuppnl.Controls.Add(signup_Firstnamelbl);
            signuppnl.Controls.Add(signup_wellcomebx);
            signuppnl.Dock = DockStyle.Fill;
            signuppnl.Location = new Point(0, 0);
            signuppnl.MaximumSize = new Size(1210, 735);
            signuppnl.MinimumSize = new Size(1210, 735);
            signuppnl.Name = "signuppnl";
            signuppnl.Size = new Size(1210, 735);
            signuppnl.TabIndex = 13;
            // 
            // Signip_rolecbx
            // 
            Signip_rolecbx.BackColor = Color.LightYellow;
            Signip_rolecbx.FormattingEnabled = true;
            Signip_rolecbx.Items.AddRange(new object[] { "Admin", "User" });
            Signip_rolecbx.Location = new Point(478, 326);
            Signip_rolecbx.Name = "Signip_rolecbx";
            Signip_rolecbx.Size = new Size(304, 29);
            Signip_rolecbx.TabIndex = 27;
            // 
            // Signip_rolelbl
            // 
            Signip_rolelbl.AutoSize = true;
            Signip_rolelbl.BackColor = Color.Transparent;
            Signip_rolelbl.Font = new Font("Bell MT", 13.8239994F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Signip_rolelbl.ForeColor = Color.FromArgb(255, 255, 204);
            Signip_rolelbl.Location = new Point(179, 322);
            Signip_rolelbl.Name = "Signip_rolelbl";
            Signip_rolelbl.Size = new Size(62, 29);
            Signip_rolelbl.TabIndex = 26;
            Signip_rolelbl.Text = "Role";
            // 
            // Signup_lastnamebx
            // 
            Signup_lastnamebx.BackColor = Color.LightYellow;
            Signup_lastnamebx.BorderStyle = BorderStyle.None;
            Signup_lastnamebx.Location = new Point(478, 188);
            Signup_lastnamebx.Multiline = true;
            Signup_lastnamebx.Name = "Signup_lastnamebx";
            Signup_lastnamebx.PlaceholderText = "Enter your Last Name";
            Signup_lastnamebx.Size = new Size(300, 29);
            Signup_lastnamebx.TabIndex = 25;
            // 
            // Signup_Lastnamelbl
            // 
            Signup_Lastnamelbl.AutoSize = true;
            Signup_Lastnamelbl.BackColor = Color.Transparent;
            Signup_Lastnamelbl.Font = new Font("Bell MT", 13.8239994F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Signup_Lastnamelbl.ForeColor = Color.FromArgb(255, 255, 204);
            Signup_Lastnamelbl.Location = new Point(179, 190);
            Signup_Lastnamelbl.Name = "Signup_Lastnamelbl";
            Signup_Lastnamelbl.Size = new Size(127, 29);
            Signup_Lastnamelbl.TabIndex = 24;
            Signup_Lastnamelbl.Text = "Last Name";
            Signup_Lastnamelbl.Click += label1_Click;
            // 
            // Signup_passbx
            // 
            Signup_passbx.BackColor = Color.LightYellow;
            Signup_passbx.Location = new Point(478, 389);
            Signup_passbx.Name = "Signup_passbx";
            Signup_passbx.PlaceholderText = "Password";
            Signup_passbx.Size = new Size(300, 29);
            Signup_passbx.TabIndex = 23;
            Signup_passbx.UseSystemPasswordChar = true;
            // 
            // Signup_Usernamelbl
            // 
            Signup_Usernamelbl.AutoSize = true;
            Signup_Usernamelbl.BackColor = Color.Transparent;
            Signup_Usernamelbl.Font = new Font("Bell MT", 13.8239994F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Signup_Usernamelbl.ForeColor = Color.FromArgb(255, 255, 204);
            Signup_Usernamelbl.Location = new Point(179, 260);
            Signup_Usernamelbl.Name = "Signup_Usernamelbl";
            Signup_Usernamelbl.Size = new Size(131, 29);
            Signup_Usernamelbl.TabIndex = 22;
            Signup_Usernamelbl.Text = "User Name";
            // 
            // signpass
            // 
            signpass.AutoSize = true;
            signpass.BackColor = Color.Transparent;
            signpass.Font = new Font("Bell MT", 13.8239994F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signpass.ForeColor = Color.FromArgb(255, 255, 204);
            signpass.Location = new Point(179, 387);
            signpass.Name = "signpass";
            signpass.Size = new Size(111, 29);
            signpass.TabIndex = 21;
            signpass.Text = "password";
            // 
            // Signup_usernamebx
            // 
            Signup_usernamebx.BackColor = Color.LightYellow;
            Signup_usernamebx.Location = new Point(478, 262);
            Signup_usernamebx.Multiline = true;
            Signup_usernamebx.Name = "Signup_usernamebx";
            Signup_usernamebx.PlaceholderText = "Username";
            Signup_usernamebx.Size = new Size(300, 29);
            Signup_usernamebx.TabIndex = 20;
            // 
            // Signup_loginlink
            // 
            Signup_loginlink.AutoSize = true;
            Signup_loginlink.BackColor = Color.Transparent;
            Signup_loginlink.Font = new Font("Segoe UI Semibold", 9.792F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Signup_loginlink.ForeColor = Color.FromArgb(255, 255, 204);
            Signup_loginlink.LinkColor = Color.FromArgb(0, 15, 255, 204);
            Signup_loginlink.Location = new Point(12, 565);
            Signup_loginlink.Name = "Signup_loginlink";
            Signup_loginlink.Size = new Size(213, 46);
            Signup_loginlink.TabIndex = 19;
            Signup_loginlink.TabStop = true;
            Signup_loginlink.Text = "Already have an account ?\r\nSIGN IN";
            Signup_loginlink.TextAlign = ContentAlignment.TopCenter;
            Signup_loginlink.LinkClicked += Signup_loginlink_LinkClicked;
            Signup_loginlink.Click += Wellcome_loginbtn_Click;
            // 
            // signupbtn
            // 
            signupbtn.BackColor = Color.FromArgb(50, 50, 50);
            signupbtn.Font = new Font("Segoe UI", 9.216F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signupbtn.ForeColor = Color.FromArgb(255, 255, 204);
            signupbtn.Location = new Point(415, 461);
            signupbtn.Name = "signupbtn";
            signupbtn.Size = new Size(191, 66);
            signupbtn.TabIndex = 18;
            signupbtn.Text = "SIGN UP";
            signupbtn.UseVisualStyleBackColor = false;
            signupbtn.Click += signupbtn_Click;
            // 
            // Signup_firstnamebx
            // 
            Signup_firstnamebx.BackColor = Color.LightYellow;
            Signup_firstnamebx.BorderStyle = BorderStyle.None;
            Signup_firstnamebx.Location = new Point(478, 124);
            Signup_firstnamebx.Multiline = true;
            Signup_firstnamebx.Name = "Signup_firstnamebx";
            Signup_firstnamebx.PlaceholderText = "Enter your First Name";
            Signup_firstnamebx.Size = new Size(300, 29);
            Signup_firstnamebx.TabIndex = 16;
            // 
            // signup_Firstnamelbl
            // 
            signup_Firstnamelbl.AutoSize = true;
            signup_Firstnamelbl.BackColor = Color.Transparent;
            signup_Firstnamelbl.Font = new Font("Bell MT", 13.8239994F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signup_Firstnamelbl.ForeColor = Color.FromArgb(255, 255, 204);
            signup_Firstnamelbl.Location = new Point(179, 124);
            signup_Firstnamelbl.Name = "signup_Firstnamelbl";
            signup_Firstnamelbl.Size = new Size(132, 29);
            signup_Firstnamelbl.TabIndex = 14;
            signup_Firstnamelbl.Text = "First Name";
            signup_Firstnamelbl.Click += label2_Click;
            // 
            // signup_wellcomebx
            // 
            signup_wellcomebx.AutoSize = true;
            signup_wellcomebx.BackColor = Color.Transparent;
            signup_wellcomebx.Font = new Font("Ravie", 36.288F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signup_wellcomebx.ForeColor = Color.FromArgb(255, 255, 204);
            signup_wellcomebx.Location = new Point(290, 21);
            signup_wellcomebx.Name = "signup_wellcomebx";
            signup_wellcomebx.Size = new Size(515, 95);
            signup_wellcomebx.TabIndex = 13;
            signup_wellcomebx.Text = "WELLCOME";
            signup_wellcomebx.TextAlign = ContentAlignment.MiddleCenter;
            signup_wellcomebx.UseCompatibleTextRendering = true;
            signup_wellcomebx.Click += signup_wellcomebx_Click;
            // 
            // Wellcome_page
            // 
            Wellcome_page.BackColor = SystemColors.ButtonShadow;
            Wellcome_page.BackgroundImage = d_labdemo.Properties.Resources.Presentation3_Page_01;
            Wellcome_page.BackgroundImageLayout = ImageLayout.Stretch;
            Wellcome_page.Controls.Add(Wellcome_signupbtn);
            Wellcome_page.Controls.Add(Wellcome_loginbtn);
            Wellcome_page.Dock = DockStyle.Fill;
            Wellcome_page.Location = new Point(0, 0);
            Wellcome_page.MaximumSize = new Size(1210, 735);
            Wellcome_page.MinimumSize = new Size(1210, 735);
            Wellcome_page.Name = "Wellcome_page";
            Wellcome_page.Size = new Size(1210, 735);
            Wellcome_page.TabIndex = 2;
            Wellcome_page.Paint += Wellcome_page_Paint;
            // 
            // Wellcome_signupbtn
            // 
            Wellcome_signupbtn.Anchor = AnchorStyles.None;
            Wellcome_signupbtn.AutoSize = true;
            Wellcome_signupbtn.BackColor = Color.FromArgb(11, 40, 39);
            Wellcome_signupbtn.Cursor = Cursors.Hand;
            Wellcome_signupbtn.Font = new Font("Segoe UI", 13.8239994F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Wellcome_signupbtn.ForeColor = Color.White;
            Wellcome_signupbtn.Location = new Point(453, 388);
            Wellcome_signupbtn.Name = "Wellcome_signupbtn";
            Wellcome_signupbtn.Size = new Size(183, 67);
            Wellcome_signupbtn.TabIndex = 1;
            Wellcome_signupbtn.Text = "SIGN UP";
            Wellcome_signupbtn.UseVisualStyleBackColor = false;
            Wellcome_signupbtn.Click += Wellcome_signupbtn_Click;
            // 
            // Wellcome_loginbtn
            // 
            Wellcome_loginbtn.Anchor = AnchorStyles.None;
            Wellcome_loginbtn.BackColor = Color.FromArgb(11, 40, 39);
            Wellcome_loginbtn.Cursor = Cursors.Hand;
            Wellcome_loginbtn.Font = new Font("Segoe UI", 13.8239994F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Wellcome_loginbtn.ForeColor = Color.White;
            Wellcome_loginbtn.Location = new Point(130, 388);
            Wellcome_loginbtn.Name = "Wellcome_loginbtn";
            Wellcome_loginbtn.Size = new Size(183, 67);
            Wellcome_loginbtn.TabIndex = 0;
            Wellcome_loginbtn.Text = "LOG IN";
            Wellcome_loginbtn.UseVisualStyleBackColor = false;
            Wellcome_loginbtn.Click += Wellcome_loginbtn_Click;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(35, 40, 45);
            sidebar.Controls.Add(Study_assistbtn);
            sidebar.Controls.Add(Usersbtn);
            sidebar.Controls.Add(Bookbtn);
            sidebar.Controls.Add(Homebtn);
            sidebar.Controls.Add(profile_sidebarpnl);
            sidebar.Controls.Add(settignbtn);
            sidebar.Controls.Add(menuStrip1);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(225, 735);
            sidebar.TabIndex = 0;
            // 
            // Study_assistbtn
            // 
            Study_assistbtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Study_assistbtn.BackColor = Color.FromArgb(30, 40, 45);
            Study_assistbtn.Cursor = Cursors.Hand;
            Study_assistbtn.Dock = DockStyle.Top;
            Study_assistbtn.FlatAppearance.BorderSize = 0;
            Study_assistbtn.FlatAppearance.CheckedBackColor = Color.White;
            Study_assistbtn.FlatAppearance.MouseOverBackColor = Color.Black;
            Study_assistbtn.FlatStyle = FlatStyle.Flat;
            Study_assistbtn.ForeColor = Color.LightYellow;
            Study_assistbtn.Location = new Point(0, 225);
            Study_assistbtn.Name = "Study_assistbtn";
            Study_assistbtn.Size = new Size(225, 57);
            Study_assistbtn.TabIndex = 6;
            Study_assistbtn.Text = "🏠︎ study";
            Study_assistbtn.UseVisualStyleBackColor = false;
            Study_assistbtn.Click += Study_assistbtn_Click;
            // 
            // Usersbtn
            // 
            Usersbtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Usersbtn.BackColor = Color.FromArgb(30, 40, 45);
            Usersbtn.Cursor = Cursors.Hand;
            Usersbtn.Dock = DockStyle.Top;
            Usersbtn.FlatAppearance.BorderSize = 0;
            Usersbtn.FlatAppearance.CheckedBackColor = Color.White;
            Usersbtn.FlatAppearance.MouseOverBackColor = Color.Black;
            Usersbtn.FlatStyle = FlatStyle.Flat;
            Usersbtn.ForeColor = Color.LightYellow;
            Usersbtn.Location = new Point(0, 181);
            Usersbtn.Name = "Usersbtn";
            Usersbtn.Size = new Size(225, 44);
            Usersbtn.TabIndex = 7;
            Usersbtn.Text = "👤  Users";
            Usersbtn.UseVisualStyleBackColor = false;
            Usersbtn.Click += Usersbtn_Click;
            // 
            // Bookbtn
            // 
            Bookbtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Bookbtn.BackColor = Color.FromArgb(30, 40, 45);
            Bookbtn.Cursor = Cursors.Hand;
            Bookbtn.Dock = DockStyle.Top;
            Bookbtn.FlatAppearance.BorderSize = 0;
            Bookbtn.FlatAppearance.CheckedBackColor = Color.White;
            Bookbtn.FlatAppearance.MouseOverBackColor = Color.Black;
            Bookbtn.FlatStyle = FlatStyle.Flat;
            Bookbtn.ForeColor = Color.LightYellow;
            Bookbtn.Location = new Point(0, 137);
            Bookbtn.Name = "Bookbtn";
            Bookbtn.Size = new Size(225, 44);
            Bookbtn.TabIndex = 9;
            Bookbtn.Text = "📊  Books";
            Bookbtn.UseVisualStyleBackColor = false;
            Bookbtn.Click += Booksbtn_Click;
            // 
            // Homebtn
            // 
            Homebtn.AutoEllipsis = true;
            Homebtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Homebtn.BackColor = Color.FromArgb(30, 40, 45);
            Homebtn.Cursor = Cursors.Hand;
            Homebtn.Dock = DockStyle.Top;
            Homebtn.FlatAppearance.BorderSize = 0;
            Homebtn.FlatAppearance.CheckedBackColor = Color.White;
            Homebtn.FlatAppearance.MouseOverBackColor = Color.Black;
            Homebtn.FlatStyle = FlatStyle.Flat;
            Homebtn.ForeColor = Color.LightYellow;
            Homebtn.Location = new Point(0, 93);
            Homebtn.Name = "Homebtn";
            Homebtn.Size = new Size(225, 44);
            Homebtn.TabIndex = 8;
            Homebtn.Text = "🏠︎ Home";
            Homebtn.UseVisualStyleBackColor = false;
            Homebtn.Click += Homebtn_Click;
            // 
            // profile_sidebarpnl
            // 
            profile_sidebarpnl.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            profile_sidebarpnl.Controls.Add(label1);
            profile_sidebarpnl.Dock = DockStyle.Top;
            profile_sidebarpnl.Location = new Point(0, 0);
            profile_sidebarpnl.Name = "profile_sidebarpnl";
            profile_sidebarpnl.Size = new Size(225, 93);
            profile_sidebarpnl.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Harlow Solid Italic", 36.288F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 255, 128);
            label1.Location = new Point(21, 6);
            label1.Name = "label1";
            label1.Size = new Size(182, 79);
            label1.TabIndex = 0;
            label1.Text = "D-lab";
            // 
            // settignbtn
            // 
            settignbtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            settignbtn.BackColor = Color.FromArgb(30, 40, 45);
            settignbtn.Dock = DockStyle.Bottom;
            settignbtn.FlatAppearance.BorderSize = 0;
            settignbtn.FlatAppearance.CheckedBackColor = Color.White;
            settignbtn.FlatAppearance.MouseOverBackColor = Color.Black;
            settignbtn.FlatStyle = FlatStyle.Flat;
            settignbtn.Font = new Font("Segoe UI", 8.064F, FontStyle.Regular, GraphicsUnit.Point, 0);
            settignbtn.ForeColor = Color.LightYellow;
            settignbtn.Location = new Point(0, 691);
            settignbtn.Margin = new Padding(0, 0, 0, 3);
            settignbtn.Name = "settignbtn";
            settignbtn.Size = new Size(225, 44);
            settignbtn.TabIndex = 5;
            settignbtn.Text = "⚙️ Setting";
            settignbtn.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.GripStyle = ToolStripGripStyle.Visible;
            menuStrip1.ImageScalingSize = new Size(21, 21);
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(211, 24);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "menuStrip1";
            // 
            // Admin_userspnl
            // 
            Admin_userspnl.BackColor = Color.FromArgb(192, 192, 255);
            Admin_userspnl.Controls.Add(updatebtn);
            Admin_userspnl.Controls.Add(Admin_useresdatagrid);
            Admin_userspnl.Controls.Add(fetch_databtn);
            Admin_userspnl.Dock = DockStyle.Fill;
            Admin_userspnl.Location = new Point(225, 0);
            Admin_userspnl.Name = "Admin_userspnl";
            Admin_userspnl.Size = new Size(985, 735);
            Admin_userspnl.TabIndex = 3;
            // 
            // updatebtn
            // 
            updatebtn.Location = new Point(786, 12);
            updatebtn.Name = "updatebtn";
            updatebtn.Size = new Size(136, 34);
            updatebtn.TabIndex = 2;
            updatebtn.Text = "Update";
            updatebtn.UseVisualStyleBackColor = true;
            updatebtn.Click += updatebtn_Click;
            // 
            // Admin_useresdatagrid
            // 
            Admin_useresdatagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Admin_useresdatagrid.BackgroundColor = Color.White;
            Admin_useresdatagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Admin_useresdatagrid.Location = new Point(0, 57);
            Admin_useresdatagrid.Name = "Admin_useresdatagrid";
            Admin_useresdatagrid.RowHeadersWidth = 53;
            Admin_useresdatagrid.Size = new Size(985, 678);
            Admin_useresdatagrid.TabIndex = 1;
            // 
            // fetch_databtn
            // 
            fetch_databtn.Location = new Point(29, 12);
            fetch_databtn.Name = "fetch_databtn";
            fetch_databtn.Size = new Size(136, 34);
            fetch_databtn.TabIndex = 0;
            fetch_databtn.Text = "Fetch data";
            fetch_databtn.UseVisualStyleBackColor = true;
            fetch_databtn.Click += fetch_databtn_Click;
            // 
            // profilepnl
            // 
            profilepnl.BackColor = Color.PowderBlue;
            profilepnl.Controls.Add(profilepic_updatebtn);
            profilepnl.Controls.Add(Profile_lastnamebx);
            profilepnl.Controls.Add(Profile_usernamebx);
            profilepnl.Controls.Add(Profile_firstnamebx);
            profilepnl.Controls.Add(Profile_usernamelbl);
            profilepnl.Controls.Add(Profile_lastnamelbl);
            profilepnl.Controls.Add(Profile_firstnamelbl);
            profilepnl.Controls.Add(Profilepic);
            profilepnl.Dock = DockStyle.Fill;
            profilepnl.Location = new Point(225, 0);
            profilepnl.Name = "profilepnl";
            profilepnl.Size = new Size(985, 735);
            profilepnl.TabIndex = 3;
            // 
            // profilepic_updatebtn
            // 
            profilepic_updatebtn.BackColor = Color.Black;
            profilepic_updatebtn.FlatAppearance.BorderSize = 0;
            profilepic_updatebtn.FlatStyle = FlatStyle.Flat;
            profilepic_updatebtn.ForeColor = Color.White;
            profilepic_updatebtn.Location = new Point(190, 137);
            profilepic_updatebtn.Name = "profilepic_updatebtn";
            profilepic_updatebtn.Size = new Size(39, 35);
            profilepic_updatebtn.TabIndex = 18;
            profilepic_updatebtn.Text = "✏️";
            profilepic_updatebtn.UseVisualStyleBackColor = false;
            profilepic_updatebtn.Click += profilepic_updatebtn_Click;
            // 
            // Profile_lastnamebx
            // 
            Profile_lastnamebx.BackColor = Color.PowderBlue;
            Profile_lastnamebx.Location = new Point(480, 117);
            Profile_lastnamebx.Name = "Profile_lastnamebx";
            Profile_lastnamebx.Size = new Size(352, 29);
            Profile_lastnamebx.TabIndex = 17;
            // 
            // Profile_usernamebx
            // 
            Profile_usernamebx.BackColor = Color.PowderBlue;
            Profile_usernamebx.Location = new Point(480, 187);
            Profile_usernamebx.Name = "Profile_usernamebx";
            Profile_usernamebx.Size = new Size(352, 29);
            Profile_usernamebx.TabIndex = 16;
            // 
            // Profile_firstnamebx
            // 
            Profile_firstnamebx.BackColor = Color.PowderBlue;
            Profile_firstnamebx.Location = new Point(480, 49);
            Profile_firstnamebx.Name = "Profile_firstnamebx";
            Profile_firstnamebx.Size = new Size(352, 29);
            Profile_firstnamebx.TabIndex = 15;
            // 
            // Profile_usernamelbl
            // 
            Profile_usernamelbl.AutoSize = true;
            Profile_usernamelbl.Font = new Font("Segoe UI Semibold", 12.096F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Profile_usernamelbl.Location = new Point(287, 186);
            Profile_usernamelbl.Name = "Profile_usernamelbl";
            Profile_usernamelbl.Size = new Size(119, 30);
            Profile_usernamelbl.TabIndex = 14;
            Profile_usernamelbl.Text = "User Name";
            // 
            // Profile_lastnamelbl
            // 
            Profile_lastnamelbl.AutoSize = true;
            Profile_lastnamelbl.Font = new Font("Segoe UI Semibold", 12.096F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Profile_lastnamelbl.Location = new Point(287, 116);
            Profile_lastnamelbl.Name = "Profile_lastnamelbl";
            Profile_lastnamelbl.Size = new Size(114, 30);
            Profile_lastnamelbl.TabIndex = 2;
            Profile_lastnamelbl.Text = "Last Name";
            // 
            // Profile_firstnamelbl
            // 
            Profile_firstnamelbl.AutoSize = true;
            Profile_firstnamelbl.Font = new Font("Segoe UI Semibold", 12.096F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Profile_firstnamelbl.Location = new Point(287, 49);
            Profile_firstnamelbl.Name = "Profile_firstnamelbl";
            Profile_firstnamelbl.Size = new Size(117, 30);
            Profile_firstnamelbl.TabIndex = 1;
            Profile_firstnamelbl.Text = "First Name";
            // 
            // Profilepic
            // 
            Profilepic.BackColor = Color.DarkSlateGray;
            Profilepic.BackgroundImage = d_labdemo.Properties.Resources.Screenshot_2026_05_13_222611;
            Profilepic.BackgroundImageLayout = ImageLayout.Stretch;
            Profilepic.Location = new Point(49, 28);
            Profilepic.Name = "Profilepic";
            Profilepic.Size = new Size(180, 146);
            Profilepic.TabIndex = 0;
            Profilepic.TabStop = false;
            // 
            // Homepagepnl
            // 
            Homepagepnl.BackColor = Color.Black;
            Homepagepnl.Controls.Add(Homepnl);
            Homepagepnl.Controls.Add(profilepnl);
            Homepagepnl.Controls.Add(Admin_userspnl);
            Homepagepnl.Controls.Add(Studypnl);
            Homepagepnl.Controls.Add(Book_catagorypnl);
            Homepagepnl.Controls.Add(sidebar);
            Homepagepnl.Dock = DockStyle.Fill;
            Homepagepnl.Location = new Point(0, 0);
            Homepagepnl.Name = "Homepagepnl";
            Homepagepnl.Size = new Size(1210, 735);
            Homepagepnl.TabIndex = 0;
            // 
            // Homepnl
            // 
            Homepnl.BackColor = SystemColors.InactiveBorder;
            Homepnl.BorderStyle = BorderStyle.Fixed3D;
            Homepnl.Controls.Add(Home_bookspnl);
            Homepnl.Dock = DockStyle.Fill;
            Homepnl.Location = new Point(225, 0);
            Homepnl.Name = "Homepnl";
            Homepnl.Size = new Size(985, 735);
            Homepnl.TabIndex = 1;
            // 
            // Home_bookspnl
            // 
            Home_bookspnl.BackColor = SystemColors.GradientActiveCaption;
            Home_bookspnl.Dock = DockStyle.Top;
            Home_bookspnl.Location = new Point(0, 0);
            Home_bookspnl.Name = "Home_bookspnl";
            Home_bookspnl.Size = new Size(981, 61);
            Home_bookspnl.TabIndex = 0;
            // 
            // Studypnl
            // 
            Studypnl.BackColor = Color.FromArgb(192, 255, 192);
            Studypnl.Controls.Add(Study_timepnl);
            Studypnl.Dock = DockStyle.Fill;
            Studypnl.Location = new Point(225, 0);
            Studypnl.Name = "Studypnl";
            Studypnl.Size = new Size(985, 735);
            Studypnl.TabIndex = 0;
            // 
            // Study_timepnl
            // 
            Study_timepnl.BackColor = Color.Black;
            Study_timepnl.Controls.Add(Timer_countdownlbl);
            Study_timepnl.Controls.Add(Timer_amountbx);
            Study_timepnl.Controls.Add(Timer_typelbl);
            Study_timepnl.Controls.Add(Timer_startbtn);
            Study_timepnl.Location = new Point(0, 0);
            Study_timepnl.Name = "Study_timepnl";
            Study_timepnl.Size = new Size(294, 172);
            Study_timepnl.TabIndex = 0;
            // 
            // Timer_countdownlbl
            // 
            Timer_countdownlbl.AutoSize = true;
            Timer_countdownlbl.BackColor = Color.FromArgb(192, 255, 192);
            Timer_countdownlbl.Font = new Font("Segoe UI", 25.92F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Timer_countdownlbl.Location = new Point(83, 12);
            Timer_countdownlbl.Name = "Timer_countdownlbl";
            Timer_countdownlbl.Size = new Size(133, 61);
            Timer_countdownlbl.TabIndex = 3;
            Timer_countdownlbl.Text = "00:00";
            // 
            // Timer_amountbx
            // 
            Timer_amountbx.BackColor = Color.FromArgb(192, 255, 192);
            Timer_amountbx.Font = new Font("Segoe UI", 9.792F);
            Timer_amountbx.Location = new Point(100, 116);
            Timer_amountbx.Name = "Timer_amountbx";
            Timer_amountbx.Size = new Size(106, 30);
            Timer_amountbx.TabIndex = 2;
            Timer_amountbx.Text = "10";
            // 
            // Timer_typelbl
            // 
            Timer_typelbl.AutoSize = true;
            Timer_typelbl.BackColor = Color.FromArgb(192, 255, 192);
            Timer_typelbl.Font = new Font("Segoe UI", 9.792F);
            Timer_typelbl.Location = new Point(212, 119);
            Timer_typelbl.Name = "Timer_typelbl";
            Timer_typelbl.Size = new Size(64, 23);
            Timer_typelbl.TabIndex = 1;
            Timer_typelbl.Text = "Minute";
            // 
            // Timer_startbtn
            // 
            Timer_startbtn.BackColor = Color.FromArgb(192, 255, 192);
            Timer_startbtn.Location = new Point(12, 114);
            Timer_startbtn.Name = "Timer_startbtn";
            Timer_startbtn.Size = new Size(82, 40);
            Timer_startbtn.TabIndex = 0;
            Timer_startbtn.Text = "START";
            Timer_startbtn.UseVisualStyleBackColor = false;
            Timer_startbtn.Click += Timer_startbtn_Click;
            // 
            // Book_catagorypnl
            // 
            Book_catagorypnl.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Book_catagorypnl.BackColor = Color.FromArgb(128, 64, 64);
            Book_catagorypnl.Controls.Add(Book_catagorytab);
            Book_catagorypnl.Dock = DockStyle.Fill;
            Book_catagorypnl.Location = new Point(225, 0);
            Book_catagorypnl.Name = "Book_catagorypnl";
            Book_catagorypnl.Size = new Size(985, 735);
            Book_catagorypnl.TabIndex = 7;
            Book_catagorypnl.TabStop = true;
            // 
            // Study_timer
            // 
            Study_timer.Enabled = true;
            Study_timer.Interval = 1000;
            Study_timer.Tick += Study_timer_Tick;
            // 
            // d_lab
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1210, 735);
            Controls.Add(Homepagepnl);
            Controls.Add(Wellcome_page);
            Controls.Add(loginpnl);
            Controls.Add(signuppnl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimumSize = new Size(1108, 700);
            Name = "d_lab";
            Text = "d_lab";
            Book_catagorytab.ResumeLayout(false);
            loginpnl.ResumeLayout(false);
            loginpnl.PerformLayout();
            signuppnl.ResumeLayout(false);
            signuppnl.PerformLayout();
            Wellcome_page.ResumeLayout(false);
            Wellcome_page.PerformLayout();
            sidebar.ResumeLayout(false);
            sidebar.PerformLayout();
            profile_sidebarpnl.ResumeLayout(false);
            profile_sidebarpnl.PerformLayout();
            Admin_userspnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Admin_useresdatagrid).EndInit();
            profilepnl.ResumeLayout(false);
            profilepnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Profilepic).EndInit();
            Homepagepnl.ResumeLayout(false);
            Homepnl.ResumeLayout(false);
            Studypnl.ResumeLayout(false);
            Study_timepnl.ResumeLayout(false);
            Study_timepnl.PerformLayout();
            Book_catagorypnl.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel loginpnl;
        private Button logibtn;
        private TextBox passbx;
        private TextBox namebx;
        private Label passlbl;
        private Label usernamelbl;
        private Label welcome_labele;
        private LinkLabel login_signup;
        private TabPage Programmingtab;
        private TabPage Medicinetab;
        private TabPage Noveltab;
        private Panel signuppnl;
        private LinkLabel Signup_loginlink;
        private Button signupbtn;
        private TextBox Signup_firstnamebx;
        private Label signup_Firstnamelbl;
        private Label signup_wellcomebx;
        private TextBox Signup_usernamebx;
        private Label signpass;
        private TextBox Signup_passbx;
        private Label Signup_Usernamelbl;
        private Panel Wellcome_page;
        private Button Wellcome_signupbtn;
        private Button Wellcome_loginbtn;
        private Panel sidebar;
        private Panel Admin_userspnl;
        private Button fetch_databtn;
        private Button updatebtn;
        private Panel profilepnl;
        private Label Signup_Lastnamelbl;
        private TextBox Signup_lastnamebx;
        private Panel Homepagepnl;
        private Panel Book_catagorypnl;
        private Panel Studypnl;
        private Panel Homepnl;
        public TabControl Book_catagorytab;
        private PictureBox Profilepic;
        private Label Profile_usernamelbl;
        private Label Profile_lastnamelbl;
        private Label Profile_firstnamelbl;
        private TextBox Profile_lastnamebx;
        private TextBox Profile_usernamebx;
        private TextBox Profile_firstnamebx;
        private ComboBox Signip_rolecbx;
        private Label Signip_rolelbl;
        private DataGridView Admin_useresdatagrid;
        private Panel Home_bookspnl;
        private Panel Study_timepnl;
        private System.Windows.Forms.Timer Study_timer;
        private Button Timer_startbtn;
        private Label Timer_typelbl;
        private TextBox Timer_amountbx;
        private Label Timer_countdownlbl;
        private Button Study_assistbtn;
        private Button Usersbtn;
        private Button Bookbtn;
        private Button Homebtn;
        private Panel profile_sidebarpnl;
        private Button profilepic_updatebtn;
        private Button settignbtn;
        private Label label1;
        private MenuStrip menuStrip1;
    }
}
