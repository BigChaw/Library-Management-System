using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MyLibraryMagmentSystem
{
    public partial class ReturnBooks : UserControl
    {
        // Set up Connection with database
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mfryj\Documents\Library.mdf");
        public ReturnBooks()
        {
            InitializeComponent();

            displayIssueBooksData();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            { 
                Invoke((MethodInvoker)refreshData);

                return;
            }
            displayIssueBooksData();
        }

        // Return Button
        private void returnReturn_Click(object sender, EventArgs e)
        {
            if (returnIssueID.Text == "" 
                || returnName.Text == ""
                || returnContact.Text == "" 
                || returnEmail.Text == ""
                || returnBookTitle.Text == "" 
                || returnAuthor.Text == ""
                || returnIssue.Value == null)
            {
                MessageBox.Show("Please select item first", "Error Message", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                if (connection.State == ConnectionState.Closed)
                {
                    DialogResult check = MessageBox.Show($"Are you sure that Issue ID: {returnIssueID.Text.Trim()}" +
                        " is return already?", "Confirmation Message", 
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (check == DialogResult.Yes)
                    {
                        try
                        {
                            // Set up date time today
                            DateTime today = DateTime.Today;

                            // Open communication with database
                            connection.Open();

                            string updateData = "UPDATE issues SET status = @status, date_update = @dateUpdate " +
                                "WHERE issue_id = @issueID";

                            using (SqlCommand cmd = new SqlCommand(updateData, connection))
                            {
                                cmd.Parameters.AddWithValue("@status", "Return");
                                cmd.Parameters.AddWithValue("@dateUpdate", today);
                                cmd.Parameters.AddWithValue("@issueID", returnIssueID.Text);

                                cmd.ExecuteNonQuery();

                                displayIssueBooksData();

                                MessageBox.Show("Returned successfully!", "Information Message", 
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
        }

        public void displayIssueBooksData()
        {
            DataIssueBooks dataIssueBooks = new DataIssueBooks();

            List<DataIssueBooks> listData = dataIssueBooks.IssueBooksData();

            Window.DataSource = listData;
        }

        private void returnWindow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                // Set up information for all rows in table window
                DataGridViewRow row = Window.Rows[e.RowIndex];

                returnIssueID.Text = row.Cells[1].Value.ToString();
                returnName.Text = row.Cells[2].Value.ToString();
                returnContact.Text = row.Cells[3].Value.ToString();
                returnEmail.Text = row.Cells[4].Value.ToString();
                returnBookTitle.Text = row.Cells[5].Value.ToString();
                returnAuthor.Text = row.Cells[6].Value.ToString();
                returnIssue.Text = row.Cells[7].Value.ToString();
            }
        }

        // Clear all Fields
        public void clearFields()
        {
            returnIssueID.Text = "";
            returnName.Text = "";
            returnContact.Text = "";
            returnEmail.Text = "";
            returnBookTitle.Text = "";
            returnAuthor.Text = "";
        }

        // Clear Button
        private void returnClear_Click(object sender, EventArgs e)
        {
            clearFields();
        }
    }
}
