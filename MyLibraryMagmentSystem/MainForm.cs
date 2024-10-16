using System;
using System.Data;
using System.Windows.Forms;

namespace MyLibraryMagmentSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // Termination box (X)
        private void X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Logout Button
        private void logoutButton_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to logout?", "Confirmation Message", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes) 
            {
                LogInForm loginForm = new LogInForm();
                loginForm.Show();
                this.Hide();
            }
        }

        // Dashboard Tab
        private void returnDashBoard_Click(object sender, EventArgs e)
        {
            // Set visible for controles buttons
            dashBoard1.Visible = true;
            addBook1.Visible = false;
            returnBooks1.Visible = false;
            issueBooks1.Visible = false;

            DashBoard dashForm = dashBoard1 as DashBoard;
            if (dashForm != null)
            {
                dashForm.refreshData();
            }
        }

        // Add Tab
        private void returnAdd_Click(object sender, EventArgs e)
        {
            // Set visible for controles buttons
            dashBoard1.Visible = false;
            addBook1.Visible = true;
            returnBooks1.Visible = false;
            issueBooks1.Visible = false;

            AddBook addForm = addBook1 as AddBook;
            if (addForm != null)
            {
                addForm.refreshData();
            }
        }

        // Issue Tab
        private void returnIssue_Click(object sender, EventArgs e)
        {
            // Set visible for controles buttons
            dashBoard1.Visible = false;
            addBook1.Visible = false;
            returnBooks1.Visible = false;
            issueBooks1.Visible = true;

            ReturnBooks returnForm = returnBooks1 as ReturnBooks;
            if (returnForm != null)
            {
                returnForm.refreshData();
            }
        }

        // Return Tab
        private void retunrBooks_Click(object sender, EventArgs e)
        {
            // Set visible for controles buttons
            dashBoard1.Visible = false;
            addBook1.Visible = false;
            returnBooks1.Visible = true;
            issueBooks1.Visible = false;

            IssueBooks issueForm = issueBooks1 as IssueBooks;
            if (issueForm != null)
            {
                issueForm.refreshData();
            }
        }
    }
}
