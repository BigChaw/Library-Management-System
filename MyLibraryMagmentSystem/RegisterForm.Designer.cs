namespace MyLibraryMagmentSystem
{
    partial class RegisterForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.registerShowPassword = new System.Windows.Forms.CheckBox();
            this.singInButt = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.registerButt = new System.Windows.Forms.Button();
            this.registerPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.registerUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.registerEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(116, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 31);
            this.label5.TabIndex = 22;
            this.label5.Text = "Registration Formular";
            // 
            // registerShowPassword
            // 
            this.registerShowPassword.AutoSize = true;
            this.registerShowPassword.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.registerShowPassword.Location = new System.Drawing.Point(335, 581);
            this.registerShowPassword.Name = "registerShowPassword";
            this.registerShowPassword.Size = new System.Drawing.Size(112, 18);
            this.registerShowPassword.TabIndex = 23;
            this.registerShowPassword.Text = "Show Password";
            this.registerShowPassword.UseVisualStyleBackColor = true;
            this.registerShowPassword.CheckedChanged += new System.EventHandler(this.registerShowPassword_CheckedChanged);
            // 
            // singInButt
            // 
            this.singInButt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.singInButt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.singInButt.FlatAppearance.BorderSize = 0;
            this.singInButt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.singInButt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.singInButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.singInButt.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.singInButt.ForeColor = System.Drawing.Color.White;
            this.singInButt.Location = new System.Drawing.Point(24, 684);
            this.singInButt.Name = "singInButt";
            this.singInButt.Size = new System.Drawing.Size(399, 38);
            this.singInButt.TabIndex = 21;
            this.singInButt.Text = "SingIn";
            this.singInButt.UseVisualStyleBackColor = false;
            this.singInButt.Click += new System.EventHandler(this.singInButt_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(174, 665);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Register Account";
            // 
            // registerButt
            // 
            this.registerButt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.registerButt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerButt.FlatAppearance.BorderSize = 0;
            this.registerButt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.registerButt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.registerButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerButt.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.registerButt.ForeColor = System.Drawing.Color.White;
            this.registerButt.Location = new System.Drawing.Point(24, 605);
            this.registerButt.Name = "registerButt";
            this.registerButt.Size = new System.Drawing.Size(399, 47);
            this.registerButt.TabIndex = 19;
            this.registerButt.Text = "Register";
            this.registerButt.UseVisualStyleBackColor = false;
            this.registerButt.Click += new System.EventHandler(this.registerButt_Click);
            // 
            // registerPassword
            // 
            this.registerPassword.Location = new System.Drawing.Point(24, 544);
            this.registerPassword.Multiline = true;
            this.registerPassword.Name = "registerPassword";
            this.registerPassword.PasswordChar = '*';
            this.registerPassword.Size = new System.Drawing.Size(399, 28);
            this.registerPassword.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(20, 521);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Password:";
            // 
            // registerUsername
            // 
            this.registerUsername.Location = new System.Drawing.Point(24, 490);
            this.registerUsername.Multiline = true;
            this.registerUsername.Name = "registerUsername";
            this.registerUsername.Size = new System.Drawing.Size(399, 28);
            this.registerUsername.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(20, 467);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(126, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 31);
            this.label2.TabIndex = 14;
            this.label2.Text = "Emperor protect us!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MyLibraryMagmentSystem.Properties.Resources.Emperor;
            this.pictureBox1.Location = new System.Drawing.Point(24, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(399, 294);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 47);
            this.panel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(424, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // registerEmail
            // 
            this.registerEmail.Location = new System.Drawing.Point(24, 436);
            this.registerEmail.Multiline = true;
            this.registerEmail.Name = "registerEmail";
            this.registerEmail.Size = new System.Drawing.Size(399, 28);
            this.registerEmail.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(20, 413);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Email Address:";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 755);
            this.Controls.Add(this.registerEmail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.registerShowPassword);
            this.Controls.Add(this.singInButt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.registerButt);
            this.Controls.Add(this.registerPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.registerUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox registerShowPassword;
        private System.Windows.Forms.Button singInButt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button registerButt;
        private System.Windows.Forms.TextBox registerPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox registerUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox registerEmail;
        private System.Windows.Forms.Label label7;
    }
}