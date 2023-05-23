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

        private TextBox GetTextBoxNumberOfSeats()
        {
            return textBoxNumberOfSeats;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTrain));
            label2 = new Label();
            label3 = new Label();
            textBoxNumberOfSeats = new TextBox();
            textBoxKindOfTrain = new TextBox();
            AdminFormbutton = new Button();
            AddButton = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(327, 133);
            label2.Name = "label2";
            label2.Size = new Size(161, 28);
            label2.TabIndex = 2;
            label2.Text = "Number Of Seats";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(327, 226);
            label3.Name = "label3";
            label3.Size = new Size(124, 28);
            label3.TabIndex = 3;
            label3.Text = "Kind Of Train";
            // 
            // textBoxNumberOfSeats
            // 
            textBoxNumberOfSeats.BackColor = Color.FromArgb(230, 231, 233);
            textBoxNumberOfSeats.Location = new Point(327, 164);
            textBoxNumberOfSeats.Name = "textBoxNumberOfSeats";
            textBoxNumberOfSeats.Size = new Size(249, 27);
            textBoxNumberOfSeats.TabIndex = 4;
            // 
            // textBoxKindOfTrain
            // 
            textBoxKindOfTrain.BackColor = Color.FromArgb(230, 231, 233);
            textBoxKindOfTrain.Location = new Point(327, 257);
            textBoxKindOfTrain.Name = "textBoxKindOfTrain";
            textBoxKindOfTrain.Size = new Size(249, 27);
            textBoxKindOfTrain.TabIndex = 5;
            // 
            // AdminFormbutton
            // 
            AdminFormbutton.BackColor = Color.FromArgb(91, 92, 194);
            AdminFormbutton.ForeColor = Color.White;
            AdminFormbutton.Location = new Point(583, 359);
            AdminFormbutton.Margin = new Padding(3, 4, 3, 4);
            AdminFormbutton.Name = "AdminFormbutton";
            AdminFormbutton.Size = new Size(217, 53);
            AdminFormbutton.TabIndex = 15;
            AdminFormbutton.Text = "Back To Admin form";
            AdminFormbutton.UseVisualStyleBackColor = false;
            AdminFormbutton.Click += AdminFormbutton_Click;
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.FromArgb(91, 92, 194);
            AddButton.ForeColor = Color.White;
            AddButton.Location = new Point(87, 359);
            AddButton.Margin = new Padding(3, 4, 3, 4);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(217, 53);
            AddButton.TabIndex = 14;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS Gothic", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(91, 92, 194);
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.Location = new Point(327, 65);
            label1.Name = "label1";
            label1.Size = new Size(249, 33);
            label1.TabIndex = 16;
            label1.Text = "Add New Train";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(893, 564);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // AddTrain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 562);
            Controls.Add(label1);
            Controls.Add(AdminFormbutton);
            Controls.Add(AddButton);
            Controls.Add(textBoxKindOfTrain);
            Controls.Add(textBoxNumberOfSeats);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddTrain";
            Text = "AddTrain";
            Load += AddTrain_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private TextBox textBoxNumberOfSeats;
        private TextBox textBox1;
        private TextBox textBoxKindOfTrain;
        private Button AdminFormbutton;
        private Button AddButton;
        private Label label1;
        private PictureBox pictureBox1;
    }
}