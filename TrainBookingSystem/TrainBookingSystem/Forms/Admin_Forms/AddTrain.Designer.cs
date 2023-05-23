namespace TrainBookingSystem.Forms
{
    partial class AddTrain
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
            textBoxNumOfSeats = new TextBox();
            labelUsername = new Label();
            textboxKindOfTrain = new TextBox();
            labelEmail = new Label();
            LoginInHeader = new Label();
            SuspendLayout();
            // 
            // LoginInHeader
            // 
            LoginInHeader.AutoSize = true;
            LoginInHeader.Font = new Font("MS Gothic", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            LoginInHeader.ForeColor = Color.FromArgb(91, 92, 194);
            LoginInHeader.Location = new Point(307, 43);
            LoginInHeader.Name = "LoginInHeader";
            LoginInHeader.Size = new Size(207, 27);
            LoginInHeader.TabIndex = 39;
            LoginInHeader.Text = "ADD NEW TRAIN";
            LoginInHeader.TextAlign = ContentAlignment.TopCenter;
            LoginInHeader.Click += LoginInHeader_Click;
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
            AddTrainButton.Location = new Point(269, 254);
            AddTrainButton.Margin = new Padding(3, 2, 3, 2);
            AddTrainButton.Name = "AddTrainButton";
            AddTrainButton.Size = new Size(262, 36);
            AddTrainButton.TabIndex = 49;
            AddTrainButton.Text = "ADD TRAIN";
            AddTrainButton.UseMnemonic = false;
            AddTrainButton.UseVisualStyleBackColor = false;
            AddTrainButton.Click += RegisterButton_Click;
            // 
            // textBoxNumOfSeats
            // 
            textBoxNumOfSeats.BackColor = Color.FromArgb(230, 231, 233);
            textBoxNumOfSeats.BorderStyle = BorderStyle.None;
            textBoxNumOfSeats.Font = new Font("MS Reference Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNumOfSeats.ForeColor = SystemColors.InfoText;
            textBoxNumOfSeats.Location = new Point(269, 110);
            textBoxNumOfSeats.Margin = new Padding(3, 2, 3, 2);
            textBoxNumOfSeats.Multiline = true;
            textBoxNumOfSeats.Name = "textBoxNumOfSeats";
            textBoxNumOfSeats.Size = new Size(262, 25);
            textBoxNumOfSeats.TabIndex = 45;
            textBoxNumOfSeats.TextChanged += textBoxNumOfSeats_TextChanged;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelUsername.Location = new Point(269, 91);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(127, 20);
            labelUsername.TabIndex = 41;
            labelUsername.Text = "Number of Seats";
            labelUsername.TextAlign = ContentAlignment.TopCenter;
            labelUsername.Click += labelUsername_Click;
            // 
            // textboxKindOfTrain
            // 
            textboxKindOfTrain.BackColor = Color.FromArgb(230, 231, 233);
            textboxKindOfTrain.BorderStyle = BorderStyle.None;
            textboxKindOfTrain.Font = new Font("MS Reference Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            textboxKindOfTrain.ForeColor = SystemColors.InfoText;
            textboxKindOfTrain.Location = new Point(269, 175);
            textboxKindOfTrain.Margin = new Padding(3, 2, 3, 2);
            textboxKindOfTrain.Multiline = true;
            textboxKindOfTrain.Name = "textboxKindOfTrain";
            textboxKindOfTrain.Size = new Size(262, 29);
            textboxKindOfTrain.TabIndex = 47;
            textboxKindOfTrain.TextChanged += textboxKindOfTrain_TextChanged;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelEmail.Location = new Point(269, 153);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(99, 20);
            labelEmail.TabIndex = 43;
            labelEmail.Text = "Kind of Train";
            labelEmail.Click += labelEmail_Click;
            // 
            // AddTrain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AddTrainButton);
            Controls.Add(textBoxNumOfSeats);
            Controls.Add(labelUsername);
            Controls.Add(textboxKindOfTrain);
            Controls.Add(labelEmail);
            Controls.Add(LoginInHeader);
            Name = "AddTrain";
            Text = "AddTrain";
            Load += AddTrain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddTrainButton;
        private TextBox textBoxNumOfSeats;
        internal Label labelUsername;
        private TextBox textboxKindOfTrain;
        private Label labelEmail;
    }
}