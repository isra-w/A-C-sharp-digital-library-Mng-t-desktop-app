using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using d.labdemo.DB;
using d.labdemo.Models;
using System.IO;

namespace d_labdemo
{
    public partial class Add_bookusercontrol : UserControl
    {
        private bool dragg = false;
        private Point dragCursor;
        private Point dragControl;
        private string? selectedPdfPath;

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

        private void SelectPdf_button_Click(object? sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select a PDF File";
                openFileDialog.Filter = "PDF Files (*.pdf)|*.pdf|All Files (*.*)|*.*";
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedPdfPath = openFileDialog.FileName;
                    PdfFileName_label.Text = Path.GetFileName(selectedPdfPath);
                }
            }
        }

        private void AddBook_button_Click(object? sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(BookTitle_textbox.Text))
            {
                MessageBox.Show("Please enter the book title.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(selectedPdfPath))
            {
                MessageBox.Show("Please select a PDF file.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Create PDF storage directory if it doesn't exist
                string pdfStoragePath = Path.Combine(Application.StartupPath, "Books_PDF");
                if (!Directory.Exists(pdfStoragePath))
                {
                    Directory.CreateDirectory(pdfStoragePath);
                }

                // Copy PDF to application directory
                string fileName = Path.GetFileName(selectedPdfPath);
                string destinationPath = Path.Combine(pdfStoragePath, fileName);

                // Handle duplicate file names
                int counter = 1;
                string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(fileName);
                string fileExtension = Path.GetExtension(fileName);
                while (File.Exists(destinationPath))
                {
                    fileName = $"{fileNameWithoutExtension}_{counter}{fileExtension}";
                    destinationPath = Path.Combine(pdfStoragePath, fileName);
                    counter++;
                }

                File.Copy(selectedPdfPath, destinationPath, false);

                // Parse year
                int year = 0;
                if (!string.IsNullOrWhiteSpace(BookYear_textbox.Text))
                {
                    if (!int.TryParse(BookYear_textbox.Text, out year))
                    {
                        MessageBox.Show("Please enter a valid year.", "Validation Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // Create Book object
                Book newBook = new Book
                {
                    Title = BookTitle_textbox.Text,
                    Author = BookAuthor_textbox.Text,
                    Category = BookCategory_textbox.Text,
                    Year = year,
                    PdfFilePath = destinationPath
                };

                // Add book to database
                if (BookRepository.AddBook(newBook))
                {
                    MessageBox.Show("Book added successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Failed to add book to database.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding book: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Close_button_Click(object? sender, EventArgs e)
        {
            this.Visible = false;
            ClearForm();
        }

        private void ClearForm()
        {
            BookTitle_textbox.Clear();
            BookAuthor_textbox.Clear();
            BookCategory_textbox.Clear();
            BookYear_textbox.Clear();
            selectedPdfPath = null;
            PdfFileName_label.Text = "No file selected";
        }
    }
}
