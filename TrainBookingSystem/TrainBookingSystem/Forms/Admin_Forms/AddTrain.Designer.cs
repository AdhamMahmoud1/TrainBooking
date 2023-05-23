namespace TrainBookingSystem.Forms.Admin_Forms
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
            System.Windows.Forms.Label LoginInHeader;
            this.AddTrainButton = new System.Windows.Forms.Button();
            this.textBoxNumOfSeats = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.textboxKindOfTrain = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            LoginInHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginInHeader
            // 
            LoginInHeader.AutoSize = true;
            LoginInHeader.Font = new System.Drawing.Font("MS Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            LoginInHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(92)))), ((int)(((byte)(194)))));
            LoginInHeader.Location = new System.Drawing.Point(276, 60);
            LoginInHeader.Name = "LoginInHeader";
            LoginInHeader.Size = new System.Drawing.Size(249, 33);
            LoginInHeader.TabIndex = 50;
            LoginInHeader.Text = "ADD NEW TRAIN";
            LoginInHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AddTrainButton
            // 
            this.AddTrainButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(92)))), ((int)(((byte)(194)))));
            this.AddTrainButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddTrainButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddTrainButton.FlatAppearance.BorderSize = 0;
            this.AddTrainButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTrainButton.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddTrainButton.ForeColor = System.Drawing.Color.White;
            this.AddTrainButton.Location = new System.Drawing.Point(251, 342);
            this.AddTrainButton.Name = "AddTrainButton";
            this.AddTrainButton.Size = new System.Drawing.Size(299, 48);
            this.AddTrainButton.TabIndex = 55;
            this.AddTrainButton.Text = "ADD TRAIN";
            this.AddTrainButton.UseMnemonic = false;
            this.AddTrainButton.UseVisualStyleBackColor = false;
            this.AddTrainButton.Click += new System.EventHandler(this.AddTrainButton_Click);
            // 
            // textBoxNumOfSeats
            // 
            this.textBoxNumOfSeats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxNumOfSeats.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNumOfSeats.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNumOfSeats.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBoxNumOfSeats.Location = new System.Drawing.Point(251, 150);
            this.textBoxNumOfSeats.Multiline = true;
            this.textBoxNumOfSeats.Name = "textBoxNumOfSeats";
            this.textBoxNumOfSeats.Size = new System.Drawing.Size(299, 33);
            this.textBoxNumOfSeats.TabIndex = 53;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelUsername.Location = new System.Drawing.Point(323, 124);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(154, 25);
            this.labelUsername.TabIndex = 51;
            this.labelUsername.Text = "Number of Seats";
            this.labelUsername.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textboxKindOfTrain
            // 
            this.textboxKindOfTrain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textboxKindOfTrain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textboxKindOfTrain.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textboxKindOfTrain.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textboxKindOfTrain.Location = new System.Drawing.Point(251, 236);
            this.textboxKindOfTrain.Multiline = true;
            this.textboxKindOfTrain.Name = "textboxKindOfTrain";
            this.textboxKindOfTrain.Size = new System.Drawing.Size(299, 39);
            this.textboxKindOfTrain.TabIndex = 54;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEmail.Location = new System.Drawing.Point(340, 207);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(121, 25);
            this.labelEmail.TabIndex = 52;
            this.labelEmail.Text = "Kind of Train";
            // 
            // AddTrain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddTrainButton);
            this.Controls.Add(this.textBoxNumOfSeats);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.textboxKindOfTrain);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(LoginInHeader);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "AddTrain";
            this.Text = "AddTrain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button AddTrainButton;
        private TextBox textBoxNumOfSeats;
        internal Label labelUsername;
        private TextBox textboxKindOfTrain;
        private Label labelEmail;
    }
}