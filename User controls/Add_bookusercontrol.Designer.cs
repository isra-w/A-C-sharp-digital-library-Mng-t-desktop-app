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
            SuspendLayout();
            // 
            // Usercontrol_addbooklbl
            // 
            Usercontrol_addbooklbl.AutoSize = true;
            Usercontrol_addbooklbl.Location = new Point(42, 26);
            Usercontrol_addbooklbl.Name = "Usercontrol_addbooklbl";
            Usercontrol_addbooklbl.Size = new Size(106, 21);
            Usercontrol_addbooklbl.TabIndex = 0;
            Usercontrol_addbooklbl.Text = "Adding books";
            // 
            // Usercontrol_booknamelbl
            // 
            Usercontrol_booknamelbl.AutoSize = true;
            Usercontrol_booknamelbl.Location = new Point(177, 45);
            Usercontrol_booknamelbl.Name = "Usercontrol_booknamelbl";
            Usercontrol_booknamelbl.Size = new Size(91, 21);
            Usercontrol_booknamelbl.TabIndex = 1;
            Usercontrol_booknamelbl.Text = "Book Name";
            // 
            // Add_bookusercontrol
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
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
    }
}
