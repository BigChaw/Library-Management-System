using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace MyLibraryMagmentSystem
{
    internal class DataIssueBooks
    {
        // Set up Connection with database
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mfryj\Documents\Library.mdf");
        public int ID { set; get; }
        public string IssueID { set; get; }
        public string Name { set; get; }
        public string Contact { set; get; }
        public string Email { set; get; }
        public string BookTitle { set; get; }
        public string Author { set; get; }
        public string DateIssue { set; get; }
        public string DateReturn { set; get; }
        public string Status { set; get; }

        public List<DataIssueBooks> IssueBooksData()
        {
            List<DataIssueBooks> listData = new List<DataIssueBooks>();
            if (connection.State != ConnectionState.Open)
            {
                try
                {
                    // Open communication with database
                    connection.Open();

                    string selectData = "SELECT * FROM issues WHERE date_delete IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connection))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            DataIssueBooks dataIssue = new DataIssueBooks();

                            dataIssue.ID = (int)reader["id"];
                            dataIssue.IssueID = reader["issue_id"].ToString();
                            dataIssue.Name = reader["full_name"].ToString();
                            dataIssue.Contact = reader["contact"].ToString();
                            dataIssue.Email = reader["email"].ToString();
                            dataIssue.BookTitle = reader["book_title"].ToString();
                            dataIssue.Author = reader["author"].ToString();
                            dataIssue.DateIssue = reader["issue_date"].ToString();
                            dataIssue.DateReturn = reader["return_date"].ToString();
                            dataIssue.Status = reader["status"].ToString();

                            listData.Add(dataIssue);
                        }
                        reader.Close();
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex);
                }
                finally
                {
                    // Close communication with database
                    connection.Close();
                }
            }
            return listData;
        }
    }
}
