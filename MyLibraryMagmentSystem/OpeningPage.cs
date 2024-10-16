using System;
using System.Data;
using System.Windows.Forms;

namespace MyLibraryMagmentSystem
{
    public partial class OpeningPage : Form
    {
        public OpeningPage()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Increasing step by 30 till 1162 (wide of OpeningPage)
            panel2.Width += 30;

            if (panel2.Width >= 1162) 
            {
                timer1.Stop();

                LogInForm LForm = new LogInForm();
                LForm.Show();
                this.Hide();
            }
        }

        private void EmperorProtecs_Click(object sender, EventArgs e)
        {

        }
    }
}
