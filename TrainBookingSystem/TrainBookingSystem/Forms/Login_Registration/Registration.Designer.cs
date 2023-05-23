namespace TrainBookingSystem.Forms
{
    partial class Registration
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
            System.Windows.Forms.Label LoginInHeader;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.labelSignUp = new System.Windows.Forms.Label();
            this.labelDontHaveAnAccount = new System.Windows.Forms.Label();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.CheckBoxShowpassword = new System.Windows.Forms.CheckBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.lablePassword = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            LoginInHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginInHeader
            // 
            LoginInHeader.AutoSize = true;
            LoginInHeader.Font = new System.Drawing.Font("MS Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            LoginInHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(92)))), ((int)(((byte)(194)))));
            LoginInHeader.Location = new System.Drawing.Point(89, 49);
            LoginInHeader.Name = "LoginInHeader";
            LoginInHeader.Size = new System.Drawing.Size(213, 33);
            LoginInHeader.TabIndex = 32;
            LoginInHeader.Text = "Get Started";
            LoginInHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelSignUp
            // 
            this.labelSignUp.AutoSize = true;
            this.labelSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelSignUp.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(92)))), ((int)(((byte)(194)))));
            this.labelSignUp.Location = new System.Drawing.Point(163, 579);
            this.labelSignUp.Name = "labelSignUp";
            this.labelSignUp.Size = new System.Drawing.Size(61, 23);
            this.labelSignUp.TabIndex = 39;
            this.labelSignUp.Text = "LOGIN";
            this.labelSignUp.Click += new System.EventHandler(this.labelSignUp_Click);
            // 
            // labelDontHaveAnAccount
            // 
            this.labelDontHaveAnAccount.AutoSize = true;
            this.labelDontHaveAnAccount.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDontHaveAnAccount.Location = new System.Drawing.Point(104, 554);
            this.labelDontHaveAnAccount.Name = "labelDontHaveAnAccount";
            this.labelDontHaveAnAccount.Size = new System.Drawing.Size(198, 25);
            this.labelDontHaveAnAccount.TabIndex = 40;
            this.labelDontHaveAnAccount.Text = "Already Have An Account?";
            this.labelDontHaveAnAccount.UseCompatibleTextRendering = true;
            // 
            // RegisterButton
            // 
            this.RegisterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(92)))), ((int)(((byte)(194)))));
            this.RegisterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RegisterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegisterButton.FlatAppearance.BorderSize = 0;
            this.RegisterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterButton.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RegisterButton.ForeColor = System.Drawing.Color.White;
            this.RegisterButton.Location = new System.Drawing.Point(46, 487);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(299, 48);
            this.RegisterButton.TabIndex = 38;
            this.RegisterButton.Text = "REGISTER";
            this.RegisterButton.UseMnemonic = false;
            this.RegisterButton.UseVisualStyleBackColor = false;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // CheckBoxShowpassword
            // 
            this.CheckBoxShowpassword.AutoSize = true;
            this.CheckBoxShowpassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckBoxShowpassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckBoxShowpassword.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CheckBoxShowpassword.Location = new System.Drawing.Point(194, 427);
            this.CheckBoxShowpassword.Name = "CheckBoxShowpassword";
            this.CheckBoxShowpassword.Size = new System.Drawing.Size(151, 27);
            this.CheckBoxShowpassword.TabIndex = 37;
            this.CheckBoxShowpassword.Text = "Show Password";
            this.CheckBoxShowpassword.UseVisualStyleBackColor = true;
            this.CheckBoxShowpassword.CheckedChanged += new System.EventHandler(this.CheckBoxShowpassword_CheckedChanged);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxPassword.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBoxPassword.Location = new System.Drawing.Point(46, 393);
            this.textBoxPassword.Multiline = true;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(299, 28);
            this.textBoxPassword.TabIndex = 35;
            // 
            // lablePassword
            // 
            this.lablePassword.AutoSize = true;
            this.lablePassword.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lablePassword.Location = new System.Drawing.Point(46, 365);
            this.lablePassword.Name = "lablePassword";
            this.lablePassword.Size = new System.Drawing.Size(91, 25);
            this.lablePassword.TabIndex = 33;
            this.lablePassword.Text = "Password";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEmail.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxEmail.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBoxEmail.Location = new System.Drawing.Point(46, 222);
            this.textBoxEmail.Multiline = true;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(299, 27);
            this.textBoxEmail.TabIndex = 36;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEmail.Location = new System.Drawing.Point(46, 196);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(58, 25);
            this.labelEmail.TabIndex = 34;
            this.labelEmail.Text = "Email";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelUsername.Location = new System.Drawing.Point(46, 113);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(97, 25);
            this.labelUsername.TabIndex = 34;
            this.labelUsername.Text = "Username";
            this.labelUsername.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUsername.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxUsername.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBoxUsername.Location = new System.Drawing.Point(46, 139);
            this.textBoxUsername.Multiline = true;
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(299, 27);
            this.textBoxUsername.TabIndex = 36;
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPhoneNumber.Location = new System.Drawing.Point(46, 284);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(137, 25);
            this.labelPhoneNumber.TabIndex = 34;
            this.labelPhoneNumber.Text = "Phone number";
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPhoneNumber.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPhoneNumber.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(46, 310);
            this.textBoxPhoneNumber.Multiline = true;
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(299, 27);
            this.textBoxPhoneNumber.TabIndex = 36;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(392, 651);
            this.Controls.Add(this.labelSignUp);
            this.Controls.Add(this.labelDontHaveAnAccount);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.CheckBoxShowpassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.lablePassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.labelPhoneNumber);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(LoginInHeader);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Regisration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelSignUp;
        private Label labelDontHaveAnAccount;
        private Button RegisterButton;
        private CheckBox CheckBoxShowpassword;
        private TextBox textBoxPassword;
        private Label lablePassword;
        private TextBox textBoxEmail;
        private Label labelEmail;
        private Label LoginInHeader;
        private TextBox textBoxUsername;
        internal Label labelUsername;
        private TextBox textBoxPhoneNumber;
        private Label labelPhoneNumber;
    }
}