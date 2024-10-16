using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MyLibraryMagmentSystem
{
    internal class DataAddBooks
    {
        // Set up Connection with database
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mfryj\Documents\Library.mdf");

        // Encupsulation - Automatic properties set and get
        // same meaning as short Automatic Properties!!!
        // public int id {
        // get {return id;}
        // set {id = value;}
        public int ID { set; get; }
        public string bookTitle { set; get; }
        public string Author { set; get; }
        public string Published { set; get; }
        public string Image { set; get; }
        public string Status { set; get; }

        // Class for adding books
        public List<DataAddBooks> addBooksData() 
        {
            List<DataAddBooks> listData = new List<DataAddBooks>();

            if (connection.State != ConnectionState.Open)
            {
                try
                {
                    // Open communication with database
                    connection.Open();

                    string selectData = "SELECT * FROM books_create " +
                    "WHERE date_delete IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connection))
                    {
                        // SqlDataReaderReads each line from table in Database one at time and also get rasult one at time
                        // --> it will read all database till the end == DON´T FORGET TO CLOSE IT
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read()) 
                        {
                            DataAddBooks data = new DataAddBooks();

                            data.ID = (int)reader["ID"];
                            data.bookTitle = reader["booktitle"].ToString();
                            data.Author = reader["author"].ToString();
                            data.Published = reader["published_date"].ToString();
                            data.Image = reader["image"].ToString();
                            data.Status = reader["status"].ToString();

                            listData.Add(data);
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error connecting to database. " + ex, "Error Message", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally 
                {
                    connection.Close();
                }
            }

            return listData;
        }
    }
}
