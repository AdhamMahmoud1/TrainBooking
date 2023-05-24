namespace TrainBookingSystem.Forms
{
    partial class UpatePassengerInfoForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelGender = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelPassengerId = new System.Windows.Forms.Label();
            this.CheckBoxShowpassword = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.CheckBoxShowpassword);
            this.panel1.Controls.Add(this.labelPassengerId);
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Controls.Add(this.buttonUpdate);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.textBoxPassword);
            this.panel1.Controls.Add(this.textBoxPhoneNumber);
            this.panel1.Controls.Add(this.textBoxEmail);
            this.panel1.Controls.Add(this.textBoxUsername);
            this.panel1.Controls.Add(this.labelGender);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(961, 560);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(91, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "Password: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Phone number: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Email: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(332, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = " Update Personal Information";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(211, 188);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(611, 32);
            this.textBoxUsername.TabIndex = 12;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(211, 243);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(611, 32);
            this.textBoxEmail.TabIndex = 12;
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(211, 301);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(611, 32);
            this.textBoxPhoneNumber.TabIndex = 12;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(211, 357);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(611, 32);
            this.textBoxPassword.TabIndex = 12;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "male",
            "female"});
            this.comboBox1.Location = new System.Drawing.Point(211, 425);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 31);
            this.comboBox1.TabIndex = 13;
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(109, 428);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(96, 23);
            this.labelGender.TabIndex = 11;
            this.labelGender.Text = "Gender: ";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.FlatAppearance.BorderSize = 2;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.ForeColor = System.Drawing.Color.SeaGreen;
            this.buttonUpdate.Location = new System.Drawing.Point(734, 469);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(188, 57);
            this.buttonUpdate.TabIndex = 14;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.FlatAppearance.BorderSize = 2;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonClose.Location = new System.Drawing.Point(509, 469);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(188, 57);
            this.buttonClose.TabIndex = 14;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelPassengerId
            // 
            this.labelPassengerId.AutoSize = true;
            this.labelPassengerId.Location = new System.Drawing.Point(211, 130);
            this.labelPassengerId.Name = "labelPassengerId";
            this.labelPassengerId.Size = new System.Drawing.Size(128, 23);
            this.labelPassengerId.TabIndex = 15;
            this.labelPassengerId.Text = "PassengerId";
            // 
            // CheckBoxShowpassword
            // 
            this.CheckBoxShowpassword.AutoSize = true;
            this.CheckBoxShowpassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckBoxShowpassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckBoxShowpassword.Location = new System.Drawing.Point(642, 395);
            this.CheckBoxShowpassword.Name = "CheckBoxShowpassword";
            this.CheckBoxShowpassword.Size = new System.Drawing.Size(180, 27);
            this.CheckBoxShowpassword.TabIndex = 29;
            this.CheckBoxShowpassword.Text = "Show Password";
            this.CheckBoxShowpassword.UseVisualStyleBackColor = true;
            this.CheckBoxShowpassword.CheckedChanged += new System.EventHandler(this.CheckBoxShowpassword_CheckedChanged);
            // 
            // UpatePassengerInfoForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(92)))), ((int)(((byte)(194)))));
            this.ClientSize = new System.Drawing.Size(977, 576);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "UpatePassengerInfoForm";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Text = "UpatePassengerInfo";
            this.Load += new System.EventHandler(this.UpatePassengerInfoForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label labelPassengerId;
        private Button buttonClose;
        private Button buttonUpdate;
        private ComboBox comboBox1;
        private TextBox textBoxPassword;
        private TextBox textBoxPhoneNumber;
        private TextBox textBoxEmail;
        private TextBox textBoxUsername;
        private Label labelGender;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private CheckBox CheckBoxShowpassword;
    }
}