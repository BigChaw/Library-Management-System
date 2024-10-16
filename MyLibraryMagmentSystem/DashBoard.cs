using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MyLibraryMagmentSystem
{
    public partial class DashBoard : UserControl
    {
        // Set up Connection with database
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mfryj\Documents\Library.mdf");
        public DashBoard()
        {
            InitializeComponent();

            displayAvailableBooks();

            displayIssuedBooks();

            displayReturnedBooks();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);

                return;
            }

            displayAvailableBooks();

            displayIssuedBooks();

            displayReturnedBooks();
        }

        // Function for display available books in Dash Board Tab
        public void displayAvailableBooks()
        {
            if (connection.State == ConnectionState.Closed)
            {
                try
                {
                    // Open communication with database
                    connection.Open();

                    string selectData = "SELECT COUNT(id) FROM books_create WHERE status = 'Available' AND " +
                        "date_delete IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connection))
                    { 
                        SqlDataReader reader = cmd.ExecuteReader();

                        int tempAvailableBooks = 0;

                        if (reader.Read())
                        {
                            // Convert SqlDataReader output to INT
                            tempAvailableBooks = Convert.ToInt32(reader[0]);

                            dashboardAB.Text = tempAvailableBooks.ToString();
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

        // Function for display issued books in Dash Board Tab
        public void displayIssuedBooks()
        {
            if (connection.State == ConnectionState.Closed)
            {
                try
                {
                    // Open communication with database
                    connection.Open();

                    string selectData = "SELECT COUNT(id) FROM issues WHERE " +
                        "date_delete IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connection))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        int tempIssuedBooks = 0;

                        if (reader.Read())
                        {
                            // Convert SqlDataReader output to INT
                            tempIssuedBooks = Convert.ToInt32(reader[0]);

                            dashboardIB.Text = tempIssuedBooks.ToString();
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

        // Function for display issued books in Dash Board Tab
        public void displayReturnedBooks()
        {
            if (connection.State == ConnectionState.Closed)
            {
                try
                {
                    // Open communication with database
                    connection.Open();

                    string selectData = "SELECT COUNT(id) FROM issues WHERE status = 'Return' AND " +
                        "date_delete IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connection))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        int tempReturnedBooks = 0;

                        if (reader.Read())
                        {
                            // Convert SqlDataReader output to INT
                            tempReturnedBooks = Convert.ToInt32(reader[0]);

                            dashboardRB.Text = tempReturnedBooks.ToString();
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
}
