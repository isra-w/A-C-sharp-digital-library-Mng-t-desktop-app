using Microsoft.Data.SqlClient;
using d.labdemo.Models;
using System;
using System.Collections.Generic;
using System.Data;

namespace d.labdemo.DB
{
    public class BookRepository
    {
        /// <summary>
        /// Adds a new book to the database
        /// </summary>
        public static bool AddBook(Book book)
        {
            try
            {
                DBConnection.intiate();
                string query = @"INSERT INTO Books (Title, Author, Category, Year, PdfFilePath) 
                               VALUES (@Title, @Author, @Category, @Year, @PdfFilePath)";

                using (SqlCommand cmd = new SqlCommand(query, DBConnection.checkConnection))
                {
                    cmd.Parameters.AddWithValue("@Title", book.Title ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Author", book.Author ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Category", book.Category ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Year", book.Year);
                    //cmd.Parameters.AddWithValue("@PdfFilePath", book.PdfFilePath ?? (object)DBNull.Value);

                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding book: {ex.Message}", "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Retrieves all books from the database
        /// </summary>
        public static List<Book> GetAllBooks()
        {
            List<Book> books = new List<Book>();
            try
            {
                DBConnection.intiate();
                string query = "SELECT BookId, Title, Author, Category, Year, PdfFilePath FROM Books";

                using (SqlCommand cmd = new SqlCommand(query, DBConnection.checkConnection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            books.Add(new Book
                            {
                                BookId = (int)reader["BookId"],
                                Title = reader["Title"].ToString() ?? string.Empty,
                                Author = reader["Author"].ToString() ?? string.Empty,
                                Category = reader["Category"].ToString() ?? string.Empty,
                                Year = Convert.ToInt32(reader["Year"]),
                                //PdfFilePath = reader["PdfFilePath"].ToString()
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving books: {ex.Message}", "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return books;
        }

        /// <summary>
        /// Retrieves books by category
        /// </summary>
        public static List<Book> GetBooksByCategory(string category)
        {
            List<Book> books = new List<Book>();
            try
            {
                DBConnection.intiate();
                string query = "SELECT BookId, Title, Author, Category, Year, PdfFilePath FROM Books WHERE Category = @Category";

                using (SqlCommand cmd = new SqlCommand(query, DBConnection.checkConnection))
                {
                    cmd.Parameters.AddWithValue("@Category", category);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            books.Add(new Book
                            {
                                BookId = (int)reader["BookId"],
                                Title = reader["Title"].ToString() ?? string.Empty,
                                Author = reader["Author"].ToString() ?? string.Empty,
                                Category = reader["Category"].ToString() ?? string.Empty,
                                Year = Convert.ToInt32(reader["Year"]),
                                //PdfFilePath = reader["PdfFilePath"].ToString()
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving books by category: {ex.Message}", "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return books;
        }

        /// <summary>
        /// Gets a single book by ID
        /// </summary>
        public static Book? GetBookById(int bookId)
        {
            try
            {
                DBConnection.intiate();
                string query = "SELECT BookId, Title, Author, Category, Year, PdfFilePath FROM Books WHERE BookId = @BookId";

                using (SqlCommand cmd = new SqlCommand(query, DBConnection.checkConnection))
                {
                    cmd.Parameters.AddWithValue("@BookId", bookId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Book
                            {
                                BookId = (int)reader["BookId"],
                                Title = reader["Title"].ToString() ?? string.Empty,
                                Author = reader["Author"].ToString() ?? string.Empty,
                                Category = reader["Category"].ToString() ?? string.Empty,
                                Year = Convert.ToInt32(reader["Year"]),
                                //File_Path = reader["PdfFilePath"].ToString()
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving book: {ex.Message}", "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        /// <summary>
        /// Deletes a book from the database
        /// </summary>
        public static bool DeleteBook(int bookId)
        {
            try
            {
                DBConnection.intiate();
                string query = "DELETE FROM Books WHERE BookId = @BookId";

                using (SqlCommand cmd = new SqlCommand(query, DBConnection.checkConnection))
                {
                    cmd.Parameters.AddWithValue("@BookId", bookId);
                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting book: {ex.Message}", "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Updates an existing book
        /// </summary>
        public static bool UpdateBook(Book book)
        {
            try
            {
                DBConnection.intiate();
                string query = @"UPDATE Books SET Title = @Title, Author = @Author, Category = @Category, 
                               Year = @Year, PdfFilePath = @PdfFilePath WHERE BookId = @BookId";

                using (SqlCommand cmd = new SqlCommand(query, DBConnection.checkConnection))
                {
                    cmd.Parameters.AddWithValue("@BookId", book.BookId);
                    cmd.Parameters.AddWithValue("@Title", book.Title ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Author", book.Author ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Category", book.Category ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Year", book.Year);
                    //cmd.Parameters.AddWithValue("@PdfFilePath", book.File_Path ?? (object)DBNull.Value);

                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating book: {ex.Message}", "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
