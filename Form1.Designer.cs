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
            Userpnl = new Panel();
            User_sidebar = new Panel();
            User_study_assistbtn = new Button();
            User_favoritebtn = new Button();
            User_shelfbtn = new Button();
            User_homebtn = new Button();
            User_settingbtn = new Button();
            tabControl1 = new TabControl();
            Programmingtab = new TabPage();
            Medicinetab = new TabPage();
            Noveltab = new TabPage();
            panel1 = new Panel();
            button1 = new Button();
            linkLabel2 = new LinkLabel();
            loginpnl = new Panel();
            login_signup = new LinkLabel();
            logibtn = new Button();
            passbx = new TextBox();
            namebx = new TextBox();
            passlbl = new Label();
            usernamelbl = new Label();
            welcome_labele = new Label();
            librarianpnl = new Panel();
            signuppnl = new Panel();
            textBox1 = new TextBox();
            signusername = new Label();
            signpass = new Label();
            signpassbx = new TextBox();
            Signup_loginlink = new LinkLabel();
            signupbtn = new Button();
            signnfamebx = new TextBox();
            signfname = new Label();
            signup_wellcomebx = new Label();
            Wellcome_page = new Panel();
            Wellcome_signupbtn = new Button();
            Wellcome_loginbtn = new Button();
            Titlepnl = new Panel();
            menubtn = new Button();
            profilelnk = new LinkLabel();
            sidebar = new Panel();
            Usersbtn = new Button();
            Shelfbtn = new Button();
            button2 = new Button();
            settignbtn = new Button();
            adminpnl = new Panel();
            Admin_userspnl = new Panel();
            User_tabeltbl = new DataGridView();
            fetch_databtn = new Button();
            Admin_homepnl = new Panel();
            Admin_shelfpnl = new Panel();
            Userpnl.SuspendLayout();
            User_sidebar.SuspendLayout();
            tabControl1.SuspendLayout();
            panel1.SuspendLayout();
            loginpnl.SuspendLayout();
            signuppnl.SuspendLayout();
            Wellcome_page.SuspendLayout();
            Titlepnl.SuspendLayout();
            sidebar.SuspendLayout();
            adminpnl.SuspendLayout();
            Admin_userspnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)User_tabeltbl).BeginInit();
            SuspendLayout();
            // 
            // Userpnl
            // 
            Userpnl.BackColor = Color.FromArgb(188, 193, 199);
            Userpnl.Controls.Add(User_sidebar);
            Userpnl.Controls.Add(tabControl1);
            Userpnl.Controls.Add(panel1);
            Userpnl.Dock = DockStyle.Fill;
            Userpnl.Location = new Point(0, 0);
            Userpnl.Name = "Userpnl";
            Userpnl.Size = new Size(1090, 641);
            Userpnl.TabIndex = 7;
            // 
            // User_sidebar
            // 
            User_sidebar.BackColor = Color.FromArgb(35, 40, 45);
            User_sidebar.BorderStyle = BorderStyle.Fixed3D;
            User_sidebar.Controls.Add(User_study_assistbtn);
            User_sidebar.Controls.Add(User_favoritebtn);
            User_sidebar.Controls.Add(User_shelfbtn);
            User_sidebar.Controls.Add(User_homebtn);
            User_sidebar.Controls.Add(User_settingbtn);
            User_sidebar.Dock = DockStyle.Left;
            User_sidebar.Location = new Point(0, 63);
            User_sidebar.MaximumSize = new Size(190, 999);
            User_sidebar.MinimumSize = new Size(107, 526);
            User_sidebar.Name = "User_sidebar";
            User_sidebar.Size = new Size(166, 578);
            User_sidebar.TabIndex = 3;
            // 
            // User_study_assistbtn
            // 
            User_study_assistbtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            User_study_assistbtn.BackColor = Color.FromArgb(30, 40, 45);
            User_study_assistbtn.Cursor = Cursors.Hand;
            User_study_assistbtn.Dock = DockStyle.Top;
            User_study_assistbtn.FlatAppearance.BorderSize = 0;
            User_study_assistbtn.FlatAppearance.CheckedBackColor = Color.White;
            User_study_assistbtn.FlatAppearance.MouseOverBackColor = Color.Black;
            User_study_assistbtn.FlatStyle = FlatStyle.Flat;
            User_study_assistbtn.ForeColor = Color.LightYellow;
            User_study_assistbtn.Location = new Point(0, 132);
            User_study_assistbtn.Name = "User_study_assistbtn";
            User_study_assistbtn.Size = new Size(162, 57);
            User_study_assistbtn.TabIndex = 6;
            User_study_assistbtn.Text = "🏠︎ study";
            User_study_assistbtn.UseVisualStyleBackColor = false;
            // 
            // User_favoritebtn
            // 
            User_favoritebtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            User_favoritebtn.BackColor = Color.FromArgb(30, 40, 45);
            User_favoritebtn.Cursor = Cursors.Hand;
            User_favoritebtn.Dock = DockStyle.Top;
            User_favoritebtn.FlatAppearance.BorderSize = 0;
            User_favoritebtn.FlatAppearance.CheckedBackColor = Color.White;
            User_favoritebtn.FlatAppearance.MouseOverBackColor = Color.Black;
            User_favoritebtn.FlatStyle = FlatStyle.Flat;
            User_favoritebtn.ForeColor = Color.LightYellow;
            User_favoritebtn.Location = new Point(0, 88);
            User_favoritebtn.Name = "User_favoritebtn";
            User_favoritebtn.Size = new Size(162, 44);
            User_favoritebtn.TabIndex = 7;
            User_favoritebtn.Text = "❤️Favorites";
            User_favoritebtn.UseVisualStyleBackColor = false;
            User_favoritebtn.Click += User_favoritebtn_Click;
            // 
            // User_shelfbtn
            // 
            User_shelfbtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            User_shelfbtn.BackColor = Color.FromArgb(30, 40, 45);
            User_shelfbtn.Cursor = Cursors.Hand;
            User_shelfbtn.Dock = DockStyle.Top;
            User_shelfbtn.FlatAppearance.BorderSize = 0;
            User_shelfbtn.FlatAppearance.CheckedBackColor = Color.White;
            User_shelfbtn.FlatAppearance.MouseOverBackColor = Color.Black;
            User_shelfbtn.FlatStyle = FlatStyle.Flat;
            User_shelfbtn.ForeColor = Color.LightYellow;
            User_shelfbtn.Location = new Point(0, 44);
            User_shelfbtn.Name = "User_shelfbtn";
            User_shelfbtn.Size = new Size(162, 44);
            User_shelfbtn.TabIndex = 9;
            User_shelfbtn.Text = "📊  Shelf";
            User_shelfbtn.UseVisualStyleBackColor = false;
            User_shelfbtn.Click += User_shelfbtn_Click;
            // 
            // User_homebtn
            // 
            User_homebtn.AutoEllipsis = true;
            User_homebtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            User_homebtn.BackColor = Color.FromArgb(30, 40, 45);
            User_homebtn.Cursor = Cursors.Hand;
            User_homebtn.Dock = DockStyle.Top;
            User_homebtn.FlatAppearance.BorderSize = 0;
            User_homebtn.FlatAppearance.CheckedBackColor = Color.White;
            User_homebtn.FlatAppearance.MouseOverBackColor = Color.Black;
            User_homebtn.FlatStyle = FlatStyle.Flat;
            User_homebtn.ForeColor = Color.LightYellow;
            User_homebtn.Location = new Point(0, 0);
            User_homebtn.Name = "User_homebtn";
            User_homebtn.Size = new Size(162, 44);
            User_homebtn.TabIndex = 8;
            User_homebtn.Text = "🏠︎ Home";
            User_homebtn.UseVisualStyleBackColor = false;
            // 
            // User_settingbtn
            // 
            User_settingbtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            User_settingbtn.BackColor = Color.FromArgb(30, 40, 45);
            User_settingbtn.Dock = DockStyle.Bottom;
            User_settingbtn.FlatAppearance.BorderSize = 0;
            User_settingbtn.FlatAppearance.CheckedBackColor = Color.White;
            User_settingbtn.FlatAppearance.MouseOverBackColor = Color.Black;
            User_settingbtn.FlatStyle = FlatStyle.Flat;
            User_settingbtn.Font = new Font("Segoe UI", 8.064F, FontStyle.Regular, GraphicsUnit.Point, 0);
            User_settingbtn.ForeColor = Color.LightYellow;
            User_settingbtn.Location = new Point(0, 530);
            User_settingbtn.Margin = new Padding(0, 0, 0, 3);
            User_settingbtn.Name = "User_settingbtn";
            User_settingbtn.Size = new Size(162, 44);
            User_settingbtn.TabIndex = 5;
            User_settingbtn.Text = "⚙️ Setting";
            User_settingbtn.UseVisualStyleBackColor = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Programmingtab);
            tabControl1.Controls.Add(Medicinetab);
            tabControl1.Controls.Add(Noveltab);
            tabControl1.Dock = DockStyle.Right;
            tabControl1.Location = new Point(175, 63);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(915, 578);
            tabControl1.TabIndex = 4;
            // 
            // Programmingtab
            // 
            Programmingtab.AccessibleName = "";
            Programmingtab.AllowDrop = true;
            Programmingtab.BackColor = SystemColors.ActiveBorder;
            Programmingtab.Cursor = Cursors.Hand;
            Programmingtab.Font = new Font("Segoe UI Semibold", 9.216F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Programmingtab.Location = new Point(4, 30);
            Programmingtab.Name = "Programmingtab";
            Programmingtab.Padding = new Padding(3);
            Programmingtab.Size = new Size(907, 544);
            Programmingtab.TabIndex = 0;
            Programmingtab.Text = "Programming";
            // 
            // Medicinetab
            // 
            Medicinetab.BackColor = SystemColors.ActiveBorder;
            Medicinetab.Location = new Point(4, 30);
            Medicinetab.Name = "Medicinetab";
            Medicinetab.Padding = new Padding(3);
            Medicinetab.Size = new Size(907, 544);
            Medicinetab.TabIndex = 1;
            Medicinetab.Text = "Medicine";
            // 
            // Noveltab
            // 
            Noveltab.Location = new Point(4, 30);
            Noveltab.Name = "Noveltab";
            Noveltab.Size = new Size(907, 544);
            Noveltab.TabIndex = 2;
            Noveltab.Text = "Novel tab";
            Noveltab.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(linkLabel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1090, 63);
            panel1.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Left;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.CheckedBackColor = Color.White;
            button1.FlatAppearance.MouseOverBackColor = Color.Black;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 21.8879986F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.LightYellow;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(107, 63);
            button1.TabIndex = 3;
            button1.Text = "☰";
            button1.UseVisualStyleBackColor = false;
            // 
            // linkLabel2
            // 
            linkLabel2.ActiveLinkColor = SystemColors.ActiveCaption;
            linkLabel2.AutoSize = true;
            linkLabel2.Dock = DockStyle.Right;
            linkLabel2.Font = new Font("Segoe UI Semibold", 12.096F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel2.LinkColor = Color.AliceBlue;
            linkLabel2.Location = new Point(979, 0);
            linkLabel2.Margin = new Padding(3, 3, 3, 0);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(111, 30);
            linkLabel2.TabIndex = 0;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "👤 profile";
            linkLabel2.VisitedLinkColor = Color.Blue;
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
            loginpnl.Name = "loginpnl";
            loginpnl.Size = new Size(1090, 641);
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
            logibtn.Click += logibtn_Click;
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
            // librarianpnl
            // 
            librarianpnl.BackColor = SystemColors.ControlDarkDark;
            librarianpnl.Dock = DockStyle.Fill;
            librarianpnl.Location = new Point(0, 0);
            librarianpnl.Name = "librarianpnl";
            librarianpnl.Size = new Size(1090, 641);
            librarianpnl.TabIndex = 13;
            // 
            // signuppnl
            // 
            signuppnl.BackgroundImage = d_labdemo.Properties.Resources.Bookshelf_Wallpaper_Desktop_HD__1_;
            signuppnl.BackgroundImageLayout = ImageLayout.Stretch;
            signuppnl.Controls.Add(textBox1);
            signuppnl.Controls.Add(signusername);
            signuppnl.Controls.Add(signpass);
            signuppnl.Controls.Add(signpassbx);
            signuppnl.Controls.Add(Signup_loginlink);
            signuppnl.Controls.Add(signupbtn);
            signuppnl.Controls.Add(signnfamebx);
            signuppnl.Controls.Add(signfname);
            signuppnl.Controls.Add(signup_wellcomebx);
            signuppnl.Dock = DockStyle.Fill;
            signuppnl.Location = new Point(0, 0);
            signuppnl.Name = "signuppnl";
            signuppnl.Size = new Size(1090, 641);
            signuppnl.TabIndex = 13;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LightYellow;
            textBox1.Location = new Point(478, 326);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Password";
            textBox1.Size = new Size(300, 29);
            textBox1.TabIndex = 23;
            textBox1.UseSystemPasswordChar = true;
            // 
            // signusername
            // 
            signusername.AutoSize = true;
            signusername.BackColor = Color.Transparent;
            signusername.Font = new Font("Bell MT", 12.096F, FontStyle.Bold);
            signusername.ForeColor = Color.LightYellow;
            signusername.Location = new Point(290, 242);
            signusername.Name = "signusername";
            signusername.Size = new Size(110, 25);
            signusername.TabIndex = 22;
            signusername.Text = "User name";
            // 
            // signpass
            // 
            signpass.AutoSize = true;
            signpass.BackColor = Color.Transparent;
            signpass.Font = new Font("Bell MT", 12.096F, FontStyle.Bold);
            signpass.ForeColor = Color.LightYellow;
            signpass.Location = new Point(290, 326);
            signpass.Name = "signpass";
            signpass.Size = new Size(97, 25);
            signpass.TabIndex = 21;
            signpass.Text = "password";
            // 
            // signpassbx
            // 
            signpassbx.BackColor = Color.LightYellow;
            signpassbx.Location = new Point(478, 242);
            signpassbx.Multiline = true;
            signpassbx.Name = "signpassbx";
            signpassbx.PlaceholderText = "Username";
            signpassbx.Size = new Size(300, 29);
            signpassbx.TabIndex = 20;
            // 
            // Signup_loginlink
            // 
            Signup_loginlink.AutoSize = true;
            Signup_loginlink.BackColor = Color.Transparent;
            Signup_loginlink.Font = new Font("Segoe UI Semibold", 9.792F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Signup_loginlink.LinkColor = Color.LightYellow;
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
            signupbtn.BackColor = Color.LightYellow;
            signupbtn.Font = new Font("Segoe UI", 9.216F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signupbtn.Location = new Point(448, 420);
            signupbtn.Name = "signupbtn";
            signupbtn.Size = new Size(191, 66);
            signupbtn.TabIndex = 18;
            signupbtn.Text = "SIGN UP";
            signupbtn.UseVisualStyleBackColor = false;
            signupbtn.Click += signupbtn_Click;
            // 
            // signnfamebx
            // 
            signnfamebx.BackColor = Color.LightYellow;
            signnfamebx.BorderStyle = BorderStyle.None;
            signnfamebx.Location = new Point(478, 151);
            signnfamebx.Multiline = true;
            signnfamebx.Name = "signnfamebx";
            signnfamebx.PlaceholderText = "Enter your name";
            signnfamebx.Size = new Size(300, 29);
            signnfamebx.TabIndex = 16;
            // 
            // signfname
            // 
            signfname.AutoSize = true;
            signfname.BackColor = Color.Transparent;
            signfname.Font = new Font("Bell MT", 12.096F, FontStyle.Bold);
            signfname.ForeColor = Color.LightYellow;
            signfname.Location = new Point(290, 149);
            signfname.Name = "signfname";
            signfname.Size = new Size(107, 25);
            signfname.TabIndex = 14;
            signfname.Text = "Full Name";
            signfname.Click += label2_Click;
            // 
            // signup_wellcomebx
            // 
            signup_wellcomebx.AutoSize = true;
            signup_wellcomebx.BackColor = Color.Transparent;
            signup_wellcomebx.Font = new Font("Ravie", 25.92F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signup_wellcomebx.ForeColor = Color.LightYellow;
            signup_wellcomebx.Location = new Point(378, 63);
            signup_wellcomebx.Name = "signup_wellcomebx";
            signup_wellcomebx.Size = new Size(368, 69);
            signup_wellcomebx.TabIndex = 13;
            signup_wellcomebx.Text = "WELLCOME";
            signup_wellcomebx.TextAlign = ContentAlignment.MiddleCenter;
            signup_wellcomebx.UseCompatibleTextRendering = true;
            // 
            // Wellcome_page
            // 
            Wellcome_page.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Wellcome_page.BackColor = SystemColors.ButtonShadow;
            Wellcome_page.BackgroundImage = d_labdemo.Properties.Resources.Presentation3_Page_01;
            Wellcome_page.BackgroundImageLayout = ImageLayout.Stretch;
            Wellcome_page.Controls.Add(Wellcome_signupbtn);
            Wellcome_page.Controls.Add(Wellcome_loginbtn);
            Wellcome_page.Location = new Point(0, 0);
            Wellcome_page.Name = "Wellcome_page";
            Wellcome_page.Size = new Size(1090, 641);
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
            Wellcome_signupbtn.Location = new Point(393, 341);
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
            Wellcome_loginbtn.Location = new Point(70, 341);
            Wellcome_loginbtn.Name = "Wellcome_loginbtn";
            Wellcome_loginbtn.Size = new Size(183, 67);
            Wellcome_loginbtn.TabIndex = 0;
            Wellcome_loginbtn.Text = "LOG IN";
            Wellcome_loginbtn.UseVisualStyleBackColor = false;
            Wellcome_loginbtn.Click += Wellcome_loginbtn_Click;
            // 
            // Titlepnl
            // 
            Titlepnl.BackColor = SystemColors.ActiveCaptionText;
            Titlepnl.Controls.Add(menubtn);
            Titlepnl.Controls.Add(profilelnk);
            Titlepnl.Dock = DockStyle.Top;
            Titlepnl.Location = new Point(0, 0);
            Titlepnl.Name = "Titlepnl";
            Titlepnl.Size = new Size(1090, 63);
            Titlepnl.TabIndex = 1;
            // 
            // menubtn
            // 
            menubtn.BackColor = Color.Transparent;
            menubtn.Cursor = Cursors.Hand;
            menubtn.Dock = DockStyle.Left;
            menubtn.FlatAppearance.BorderSize = 0;
            menubtn.FlatAppearance.CheckedBackColor = Color.White;
            menubtn.FlatAppearance.MouseOverBackColor = Color.Black;
            menubtn.FlatStyle = FlatStyle.Flat;
            menubtn.Font = new Font("Segoe UI", 21.8879986F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menubtn.ForeColor = Color.LightYellow;
            menubtn.Location = new Point(0, 0);
            menubtn.Name = "menubtn";
            menubtn.Size = new Size(107, 63);
            menubtn.TabIndex = 3;
            menubtn.Text = "☰";
            menubtn.UseVisualStyleBackColor = false;
            // 
            // profilelnk
            // 
            profilelnk.ActiveLinkColor = SystemColors.ActiveCaption;
            profilelnk.AutoSize = true;
            profilelnk.Dock = DockStyle.Right;
            profilelnk.Font = new Font("Segoe UI Semibold", 12.096F, FontStyle.Bold, GraphicsUnit.Point, 0);
            profilelnk.LinkColor = Color.AliceBlue;
            profilelnk.Location = new Point(979, 0);
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
            sidebar.BackColor = Color.FromArgb(35, 40, 45);
            sidebar.Controls.Add(Usersbtn);
            sidebar.Controls.Add(Shelfbtn);
            sidebar.Controls.Add(button2);
            sidebar.Controls.Add(settignbtn);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 63);
            sidebar.MaximumSize = new Size(190, 999);
            sidebar.MinimumSize = new Size(91, 526);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(146, 578);
            sidebar.TabIndex = 0;
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
            Usersbtn.Location = new Point(0, 88);
            Usersbtn.Name = "Usersbtn";
            Usersbtn.Size = new Size(146, 44);
            Usersbtn.TabIndex = 7;
            Usersbtn.Text = "👤  Users";
            Usersbtn.UseVisualStyleBackColor = false;
            Usersbtn.Click += Usersbtn_Click;
            // 
            // Shelfbtn
            // 
            Shelfbtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Shelfbtn.BackColor = Color.FromArgb(30, 40, 45);
            Shelfbtn.Cursor = Cursors.Hand;
            Shelfbtn.Dock = DockStyle.Top;
            Shelfbtn.FlatAppearance.BorderSize = 0;
            Shelfbtn.FlatAppearance.CheckedBackColor = Color.White;
            Shelfbtn.FlatAppearance.MouseOverBackColor = Color.Black;
            Shelfbtn.FlatStyle = FlatStyle.Flat;
            Shelfbtn.ForeColor = Color.LightYellow;
            Shelfbtn.Location = new Point(0, 44);
            Shelfbtn.Name = "Shelfbtn";
            Shelfbtn.Size = new Size(146, 44);
            Shelfbtn.TabIndex = 9;
            Shelfbtn.Text = "📊  Shelf";
            Shelfbtn.UseVisualStyleBackColor = false;
            Shelfbtn.Click += Shelfbtn_Click;
            // 
            // button2
            // 
            button2.AutoEllipsis = true;
            button2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button2.BackColor = Color.FromArgb(30, 40, 45);
            button2.Cursor = Cursors.Hand;
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.CheckedBackColor = Color.White;
            button2.FlatAppearance.MouseOverBackColor = Color.Black;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.LightYellow;
            button2.Location = new Point(0, 0);
            button2.Name = "button2";
            button2.Size = new Size(146, 44);
            button2.TabIndex = 8;
            button2.Text = "🏠︎ Home";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
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
            settignbtn.Location = new Point(0, 534);
            settignbtn.Margin = new Padding(0, 0, 0, 3);
            settignbtn.Name = "settignbtn";
            settignbtn.Size = new Size(146, 44);
            settignbtn.TabIndex = 5;
            settignbtn.Text = "⚙️ Setting";
            settignbtn.UseVisualStyleBackColor = false;
            // 
            // adminpnl
            // 
            adminpnl.AutoSize = true;
            adminpnl.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            adminpnl.BackColor = Color.FromArgb(188, 193, 199);
            adminpnl.Controls.Add(Admin_userspnl);
            adminpnl.Controls.Add(Admin_homepnl);
            adminpnl.Controls.Add(Admin_shelfpnl);
            adminpnl.Controls.Add(sidebar);
            adminpnl.Controls.Add(Titlepnl);
            adminpnl.Dock = DockStyle.Fill;
            adminpnl.Location = new Point(0, 0);
            adminpnl.MinimumSize = new Size(841, 589);
            adminpnl.Name = "adminpnl";
            adminpnl.Size = new Size(1090, 641);
            adminpnl.TabIndex = 7;
            // 
            // Admin_userspnl
            // 
            Admin_userspnl.BackColor = Color.SlateGray;
            Admin_userspnl.Controls.Add(User_tabeltbl);
            Admin_userspnl.Controls.Add(fetch_databtn);
            Admin_userspnl.Dock = DockStyle.Fill;
            Admin_userspnl.Location = new Point(146, 63);
            Admin_userspnl.Name = "Admin_userspnl";
            Admin_userspnl.Size = new Size(944, 578);
            Admin_userspnl.TabIndex = 3;
            // 
            // User_tabeltbl
            // 
            User_tabeltbl.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            User_tabeltbl.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            User_tabeltbl.Location = new Point(22, 62);
            User_tabeltbl.Name = "User_tabeltbl";
            User_tabeltbl.RowHeadersWidth = 53;
            User_tabeltbl.Size = new Size(913, 406);
            User_tabeltbl.TabIndex = 1;
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
            // Admin_homepnl
            // 
            Admin_homepnl.BackColor = Color.FromArgb(192, 255, 255);
            Admin_homepnl.Dock = DockStyle.Fill;
            Admin_homepnl.Location = new Point(146, 63);
            Admin_homepnl.Name = "Admin_homepnl";
            Admin_homepnl.Size = new Size(944, 578);
            Admin_homepnl.TabIndex = 2;
            // 
            // Admin_shelfpnl
            // 
            Admin_shelfpnl.BackColor = Color.FromArgb(224, 224, 224);
            Admin_shelfpnl.Dock = DockStyle.Fill;
            Admin_shelfpnl.Location = new Point(146, 63);
            Admin_shelfpnl.Name = "Admin_shelfpnl";
            Admin_shelfpnl.Size = new Size(944, 578);
            Admin_shelfpnl.TabIndex = 3;
            // 
            // d_lab
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1090, 641);
            Controls.Add(adminpnl);
            Controls.Add(loginpnl);
            Controls.Add(signuppnl);
            Controls.Add(Wellcome_page);
            Controls.Add(Userpnl);
            Controls.Add(librarianpnl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1108, 689);
            MinimumSize = new Size(1108, 689);
            Name = "d_lab";
            Text = "d_lab";
            Userpnl.ResumeLayout(false);
            User_sidebar.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            loginpnl.ResumeLayout(false);
            loginpnl.PerformLayout();
            signuppnl.ResumeLayout(false);
            signuppnl.PerformLayout();
            Wellcome_page.ResumeLayout(false);
            Wellcome_page.PerformLayout();
            Titlepnl.ResumeLayout(false);
            Titlepnl.PerformLayout();
            sidebar.ResumeLayout(false);
            adminpnl.ResumeLayout(false);
            Admin_userspnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)User_tabeltbl).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel Userpnl;
        private Panel loginpnl;
        private Button logibtn;
        private TextBox passbx;
        private TextBox namebx;
        private Label passlbl;
        private Label usernamelbl;
        private Label welcome_labele;
        private LinkLabel login_signup;
        private Panel User_sidebar;
        private Button User_study_assistbtn;
        private Button User_favoritebtn;
        private Button User_shelfbtn;
        private Button User_homebtn;
        private Button User_settingbtn;
        private Panel panel1;
        private Button button1;
        private LinkLabel linkLabel2;
        private TabControl tabControl1;
        private TabPage Programmingtab;
        private TabPage Medicinetab;
        private TabPage Noveltab;
        private Panel librarianpnl;
        private Panel signuppnl;
        private LinkLabel Signup_loginlink;
        private Button signupbtn;
        private TextBox signnfamebx;
        private Label signfname;
        private Label signup_wellcomebx;
        private TextBox signpassbx;
        private Label signpass;
        private TextBox textBox1;
        private Label signusername;
        private Panel Wellcome_page;
        private Button Wellcome_signupbtn;
        private Button Wellcome_loginbtn;
        private Panel Titlepnl;
        private Button menubtn;
        private LinkLabel profilelnk;
        private Panel sidebar;
        private Button Usersbtn;
        private Button Shelfbtn;
        private Button button2;
        private Button settignbtn;
        private Panel adminpnl;
        private Panel Admin_homepnl;
        private Panel Admin_shelfpnl;
        private Panel Admin_userspnl;
        private DataGridView User_tabeltbl;
        private Button fetch_databtn;
    }
}
