using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Drawing;
using System.Collections.Generic;

namespace MyLibraryMagmentSystem
{
    public partial class AddBook : UserControl
    {
        // Set up Connection with database
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mfryj\Documents\Library.mdf");
        public AddBook()
        {
            InitializeComponent();

            displayBooks();
        }
        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displayBooks();
        }

        // Import button --> for pictures
        private void addImportButton_Click(object sender, EventArgs e)
        {
            String imagePath = "";

            try
            {
                // Instance - Open file dialog to open the file window
                OpenFileDialog fileDialog = new OpenFileDialog();

                // Set or Get types of files in window
                fileDialog.Filter = "Image Files(*.jpg; *.png) | *.jpg; *.png";

                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = fileDialog.FileName;
                    addbookPicture.ImageLocation = imagePath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to database " + ex, "Error Message", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close communication with database
                connection.Close();
            }
        }

        // Add Button
        private void button1_Click(object sender, EventArgs e)
        {
            if (addbookPicture == null 
            || addBookTitle.Text == "" 
            || addAuthor.Text == "" 
            || addPublished.Value == null
            || addStatus.Text == "" 
            || addbookPicture.Image == null)
            {
                MessageBox.Show("You did not fill all blank fields.", "Error Message", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                if (connection.State == ConnectionState.Closed)
                {
                    try
                    {
                        connection.Open();
                        // Actual date today
                        DateTime dateTime = DateTime.Today;

                        // Insert date to database
                        string insertData = "INSERT INTO books_create " + "(booktitle, author, published_date, status, image, date_insert)" +
                            "VALUES(@BookTitle, @author, @published, @status, @image, @dateInsert)";

                        // Set default Path to Book file
                        string path = Path.Combine(@"C:\Users\Mfryj\Desktop\C# Projects\MyLibrarySytem\MyLibraryMagmentSystem\MyLibraryMagmentSystem\BooksDirectory\",
                        addBookTitle.Text.Trim() + "_" + addAuthor.Text.Trim() + "_" + ".jpg");

                        // Get name of directory, where are you currently
                        string directoryPath = Path.GetDirectoryName(path);

                        if (!Directory.Exists(directoryPath))
                        {
                            Directory.CreateDirectory(directoryPath);
                        }

                        if (addbookPicture.ImageLocation == null) {
                            throw new ArgumentNullException("No picture is attached. Please do it by import button and try it again!");
                        }
                        else 
                        { 
                        File.Copy(addbookPicture.ImageLocation, path, true);
                        }

                        using (SqlCommand cmd = new SqlCommand(insertData, connection))
                        {
                            cmd.Parameters.AddWithValue("@BookTitle", addBookTitle.Text.Trim());
                            cmd.Parameters.AddWithValue("@author", addAuthor.Text.Trim());
                            cmd.Parameters.AddWithValue("@published", addPublished.Value);
                            cmd.Parameters.AddWithValue("@status", addStatus.Text.Trim());
                            cmd.Parameters.AddWithValue("@image", path);
                            cmd.Parameters.AddWithValue("@dateInsert", dateTime);

                            cmd.ExecuteNonQuery();
                            
                            displayBooks();

                            MessageBox.Show("Added Successfully!", "Information Message", 
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clearFields();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error connecting to database " + ex, "Error Message", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        // Function to Clear all fields
        public void clearFields()
        {
            addBookTitle.Text = "";
            addAuthor.Text = "";
            addbookPicture.Image = null;
            addStatus.SelectedIndex = -1;
        }

        // Function for display all books (list) in window
        public void displayBooks()
        {
            DataAddBooks addBooks = new DataAddBooks();
            List<DataAddBooks> listData = addBooks.addBooksData();

            Window.DataSource = listData;
        }

        // Set up BookID to 0 --> then will be increasing
        private int bookID = 0;
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                // Add row to table Add Books
                DataGridViewRow row = Window.Rows[e.RowIndex];

                bookID = (int)row.Cells[0].Value;
                addBookTitle.Text = row.Cells[1].Value.ToString();
                addAuthor.Text = row.Cells[2].Value.ToString();
                addPublished.Text = row.Cells[3].Value.ToString();

                string imagePath = row.Cells[4].Value.ToString();

                if (imagePath != null || imagePath.Length >= 1)
                {
                    addbookPicture.Image = Image.FromFile(imagePath);

                }
                else
                {
                    addbookPicture.Image = null;
                }
                addStatus.Text = row.Cells[5].Value.ToString();
            }  
        }

        // Clear button
        private void button3_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        // Update Button
        private void button2_Click(object sender, EventArgs e)
        {
            if (addbookPicture == null 
            || addBookTitle.Text == "" 
            || addAuthor.Text == "" 
            || addPublished.Value == null
            || addStatus.Text == "" 
            || addbookPicture.Image == null)
            {
                MessageBox.Show("Please select item first.", "Error Message", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                if (connection.State != ConnectionState.Open) 
                {
                    DialogResult check = MessageBox.Show($"Are you sure you want to UPDATE book ID: {bookID}?", "Conformation Message", 
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (check == DialogResult.Yes)
                    {
                        try
                        {
                            // Open communication with database
                            connection.Open();

                            // Actual date today
                            DateTime today = DateTime.Today;

                            // Update data in database
                            string updateData = "UPDATE books_create SET booktitle = @BookTitle, author = @author, status = @status, " +
                                "date_update = @dateUpdate WHERE id = @id";

                            using (SqlCommand cmd = new SqlCommand(updateData, connection))
                            {
                                cmd.Parameters.AddWithValue("@BookTitle", addBookTitle.Text.Trim());
                                cmd.Parameters.AddWithValue("@author", addAuthor.Text.Trim());
                                cmd.Parameters.AddWithValue("@published", addPublished.Value);
                                cmd.Parameters.AddWithValue("@status", addStatus.Text.Trim());
                                cmd.Parameters.AddWithValue("@dateUpdate", today);
                                cmd.Parameters.AddWithValue("@id", bookID);

                                cmd.ExecuteNonQuery();

                                displayBooks();

                                MessageBox.Show("Updated successfully!", "Information Message", 
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                                clearFields();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error connecting to database " + ex, "Error Message", 
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            // Close communication with database
                            connection.Close();
                        }
                    }
                    else 
                    {
                        MessageBox.Show("Cancelled.", "Information Message", 
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        // Delete Button
        private void button4_Click(object sender, EventArgs e)
        {
            if (addbookPicture == null 
            || addBookTitle.Text == "" 
            || addAuthor.Text == "" 
            || addPublished.Value == null
            || addStatus.Text == "" 
            || addbookPicture.Image == null)
            {
                MessageBox.Show("Please select item first.", "Error Message", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connection.State != ConnectionState.Open)
                {
                    DialogResult check = MessageBox.Show($"Are you sure you want to DELETE book ID: {bookID}?", "Conformation Message", 
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (check == DialogResult.Yes)
                    {
                        try
                        {
                            // Open communication with database
                            connection.Open();

                            // Actual date today
                            DateTime today = DateTime.Today;

                            // Update data in database
                            string updateData = "UPDATE books_create SET date_delete = @dateDelete WHERE id = @id";

                            using (SqlCommand cmd = new SqlCommand(updateData, connection))
                            {
                                cmd.Parameters.AddWithValue("@dateDelete", today);
                                cmd.Parameters.AddWithValue("@id", bookID);

                                cmd.ExecuteNonQuery();

                                displayBooks();

                                MessageBox.Show("Deleted successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                clearFields();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error connecting to database " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            // Close communication with database
                            connection.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cancelled.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
    }
}
