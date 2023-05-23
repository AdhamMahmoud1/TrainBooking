namespace TrainBookingSystem.Forms.Admin_Forms
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
            this.AdminFormbutton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.textBoxNumOfSeats = new System.Windows.Forms.TextBox();
            this.textBoxKindOFTrain = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewForTrains = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForTrains)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AdminFormbutton
            // 
            this.AdminFormbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(92)))), ((int)(((byte)(194)))));
            this.AdminFormbutton.ForeColor = System.Drawing.Color.White;
            this.AdminFormbutton.Location = new System.Drawing.Point(525, 431);
            this.AdminFormbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AdminFormbutton.Name = "AdminFormbutton";
            this.AdminFormbutton.Size = new System.Drawing.Size(217, 53);
            this.AdminFormbutton.TabIndex = 21;
            this.AdminFormbutton.Text = "Back To Admin form";
            this.AdminFormbutton.UseVisualStyleBackColor = false;
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(92)))), ((int)(((byte)(194)))));
            this.UpdateButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.UpdateButton.Location = new System.Drawing.Point(120, 431);
            this.UpdateButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(217, 53);
            this.UpdateButton.TabIndex = 15;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = false;
            // 
            // textBoxNumOfSeats
            // 
            this.textBoxNumOfSeats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxNumOfSeats.Location = new System.Drawing.Point(120, 59);
            this.textBoxNumOfSeats.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNumOfSeats.Name = "textBoxNumOfSeats";
            this.textBoxNumOfSeats.Size = new System.Drawing.Size(217, 27);
            this.textBoxNumOfSeats.TabIndex = 16;
            // 
            // textBoxKindOFTrain
            // 
            this.textBoxKindOFTrain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxKindOFTrain.ForeColor = System.Drawing.Color.Black;
            this.textBoxKindOFTrain.Location = new System.Drawing.Point(525, 59);
            this.textBoxKindOFTrain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxKindOFTrain.Name = "textBoxKindOFTrain";
            this.textBoxKindOFTrain.Size = new System.Drawing.Size(217, 27);
            this.textBoxKindOFTrain.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(120, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Number Of Seats";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(525, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Kind Of Train";
            // 
            // dataGridViewForTrains
            // 
            this.dataGridViewForTrains.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewForTrains.Location = new System.Drawing.Point(203, 143);
            this.dataGridViewForTrains.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewForTrains.Name = "dataGridViewForTrains";
            this.dataGridViewForTrains.RowHeadersWidth = 51;
            this.dataGridViewForTrains.RowTemplate.Height = 25;
            this.dataGridViewForTrains.Size = new System.Drawing.Size(429, 189);
            this.dataGridViewForTrains.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(897, 562);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // UpdateTrain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(896, 560);
            this.Controls.Add(this.AdminFormbutton);
            this.Controls.Add(this.dataGridViewForTrains);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxKindOFTrain);
            this.Controls.Add(this.textBoxNumOfSeats);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UpdateTrain";
            this.Text = "UpdateTrain";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForTrains)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button AdminFormbutton;
        private Button UpdateButton;
        private TextBox textBoxNumOfSeats;
        private TextBox textBoxKindOFTrain;
        private Label label1;
        private Label label2;
        private DataGridView dataGridViewForTrains;
        private PictureBox pictureBox1;
    }
}