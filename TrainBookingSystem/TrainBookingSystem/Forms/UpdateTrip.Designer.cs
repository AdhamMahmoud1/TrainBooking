namespace TrainBookingSystem.Forms
{
    partial class UpdateTrip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateTrip));
            AdminFormbutton = new Button();
            dataGridViewForTrips = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            textBoxDest = new TextBox();
            textBoxSource = new TextBox();
            UpdateButton = new Button();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            textBoxTrainID = new TextBox();
            label4 = new Label();
            textBoxPrice = new TextBox();
            label5 = new Label();
            textBoxDate = new TextBox();
            label6 = new Label();
            textBoxArrivalTime = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewForTrips).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // AdminFormbutton
            // 
            AdminFormbutton.BackColor = Color.FromArgb(91, 92, 194);
            AdminFormbutton.ForeColor = Color.White;
            AdminFormbutton.Location = new Point(634, 496);
            AdminFormbutton.Margin = new Padding(3, 4, 3, 4);
            AdminFormbutton.Name = "AdminFormbutton";
            AdminFormbutton.Size = new Size(217, 53);
            AdminFormbutton.TabIndex = 21;
            AdminFormbutton.Text = "Back To Admin form";
            AdminFormbutton.UseVisualStyleBackColor = false;
            AdminFormbutton.Click += AdminFormbutton_Click;
            // 
            // dataGridViewForTrips
            // 
            dataGridViewForTrips.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewForTrips.Location = new Point(225, 289);
            dataGridViewForTrips.Margin = new Padding(3, 4, 3, 4);
            dataGridViewForTrips.Name = "dataGridViewForTrips";
            dataGridViewForTrips.RowHeadersWidth = 51;
            dataGridViewForTrips.RowTemplate.Height = 25;
            dataGridViewForTrips.Size = new Size(429, 189);
            dataGridViewForTrips.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(563, 9);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 19;
            label2.Text = "Destination";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(134, 9);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 18;
            label1.Text = "Source";
            // 
            // textBoxDest
            // 
            textBoxDest.BackColor = Color.FromArgb(230, 231, 233);
            textBoxDest.ForeColor = Color.Black;
            textBoxDest.Location = new Point(563, 33);
            textBoxDest.Margin = new Padding(3, 4, 3, 4);
            textBoxDest.Name = "textBoxDest";
            textBoxDest.Size = new Size(217, 27);
            textBoxDest.TabIndex = 17;
            // 
            // textBoxSource
            // 
            textBoxSource.BackColor = Color.FromArgb(230, 231, 233);
            textBoxSource.Location = new Point(134, 33);
            textBoxSource.Margin = new Padding(3, 4, 3, 4);
            textBoxSource.Name = "textBoxSource";
            textBoxSource.Size = new Size(217, 27);
            textBoxSource.TabIndex = 16;
            // 
            // UpdateButton
            // 
            UpdateButton.BackColor = Color.FromArgb(91, 92, 194);
            UpdateButton.ForeColor = Color.WhiteSmoke;
            UpdateButton.Location = new Point(29, 496);
            UpdateButton.Margin = new Padding(3, 4, 3, 4);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(217, 53);
            UpdateButton.TabIndex = 15;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = false;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(898, 564);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(134, 221);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 23;
            label3.Text = "TrainID";
            // 
            // textBoxTrainID
            // 
            textBoxTrainID.BackColor = Color.FromArgb(230, 231, 233);
            textBoxTrainID.Location = new Point(135, 245);
            textBoxTrainID.Margin = new Padding(3, 4, 3, 4);
            textBoxTrainID.Name = "textBoxTrainID";
            textBoxTrainID.Size = new Size(217, 27);
            textBoxTrainID.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(563, 221);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 25;
            label4.Text = "Price";
            // 
            // textBoxPrice
            // 
            textBoxPrice.BackColor = Color.FromArgb(230, 231, 233);
            textBoxPrice.ForeColor = Color.Black;
            textBoxPrice.Location = new Point(563, 245);
            textBoxPrice.Margin = new Padding(3, 4, 3, 4);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(217, 27);
            textBoxPrice.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(134, 117);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 27;
            label5.Text = "Date";
            // 
            // textBoxDate
            // 
            textBoxDate.BackColor = Color.FromArgb(230, 231, 233);
            textBoxDate.ForeColor = Color.Black;
            textBoxDate.Location = new Point(134, 141);
            textBoxDate.Margin = new Padding(3, 4, 3, 4);
            textBoxDate.Name = "textBoxDate";
            textBoxDate.Size = new Size(217, 27);
            textBoxDate.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Black;
            label6.Location = new Point(563, 117);
            label6.Name = "label6";
            label6.Size = new Size(89, 20);
            label6.TabIndex = 29;
            label6.Text = "Arrival Time";
            // 
            // textBoxArrivalTime
            // 
            textBoxArrivalTime.BackColor = Color.FromArgb(230, 231, 233);
            textBoxArrivalTime.ForeColor = Color.Black;
            textBoxArrivalTime.Location = new Point(563, 141);
            textBoxArrivalTime.Margin = new Padding(3, 4, 3, 4);
            textBoxArrivalTime.Name = "textBoxArrivalTime";
            textBoxArrivalTime.Size = new Size(217, 27);
            textBoxArrivalTime.TabIndex = 28;
            // 
            // UpdateTrip
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 562);
            Controls.Add(label6);
            Controls.Add(textBoxArrivalTime);
            Controls.Add(label5);
            Controls.Add(textBoxDate);
            Controls.Add(label4);
            Controls.Add(textBoxPrice);
            Controls.Add(label3);
            Controls.Add(textBoxTrainID);
            Controls.Add(AdminFormbutton);
            Controls.Add(dataGridViewForTrips);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxDest);
            Controls.Add(textBoxSource);
            Controls.Add(UpdateButton);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "UpdateTrip";
            Text = "UpdateTrip";
            Load += UpdateTrip_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewForTrips).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AdminFormbutton;
        private DataGridView dataGridViewForTrips;
        private Label label2;
        private Label label1;
        private TextBox textBoxDest;
        private TextBox textBoxSource;
        private Button UpdateButton;
        private PictureBox pictureBox1;
        private Label label3;
        private TextBox textBoxTrainID;
        private Label label4;
        private TextBox textBoxPrice;
        private Label label5;
        private TextBox textBoxDate;
        private Label label6;
        private TextBox textBoxArrivalTime;
    }
}