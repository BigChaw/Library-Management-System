namespace MyLibraryMagmentSystem
{
    partial class IssueBooks
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.issueAuthor = new System.Windows.Forms.ComboBox();
            this.issueBookTitle = new System.Windows.Forms.ComboBox();
            this.issuePicture = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.issueStatus = new System.Windows.Forms.ComboBox();
            this.issueClear = new System.Windows.Forms.Button();
            this.issueDelete = new System.Windows.Forms.Button();
            this.issueUpdate = new System.Windows.Forms.Button();
            this.issueAdd = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.issueReturn = new System.Windows.Forms.DateTimePicker();
            this.issueIssue = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.issueEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.issueContact = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.issueName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.issueIssueID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Window = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.issuePicture)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Window)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.issueAuthor);
            this.panel1.Controls.Add(this.issueBookTitle);
            this.panel1.Controls.Add(this.issuePicture);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.issueStatus);
            this.panel1.Controls.Add(this.issueClear);
            this.panel1.Controls.Add(this.issueDelete);
            this.panel1.Controls.Add(this.issueUpdate);
            this.panel1.Controls.Add(this.issueAdd);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.issueReturn);
            this.panel1.Controls.Add(this.issueIssue);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.issueEmail);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.issueContact);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.issueName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.issueIssueID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(24, 345);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(829, 191);
            this.panel1.TabIndex = 0;
            // 
            // issueAuthor
            // 
            this.issueAuthor.FormattingEnabled = true;
            this.issueAuthor.Location = new System.Drawing.Point(291, 91);
            this.issueAuthor.Name = "issueAuthor";
            this.issueAuthor.Size = new System.Drawing.Size(131, 21);
            this.issueAuthor.TabIndex = 31;
            // 
            // issueBookTitle
            // 
            this.issueBookTitle.FormattingEnabled = true;
            this.issueBookTitle.Location = new System.Drawing.Point(290, 56);
            this.issueBookTitle.Name = "issueBookTitle";
            this.issueBookTitle.Size = new System.Drawing.Size(131, 21);
            this.issueBookTitle.TabIndex = 30;
            this.issueBookTitle.SelectedIndexChanged += new System.EventHandler(this.issueBookTitle_SelectedIndexChanged);
            // 
            // issuePicture
            // 
            this.issuePicture.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.issuePicture.Image = global::MyLibraryMagmentSystem.Properties.Resources.ebook;
            this.issuePicture.Location = new System.Drawing.Point(677, 14);
            this.issuePicture.Name = "issuePicture";
            this.issuePicture.Size = new System.Drawing.Size(128, 132);
            this.issuePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.issuePicture.TabIndex = 29;
            this.issuePicture.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(437, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 16);
            this.label10.TabIndex = 28;
            this.label10.Text = "Status:";
            // 
            // issueStatus
            // 
            this.issueStatus.FormattingEnabled = true;
            this.issueStatus.Items.AddRange(new object[] {
            "Return",
            "Not Return"});
            this.issueStatus.Location = new System.Drawing.Point(493, 94);
            this.issueStatus.Name = "issueStatus";
            this.issueStatus.Size = new System.Drawing.Size(162, 21);
            this.issueStatus.TabIndex = 27;
            // 
            // issueClear
            // 
            this.issueClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.issueClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.issueClear.FlatAppearance.BorderSize = 0;
            this.issueClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.issueClear.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.issueClear.ForeColor = System.Drawing.Color.White;
            this.issueClear.Location = new System.Drawing.Point(525, 132);
            this.issueClear.Name = "issueClear";
            this.issueClear.Size = new System.Drawing.Size(107, 47);
            this.issueClear.TabIndex = 26;
            this.issueClear.Text = "Clear";
            this.issueClear.UseVisualStyleBackColor = false;
            this.issueClear.Click += new System.EventHandler(this.issueClear_Click);
            // 
            // issueDelete
            // 
            this.issueDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.issueDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.issueDelete.FlatAppearance.BorderSize = 0;
            this.issueDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.issueDelete.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.issueDelete.ForeColor = System.Drawing.Color.White;
            this.issueDelete.Location = new System.Drawing.Point(401, 132);
            this.issueDelete.Name = "issueDelete";
            this.issueDelete.Size = new System.Drawing.Size(107, 47);
            this.issueDelete.TabIndex = 25;
            this.issueDelete.Text = "Delete";
            this.issueDelete.UseVisualStyleBackColor = false;
            this.issueDelete.Click += new System.EventHandler(this.issueDelete_Click);
            // 
            // issueUpdate
            // 
            this.issueUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.issueUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.issueUpdate.FlatAppearance.BorderSize = 0;
            this.issueUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.issueUpdate.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.issueUpdate.ForeColor = System.Drawing.Color.White;
            this.issueUpdate.Location = new System.Drawing.Point(279, 132);
            this.issueUpdate.Name = "issueUpdate";
            this.issueUpdate.Size = new System.Drawing.Size(107, 47);
            this.issueUpdate.TabIndex = 24;
            this.issueUpdate.Text = "Update";
            this.issueUpdate.UseVisualStyleBackColor = false;
            this.issueUpdate.Click += new System.EventHandler(this.issueUpdate_Click);
            // 
            // issueAdd
            // 
            this.issueAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.issueAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.issueAdd.FlatAppearance.BorderSize = 0;
            this.issueAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.issueAdd.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.issueAdd.ForeColor = System.Drawing.Color.White;
            this.issueAdd.Location = new System.Drawing.Point(154, 132);
            this.issueAdd.Name = "issueAdd";
            this.issueAdd.Size = new System.Drawing.Size(107, 47);
            this.issueAdd.TabIndex = 23;
            this.issueAdd.Text = "Add";
            this.issueAdd.UseVisualStyleBackColor = false;
            this.issueAdd.Click += new System.EventHandler(this.issueAdd_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(437, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "Return:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(445, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Issue:";
            // 
            // issueReturn
            // 
            this.issueReturn.Location = new System.Drawing.Point(493, 57);
            this.issueReturn.Name = "issueReturn";
            this.issueReturn.Size = new System.Drawing.Size(162, 20);
            this.issueReturn.TabIndex = 20;
            // 
            // issueIssue
            // 
            this.issueIssue.Location = new System.Drawing.Point(493, 16);
            this.issueIssue.Name = "issueIssue";
            this.issueIssue.Size = new System.Drawing.Size(158, 20);
            this.issueIssue.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(234, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Author:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(216, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Book Title:";
            // 
            // issueEmail
            // 
            this.issueEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.issueEmail.Location = new System.Drawing.Point(290, 17);
            this.issueEmail.Name = "issueEmail";
            this.issueEmail.Size = new System.Drawing.Size(132, 22);
            this.issueEmail.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(241, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Email:";
            // 
            // issueContact
            // 
            this.issueContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.issueContact.Location = new System.Drawing.Point(80, 90);
            this.issueContact.Name = "issueContact";
            this.issueContact.Size = new System.Drawing.Size(127, 22);
            this.issueContact.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(19, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Contact:";
            // 
            // issueName
            // 
            this.issueName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.issueName.Location = new System.Drawing.Point(80, 52);
            this.issueName.Name = "issueName";
            this.issueName.Size = new System.Drawing.Size(127, 22);
            this.issueName.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(29, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Name:";
            // 
            // issueIssueID
            // 
            this.issueIssueID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.issueIssueID.Location = new System.Drawing.Point(80, 14);
            this.issueIssueID.Name = "issueIssueID";
            this.issueIssueID.Size = new System.Drawing.Size(127, 22);
            this.issueIssueID.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(16, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Issue ID:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.Window);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(24, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(829, 324);
            this.panel2.TabIndex = 1;
            // 
            // Window
            // 
            this.Window.AllowUserToAddRows = false;
            this.Window.AllowUserToDeleteRows = false;
            this.Window.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.Window.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Window.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Window.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Window.EnableHeadersVisualStyles = false;
            this.Window.Location = new System.Drawing.Point(12, 43);
            this.Window.Name = "Window";
            this.Window.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Window.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Window.RowHeadersVisible = false;
            this.Window.Size = new System.Drawing.Size(804, 268);
            this.Window.TabIndex = 2;
            this.Window.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.issueWindow_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(15, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "All Issued Books";
            // 
            // IssueBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "IssueBooks";
            this.Size = new System.Drawing.Size(875, 553);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.issuePicture)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Window)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox issueContact;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox issueName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox issueIssueID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker issueReturn;
        private System.Windows.Forms.DateTimePicker issueIssue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox issueEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button issueAdd;
        private System.Windows.Forms.Button issueClear;
        private System.Windows.Forms.Button issueDelete;
        private System.Windows.Forms.Button issueUpdate;
        private System.Windows.Forms.ComboBox issueStatus;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox issuePicture;
        private System.Windows.Forms.ComboBox issueAuthor;
        private System.Windows.Forms.ComboBox issueBookTitle;
        private System.Windows.Forms.DataGridView Window;
    }
}
