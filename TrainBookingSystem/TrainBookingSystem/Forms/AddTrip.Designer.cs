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

        private Button GetAddTripButton()
        {
            return AddTripButton;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent(Button addTripButton)
        {
            Label LoginInHeader;
            AddTripButton = new Button();
            textBoxNumOfSource = new TextBox();
            labelSource = new Label();
            textboxDestination = new TextBox();
            labelDestination = new Label();
            textBox1 = new TextBox();
            textBox4ArrivalDate = new TextBox();
            label4ArrivalDate = new Label();
            label1 = new Label();
            textBox2Date = new TextBox();
            textBox5TrainID = new TextBox();
            label5TrainID = new Label();
            textBox3Price = new TextBox();
            label2 = new Label();
            LoginInHeader = new Label();
            SuspendLayout();
            // 
            // LoginInHeader
            // 
            LoginInHeader.AutoSize = true;
            LoginInHeader.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            LoginInHeader.ForeColor = Color.FromArgb(91, 92, 194);
            LoginInHeader.Location = new Point(12, 9);
            LoginInHeader.Name = "LoginInHeader";
            LoginInHeader.Size = new Size(173, 31);
            LoginInHeader.TabIndex = 50;
            LoginInHeader.Text = "Add New Trip";
            LoginInHeader.TextAlign = ContentAlignment.TopCenter;
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
            AddTripButton.Location = new Point(487, 332);
            AddTripButton.Margin = new Padding(3, 2, 3, 2);
            AddTripButton.Name = "AddTripButton";
            AddTripButton.Size = new Size(262, 36);
            AddTripButton.TabIndex = 55;
            AddTripButton.Text = "AddTrip";
            AddTripButton.UseMnemonic = false;
            AddTripButton.UseVisualStyleBackColor = false;
            AddTripButton.Click += new EventHandler(AddTripButton_Click);
            // 
            // textBoxNumOfSource
            // 
            textBoxNumOfSource.BackColor = Color.FromArgb(230, 231, 233);
            textBoxNumOfSource.BorderStyle = BorderStyle.None;
            textBoxNumOfSource.Font = new Font("MS Reference Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNumOfSource.ForeColor = SystemColors.InfoText;
            textBoxNumOfSource.Location = new Point(12, 87);
            textBoxNumOfSource.Margin = new Padding(3, 2, 3, 2);
            textBoxNumOfSource.Multiline = true;
            textBoxNumOfSource.Name = "textBoxNumOfSource";
            textBoxNumOfSource.Size = new Size(262, 25);
            textBoxNumOfSource.TabIndex = 53;
            textBoxNumOfSource.TextChanged += textBoxNumOfSource_TextChanged;
            // 
            // labelSource
            // 
            labelSource.AutoSize = true;
            labelSource.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelSource.Location = new Point(12, 60);
            labelSource.Name = "labelSource";
            labelSource.Size = new Size(56, 20);
            labelSource.TabIndex = 51;
            labelSource.Text = "Source";
            labelSource.TextAlign = ContentAlignment.TopCenter;
            // 
            // textboxDestination
            // 
            textboxDestination.BackColor = Color.FromArgb(230, 231, 233);
            textboxDestination.BorderStyle = BorderStyle.None;
            textboxDestination.Font = new Font("MS Reference Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            textboxDestination.ForeColor = SystemColors.InfoText;
            textboxDestination.Location = new Point(496, 87);
            textboxDestination.Margin = new Padding(3, 2, 3, 2);
            textboxDestination.Multiline = true;
            textboxDestination.Name = "textboxDestination";
            textboxDestination.Size = new Size(262, 29);
            textboxDestination.TabIndex = 54;
            // 
            // labelDestination
            // 
            labelDestination.AutoSize = true;
            labelDestination.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelDestination.Location = new Point(496, 60);
            labelDestination.Name = "labelDestination";
            labelDestination.Size = new Size(90, 20);
            labelDestination.TabIndex = 52;
            labelDestination.Text = "Destination";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(230, 231, 233);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("MS Reference Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.InfoText;
            textBox1.Location = new Point(12, 167);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(262, 25);
            textBox1.TabIndex = 57;
            // 
            // textBox4ArrivalDate
            // 
            textBox4ArrivalDate.BackColor = Color.FromArgb(230, 231, 233);
            textBox4ArrivalDate.BorderStyle = BorderStyle.None;
            textBox4ArrivalDate.Font = new Font("MS Reference Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4ArrivalDate.ForeColor = SystemColors.InfoText;
            textBox4ArrivalDate.Location = new Point(496, 167);
            textBox4ArrivalDate.Margin = new Padding(3, 2, 3, 2);
            textBox4ArrivalDate.Multiline = true;
            textBox4ArrivalDate.Name = "textBox4ArrivalDate";
            textBox4ArrivalDate.Size = new Size(262, 25);
            textBox4ArrivalDate.TabIndex = 59;
            textBox4ArrivalDate.TextChanged += textBox2_TextChanged;
            // 
            // label4ArrivalDate
            // 
            label4ArrivalDate.AutoSize = true;
            label4ArrivalDate.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4ArrivalDate.Location = new Point(496, 140);
            label4ArrivalDate.Name = "label4ArrivalDate";
            label4ArrivalDate.Size = new Size(93, 20);
            label4ArrivalDate.TabIndex = 58;
            label4ArrivalDate.Text = "Arrival Date";
            label4ArrivalDate.TextAlign = ContentAlignment.TopCenter;
            label4ArrivalDate.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 145);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 56;
            label1.Text = "Date";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBox2Date
            // 
            textBox2Date.BackColor = Color.FromArgb(230, 231, 233);
            textBox2Date.BorderStyle = BorderStyle.None;
            textBox2Date.Font = new Font("MS Reference Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2Date.ForeColor = SystemColors.InfoText;
            textBox2Date.Location = new Point(12, 167);
            textBox2Date.Margin = new Padding(3, 2, 3, 2);
            textBox2Date.Multiline = true;
            textBox2Date.Name = "textBox2Date";
            textBox2Date.Size = new Size(262, 25);
            textBox2Date.TabIndex = 57;
            textBox2Date.TextChanged += textBox2Date_TextChanged;
            // 
            // textBox5TrainID
            // 
            textBox5TrainID.BackColor = Color.FromArgb(230, 231, 233);
            textBox5TrainID.BorderStyle = BorderStyle.None;
            textBox5TrainID.Font = new Font("MS Reference Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5TrainID.ForeColor = SystemColors.InfoText;
            textBox5TrainID.Location = new Point(12, 259);
            textBox5TrainID.Margin = new Padding(3, 2, 3, 2);
            textBox5TrainID.Multiline = true;
            textBox5TrainID.Name = "textBox5TrainID";
            textBox5TrainID.Size = new Size(262, 25);
            textBox5TrainID.TabIndex = 61;
            textBox5TrainID.TextChanged += textBox5TrainID_TextChanged;
            // 
            // label5TrainID
            // 
            label5TrainID.AutoSize = true;
            label5TrainID.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5TrainID.Location = new Point(12, 224);
            label5TrainID.Name = "label5TrainID";
            label5TrainID.Size = new Size(64, 20);
            label5TrainID.TabIndex = 60;
            label5TrainID.Text = "Train ID";
            label5TrainID.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBox3Price
            // 
            textBox3Price.BackColor = Color.FromArgb(230, 231, 233);
            textBox3Price.BorderStyle = BorderStyle.None;
            textBox3Price.Font = new Font("MS Reference Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3Price.ForeColor = SystemColors.InfoText;
            textBox3Price.Location = new Point(496, 259);
            textBox3Price.Margin = new Padding(3, 2, 3, 2);
            textBox3Price.Multiline = true;
            textBox3Price.Name = "textBox3Price";
            textBox3Price.Size = new Size(262, 25);
            textBox3Price.TabIndex = 63;
            textBox3Price.TextChanged += textBox3Price_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(496, 224);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 62;
            label2.Text = "Price";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // AddTrip
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox3Price);
            Controls.Add(label2);
            Controls.Add(textBox5TrainID);
            Controls.Add(label5TrainID);
            Controls.Add(textBox4ArrivalDate);
            Controls.Add(label4ArrivalDate);
            Controls.Add(textBox2Date);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(AddTripButton);
            Controls.Add(textBoxNumOfSource);
            Controls.Add(labelSource);
            Controls.Add(textboxDestination);
            Controls.Add(labelDestination);
            Controls.Add(LoginInHeader);
            Name = "AddTrip";
            Text = "AddTrip";
            Load += AddTrip_Load;
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion
        private Button AddTripButton;
        private TextBox textBoxNumOfSource;
        internal Label labelSource;
        private TextBox textboxDestination;
        private Label labelDestination;
        private TextBox textBox1;
        internal Label label3Date;
        private TextBox textBox4ArrivalDate;
        internal Label label4ArrivalDate;
        internal Label label1;
        private TextBox textBox2Date;
        private TextBox textBox5TrainID;
        internal Label label5TrainID;
        private TextBox textBox3Price;
        internal Label label2;
    }
}