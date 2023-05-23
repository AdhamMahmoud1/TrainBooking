namespace TrainBookingSystem.Forms
{
    partial class MyTripsForm
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
            this.dataGridViewBookedTrips = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonCancelTrip = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookedTrips)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewBookedTrips
            // 
            this.dataGridViewBookedTrips.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewBookedTrips.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBookedTrips.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewBookedTrips.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBookedTrips.Location = new System.Drawing.Point(0, 79);
            this.dataGridViewBookedTrips.Name = "dataGridViewBookedTrips";
            this.dataGridViewBookedTrips.RowHeadersWidth = 51;
            this.dataGridViewBookedTrips.RowTemplate.Height = 29;
            this.dataGridViewBookedTrips.Size = new System.Drawing.Size(977, 370);
            this.dataGridViewBookedTrips.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(353, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Copyrights @ FCAI 2023";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(353, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Copyrights @ FCAI 2023";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 533);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(977, 43);
            this.panel2.TabIndex = 5;
            // 
            // buttonCancelTrip
            // 
            this.buttonCancelTrip.BackColor = System.Drawing.Color.White;
            this.buttonCancelTrip.FlatAppearance.BorderSize = 2;
            this.buttonCancelTrip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelTrip.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCancelTrip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(92)))), ((int)(((byte)(194)))));
            this.buttonCancelTrip.Location = new System.Drawing.Point(368, 444);
            this.buttonCancelTrip.Name = "buttonCancelTrip";
            this.buttonCancelTrip.Size = new System.Drawing.Size(209, 91);
            this.buttonCancelTrip.TabIndex = 0;
            this.buttonCancelTrip.Text = "Cancel";
            this.buttonCancelTrip.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonCancelTrip.UseVisualStyleBackColor = false;
            this.buttonCancelTrip.Click += new System.EventHandler(this.buttonCancelTrip_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(92)))), ((int)(((byte)(194)))));
            this.panel1.Controls.Add(this.buttonCancelTrip);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(977, 576);
            this.panel1.TabIndex = 4;
            // 
            // MyTripsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(977, 576);
            this.Controls.Add(this.dataGridViewBookedTrips);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MyTripsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "MyTrips";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookedTrips)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DataGridView dataGridViewBookedTrips;
        private Label label1;
        private Label label2;
        private Panel panel2;
        private Button buttonCancelTrip;
        private Panel panel1;
    }
}