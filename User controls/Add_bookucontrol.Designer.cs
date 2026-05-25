namespace D_lab.User_controls
{
    partial class Add_bookucontrol
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
            Add_bookucontrollbl = new Label();
            Adducontrol_booktitlelbl = new Label();
            Adducontrol_authornamelbl = new Label();
            Adducontrol_formatlbl = new Label();
            Adducontrol_catagorylbl = new Label();
            Adducontrol_addbtn = new Button();
            Adducontrol_booktitleBX = new TextBox();
            Adducontrol_authornameBX = new TextBox();
            Adducontrol_catagorycbx = new ComboBox();
            Adducontrol_formatcbx = new ComboBox();
            Adducontrol_closebtn = new Button();
            Adducontrol_publicationyearlbl = new Label();
            Adducontrol_publicationyeardatepiker = new DateTimePicker();
            SuspendLayout();
            // 
            // Add_bookucontrollbl
            // 
            Add_bookucontrollbl.AutoSize = true;
            Add_bookucontrollbl.Font = new Font("Showcard Gothic", 17.855999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Add_bookucontrollbl.Location = new Point(133, 46);
            Add_bookucontrollbl.Name = "Add_bookucontrollbl";
            Add_bookucontrollbl.Size = new Size(521, 38);
            Add_bookucontrollbl.TabIndex = 0;
            Add_bookucontrollbl.Text = "Fill all the fildes to add book";
            // 
            // Adducontrol_booktitlelbl
            // 
            Adducontrol_booktitlelbl.AutoSize = true;
            Adducontrol_booktitlelbl.Location = new Point(121, 127);
            Adducontrol_booktitlelbl.Name = "Adducontrol_booktitlelbl";
            Adducontrol_booktitlelbl.Size = new Size(78, 21);
            Adducontrol_booktitlelbl.TabIndex = 1;
            Adducontrol_booktitlelbl.Text = "Book Title";
            Adducontrol_booktitlelbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Adducontrol_authornamelbl
            // 
            Adducontrol_authornamelbl.AutoSize = true;
            Adducontrol_authornamelbl.Location = new Point(121, 187);
            Adducontrol_authornamelbl.Name = "Adducontrol_authornamelbl";
            Adducontrol_authornamelbl.Size = new Size(104, 21);
            Adducontrol_authornamelbl.TabIndex = 2;
            Adducontrol_authornamelbl.Text = "Author Name";
            Adducontrol_authornamelbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Adducontrol_formatlbl
            // 
            Adducontrol_formatlbl.AutoSize = true;
            Adducontrol_formatlbl.Location = new Point(121, 389);
            Adducontrol_formatlbl.Name = "Adducontrol_formatlbl";
            Adducontrol_formatlbl.Size = new Size(60, 21);
            Adducontrol_formatlbl.TabIndex = 3;
            Adducontrol_formatlbl.Text = "Format";
            Adducontrol_formatlbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Adducontrol_catagorylbl
            // 
            Adducontrol_catagorylbl.AutoSize = true;
            Adducontrol_catagorylbl.Location = new Point(121, 249);
            Adducontrol_catagorylbl.Name = "Adducontrol_catagorylbl";
            Adducontrol_catagorylbl.Size = new Size(73, 21);
            Adducontrol_catagorylbl.TabIndex = 4;
            Adducontrol_catagorylbl.Text = "Catagory";
            Adducontrol_catagorylbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Adducontrol_addbtn
            // 
            Adducontrol_addbtn.BackColor = SystemColors.ActiveCaption;
            Adducontrol_addbtn.FlatStyle = FlatStyle.Popup;
            Adducontrol_addbtn.Location = new Point(313, 458);
            Adducontrol_addbtn.Name = "Adducontrol_addbtn";
            Adducontrol_addbtn.Size = new Size(140, 40);
            Adducontrol_addbtn.TabIndex = 5;
            Adducontrol_addbtn.Text = "ADD";
            Adducontrol_addbtn.UseVisualStyleBackColor = false;
            Adducontrol_addbtn.Click += Adducontrol_addbtn_Click;
            // 
            // Adducontrol_booktitleBX
            // 
            Adducontrol_booktitleBX.Location = new Point(313, 124);
            Adducontrol_booktitleBX.Name = "Adducontrol_booktitleBX";
            Adducontrol_booktitleBX.Size = new Size(270, 29);
            Adducontrol_booktitleBX.TabIndex = 6;
            // 
            // Adducontrol_authornameBX
            // 
            Adducontrol_authornameBX.Location = new Point(313, 184);
            Adducontrol_authornameBX.Name = "Adducontrol_authornameBX";
            Adducontrol_authornameBX.Size = new Size(270, 29);
            Adducontrol_authornameBX.TabIndex = 7;
            // 
            // Adducontrol_catagorycbx
            // 
            Adducontrol_catagorycbx.FormattingEnabled = true;
            Adducontrol_catagorycbx.Items.AddRange(new object[] { "Programming", "Medicine", "Novel" });
            Adducontrol_catagorycbx.Location = new Point(313, 241);
            Adducontrol_catagorycbx.Name = "Adducontrol_catagorycbx";
            Adducontrol_catagorycbx.Size = new Size(270, 29);
            Adducontrol_catagorycbx.TabIndex = 8;
            // 
            // Adducontrol_formatcbx
            // 
            Adducontrol_formatcbx.FormattingEnabled = true;
            Adducontrol_formatcbx.Items.AddRange(new object[] { "Pdf", "epub", "pptx" });
            Adducontrol_formatcbx.Location = new Point(313, 381);
            Adducontrol_formatcbx.Name = "Adducontrol_formatcbx";
            Adducontrol_formatcbx.Size = new Size(270, 29);
            Adducontrol_formatcbx.TabIndex = 9;
            // 
            // Adducontrol_closebtn
            // 
            Adducontrol_closebtn.Font = new Font("Segoe UI Semibold", 9.792F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Adducontrol_closebtn.ForeColor = Color.FromArgb(192, 0, 0);
            Adducontrol_closebtn.Location = new Point(701, 14);
            Adducontrol_closebtn.Name = "Adducontrol_closebtn";
            Adducontrol_closebtn.Size = new Size(67, 39);
            Adducontrol_closebtn.TabIndex = 10;
            Adducontrol_closebtn.Text = "❌";
            Adducontrol_closebtn.UseVisualStyleBackColor = true;
            Adducontrol_closebtn.Click += Add_bookucontrol_closebtn_Click;
            // 
            // Adducontrol_publicationyearlbl
            // 
            Adducontrol_publicationyearlbl.AutoSize = true;
            Adducontrol_publicationyearlbl.Location = new Point(121, 320);
            Adducontrol_publicationyearlbl.Name = "Adducontrol_publicationyearlbl";
            Adducontrol_publicationyearlbl.Size = new Size(73, 21);
            Adducontrol_publicationyearlbl.TabIndex = 11;
            Adducontrol_publicationyearlbl.Text = "Catagory";
            Adducontrol_publicationyearlbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Adducontrol_publicationyeardatepiker
            // 
            Adducontrol_publicationyeardatepiker.Location = new Point(313, 320);
            Adducontrol_publicationyeardatepiker.Name = "Adducontrol_publicationyeardatepiker";
            Adducontrol_publicationyeardatepiker.Size = new Size(270, 29);
            Adducontrol_publicationyeardatepiker.TabIndex = 12;
            // 
            // Add_bookucontrol
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Adducontrol_publicationyeardatepiker);
            Controls.Add(Adducontrol_publicationyearlbl);
            Controls.Add(Adducontrol_closebtn);
            Controls.Add(Adducontrol_formatcbx);
            Controls.Add(Adducontrol_catagorycbx);
            Controls.Add(Adducontrol_authornameBX);
            Controls.Add(Adducontrol_booktitleBX);
            Controls.Add(Adducontrol_addbtn);
            Controls.Add(Adducontrol_catagorylbl);
            Controls.Add(Adducontrol_formatlbl);
            Controls.Add(Adducontrol_authornamelbl);
            Controls.Add(Adducontrol_booktitlelbl);
            Controls.Add(Add_bookucontrollbl);
            Name = "Add_bookucontrol";
            Size = new Size(786, 514);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Add_bookucontrollbl;
        private Label Adducontrol_booktitlelbl;
        private Label Adducontrol_authornamelbl;
        private Label Adducontrol_formatlbl;
        private Label Adducontrol_catagorylbl;
        private Button Adducontrol_addbtn;
        private TextBox Adducontrol_booktitleBX;
        private TextBox Adducontrol_authornameBX;
        private ComboBox Adducontrol_catagorycbx;
        private ComboBox Adducontrol_formatcbx;
        private Button Adducontrol_closebtn;
        private Label Adducontrol_publicationyearlbl;
        private DateTimePicker Adducontrol_publicationyeardatepiker;
    }
}
