namespace d_labdemo
{
    partial class Add_bookusercontrol
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
            Usercontrol_addbooklbl = new Label();
            Usercontrol_booknamelbl = new Label();
            BookTitle_textbox = new TextBox();
            BookAuthor_label = new Label();
            BookAuthor_textbox = new TextBox();
            BookCategory_label = new Label();
            BookCategory_textbox = new TextBox();
            BookYear_label = new Label();
            BookYear_textbox = new TextBox();
            PdfFile_label = new Label();
            SelectPdf_button = new Button();
            PdfFileName_label = new Label();
            AddBook_button = new Button();
            Close_button = new Button();
            SuspendLayout();
            // 
            // Usercontrol_addbooklbl
            // 
            Usercontrol_addbooklbl.AutoSize = true;
            Usercontrol_addbooklbl.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            Usercontrol_addbooklbl.Location = new Point(42, 26);
            Usercontrol_addbooklbl.Name = "Usercontrol_addbooklbl";
            Usercontrol_addbooklbl.Size = new Size(106, 32);
            Usercontrol_addbooklbl.TabIndex = 0;
            Usercontrol_addbooklbl.Text = "Adding books";
            // 
            // Usercontrol_booknamelbl
            // 
            Usercontrol_booknamelbl.AutoSize = true;
            Usercontrol_booknamelbl.Location = new Point(42, 80);
            Usercontrol_booknamelbl.Name = "Usercontrol_booknamelbl";
            Usercontrol_booknamelbl.Size = new Size(85, 21);
            Usercontrol_booknamelbl.TabIndex = 1;
            Usercontrol_booknamelbl.Text = "Book Title";
            // 
            // BookTitle_textbox
            // 
            BookTitle_textbox.Location = new Point(42, 104);
            BookTitle_textbox.Name = "BookTitle_textbox";
            BookTitle_textbox.Size = new Size(300, 29);
            BookTitle_textbox.TabIndex = 2;
            // 
            // BookAuthor_label
            // 
            BookAuthor_label.AutoSize = true;
            BookAuthor_label.Location = new Point(42, 140);
            BookAuthor_label.Name = "BookAuthor_label";
            BookAuthor_label.Size = new Size(63, 21);
            BookAuthor_label.TabIndex = 3;
            BookAuthor_label.Text = "Author";
            // 
            // BookAuthor_textbox
            // 
            BookAuthor_textbox.Location = new Point(42, 164);
            BookAuthor_textbox.Name = "BookAuthor_textbox";
            BookAuthor_textbox.Size = new Size(300, 29);
            BookAuthor_textbox.TabIndex = 4;
            // 
            // BookCategory_label
            // 
            BookCategory_label.AutoSize = true;
            BookCategory_label.Location = new Point(42, 200);
            BookCategory_label.Name = "BookCategory_label";
            BookCategory_label.Size = new Size(79, 21);
            BookCategory_label.TabIndex = 5;
            BookCategory_label.Text = "Category";
            // 
            // BookCategory_textbox
            // 
            BookCategory_textbox.Location = new Point(42, 224);
            BookCategory_textbox.Name = "BookCategory_textbox";
            BookCategory_textbox.Size = new Size(300, 29);
            BookCategory_textbox.TabIndex = 6;
            // 
            // BookYear_label
            // 
            BookYear_label.AutoSize = true;
            BookYear_label.Location = new Point(42, 260);
            BookYear_label.Name = "BookYear_label";
            BookYear_label.Size = new Size(41, 21);
            BookYear_label.TabIndex = 7;
            BookYear_label.Text = "Year";
            // 
            // BookYear_textbox
            // 
            BookYear_textbox.Location = new Point(42, 284);
            BookYear_textbox.Name = "BookYear_textbox";
            BookYear_textbox.Size = new Size(150, 29);
            BookYear_textbox.TabIndex = 8;
            // 
            // PdfFile_label
            // 
            PdfFile_label.AutoSize = true;
            PdfFile_label.Location = new Point(42, 320);
            PdfFile_label.Name = "PdfFile_label";
            PdfFile_label.Size = new Size(79, 21);
            PdfFile_label.TabIndex = 9;
            PdfFile_label.Text = "PDF File";
            // 
            // SelectPdf_button
            // 
            SelectPdf_button.BackColor = Color.SteelBlue;
            SelectPdf_button.ForeColor = Color.White;
            SelectPdf_button.Location = new Point(42, 344);
            SelectPdf_button.Name = "SelectPdf_button";
            SelectPdf_button.Size = new Size(120, 35);
            SelectPdf_button.TabIndex = 10;
            SelectPdf_button.Text = "Select PDF";
            SelectPdf_button.UseVisualStyleBackColor = false;
            SelectPdf_button.Click += SelectPdf_button_Click;
            // 
            // PdfFileName_label
            // 
            PdfFileName_label.AutoSize = true;
            PdfFileName_label.Location = new Point(170, 344);
            PdfFileName_label.Name = "PdfFileName_label";
            PdfFileName_label.Size = new Size(95, 21);
            PdfFileName_label.TabIndex = 11;
            PdfFileName_label.Text = "No file selected";
            // 
            // AddBook_button
            // 
            AddBook_button.BackColor = Color.SeaGreen;
            AddBook_button.ForeColor = Color.White;
            AddBook_button.Location = new Point(42, 390);
            AddBook_button.Name = "AddBook_button";
            AddBook_button.Size = new Size(120, 35);
            AddBook_button.TabIndex = 12;
            AddBook_button.Text = "Add Book";
            AddBook_button.UseVisualStyleBackColor = false;
            AddBook_button.Click += AddBook_button_Click;
            // 
            // Close_button
            // 
            Close_button.BackColor = Color.IndianRed;
            Close_button.ForeColor = Color.White;
            Close_button.Location = new Point(170, 390);
            Close_button.Name = "Close_button";
            Close_button.Size = new Size(120, 35);
            Close_button.TabIndex = 13;
            Close_button.Text = "Close";
            Close_button.UseVisualStyleBackColor = false;
            Close_button.Click += Close_button_Click;
            // 
            // Add_bookusercontrol
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            Controls.Add(Close_button);
            Controls.Add(AddBook_button);
            Controls.Add(PdfFileName_label);
            Controls.Add(SelectPdf_button);
            Controls.Add(PdfFile_label);
            Controls.Add(BookYear_textbox);
            Controls.Add(BookYear_label);
            Controls.Add(BookCategory_textbox);
            Controls.Add(BookCategory_label);
            Controls.Add(BookAuthor_textbox);
            Controls.Add(BookAuthor_label);
            Controls.Add(BookTitle_textbox);
            Controls.Add(Usercontrol_booknamelbl);
            Controls.Add(Usercontrol_addbooklbl);
            Name = "Add_bookusercontrol";
            Size = new Size(787, 385);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Usercontrol_addbooklbl;
        private Label Usercontrol_booknamelbl;
        private TextBox BookTitle_textbox;
        private Label BookAuthor_label;
        private TextBox BookAuthor_textbox;
        private Label BookCategory_label;
        private TextBox BookCategory_textbox;
        private Label BookYear_label;
        private TextBox BookYear_textbox;
        private Label PdfFile_label;
        private Button SelectPdf_button;
        private Label PdfFileName_label;
        private Button AddBook_button;
        private Button Close_button;
    }
}
