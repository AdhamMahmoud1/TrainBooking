namespace TrainBookingSystem.Forms
{
    partial class AddTrip
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
            AddTrainButton = new Button();
            textBoxSource = new TextBox();
            labelUsername = new Label();
            textboxDate = new TextBox();
            labelEmail = new Label();
            textBoxDest = new TextBox();
            label1 = new Label();
            textBoxArrival = new TextBox();
            label2 = new Label();
            textBoxTrainID = new TextBox();
            label3 = new Label();
            textBoxPrice = new TextBox();
            label4 = new Label();
            LoginInHeader = new Label();
            SuspendLayout();
            // 
            // LoginInHeader
            // 
            LoginInHeader.AutoSize = true;
            LoginInHeader.Font = new Font("MS Gothic", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            LoginInHeader.ForeColor = Color.FromArgb(91, 92, 194);
            LoginInHeader.Location = new Point(12, 26);
            LoginInHeader.Name = "LoginInHeader";
            LoginInHeader.Size = new Size(375, 33);
            LoginInHeader.TabIndex = 50;
            LoginInHeader.Text = "Welcom To Admin Page";
            LoginInHeader.TextAlign = ContentAlignment.TopCenter;
            // 
            // AddTrainButton
            // 
            AddTrainButton.BackColor = Color.FromArgb(91, 92, 194);
            AddTrainButton.BackgroundImageLayout = ImageLayout.None;
            AddTrainButton.Cursor = Cursors.Hand;
            AddTrainButton.FlatAppearance.BorderSize = 0;
            AddTrainButton.FlatStyle = FlatStyle.Flat;
            AddTrainButton.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            AddTrainButton.ForeColor = Color.White;
            AddTrainButton.Location = new Point(479, 375);
            AddTrainButton.Name = "AddTrainButton";
            AddTrainButton.Size = new Size(299, 48);
            AddTrainButton.TabIndex = 55;
            AddTrainButton.Text = "ADD TRIP";
            AddTrainButton.UseMnemonic = false;
            AddTrainButton.UseVisualStyleBackColor = false;
            AddTrainButton.Click += AddTrainButton_Click;
            // 
            // textBoxSource
            // 
            textBoxSource.BackColor = Color.FromArgb(230, 231, 233);
            textBoxSource.BorderStyle = BorderStyle.None;
            textBoxSource.Font = new Font("MS Reference Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSource.ForeColor = SystemColors.InfoText;
            textBoxSource.Location = new Point(12, 130);
            textBoxSource.Multiline = true;
            textBoxSource.Name = "textBoxSource";
            textBoxSource.Size = new Size(299, 33);
            textBoxSource.TabIndex = 53;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelUsername.Location = new Point(12, 102);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(70, 25);
            labelUsername.TabIndex = 51;
            labelUsername.Text = "Source";
            labelUsername.TextAlign = ContentAlignment.TopCenter;
            // 
            // textboxDate
            // 
            textboxDate.BackColor = Color.FromArgb(230, 231, 233);
            textboxDate.BorderStyle = BorderStyle.None;
            textboxDate.Font = new Font("MS Reference Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            textboxDate.ForeColor = SystemColors.InfoText;
            textboxDate.Location = new Point(12, 212);
            textboxDate.Multiline = true;
            textboxDate.Name = "textboxDate";
            textboxDate.Size = new Size(299, 39);
            textboxDate.TabIndex = 54;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelEmail.Location = new Point(12, 175);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(52, 25);
            labelEmail.TabIndex = 52;
            labelEmail.Text = "Date";
            labelEmail.Click += labelEmail_Click;
            // 
            // textBoxDest
            // 
            textBoxDest.BackColor = Color.FromArgb(230, 231, 233);
            textBoxDest.BorderStyle = BorderStyle.None;
            textBoxDest.Font = new Font("MS Reference Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDest.ForeColor = SystemColors.InfoText;
            textBoxDest.Location = new Point(489, 130);
            textBoxDest.Multiline = true;
            textBoxDest.Name = "textBoxDest";
            textBoxDest.Size = new Size(299, 33);
            textBoxDest.TabIndex = 58;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(489, 102);
            label1.Name = "label1";
            label1.Size = new Size(110, 25);
            label1.TabIndex = 56;
            label1.Text = "Destination";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBoxArrival
            // 
            textBoxArrival.BackColor = Color.FromArgb(230, 231, 233);
            textBoxArrival.BorderStyle = BorderStyle.None;
            textBoxArrival.Font = new Font("MS Reference Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxArrival.ForeColor = SystemColors.InfoText;
            textBoxArrival.Location = new Point(479, 212);
            textBoxArrival.Multiline = true;
            textBoxArrival.Name = "textBoxArrival";
            textBoxArrival.Size = new Size(299, 39);
            textBoxArrival.TabIndex = 59;
            textBoxArrival.TextChanged += textBoxArrival_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(489, 184);
            label2.Name = "label2";
            label2.Size = new Size(114, 25);
            label2.TabIndex = 57;
            label2.Text = "Arrival Date";
            // 
            // textBoxTrainID
            // 
            textBoxTrainID.BackColor = Color.FromArgb(230, 231, 233);
            textBoxTrainID.BorderStyle = BorderStyle.None;
            textBoxTrainID.Font = new Font("MS Reference Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTrainID.ForeColor = SystemColors.InfoText;
            textBoxTrainID.Location = new Point(12, 299);
            textBoxTrainID.Multiline = true;
            textBoxTrainID.Name = "textBoxTrainID";
            textBoxTrainID.Size = new Size(299, 33);
            textBoxTrainID.TabIndex = 62;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 271);
            label3.Name = "label3";
            label3.Size = new Size(78, 25);
            label3.TabIndex = 60;
            label3.Text = "Train ID";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBoxPrice
            // 
            textBoxPrice.BackColor = Color.FromArgb(230, 231, 233);
            textBoxPrice.BorderStyle = BorderStyle.None;
            textBoxPrice.Font = new Font("MS Reference Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPrice.ForeColor = SystemColors.InfoText;
            textBoxPrice.Location = new Point(479, 299);
            textBoxPrice.Multiline = true;
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(299, 33);
            textBoxPrice.TabIndex = 64;
            textBoxPrice.TextChanged += textBoxPrice_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(479, 271);
            label4.Name = "label4";
            label4.Size = new Size(54, 25);
            label4.TabIndex = 63;
            label4.Text = "Price";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // AddTrip
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxPrice);
            Controls.Add(label4);
            Controls.Add(textBoxTrainID);
            Controls.Add(label3);
            Controls.Add(textBoxDest);
            Controls.Add(label1);
            Controls.Add(textBoxArrival);
            Controls.Add(label2);
            Controls.Add(AddTrainButton);
            Controls.Add(textBoxSource);
            Controls.Add(labelUsername);
            Controls.Add(textboxDate);
            Controls.Add(labelEmail);
            Controls.Add(LoginInHeader);
            Name = "AddTrip";
            Text = "AddTrip";
            Load += AddTrip_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddTrainButton;
        private TextBox textBoxSource;
        internal Label labelUsername;
        private TextBox textboxDate;
        private Label labelEmail;
        private TextBox textBoxDest;
        internal Label label1;
        private TextBox textBoxArrival;
        private Label label2;
        private TextBox textBoxTrainID;
        internal Label label3;
        private TextBox textBoxPrice;
        internal Label label4;
    }
}