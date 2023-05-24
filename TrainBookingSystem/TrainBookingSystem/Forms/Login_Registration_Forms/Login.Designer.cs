namespace TrainBookingSystem.Forms
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.labelSignUp = new System.Windows.Forms.Label();
            this.labelDontHaveAnAccount = new System.Windows.Forms.Label();
            this.LoginAsCustomerButton = new System.Windows.Forms.Button();
            this.CheckBoxShowpassword = new System.Windows.Forms.CheckBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.lablePassword = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.LoginInHeader = new System.Windows.Forms.Label();
            this.emailError = new System.Windows.Forms.ErrorProvider(this.components);
            this.passwordError = new System.Windows.Forms.ErrorProvider(this.components);
            this.LoginAdmin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.emailError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordError)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSignUp
            // 
            this.labelSignUp.AutoSize = true;
            this.labelSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelSignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(92)))), ((int)(((byte)(194)))));
            this.labelSignUp.Location = new System.Drawing.Point(148, 544);
            this.labelSignUp.Name = "labelSignUp";
            this.labelSignUp.Size = new System.Drawing.Size(74, 23);
            this.labelSignUp.TabIndex = 30;
            this.labelSignUp.Text = "Sign Up";
            this.labelSignUp.Click += new System.EventHandler(this.labelSignUp_Click);
            // 
            // labelDontHaveAnAccount
            // 
            this.labelDontHaveAnAccount.AutoSize = true;
            this.labelDontHaveAnAccount.Location = new System.Drawing.Point(92, 521);
            this.labelDontHaveAnAccount.Name = "labelDontHaveAnAccount";
            this.labelDontHaveAnAccount.Size = new System.Drawing.Size(203, 23);
            this.labelDontHaveAnAccount.TabIndex = 31;
            this.labelDontHaveAnAccount.Text = "Don\'t Have An Account?";
            // 
            // LoginAsCustomerButton
            // 
            this.LoginAsCustomerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(92)))), ((int)(((byte)(194)))));
            this.LoginAsCustomerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LoginAsCustomerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginAsCustomerButton.FlatAppearance.BorderSize = 0;
            this.LoginAsCustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginAsCustomerButton.ForeColor = System.Drawing.Color.White;
            this.LoginAsCustomerButton.Location = new System.Drawing.Point(37, 459);
            this.LoginAsCustomerButton.Name = "LoginAsCustomerButton";
            this.LoginAsCustomerButton.Size = new System.Drawing.Size(299, 48);
            this.LoginAsCustomerButton.TabIndex = 29;
            this.LoginAsCustomerButton.Text = "Login As Customer";
            this.LoginAsCustomerButton.UseMnemonic = false;
            this.LoginAsCustomerButton.UseVisualStyleBackColor = false;
            this.LoginAsCustomerButton.Click += new System.EventHandler(this.LoginAsCustomerButton_Click);
            // 
            // CheckBoxShowpassword
            // 
            this.CheckBoxShowpassword.AutoSize = true;
            this.CheckBoxShowpassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckBoxShowpassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckBoxShowpassword.Location = new System.Drawing.Point(185, 319);
            this.CheckBoxShowpassword.Name = "CheckBoxShowpassword";
            this.CheckBoxShowpassword.Size = new System.Drawing.Size(151, 27);
            this.CheckBoxShowpassword.TabIndex = 28;
            this.CheckBoxShowpassword.Text = "Show Password";
            this.CheckBoxShowpassword.UseVisualStyleBackColor = true;
            this.CheckBoxShowpassword.CheckedChanged += new System.EventHandler(this.CheckBoxShowpassword_CheckedChanged);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPassword.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBoxPassword.Location = new System.Drawing.Point(37, 285);
            this.textBoxPassword.Multiline = true;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(299, 28);
            this.textBoxPassword.TabIndex = 24;
            // 
            // lablePassword
            // 
            this.lablePassword.AutoSize = true;
            this.lablePassword.Location = new System.Drawing.Point(37, 259);
            this.lablePassword.Name = "lablePassword";
            this.lablePassword.Size = new System.Drawing.Size(84, 23);
            this.lablePassword.TabIndex = 20;
            this.lablePassword.Text = "Password";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEmail.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxEmail.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBoxEmail.Location = new System.Drawing.Point(37, 204);
            this.textBoxEmail.Multiline = true;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(299, 27);
            this.textBoxEmail.TabIndex = 26;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(37, 178);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(54, 23);
            this.labelEmail.TabIndex = 22;
            this.labelEmail.Text = "Email";
            // 
            // LoginInHeader
            // 
            this.LoginInHeader.AutoSize = true;
            this.LoginInHeader.Font = new System.Drawing.Font("MS Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoginInHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(92)))), ((int)(((byte)(194)))));
            this.LoginInHeader.Location = new System.Drawing.Point(117, 90);
            this.LoginInHeader.Name = "LoginInHeader";
            this.LoginInHeader.Size = new System.Drawing.Size(141, 33);
            this.LoginInHeader.TabIndex = 19;
            this.LoginInHeader.Text = "WELCOME";
            this.LoginInHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // emailError
            // 
            this.emailError.ContainerControl = this;
            // 
            // passwordError
            // 
            this.passwordError.ContainerControl = this;
            // 
            // LoginAdmin
            // 
            this.LoginAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(92)))), ((int)(((byte)(194)))));
            this.LoginAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LoginAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginAdmin.FlatAppearance.BorderSize = 0;
            this.LoginAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginAdmin.ForeColor = System.Drawing.Color.White;
            this.LoginAdmin.Location = new System.Drawing.Point(37, 405);
            this.LoginAdmin.Name = "LoginAdmin";
            this.LoginAdmin.Size = new System.Drawing.Size(299, 48);
            this.LoginAdmin.TabIndex = 29;
            this.LoginAdmin.Text = "Login As Admin";
            this.LoginAdmin.UseVisualStyleBackColor = false;
            this.LoginAdmin.Click += new System.EventHandler(this.LoginAsAdminButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(380, 622);
            this.Controls.Add(this.labelSignUp);
            this.Controls.Add(this.labelDontHaveAnAccount);
            this.Controls.Add(this.LoginAdmin);
            this.Controls.Add(this.LoginAsCustomerButton);
            this.Controls.Add(this.CheckBoxShowpassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.lablePassword);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.LoginInHeader);
            this.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.emailError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelSignUp;
        private Label labelDontHaveAnAccount;
        private Button LoginAsCustomerButton;
        private CheckBox CheckBoxShowpassword;
        private TextBox textBoxPassword;
        private Label lablePassword;
        private TextBox textBoxEmail;
        private Label labelEmail;
        private Label LoginInHeader;
        private ErrorProvider emailError;
        private ErrorProvider passwordError;
        private Button LoginAdmin;
    }
}