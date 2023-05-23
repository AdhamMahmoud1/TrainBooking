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
            button2 = new Button();
            button1 = new Button();
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
            pictureBox1.Size = new Size(894, 561);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(91, 92, 194);
            button2.Location = new Point(356, 305);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.RightToLeft = RightToLeft.No;
            button2.Size = new Size(190, 48);
            button2.TabIndex = 9;
            button2.Text = "Add Trip";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(91, 92, 194);
            button1.Location = new Point(356, 390);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.No;
            button1.Size = new Size(190, 48);
            button1.TabIndex = 8;
            button1.Text = "Update Trip";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(230, 231, 233);
            label1.Font = new Font("MS Gothic", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(91, 92, 194);
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.Location = new Point(260, 84);
            label1.Name = "label1";
            label1.Size = new Size(375, 33);
            label1.TabIndex = 7;
            label1.Text = "Welcome Sweety Admin";
            // 
            // UpdateTrainButton
            // 
            UpdateTrainButton.BackColor = Color.FromArgb(91, 92, 194);
            UpdateTrainButton.Location = new Point(356, 218);
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
            AddTrainButton.Location = new Point(356, 136);
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
            LogOutButton.Location = new Point(782, 501);
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
            ClientSize = new Size(895, 562);
            Controls.Add(LogOutButton);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(UpdateTrainButton);
            Controls.Add(AddTrainButton);
            Controls.Add(pictureBox1);
            Name = "AdminForm";
            Text = "AdminForm";
            Load += AdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button2;
        private Button button1;
        private Label label1;
        private Button UpdateTrainButton;
        private Button AddTrainButton;
        private Button LogOutButton;
    }
}