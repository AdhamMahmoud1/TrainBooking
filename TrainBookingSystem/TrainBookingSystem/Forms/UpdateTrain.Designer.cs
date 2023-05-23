namespace TrainBookingSystem.Forms
{
    partial class UpdateTrain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateTrain));
            pictureBox1 = new PictureBox();
            AdminFormbutton = new Button();
            dataGridViewForTrains = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            textBoxKindOFTrain = new TextBox();
            textBoxNumOfSeats = new TextBox();
            UpdateButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewForTrains).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(897, 562);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // AdminFormbutton
            // 
            AdminFormbutton.BackColor = Color.FromArgb(91, 92, 194);
            AdminFormbutton.ForeColor = Color.White;
            AdminFormbutton.Location = new Point(526, 431);
            AdminFormbutton.Margin = new Padding(3, 4, 3, 4);
            AdminFormbutton.Name = "AdminFormbutton";
            AdminFormbutton.Size = new Size(217, 53);
            AdminFormbutton.TabIndex = 13;
            AdminFormbutton.Text = "Back To Admin form";
            AdminFormbutton.UseVisualStyleBackColor = false;
            AdminFormbutton.Click += AdminFormbutton_Click_1;
            // 
            // dataGridViewForTrains
            // 
            dataGridViewForTrains.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewForTrains.Location = new Point(204, 143);
            dataGridViewForTrains.Margin = new Padding(3, 4, 3, 4);
            dataGridViewForTrains.Name = "dataGridViewForTrains";
            dataGridViewForTrains.RowHeadersWidth = 51;
            dataGridViewForTrains.RowTemplate.Height = 25;
            dataGridViewForTrains.Size = new Size(429, 189);
            dataGridViewForTrains.TabIndex = 12;
            dataGridViewForTrains.SelectionChanged += dataGridViewForTrains_SelectionChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(526, 35);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 11;
            label2.Text = "Kind Of Train";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(121, 35);
            label1.Name = "label1";
            label1.Size = new Size(122, 20);
            label1.TabIndex = 10;
            label1.Text = "Number Of Seats";
            // 
            // textBoxKindOFTrain
            // 
            textBoxKindOFTrain.BackColor = Color.FromArgb(230, 231, 233);
            textBoxKindOFTrain.ForeColor = Color.Black;
            textBoxKindOFTrain.Location = new Point(526, 59);
            textBoxKindOFTrain.Margin = new Padding(3, 4, 3, 4);
            textBoxKindOFTrain.Name = "textBoxKindOFTrain";
            textBoxKindOFTrain.Size = new Size(217, 27);
            textBoxKindOFTrain.TabIndex = 9;
            // 
            // textBoxNumOfSeats
            // 
            textBoxNumOfSeats.BackColor = Color.FromArgb(230, 231, 233);
            textBoxNumOfSeats.Location = new Point(121, 59);
            textBoxNumOfSeats.Margin = new Padding(3, 4, 3, 4);
            textBoxNumOfSeats.Name = "textBoxNumOfSeats";
            textBoxNumOfSeats.Size = new Size(217, 27);
            textBoxNumOfSeats.TabIndex = 8;
            // 
            // UpdateButton
            // 
            UpdateButton.BackColor = Color.FromArgb(91, 92, 194);
            UpdateButton.ForeColor = Color.WhiteSmoke;
            UpdateButton.Location = new Point(121, 431);
            UpdateButton.Margin = new Padding(3, 4, 3, 4);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(217, 53);
            UpdateButton.TabIndex = 7;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = false;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // UpdateTrain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 562);
            Controls.Add(AdminFormbutton);
            Controls.Add(dataGridViewForTrains);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxKindOFTrain);
            Controls.Add(textBoxNumOfSeats);
            Controls.Add(UpdateButton);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "UpdateTrain";
            Text = "UpdateTrain";
            Load += UpdateTrain_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewForTrains).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button AdminFormbutton;
        private DataGridView dataGridViewForTrains;
        private Label label2;
        private Label label1;
        private TextBox textBoxKindOFTrain;
        private TextBox textBoxNumOfSeats;
        private Button UpdateButton;
    }
}