using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace MyLibraryMagmentSystem
{
    public partial class RegisterForm : Form
    {
        // ADD Connect String according where do you have save DB on local machine --> Globals
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mfryj\Documents\Library.mdf;Integrated Security=True;Connect Timeout=30");

        public RegisterForm()
        {
            InitializeComponent();
        }

        // Singup Button
        private void singInButt_Click(object sender, EventArgs e)
        {
            // Performe Login
            LogInForm logForm = new LogInForm();
            logForm.Show();
            this.Hide();
        }

        // Termination box (X)
        private void label1_Click(object sender, EventArgs e)
        {
            // Terminated User Window
            Application.Exit();
        }

        // Register Button
        private void registerButt_Click(object sender, EventArgs e)
        {
            if (registerEmail.Text == "" && registerUsername.Text == "" && registerPassword.Text == "")
            {
                MessageBox.Show("Please fill all blank fields.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (registerEmail.Text == "" && registerUsername.Text == "")
            {
                MessageBox.Show("Please fill Email address and Username.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (registerUsername.Text == "" && registerPassword.Text == "")
            {
                MessageBox.Show("Please fill Username and Password.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (registerEmail.Text == "" && registerPassword.Text == "")
            {
                MessageBox.Show("Plese fill the Email adress and Password.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (registerEmail.Text == "")
            {
                MessageBox.Show("Please fill Email address.", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (registerUsername.Text == "")
            {
                MessageBox.Show("Please fill Username.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (registerPassword.Text == "") 
            {
                MessageBox.Show("Please fill the Password.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connection.State != ConnectionState.Open)
                {
                    try
                    {
                        connection.Open();

                        String checkUsername = "SELECT COUNT(*) FROM users WHERE username = @username";
                        using (SqlCommand checkCMD = new SqlCommand(checkUsername, connection))
                        {
                            checkCMD.Parameters.AddWithValue("@username", registerUsername.Text.Trim());
                            int count = (int)checkCMD.ExecuteScalar();

                            if (count > 1)
                            {
                                MessageBox.Show(registerUsername.Text.Trim() + " name is already taken. Please choose another one.", "Error Message", 
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                // To get date today
                                DateTime day = DateTime.Today;

                                String insertData = "INSERT INTO users (email, username, password, data_register)" + "VALUES (@email, @username, @password, @date)";

                                using (SqlCommand insertCMD = new SqlCommand(insertData, connection))
                                {
                                    insertCMD.Parameters.AddWithValue("@email", registerEmail.Text.Trim());
                                    insertCMD.Parameters.AddWithValue("@username", registerUsername.Text.Trim());
                                    insertCMD.Parameters.AddWithValue("@password", registerPassword.Text.Trim());
                                    insertCMD.Parameters.AddWithValue("@date", day);

                                    insertCMD.ExecuteNonQuery();

                                    MessageBox.Show("Registration is successfull.", "Information Message",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    LogInForm lForm = new LogInForm();
                                    lForm.Show();
                                    this.Hide();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error connecting Database: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        private void registerShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            // Set masked password
            registerPassword.PasswordChar = registerShowPassword.Checked ? '\0' : '*';
        }
    }
}
