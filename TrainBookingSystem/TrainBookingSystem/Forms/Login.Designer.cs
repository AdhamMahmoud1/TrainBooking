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
            emailError = new ErrorProvider(components);
            passwordError = new ErrorProvider(components);
            pictureBox1 = new PictureBox();
            labelSignUp = new Label();
            labelDontHaveAnAccount = new Label();
            LoginAsAdminButton = new Button();
            LoginAsCustomerButton = new Button();
            CheckBoxShowpassword = new CheckBox();
            textBoxPassword = new TextBox();
            lablePassword = new Label();
            textBoxEmail = new TextBox();
            labelEmail = new Label();
            LoginInHeader = new Label();
            ((System.ComponentModel.ISupportInitialize)emailError).BeginInit();
            ((System.ComponentModel.ISupportInitialize)passwordError).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // emailError
            // 
            emailError.ContainerControl = this;
            // 
            // passwordError
            // 
            passwordError.ContainerControl = this;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(-2, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(893, 564);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // labelSignUp
            // 
            labelSignUp.AutoSize = true;
            labelSignUp.BackColor = Color.FromArgb(230, 231, 233);
            labelSignUp.Cursor = Cursors.Hand;
            labelSignUp.ForeColor = Color.FromArgb(91, 92, 194);
            labelSignUp.Location = new Point(408, 497);
            labelSignUp.Name = "labelSignUp";
            labelSignUp.Size = new Size(74, 23);
            labelSignUp.TabIndex = 40;
            labelSignUp.Text = "Sign Up";
            labelSignUp.Click += labelSignUp_Click;
            // 
            // labelDontHaveAnAccount
            // 
            labelDontHaveAnAccount.AutoSize = true;
            labelDontHaveAnAccount.BackColor = Color.FromArgb(230, 231, 233);
            labelDontHaveAnAccount.Location = new Point(353, 474);
            labelDontHaveAnAccount.Name = "labelDontHaveAnAccount";
            labelDontHaveAnAccount.Size = new Size(203, 23);
            labelDontHaveAnAccount.TabIndex = 41;
            labelDontHaveAnAccount.Text = "Don't Have An Account?";
            // 
            // LoginAsAdminButton
            // 
            LoginAsAdminButton.BackColor = Color.FromArgb(91, 92, 194);
            LoginAsAdminButton.BackgroundImageLayout = ImageLayout.None;
            LoginAsAdminButton.Cursor = Cursors.Hand;
            LoginAsAdminButton.FlatAppearance.BorderSize = 0;
            LoginAsAdminButton.FlatStyle = FlatStyle.Flat;
            LoginAsAdminButton.ForeColor = Color.White;
            LoginAsAdminButton.Location = new Point(298, 358);
            LoginAsAdminButton.Name = "LoginAsAdminButton";
            LoginAsAdminButton.Size = new Size(299, 48);
            LoginAsAdminButton.TabIndex = 38;
            LoginAsAdminButton.Text = "Login As Admin";
            LoginAsAdminButton.UseVisualStyleBackColor = false;
            LoginAsAdminButton.Click += LoginAsAdminButton_Click;
            // 
            // LoginAsCustomerButton
            // 
            LoginAsCustomerButton.BackColor = Color.FromArgb(91, 92, 194);
            LoginAsCustomerButton.BackgroundImageLayout = ImageLayout.None;
            LoginAsCustomerButton.Cursor = Cursors.Hand;
            LoginAsCustomerButton.FlatAppearance.BorderSize = 0;
            LoginAsCustomerButton.FlatStyle = FlatStyle.Flat;
            LoginAsCustomerButton.ForeColor = Color.White;
            LoginAsCustomerButton.Location = new Point(298, 412);
            LoginAsCustomerButton.Name = "LoginAsCustomerButton";
            LoginAsCustomerButton.Size = new Size(299, 48);
            LoginAsCustomerButton.TabIndex = 39;
            LoginAsCustomerButton.Text = "Login As Customer";
            LoginAsCustomerButton.UseMnemonic = false;
            LoginAsCustomerButton.UseVisualStyleBackColor = false;
            LoginAsCustomerButton.Click += LoginAsCustomerButton_Click;
            // 
            // CheckBoxShowpassword
            // 
            CheckBoxShowpassword.AutoSize = true;
            CheckBoxShowpassword.BackColor = Color.FromArgb(230, 231, 233);
            CheckBoxShowpassword.Cursor = Cursors.Hand;
            CheckBoxShowpassword.FlatStyle = FlatStyle.Flat;
            CheckBoxShowpassword.ForeColor = Color.Black;
            CheckBoxShowpassword.Location = new Point(446, 272);
            CheckBoxShowpassword.Name = "CheckBoxShowpassword";
            CheckBoxShowpassword.Size = new Size(151, 27);
            CheckBoxShowpassword.TabIndex = 37;
            CheckBoxShowpassword.Text = "Show Password";
            CheckBoxShowpassword.UseVisualStyleBackColor = false;
            CheckBoxShowpassword.CheckedChanged += CheckBoxShowpassword_CheckedChanged;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = Color.FromArgb(230, 231, 233);
            textBoxPassword.BorderStyle = BorderStyle.None;
            textBoxPassword.Font = new Font("MS Reference Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.ForeColor = SystemColors.InfoText;
            textBoxPassword.Location = new Point(298, 238);
            textBoxPassword.Multiline = true;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(299, 28);
            textBoxPassword.TabIndex = 35;
            // 
            // lablePassword
            // 
            lablePassword.AutoSize = true;
            lablePassword.BackColor = Color.FromArgb(230, 231, 233);
            lablePassword.ForeColor = Color.Black;
            lablePassword.Location = new Point(298, 212);
            lablePassword.Name = "lablePassword";
            lablePassword.Size = new Size(84, 23);
            lablePassword.TabIndex = 33;
            lablePassword.Text = "Password";
            // 
            // textBoxEmail
            // 
            textBoxEmail.BackColor = Color.FromArgb(230, 231, 233);
            textBoxEmail.BorderStyle = BorderStyle.None;
            textBoxEmail.Font = new Font("MS Reference Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEmail.ForeColor = SystemColors.InfoText;
            textBoxEmail.Location = new Point(298, 157);
            textBoxEmail.Multiline = true;
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(299, 27);
            textBoxEmail.TabIndex = 36;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.BackColor = Color.FromArgb(230, 231, 233);
            labelEmail.ForeColor = Color.Black;
            labelEmail.Location = new Point(298, 131);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(54, 23);
            labelEmail.TabIndex = 34;
            labelEmail.Text = "Email";
            // 
            // LoginInHeader
            // 
            LoginInHeader.AutoSize = true;
            LoginInHeader.BackColor = Color.FromArgb(230, 231, 233);
            LoginInHeader.Font = new Font("MS Gothic", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            LoginInHeader.ForeColor = Color.FromArgb(91, 92, 194);
            LoginInHeader.Location = new Point(378, 43);
            LoginInHeader.Name = "LoginInHeader";
            LoginInHeader.Size = new Size(141, 33);
            LoginInHeader.TabIndex = 32;
            LoginInHeader.Text = "WELCOME";
            LoginInHeader.TextAlign = ContentAlignment.TopCenter;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(895, 562);
            Controls.Add(labelSignUp);
            Controls.Add(labelDontHaveAnAccount);
            Controls.Add(LoginAsAdminButton);
            Controls.Add(LoginAsCustomerButton);
            Controls.Add(CheckBoxShowpassword);
            Controls.Add(textBoxPassword);
            Controls.Add(lablePassword);
            Controls.Add(textBoxEmail);
            Controls.Add(labelEmail);
            Controls.Add(LoginInHeader);
            Controls.Add(pictureBox1);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ErrorProvider emailError;
        private ErrorProvider passwordError;
        private Label labelSignUp;
        private Label labelDontHaveAnAccount;
        private Button LoginAsAdminButton;
        private Button LoginAsCustomerButton;
        private CheckBox CheckBoxShowpassword;
        private TextBox textBoxPassword;
        private Label lablePassword;
        private TextBox textBoxEmail;
        private Label labelEmail;
        private Label LoginInHeader;
        private PictureBox pictureBox1;
    }
}