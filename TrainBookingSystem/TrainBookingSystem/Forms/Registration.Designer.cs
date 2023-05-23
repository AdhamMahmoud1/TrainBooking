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
            Label LoginInHeader;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            pictureBox1 = new PictureBox();
            label2 = new Label();
            textBoxSSN = new TextBox();
            label1 = new Label();
            textBoxGender = new TextBox();
            labelSignUp = new Label();
            labelDontHaveAnAccount = new Label();
            RegisterButton = new Button();
            CheckBoxShowpassword = new CheckBox();
            textBoxPassword = new TextBox();
            lablePassword = new Label();
            textBoxUsername = new TextBox();
            labelUsername = new Label();
            textBoxPhoneNumber = new TextBox();
            labelPhoneNumber = new Label();
            textBoxEmail = new TextBox();
            labelEmail = new Label();
            LoginInHeader = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LoginInHeader
            // 
            LoginInHeader.AutoSize = true;
            LoginInHeader.Font = new Font("MS Gothic", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            LoginInHeader.ForeColor = Color.FromArgb(91, 92, 194);
            LoginInHeader.Location = new Point(336, 25);
            LoginInHeader.Name = "LoginInHeader";
            LoginInHeader.Size = new Size(213, 33);
            LoginInHeader.TabIndex = 62;
            LoginInHeader.Text = "Get Started";
            LoginInHeader.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(896, 556);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(230, 231, 233);
            label2.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(531, 180);
            label2.Name = "label2";
            label2.Size = new Size(46, 25);
            label2.TabIndex = 78;
            label2.Text = "SSN";
            // 
            // textBoxSSN
            // 
            textBoxSSN.BackColor = Color.FromArgb(230, 231, 233);
            textBoxSSN.Location = new Point(531, 205);
            textBoxSSN.Margin = new Padding(3, 4, 3, 4);
            textBoxSSN.Name = "textBoxSSN";
            textBoxSSN.Size = new Size(295, 27);
            textBoxSSN.TabIndex = 77;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(230, 231, 233);
            label1.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(531, 91);
            label1.Name = "label1";
            label1.Size = new Size(74, 25);
            label1.TabIndex = 76;
            label1.Text = "Gender";
            // 
            // textBoxGender
            // 
            textBoxGender.BackColor = Color.FromArgb(230, 231, 233);
            textBoxGender.Location = new Point(531, 117);
            textBoxGender.Margin = new Padding(3, 4, 3, 4);
            textBoxGender.Name = "textBoxGender";
            textBoxGender.Size = new Size(295, 27);
            textBoxGender.TabIndex = 75;
            // 
            // labelSignUp
            // 
            labelSignUp.AutoSize = true;
            labelSignUp.Cursor = Cursors.Hand;
            labelSignUp.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelSignUp.ForeColor = Color.FromArgb(91, 92, 194);
            labelSignUp.Location = new Point(401, 509);
            labelSignUp.Name = "labelSignUp";
            labelSignUp.Size = new Size(61, 23);
            labelSignUp.TabIndex = 73;
            labelSignUp.Text = "LOGIN";
            labelSignUp.Click += labelSignUp_Click;
            // 
            // labelDontHaveAnAccount
            // 
            labelDontHaveAnAccount.AutoSize = true;
            labelDontHaveAnAccount.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelDontHaveAnAccount.Location = new Point(336, 484);
            labelDontHaveAnAccount.Name = "labelDontHaveAnAccount";
            labelDontHaveAnAccount.Size = new Size(198, 25);
            labelDontHaveAnAccount.TabIndex = 74;
            labelDontHaveAnAccount.Text = "Already Have An Account?";
            labelDontHaveAnAccount.UseCompatibleTextRendering = true;
            // 
            // RegisterButton
            // 
            RegisterButton.BackColor = Color.FromArgb(91, 92, 194);
            RegisterButton.BackgroundImageLayout = ImageLayout.None;
            RegisterButton.Cursor = Cursors.Hand;
            RegisterButton.FlatAppearance.BorderSize = 0;
            RegisterButton.FlatStyle = FlatStyle.Flat;
            RegisterButton.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            RegisterButton.ForeColor = Color.White;
            RegisterButton.Location = new Point(278, 417);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(299, 48);
            RegisterButton.TabIndex = 72;
            RegisterButton.Text = "REGISTER";
            RegisterButton.UseMnemonic = false;
            RegisterButton.UseVisualStyleBackColor = false;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // CheckBoxShowpassword
            // 
            CheckBoxShowpassword.AutoSize = true;
            CheckBoxShowpassword.BackColor = Color.FromArgb(230, 231, 233);
            CheckBoxShowpassword.Cursor = Cursors.Hand;
            CheckBoxShowpassword.FlatStyle = FlatStyle.Flat;
            CheckBoxShowpassword.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            CheckBoxShowpassword.ForeColor = Color.Black;
            CheckBoxShowpassword.Location = new Point(679, 342);
            CheckBoxShowpassword.Name = "CheckBoxShowpassword";
            CheckBoxShowpassword.Size = new Size(151, 27);
            CheckBoxShowpassword.TabIndex = 71;
            CheckBoxShowpassword.Text = "Show Password";
            CheckBoxShowpassword.UseVisualStyleBackColor = false;
            CheckBoxShowpassword.CheckedChanged += CheckBoxShowpassword_CheckedChanged;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = Color.FromArgb(230, 231, 233);
            textBoxPassword.BorderStyle = BorderStyle.None;
            textBoxPassword.Font = new Font("MS Reference Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxPassword.ForeColor = SystemColors.InfoText;
            textBoxPassword.Location = new Point(531, 303);
            textBoxPassword.Multiline = true;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(299, 28);
            textBoxPassword.TabIndex = 67;
            // 
            // lablePassword
            // 
            lablePassword.AutoSize = true;
            lablePassword.BackColor = Color.FromArgb(230, 231, 233);
            lablePassword.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lablePassword.ForeColor = Color.Black;
            lablePassword.Location = new Point(531, 279);
            lablePassword.Name = "lablePassword";
            lablePassword.Size = new Size(91, 25);
            lablePassword.TabIndex = 63;
            lablePassword.Text = "Password";
            // 
            // textBoxUsername
            // 
            textBoxUsername.BackColor = Color.FromArgb(230, 231, 233);
            textBoxUsername.BorderStyle = BorderStyle.None;
            textBoxUsername.Font = new Font("MS Reference Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxUsername.ForeColor = SystemColors.InfoText;
            textBoxUsername.Location = new Point(65, 117);
            textBoxUsername.Multiline = true;
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(299, 27);
            textBoxUsername.TabIndex = 68;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.BackColor = Color.FromArgb(230, 231, 233);
            labelUsername.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelUsername.ForeColor = Color.Black;
            labelUsername.Location = new Point(65, 91);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(97, 25);
            labelUsername.TabIndex = 65;
            labelUsername.Text = "Username";
            labelUsername.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.BackColor = Color.FromArgb(230, 231, 233);
            textBoxPhoneNumber.BorderStyle = BorderStyle.None;
            textBoxPhoneNumber.Font = new Font("MS Reference Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPhoneNumber.ForeColor = SystemColors.InfoText;
            textBoxPhoneNumber.Location = new Point(65, 304);
            textBoxPhoneNumber.Multiline = true;
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.Size = new Size(299, 27);
            textBoxPhoneNumber.TabIndex = 69;
            // 
            // labelPhoneNumber
            // 
            labelPhoneNumber.AutoSize = true;
            labelPhoneNumber.BackColor = Color.FromArgb(230, 231, 233);
            labelPhoneNumber.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelPhoneNumber.ForeColor = Color.Black;
            labelPhoneNumber.Location = new Point(65, 279);
            labelPhoneNumber.Name = "labelPhoneNumber";
            labelPhoneNumber.Size = new Size(137, 25);
            labelPhoneNumber.TabIndex = 64;
            labelPhoneNumber.Text = "Phone number";
            // 
            // textBoxEmail
            // 
            textBoxEmail.BackColor = Color.FromArgb(230, 231, 233);
            textBoxEmail.BorderStyle = BorderStyle.None;
            textBoxEmail.Font = new Font("MS Reference Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEmail.ForeColor = SystemColors.InfoText;
            textBoxEmail.Location = new Point(65, 205);
            textBoxEmail.Multiline = true;
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(299, 27);
            textBoxEmail.TabIndex = 70;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.BackColor = Color.FromArgb(230, 231, 233);
            labelEmail.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelEmail.ForeColor = Color.Black;
            labelEmail.Location = new Point(65, 180);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(58, 25);
            labelEmail.TabIndex = 66;
            labelEmail.Text = "Email";
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(895, 556);
            Controls.Add(label2);
            Controls.Add(textBoxSSN);
            Controls.Add(label1);
            Controls.Add(textBoxGender);
            Controls.Add(labelSignUp);
            Controls.Add(labelDontHaveAnAccount);
            Controls.Add(RegisterButton);
            Controls.Add(CheckBoxShowpassword);
            Controls.Add(textBoxPassword);
            Controls.Add(lablePassword);
            Controls.Add(textBoxUsername);
            Controls.Add(labelUsername);
            Controls.Add(textBoxPhoneNumber);
            Controls.Add(labelPhoneNumber);
            Controls.Add(textBoxEmail);
            Controls.Add(labelEmail);
            Controls.Add(LoginInHeader);
            Controls.Add(pictureBox1);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Registration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Regisration";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label2;
        private TextBox textBoxSSN;
        private Label label1;
        private TextBox textBoxGender;
        private Label labelSignUp;
        private Label labelDontHaveAnAccount;
        private Button RegisterButton;
        private CheckBox CheckBoxShowpassword;
        private TextBox textBoxPassword;
        private Label lablePassword;
        private TextBox textBoxUsername;
        internal Label labelUsername;
        private TextBox textBoxPhoneNumber;
        private Label labelPhoneNumber;
        private TextBox textBoxEmail;
        private Label labelEmail;
    }
}