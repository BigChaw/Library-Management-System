using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;

namespace MyLibraryMagmentSystem
{
    public partial class IssueBooks : UserControl
    {
        // Set up Connection with database
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mfryj\Documents\Library.mdf");

        public IssueBooks()
        {
            InitializeComponent();

            displayBookIssueData();

            DataBookTitle();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);

                return;
            }

            displayBookIssueData();

            DataBookTitle();
        }

        // Add Button
        private void issueAdd_Click(object sender, EventArgs e)
        {
            if (issueIssueID.Text == "" 
                || issueName.Text == "" 
                || issueContact.Text == ""
                || issueEmail.Text == "" 
                || issueBookTitle.Text == ""
                || issueAuthor.Text == "" 
                || issueIssue.Value == null
                || issueReturn.Value == null 
                || issueStatus.Text == ""
                || issuePicture.Image == null)
            {
                MessageBox.Show("You did not fill all blank fields.", "Error Message", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connection.State != ConnectionState.Open)
                {
                    try
                    {
                        DateTime today = DateTime.Today;

                        // Open communication with database
                        connection.Open();

                        string insertData = "INSERT INTO issues (issue_id, full_name, contact, email" +
                            ", book_title, author, status, issue_date, return_date, date_insert)" +
                            "VALUES(@issueID, @fullName, @contact, @email, @bookTitle, @author" +
                            ", @status, @issueDate, @returnDate, @dateInsert)";

                        using (SqlCommand cmd = new SqlCommand(insertData, connection)) 
                        {
                            cmd.Parameters.AddWithValue("@issueID", issueIssueID.Text.Trim());
                            cmd.Parameters.AddWithValue("@fullName", issueName.Text.Trim());
                            cmd.Parameters.AddWithValue("@contact", issueContact.Text.Trim());
                            cmd.Parameters.AddWithValue("@email", issueEmail.Text.Trim());
                            cmd.Parameters.AddWithValue("@bookTitle", issueBookTitle.Text.Trim());
                            cmd.Parameters.AddWithValue("@author", issueAuthor.Text.Trim());
                            cmd.Parameters.AddWithValue("@status", issueStatus.Text.Trim());
                            cmd.Parameters.AddWithValue("@issueDate", issueIssue.Value);
                            cmd.Parameters.AddWithValue("@returnDate", issueReturn.Value);
                            cmd.Parameters.AddWithValue("@dateInsert", today);

                            cmd.ExecuteNonQuery();

                            displayBookIssueData();

                            MessageBox.Show("Issued succesfully!", "Information Message", 
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
            }
        }

        public void displayBookIssueData()
        {
            DataIssueBooks dataIssueBooks = new DataIssueBooks();
            List<DataIssueBooks> listData = dataIssueBooks.IssueBooksData();

            Window.DataSource = listData;
        }

        public void DataBookTitle()
        {
            if (connection.State == ConnectionState.Closed)
            {
                try
                {
                    // Open communication with database
                    connection.Open();
                    string selectData = "SELECT id, booktitle FROM books_create WHERE status = 'Available' AND date_delete IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        issueBookTitle.DataSource = table;
                        issueBookTitle.DisplayMember = "booktitle";
                        issueBookTitle.ValueMember = "id";
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
        }

        private void issueBookTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (connection.State != ConnectionState.Open)
            {
                if (issueBookTitle.SelectedValue != null) 
                {
                    DataRowView selectedRow = (DataRowView)issueBookTitle.SelectedItem;
                    int selectedID = Convert.ToInt32(selectedRow["id"]);

                    try
                    {
                        // Open communication with database
                        connection.Open();

                        string selectData = "SELECT * FROM books_create WHERE id = @id";

                        using (SqlCommand cmd = new SqlCommand(selectData, connection))
                        {
                            cmd.Parameters.AddWithValue("@id", selectedID);

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();

                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                issueAuthor.Text = table.Rows[0]["author"].ToString();

                                string imagePath = table.Rows[0]["image"].ToString();

                                if (imagePath != null)
                                {
                                    issuePicture.Image = Image.FromFile(imagePath);
                                }
                                else
                                {
                                    issuePicture.Image = null;
                                }
                            }
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
            }
        }

        // Update button
        private void issueUpdate_Click(object sender, EventArgs e)
        {
            if (issueIssueID.Text == "" 
                || issueName.Text == "" 
                || issueContact.Text == ""
                || issueEmail.Text == "" 
                || issueBookTitle.Text == ""
                || issueAuthor.Text == "" 
                || issueIssue.Value == null
                || issueReturn.Value == null 
                || issueStatus.Text == ""
                || issuePicture.Image == null)
            {
                MessageBox.Show("You did not fill all blank fields.", "Error Message", 
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else 
            {
                if (connection.State != ConnectionState.Open)
                {
                    DialogResult check = MessageBox.Show($"Are you sure to you want to UPDATE issue ID: {issueIssueID}?", 
                        "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (check == DialogResult.Yes)
                    {
                        try
                        {
                            // set up date today
                            DateTime today = DateTime.Today;

                            // Open communication with database
                            connection.Open();

                            string updateData = "UPDATE issues SET full_name = @fullName, contact = @contact" +
                                ", email = @email, book_title = @bookTitle, author = @author" +
                                ", status = @status, issue_date = @issueDate, return_date = @returnDate" +
                                ", date_update = @dateUpdate WHERE issue_id = @issueID";

                            using (SqlCommand cmd = new SqlCommand(updateData, connection))
                            {
                                cmd.Parameters.AddWithValue("@fullName", issueName.Text.Trim());
                                cmd.Parameters.AddWithValue("@contact", issueContact.Text.Trim());
                                cmd.Parameters.AddWithValue("@update", issueContact.Text.Trim());
                                cmd.Parameters.AddWithValue("@email", issueEmail.Text.Trim());
                                cmd.Parameters.AddWithValue("@bookTitle", issueBookTitle.Text.Trim());
                                cmd.Parameters.AddWithValue("@author", issueAuthor.Text.Trim());
                                cmd.Parameters.AddWithValue("@status", issueStatus.Text.Trim());
                                cmd.Parameters.AddWithValue("@issueDate", issueIssue.Value);
                                cmd.Parameters.AddWithValue("@returnDate", issueReturn.Value);
                                cmd.Parameters.AddWithValue("@dateUpdate", today);
                                cmd.Parameters.AddWithValue("@issueID", issueIssueID.Text.Trim());

                                cmd.ExecuteNonQuery();

                                displayBookIssueData();

                                MessageBox.Show("Updated succesfully!", "Information Message", 
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                                clearFields();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error connecting to database: {ex}", "Error Message", 
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            // Close communication with database
                            connection.Close();
                        }
                    }
                }
                else 
                {
                    // If you chose no possible
                    MessageBox.Show("Cancelled.", "Information Message", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Delete button
        private void issueDelete_Click(object sender, EventArgs e)
        {
            if (issueIssueID.Text == "" 
                || issueName.Text == "" 
                || issueContact.Text == ""
                || issueEmail.Text == "" 
                || issueBookTitle.Text == ""
                || issueAuthor.Text == "" 
                || issueIssue.Value == null
                || issueReturn.Value == null 
                || issueStatus.Text == ""
                || issuePicture.Image == null)
            {
                MessageBox.Show("Please select item first.", "Error Message", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                if (connection.State != ConnectionState.Open)
                {
                    DialogResult check = MessageBox.Show($"Are you sure you want to DELETE issue ID: {issueIssueID.Text.Trim()}?", "Conformation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (check == DialogResult.Yes)
                    {
                        try
                        {
                            connection.Open();

                            // Actual date today
                            DateTime today = DateTime.Today;

                            // Update data in database
                            string updateData = "UPDATE issues SET date_delete = @dateDelete WHERE issue_id = @issueID";

                            using (SqlCommand cmd = new SqlCommand(updateData, connection))
                            {
                                cmd.Parameters.AddWithValue("@dateDelete", today);
                                cmd.Parameters.AddWithValue("@issueID", issueIssueID.Text.Trim());

                                cmd.ExecuteNonQuery();

                                displayBookIssueData();

                                MessageBox.Show("Deleted succesfully!", "Information Message", 
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
                    else
                    {
                        MessageBox.Show("Cancelled.", "Information Message", 
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        // Clear all fields
        public void clearFields()
        {
            issueIssueID.Text = "";
            issueName.Text = "";
            issueContact.Text = "";
            issueEmail.Text = "";
            issueBookTitle.SelectedIndex = -1;
            issueAuthor.SelectedIndex = -1;
            issueStatus.SelectedIndex = -1;
            issuePicture.Image = null;
        }

        // Clear button
        private void issueClear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void issueWindow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                // Set up information for all rows in table window
                DataGridViewRow row = Window.Rows[e.RowIndex];

                issueIssueID.Text = row.Cells[1].Value.ToString();
                issueName.Text = row.Cells[2].Value.ToString();
                issueContact.Text = row.Cells[3].Value.ToString();
                issueEmail.Text = row.Cells[4].Value.ToString();
                issueBookTitle.Text = row.Cells[5].Value.ToString();
                issueAuthor.Text = row.Cells[6].Value.ToString();
                issueIssue.Text = row.Cells[7].Value.ToString();
                issueReturn.Text = row.Cells[8].Value.ToString();
                issueStatus.Text = row.Cells[9].Value.ToString();
            }
        }
    }
}
