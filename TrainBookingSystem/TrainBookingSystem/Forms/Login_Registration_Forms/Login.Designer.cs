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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            labelSignUp = new Label();
            labelDontHaveAnAccount = new Label();
            LoginAsCustomerButton = new Button();
            CheckBoxShowpassword = new CheckBox();
            textBoxPassword = new TextBox();
            lablePassword = new Label();
            textBoxEmail = new TextBox();
            labelEmail = new Label();
            LoginInHeader = new Label();
            emailError = new ErrorProvider(components);
            passwordError = new ErrorProvider(components);
            LoginAdmin = new Button();
            ((System.ComponentModel.ISupportInitialize)emailError).BeginInit();
            ((System.ComponentModel.ISupportInitialize)passwordError).BeginInit();
            SuspendLayout();
            // 
            // labelSignUp
            // 
            labelSignUp.AutoSize = true;
            labelSignUp.Cursor = Cursors.Hand;
            labelSignUp.ForeColor = Color.FromArgb(91, 92, 194);
            labelSignUp.Location = new Point(148, 544);
            labelSignUp.Name = "labelSignUp";
            labelSignUp.Size = new Size(61, 19);
            labelSignUp.TabIndex = 30;
            labelSignUp.Text = "Sign Up";
            labelSignUp.Click += labelSignUp_Click;
            // 
            // labelDontHaveAnAccount
            // 
            labelDontHaveAnAccount.AutoSize = true;
            labelDontHaveAnAccount.Location = new Point(92, 521);
            labelDontHaveAnAccount.Name = "labelDontHaveAnAccount";
            labelDontHaveAnAccount.Size = new Size(169, 19);
            labelDontHaveAnAccount.TabIndex = 31;
            labelDontHaveAnAccount.Text = "Don't Have An Account?";
            // 
            // LoginAsCustomerButton
            // 
            LoginAsCustomerButton.BackColor = Color.FromArgb(91, 92, 194);
            LoginAsCustomerButton.BackgroundImageLayout = ImageLayout.None;
            LoginAsCustomerButton.Cursor = Cursors.Hand;
            LoginAsCustomerButton.FlatAppearance.BorderSize = 0;
            LoginAsCustomerButton.FlatStyle = FlatStyle.Flat;
            LoginAsCustomerButton.ForeColor = Color.White;
            LoginAsCustomerButton.Location = new Point(37, 459);
            LoginAsCustomerButton.Name = "LoginAsCustomerButton";
            LoginAsCustomerButton.Size = new Size(299, 48);
            LoginAsCustomerButton.TabIndex = 29;
            LoginAsCustomerButton.Text = "Login As Customer";
            LoginAsCustomerButton.UseMnemonic = false;
            LoginAsCustomerButton.UseVisualStyleBackColor = false;
            LoginAsCustomerButton.Click += LoginAsCustomerButton_Click;
            // 
            // CheckBoxShowpassword
            // 
            CheckBoxShowpassword.AutoSize = true;
            CheckBoxShowpassword.Cursor = Cursors.Hand;
            CheckBoxShowpassword.FlatStyle = FlatStyle.Flat;
            CheckBoxShowpassword.Location = new Point(185, 319);
            CheckBoxShowpassword.Name = "CheckBoxShowpassword";
            CheckBoxShowpassword.Size = new Size(129, 23);
            CheckBoxShowpassword.TabIndex = 28;
            CheckBoxShowpassword.Text = "Show Password";
            CheckBoxShowpassword.UseVisualStyleBackColor = true;
            CheckBoxShowpassword.CheckedChanged += CheckBoxShowpassword_CheckedChanged;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = Color.FromArgb(230, 231, 233);
            textBoxPassword.BorderStyle = BorderStyle.None;
            textBoxPassword.Font = new Font("MS Reference Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.ForeColor = SystemColors.InfoText;
            textBoxPassword.Location = new Point(37, 285);
            textBoxPassword.Multiline = true;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(299, 28);
            textBoxPassword.TabIndex = 24;
            // 
            // lablePassword
            // 
            lablePassword.AutoSize = true;
            lablePassword.Location = new Point(37, 259);
            lablePassword.Name = "lablePassword";
            lablePassword.Size = new Size(73, 19);
            lablePassword.TabIndex = 20;
            lablePassword.Text = "Password";
            // 
            // textBoxEmail
            // 
            textBoxEmail.BackColor = Color.FromArgb(230, 231, 233);
            textBoxEmail.BorderStyle = BorderStyle.None;
            textBoxEmail.Font = new Font("MS Reference Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEmail.ForeColor = SystemColors.InfoText;
            textBoxEmail.Location = new Point(37, 204);
            textBoxEmail.Multiline = true;
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(299, 27);
            textBoxEmail.TabIndex = 26;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(37, 178);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(45, 19);
            labelEmail.TabIndex = 22;
            labelEmail.Text = "Email";
            // 
            // LoginInHeader
            // 
            LoginInHeader.AutoSize = true;
            LoginInHeader.Font = new Font("MS Gothic", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            LoginInHeader.ForeColor = Color.FromArgb(91, 92, 194);
            LoginInHeader.Location = new Point(117, 90);
            LoginInHeader.Name = "LoginInHeader";
            LoginInHeader.Size = new Size(117, 27);
            LoginInHeader.TabIndex = 19;
            LoginInHeader.Text = "WELCOME";
            LoginInHeader.TextAlign = ContentAlignment.TopCenter;
            // 
            // emailError
            // 
            emailError.ContainerControl = this;
            // 
            // passwordError
            // 
            passwordError.ContainerControl = this;
            // 
            // LoginAdmin
            // 
            LoginAdmin.BackColor = Color.FromArgb(91, 92, 194);
            LoginAdmin.BackgroundImageLayout = ImageLayout.None;
            LoginAdmin.Cursor = Cursors.Hand;
            LoginAdmin.FlatAppearance.BorderSize = 0;
            LoginAdmin.FlatStyle = FlatStyle.Flat;
            LoginAdmin.ForeColor = Color.White;
            LoginAdmin.Location = new Point(37, 405);
            LoginAdmin.Name = "LoginAdmin";
            LoginAdmin.Size = new Size(299, 48);
            LoginAdmin.TabIndex = 29;
            LoginAdmin.Text = "Login As Admin";
            LoginAdmin.UseVisualStyleBackColor = false;
            LoginAdmin.Click += LoginAsAdminButton_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(380, 622);
            Controls.Add(labelSignUp);
            Controls.Add(labelDontHaveAnAccount);
            Controls.Add(LoginAdmin);
            Controls.Add(LoginAsCustomerButton);
            Controls.Add(CheckBoxShowpassword);
            Controls.Add(textBoxPassword);
            Controls.Add(lablePassword);
            Controls.Add(textBoxEmail);
            Controls.Add(labelEmail);
            Controls.Add(LoginInHeader);
            Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)emailError).EndInit();
            ((System.ComponentModel.ISupportInitialize)passwordError).EndInit();
            ResumeLayout(false);
            PerformLayout();
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