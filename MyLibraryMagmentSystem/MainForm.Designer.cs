namespace MyLibraryMagmentSystem
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.X = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.retunrBooks = new System.Windows.Forms.Button();
            this.returnIssue = new System.Windows.Forms.Button();
            this.returnAdd = new System.Windows.Forms.Button();
            this.returnDashBoard = new System.Windows.Forms.Button();
            this.greetLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.dashBoard1 = new MyLibraryMagmentSystem.DashBoard();
            this.addBook1 = new MyLibraryMagmentSystem.AddBook();
            this.issueBooks1 = new MyLibraryMagmentSystem.IssueBooks();
            this.returnBooks1 = new MyLibraryMagmentSystem.ReturnBooks();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.X);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 47);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Library Managment System - Warhammer";
            // 
            // X
            // 
            this.X.AutoSize = true;
            this.X.BackColor = System.Drawing.Color.White;
            this.X.Cursor = System.Windows.Forms.Cursors.Hand;
            this.X.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.X.Location = new System.Drawing.Point(1065, 9);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(23, 25);
            this.X.TabIndex = 0;
            this.X.Text = "X";
            this.X.Click += new System.EventHandler(this.X_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.logoutButton);
            this.panel2.Controls.Add(this.retunrBooks);
            this.panel2.Controls.Add(this.returnIssue);
            this.panel2.Controls.Add(this.returnAdd);
            this.panel2.Controls.Add(this.returnDashBoard);
            this.panel2.Controls.Add(this.greetLabel);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 553);
            this.panel2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(54, 519);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Log Out";
            // 
            // logoutButton
            // 
            this.logoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.logoutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logoutButton.Image = global::MyLibraryMagmentSystem.Properties.Resources.power_off;
            this.logoutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutButton.Location = new System.Drawing.Point(3, 503);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(45, 45);
            this.logoutButton.TabIndex = 8;
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // retunrBooks
            // 
            this.retunrBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.retunrBooks.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.retunrBooks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.retunrBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.retunrBooks.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.retunrBooks.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.retunrBooks.Image = global::MyLibraryMagmentSystem.Properties.Resources._return;
            this.retunrBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.retunrBooks.Location = new System.Drawing.Point(11, 338);
            this.retunrBooks.Name = "retunrBooks";
            this.retunrBooks.Size = new System.Drawing.Size(200, 45);
            this.retunrBooks.TabIndex = 7;
            this.retunrBooks.Text = "Return Books";
            this.retunrBooks.UseVisualStyleBackColor = true;
            this.retunrBooks.Click += new System.EventHandler(this.retunrBooks_Click);
            // 
            // returnIssue
            // 
            this.returnIssue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.returnIssue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.returnIssue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.returnIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnIssue.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.returnIssue.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.returnIssue.Image = global::MyLibraryMagmentSystem.Properties.Resources.book_normal__1_;
            this.returnIssue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.returnIssue.Location = new System.Drawing.Point(11, 287);
            this.returnIssue.Name = "returnIssue";
            this.returnIssue.Size = new System.Drawing.Size(200, 45);
            this.returnIssue.TabIndex = 6;
            this.returnIssue.Text = "Issue Books";
            this.returnIssue.UseVisualStyleBackColor = true;
            this.returnIssue.Click += new System.EventHandler(this.returnIssue_Click);
            // 
            // returnAdd
            // 
            this.returnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.returnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.returnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.returnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnAdd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.returnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.returnAdd.Image = global::MyLibraryMagmentSystem.Properties.Resources.book11;
            this.returnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.returnAdd.Location = new System.Drawing.Point(11, 235);
            this.returnAdd.Name = "returnAdd";
            this.returnAdd.Size = new System.Drawing.Size(200, 45);
            this.returnAdd.TabIndex = 5;
            this.returnAdd.Text = "Add Books";
            this.returnAdd.UseVisualStyleBackColor = true;
            this.returnAdd.Click += new System.EventHandler(this.returnAdd_Click);
            // 
            // returnDashBoard
            // 
            this.returnDashBoard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.returnDashBoard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.returnDashBoard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.returnDashBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnDashBoard.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.returnDashBoard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.returnDashBoard.Image = global::MyLibraryMagmentSystem.Properties.Resources.dashboard;
            this.returnDashBoard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.returnDashBoard.Location = new System.Drawing.Point(11, 184);
            this.returnDashBoard.Name = "returnDashBoard";
            this.returnDashBoard.Size = new System.Drawing.Size(200, 45);
            this.returnDashBoard.TabIndex = 3;
            this.returnDashBoard.Text = "Dash Board";
            this.returnDashBoard.UseVisualStyleBackColor = true;
            this.returnDashBoard.Click += new System.EventHandler(this.returnDashBoard_Click);
            // 
            // greetLabel
            // 
            this.greetLabel.AutoSize = true;
            this.greetLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.greetLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.greetLabel.Location = new System.Drawing.Point(40, 135);
            this.greetLabel.Name = "greetLabel";
            this.greetLabel.Size = new System.Drawing.Size(147, 19);
            this.greetLabel.TabIndex = 4;
            this.greetLabel.Text = "Welcome, Stranger!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MyLibraryMagmentSystem.Properties.Resources.Logo_Imperial;
            this.pictureBox1.Location = new System.Drawing.Point(11, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 129);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dashBoard1);
            this.panel3.Controls.Add(this.addBook1);
            this.panel3.Controls.Add(this.issueBooks1);
            this.panel3.Controls.Add(this.returnBooks1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(225, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(875, 553);
            this.panel3.TabIndex = 3;
            // 
            // dashBoard1
            // 
            this.dashBoard1.Location = new System.Drawing.Point(0, 0);
            this.dashBoard1.Name = "dashBoard1";
            this.dashBoard1.Size = new System.Drawing.Size(875, 553);
            this.dashBoard1.TabIndex = 3;
            // 
            // addBook1
            // 
            this.addBook1.Location = new System.Drawing.Point(0, 0);
            this.addBook1.Name = "addBook1";
            this.addBook1.Size = new System.Drawing.Size(875, 553);
            this.addBook1.TabIndex = 2;
            // 
            // issueBooks1
            // 
            this.issueBooks1.Location = new System.Drawing.Point(0, 0);
            this.issueBooks1.Name = "issueBooks1";
            this.issueBooks1.Size = new System.Drawing.Size(872, 553);
            this.issueBooks1.TabIndex = 1;
            // 
            // returnBooks1
            // 
            this.returnBooks1.Location = new System.Drawing.Point(0, 0);
            this.returnBooks1.Name = "returnBooks1";
            this.returnBooks1.Size = new System.Drawing.Size(875, 553);
            this.returnBooks1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label X;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label greetLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button returnDashBoard;
        private System.Windows.Forms.Button returnAdd;
        private System.Windows.Forms.Button returnIssue;
        private System.Windows.Forms.Button retunrBooks;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private ReturnBooks returnBooks1;
        private IssueBooks issueBooks1;
        private AddBook addBook1;
        private DashBoard dashBoard1;
    }
}