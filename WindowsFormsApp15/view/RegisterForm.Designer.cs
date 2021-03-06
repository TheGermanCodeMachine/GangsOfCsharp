﻿namespace WindowsFormsApp15
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCreateAccount = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxRepeatPassword = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelClose = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.universityComboBox = new System.Windows.Forms.ComboBox();
            this.areaOfStudiesComboBox = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.buttonCreateAccount);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(690, 672);
            this.panel1.TabIndex = 10;
            // 
            // buttonCreateAccount
            // 
            this.buttonCreateAccount.BackColor = System.Drawing.Color.Lime;
            this.buttonCreateAccount.FlatAppearance.BorderSize = 0;
            this.buttonCreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateAccount.ForeColor = System.Drawing.Color.Black;
            this.buttonCreateAccount.Location = new System.Drawing.Point(10, 605);
            this.buttonCreateAccount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCreateAccount.Name = "buttonCreateAccount";
            this.buttonCreateAccount.Size = new System.Drawing.Size(670, 63);
            this.buttonCreateAccount.TabIndex = 9;
            this.buttonCreateAccount.Text = "CREATE ACCOUNT";
            this.buttonCreateAccount.UseVisualStyleBackColor = false;
            this.buttonCreateAccount.Click += new System.EventHandler(this.ButtonCreateAccount_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.Controls.Add(this.areaOfStudiesComboBox);
            this.panel3.Controls.Add(this.universityComboBox);
            this.panel3.Controls.Add(this.textBoxFirstName);
            this.panel3.Controls.Add(this.textBoxRepeatPassword);
            this.panel3.Controls.Add(this.textBoxLastName);
            this.panel3.Controls.Add(this.textBoxEmail);
            this.panel3.Controls.Add(this.textBoxPassword);
            this.panel3.Controls.Add(this.textBoxUsername);
            this.panel3.Location = new System.Drawing.Point(18, 132);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(663, 463);
            this.panel3.TabIndex = 11;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFirstName.ForeColor = System.Drawing.Color.Gray;
            this.textBoxFirstName.Location = new System.Drawing.Point(8, 18);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxFirstName.Multiline = true;
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(270, 52);
            this.textBoxFirstName.TabIndex = 1;
            this.textBoxFirstName.Text = "first name";
            this.textBoxFirstName.Enter += new System.EventHandler(this.TextBoxFirstName_Enter);
            this.textBoxFirstName.Leave += new System.EventHandler(this.TextBoxFirstName_Leave);
            // 
            // textBoxRepeatPassword
            // 
            this.textBoxRepeatPassword.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRepeatPassword.ForeColor = System.Drawing.Color.Gray;
            this.textBoxRepeatPassword.Location = new System.Drawing.Point(8, 403);
            this.textBoxRepeatPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxRepeatPassword.Name = "textBoxRepeatPassword";
            this.textBoxRepeatPassword.Size = new System.Drawing.Size(606, 54);
            this.textBoxRepeatPassword.TabIndex = 10;
            this.textBoxRepeatPassword.Text = "confirm password";
            this.textBoxRepeatPassword.Enter += new System.EventHandler(this.TextBoxRepeatPassword_Enter);
            this.textBoxRepeatPassword.Leave += new System.EventHandler(this.TextBoxRepeatPassword_Leave);
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLastName.ForeColor = System.Drawing.Color.Gray;
            this.textBoxLastName.Location = new System.Drawing.Point(312, 18);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxLastName.Multiline = true;
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(301, 52);
            this.textBoxLastName.TabIndex = 2;
            this.textBoxLastName.Text = "last name";
            this.textBoxLastName.Enter += new System.EventHandler(this.TextBoxLastName_Enter);
            this.textBoxLastName.Leave += new System.EventHandler(this.TextBoxLastName_Leave);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.ForeColor = System.Drawing.Color.Gray;
            this.textBoxEmail.Location = new System.Drawing.Point(8, 82);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxEmail.Multiline = true;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(606, 52);
            this.textBoxEmail.TabIndex = 3;
            this.textBoxEmail.Text = "email adress";
            this.textBoxEmail.Enter += new System.EventHandler(this.TextBoxEmail_Enter);
            this.textBoxEmail.Leave += new System.EventHandler(this.TextBoxEmail_Leave);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.ForeColor = System.Drawing.Color.Gray;
            this.textBoxPassword.Location = new System.Drawing.Point(8, 335);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(606, 54);
            this.textBoxPassword.TabIndex = 9;
            this.textBoxPassword.Text = "password";
            this.textBoxPassword.Enter += new System.EventHandler(this.TextBoxPassword_Enter);
            this.textBoxPassword.Leave += new System.EventHandler(this.TextBoxPassword_Leave);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.ForeColor = System.Drawing.Color.Gray;
            this.textBoxUsername.Location = new System.Drawing.Point(8, 272);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxUsername.Multiline = true;
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(606, 52);
            this.textBoxUsername.TabIndex = 6;
            this.textBoxUsername.Text = "username";
            this.textBoxUsername.Enter += new System.EventHandler(this.TextBoxUsername_Enter);
            this.textBoxUsername.Leave += new System.EventHandler(this.TextBoxUsername_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.labelClose);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(706, 123);
            this.panel2.TabIndex = 0;
            // 
            // labelClose
            // 
            this.labelClose.AutoSize = true;
            this.labelClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClose.ForeColor = System.Drawing.SystemColors.MenuText;
            this.labelClose.Location = new System.Drawing.Point(658, 0);
            this.labelClose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(30, 29);
            this.labelClose.TabIndex = 12;
            this.labelClose.Text = "X";
            this.labelClose.Click += new System.EventHandler(this.LabelClose_Click);
            this.labelClose.MouseEnter += new System.EventHandler(this.LabelClose_MouseEnter);
            this.labelClose.MouseLeave += new System.EventHandler(this.LabelClose_MouseLeave);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(706, 123);
            this.label1.TabIndex = 0;
            this.label1.Text = "CREATE YOUR ACCOUNT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Label1_MouseMove);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // universityComboBox
            // 
            this.universityComboBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.universityComboBox.FormattingEnabled = true;
            this.universityComboBox.Location = new System.Drawing.Point(8, 143);
            this.universityComboBox.Name = "universityComboBox";
            this.universityComboBox.Size = new System.Drawing.Size(605, 57);
            this.universityComboBox.TabIndex = 11;
            this.universityComboBox.Text = "university";
            // 
            // areaOfStudiesComboBox
            // 
            this.areaOfStudiesComboBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.areaOfStudiesComboBox.FormattingEnabled = true;
            this.areaOfStudiesComboBox.Location = new System.Drawing.Point(8, 207);
            this.areaOfStudiesComboBox.Name = "areaOfStudiesComboBox";
            this.areaOfStudiesComboBox.Size = new System.Drawing.Size(605, 57);
            this.areaOfStudiesComboBox.TabIndex = 12;
            this.areaOfStudiesComboBox.Text = "Area of Studies";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 672);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxRepeatPassword;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonCreateAccount;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox areaOfStudiesComboBox;
        private System.Windows.Forms.ComboBox universityComboBox;
    }
}