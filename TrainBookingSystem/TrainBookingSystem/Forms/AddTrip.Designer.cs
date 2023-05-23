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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTrip));
            pictureBox1 = new PictureBox();
            LoginInHeader = new Label();
            AdminFormbutton = new Button();
            AddTripButton = new Button();
            textBoxDest = new TextBox();
            textBoxSource = new TextBox();
            labelDestination = new Label();
            labelSource = new Label();
            textboxDate = new TextBox();
            labelDate = new Label();
            textBoxTrainID = new TextBox();
            labelTrainID = new Label();
            textBoxPrice = new TextBox();
            labelPrice = new Label();
            textBoxArrival = new TextBox();
            labelArrivalTime = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(-1, 2);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(784, 417);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // LoginInHeader
            // 
            LoginInHeader.AutoSize = true;
            LoginInHeader.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            LoginInHeader.ForeColor = Color.FromArgb(91, 92, 194);
            LoginInHeader.Location = new Point(10, 7);
            LoginInHeader.Name = "LoginInHeader";
            LoginInHeader.Size = new Size(179, 31);
            LoginInHeader.TabIndex = 50;
            LoginInHeader.Text = "Add New Trip";
            LoginInHeader.TextAlign = ContentAlignment.TopCenter;
            // 
            // AdminFormbutton
            // 
            AdminFormbutton.BackColor = Color.FromArgb(91, 92, 194);
            AdminFormbutton.BackgroundImageLayout = ImageLayout.None;
            AdminFormbutton.Cursor = Cursors.Hand;
            AdminFormbutton.FlatAppearance.BorderSize = 0;
            AdminFormbutton.FlatStyle = FlatStyle.Flat;
            AdminFormbutton.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            AdminFormbutton.ForeColor = Color.White;
            AdminFormbutton.Location = new Point(531, 356);
            AdminFormbutton.Margin = new Padding(3, 2, 3, 2);
            AdminFormbutton.Name = "AdminFormbutton";
            AdminFormbutton.Size = new Size(229, 27);
            AdminFormbutton.TabIndex = 55;
            AdminFormbutton.Text = "Back To Admin form";
            AdminFormbutton.UseMnemonic = false;
            AdminFormbutton.UseVisualStyleBackColor = false;
            AdminFormbutton.Click += AdminFormbutton_Click;
            // 
            // AddTripButton
            // 
            AddTripButton.BackColor = Color.FromArgb(91, 92, 194);
            AddTripButton.BackgroundImageLayout = ImageLayout.None;
            AddTripButton.Cursor = Cursors.Hand;
            AddTripButton.FlatAppearance.BorderSize = 0;
            AddTripButton.FlatStyle = FlatStyle.Flat;
            AddTripButton.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            AddTripButton.ForeColor = Color.White;
            AddTripButton.Location = new Point(20, 356);
            AddTripButton.Margin = new Padding(3, 2, 3, 2);
            AddTripButton.Name = "AddTripButton";
            AddTripButton.Size = new Size(229, 27);
            AddTripButton.TabIndex = 55;
            AddTripButton.Text = "Add Trip";
            AddTripButton.UseMnemonic = false;
            AddTripButton.UseVisualStyleBackColor = false;
            AddTripButton.Click += AddTripButton_Click;
            // 
            // textBoxDest
            // 
            textBoxDest.BackColor = Color.FromArgb(230, 231, 233);
            textBoxDest.BorderStyle = BorderStyle.None;
            textBoxDest.Font = new Font("MS Reference Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDest.ForeColor = SystemColors.InfoText;
            textBoxDest.Location = new Point(434, 65);
            textBoxDest.Margin = new Padding(3, 2, 3, 2);
            textBoxDest.Multiline = true;
            textBoxDest.Name = "textBoxDest";
            textBoxDest.Size = new Size(229, 22);
            textBoxDest.TabIndex = 54;
            // 
            // textBoxSource
            // 
            textBoxSource.BackColor = Color.FromArgb(230, 231, 233);
            textBoxSource.BorderStyle = BorderStyle.None;
            textBoxSource.Font = new Font("MS Reference Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSource.ForeColor = SystemColors.InfoText;
            textBoxSource.Location = new Point(10, 65);
            textBoxSource.Margin = new Padding(3, 2, 3, 2);
            textBoxSource.Multiline = true;
            textBoxSource.Name = "textBoxSource";
            textBoxSource.Size = new Size(229, 19);
            textBoxSource.TabIndex = 53;
            // 
            // labelDestination
            // 
            labelDestination.AutoSize = true;
            labelDestination.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelDestination.Location = new Point(434, 45);
            labelDestination.Name = "labelDestination";
            labelDestination.Size = new Size(90, 20);
            labelDestination.TabIndex = 52;
            labelDestination.Text = "Destination";
            // 
            // labelSource
            // 
            labelSource.AutoSize = true;
            labelSource.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelSource.Location = new Point(10, 45);
            labelSource.Name = "labelSource";
            labelSource.Size = new Size(56, 20);
            labelSource.TabIndex = 51;
            labelSource.Text = "Source";
            labelSource.TextAlign = ContentAlignment.TopCenter;
            // 
            // textboxDate
            // 
            textboxDate.BackColor = Color.FromArgb(230, 231, 233);
            textboxDate.BorderStyle = BorderStyle.None;
            textboxDate.Font = new Font("MS Reference Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            textboxDate.ForeColor = SystemColors.InfoText;
            textboxDate.Location = new Point(10, 130);
            textboxDate.Margin = new Padding(3, 2, 3, 2);
            textboxDate.Multiline = true;
            textboxDate.Name = "textboxDate";
            textboxDate.Size = new Size(262, 29);
            textboxDate.TabIndex = 57;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelDate.Location = new Point(10, 110);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(42, 20);
            labelDate.TabIndex = 56;
            labelDate.Text = "Date";
            // 
            // textBoxTrainID
            // 
            textBoxTrainID.BackColor = Color.FromArgb(230, 231, 233);
            textBoxTrainID.BorderStyle = BorderStyle.None;
            textBoxTrainID.Font = new Font("MS Reference Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTrainID.ForeColor = SystemColors.InfoText;
            textBoxTrainID.Location = new Point(10, 218);
            textBoxTrainID.Margin = new Padding(3, 2, 3, 2);
            textBoxTrainID.Multiline = true;
            textBoxTrainID.Name = "textBoxTrainID";
            textBoxTrainID.Size = new Size(262, 25);
            textBoxTrainID.TabIndex = 64;
            // 
            // labelTrainID
            // 
            labelTrainID.AutoSize = true;
            labelTrainID.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelTrainID.Location = new Point(10, 196);
            labelTrainID.Name = "labelTrainID";
            labelTrainID.Size = new Size(64, 20);
            labelTrainID.TabIndex = 63;
            labelTrainID.Text = "Train ID";
            labelTrainID.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBoxPrice
            // 
            textBoxPrice.BackColor = Color.FromArgb(230, 231, 233);
            textBoxPrice.BorderStyle = BorderStyle.None;
            textBoxPrice.Font = new Font("MS Reference Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPrice.ForeColor = SystemColors.InfoText;
            textBoxPrice.Location = new Point(434, 218);
            textBoxPrice.Margin = new Padding(3, 2, 3, 2);
            textBoxPrice.Multiline = true;
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(262, 25);
            textBoxPrice.TabIndex = 68;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelPrice.Location = new Point(434, 196);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(43, 20);
            labelPrice.TabIndex = 67;
            labelPrice.Text = "Price";
            labelPrice.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBoxArrival
            // 
            textBoxArrival.BackColor = Color.FromArgb(230, 231, 233);
            textBoxArrival.BorderStyle = BorderStyle.None;
            textBoxArrival.Font = new Font("MS Reference Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxArrival.ForeColor = SystemColors.InfoText;
            textBoxArrival.Location = new Point(434, 130);
            textBoxArrival.Margin = new Padding(3, 2, 3, 2);
            textBoxArrival.Multiline = true;
            textBoxArrival.Name = "textBoxArrival";
            textBoxArrival.Size = new Size(262, 29);
            textBoxArrival.TabIndex = 66;
            // 
            // labelArrivalTime
            // 
            labelArrivalTime.AutoSize = true;
            labelArrivalTime.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelArrivalTime.Location = new Point(434, 110);
            labelArrivalTime.Name = "labelArrivalTime";
            labelArrivalTime.Size = new Size(93, 20);
            labelArrivalTime.TabIndex = 65;
            labelArrivalTime.Text = "Arrival Date";
            // 
            // AddTrip
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(783, 422);
            Controls.Add(textBoxPrice);
            Controls.Add(labelPrice);
            Controls.Add(textBoxArrival);
            Controls.Add(labelArrivalTime);
            Controls.Add(textBoxTrainID);
            Controls.Add(labelTrainID);
            Controls.Add(textboxDate);
            Controls.Add(labelDate);
            Controls.Add(LoginInHeader);
            Controls.Add(AdminFormbutton);
            Controls.Add(AddTripButton);
            Controls.Add(textBoxDest);
            Controls.Add(textBoxSource);
            Controls.Add(labelDestination);
            Controls.Add(labelSource);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddTrip";
            Text = "AddTrip";
            Load += AddTrip_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label LoginInHeader;
        private Button AdminFormbutton;
        private Button AddTripButton;
        private TextBox textBoxDest;
        private TextBox textBoxSource;
        private Label labelDestination;
        private Label labelSource;
        private TextBox textboxDate;
        private Label labelDate;
        private TextBox textBoxTrainID;
        internal Label labelTrainID;
        private TextBox textBoxPrice;
        internal Label labelPrice;
        private TextBox textBoxArrival;
        private Label labelArrivalTime;
    }
}