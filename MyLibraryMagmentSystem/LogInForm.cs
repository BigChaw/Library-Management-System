using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MyLibraryMagmentSystem
{
    public partial class LogInForm : Form
    {
        // ADD Connect String according where do you have save DB on local machine
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mfryj\Documents\Library.mdf");

        public LogInForm()
        {
            InitializeComponent();
        }

        // Login Button
        private void button1_Click(object sender, EventArgs e)
        {
            if (loginName.Text == "" && loginPassword.Text == "")
            {
                MessageBox.Show("Please fill Username and Password.", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (loginName.Text == "")
            {
                MessageBox.Show("Please fill Username.", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (loginPassword.Text == "")
            {
                MessageBox.Show("Please fill Password.", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connection.State != ConnectionState.Open)
                {
                    try
                    {
                        connection.Open();

                        String selectData = "SELECT * FROM users WHERE username = @username AND password = @password";
                        using (SqlCommand cmd = new SqlCommand(selectData, connection))
                        {
                            cmd.Parameters.AddWithValue("@username", loginName.Text.Trim());
                            cmd.Parameters.AddWithValue("@password", loginPassword.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show("Login successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                MainForm mForm = new MainForm();
                                mForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                 MessageBox.Show("Incorrect Username or Password. Please try it again.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error connecting database: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        // Singup Button
        private void singupButt_Click(object sender, EventArgs e)
        {
            // Perform Registration
            RegisterForm regForm = new RegisterForm();
            regForm.Show();
            this.Hide();
        }

        // Termination box (X)
        private void label1_Click(object sender, EventArgs e)
        {
            // Terminated User Window
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Set masked password
            loginPassword.PasswordChar = loginShowPassword.Checked ? '\0' : '*';
        }

    }
}
