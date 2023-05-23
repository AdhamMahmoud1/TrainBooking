namespace TrainBookingSystem.Forms
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            pictureBox1 = new PictureBox();
            AddTripButton = new Button();
            UpdateTripButton = new Button();
            label1 = new Label();
            UpdateTrainButton = new Button();
            AddTrainButton = new Button();
            LogOutButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(915, 611);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // AddTripButton
            // 
            AddTripButton.BackColor = Color.FromArgb(91, 92, 194);
            AddTripButton.Location = new Point(356, 325);
            AddTripButton.Margin = new Padding(3, 4, 3, 4);
            AddTripButton.Name = "AddTripButton";
            AddTripButton.RightToLeft = RightToLeft.No;
            AddTripButton.Size = new Size(190, 48);
            AddTripButton.TabIndex = 9;
            AddTripButton.Text = "Add Trip";
            AddTripButton.UseVisualStyleBackColor = false;
            AddTripButton.Click += AddTripButton_Click;
            // 
            // UpdateTripButton
            // 
            UpdateTripButton.BackColor = Color.FromArgb(91, 92, 194);
            UpdateTripButton.Location = new Point(356, 409);
            UpdateTripButton.Margin = new Padding(3, 4, 3, 4);
            UpdateTripButton.Name = "UpdateTripButton";
            UpdateTripButton.RightToLeft = RightToLeft.No;
            UpdateTripButton.Size = new Size(190, 48);
            UpdateTripButton.TabIndex = 8;
            UpdateTripButton.Text = "Update Trip";
            UpdateTripButton.UseVisualStyleBackColor = false;
            UpdateTripButton.Click += UpdateTripButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(230, 231, 233);
            label1.Font = new Font("MS Gothic", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(91, 92, 194);
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.Location = new Point(259, 71);
            label1.Name = "label1";
            label1.Size = new Size(393, 33);
            label1.TabIndex = 7;
            label1.Text = "Welcome To Admin Page";
            // 
            // UpdateTrainButton
            // 
            UpdateTrainButton.BackColor = Color.FromArgb(91, 92, 194);
            UpdateTrainButton.Location = new Point(356, 239);
            UpdateTrainButton.Margin = new Padding(3, 4, 3, 4);
            UpdateTrainButton.Name = "UpdateTrainButton";
            UpdateTrainButton.RightToLeft = RightToLeft.No;
            UpdateTrainButton.Size = new Size(190, 48);
            UpdateTrainButton.TabIndex = 6;
            UpdateTrainButton.Text = "Update Train";
            UpdateTrainButton.UseVisualStyleBackColor = false;
            UpdateTrainButton.Click += UpdateTrainButton_Click;
            // 
            // AddTrainButton
            // 
            AddTrainButton.BackColor = Color.FromArgb(91, 92, 194);
            AddTrainButton.Location = new Point(356, 156);
            AddTrainButton.Margin = new Padding(3, 4, 3, 4);
            AddTrainButton.Name = "AddTrainButton";
            AddTrainButton.Size = new Size(190, 48);
            AddTrainButton.TabIndex = 5;
            AddTrainButton.Text = "Add Train";
            AddTrainButton.UseVisualStyleBackColor = false;
            AddTrainButton.Click += AddTrainButton_Click;
            // 
            // LogOutButton
            // 
            LogOutButton.BackColor = SystemColors.Control;
            LogOutButton.ForeColor = SystemColors.ActiveCaptionText;
            LogOutButton.Location = new Point(801, 546);
            LogOutButton.Margin = new Padding(3, 4, 3, 4);
            LogOutButton.Name = "LogOutButton";
            LogOutButton.RightToLeft = RightToLeft.No;
            LogOutButton.Size = new Size(101, 48);
            LogOutButton.TabIndex = 10;
            LogOutButton.Text = "Log out";
            LogOutButton.UseVisualStyleBackColor = false;
            LogOutButton.Click += LogOutButton_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 607);
            Controls.Add(LogOutButton);
            Controls.Add(AddTripButton);
            Controls.Add(UpdateTripButton);
            Controls.Add(label1);
            Controls.Add(UpdateTrainButton);
            Controls.Add(AddTrainButton);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AdminForm";
            Text = "AdminForm";
            Load += AdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button AddTripButton;
        private Button UpdateTripButton;
        private Label label1;
        private Button UpdateTrainButton;
        private Button AddTrainButton;
        private Button LogOutButton;
    }
}