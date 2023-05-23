namespace TrainBookingSystem.User_Controls
{
    partial class RegisterTrip
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxFrom = new System.Windows.Forms.ComboBox();
            this.comboBoxTo = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonRegisterTrip = new System.Windows.Forms.Button();
            this.dataGridViewTripsWithSourceAndDistination = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTripsWithSourceAndDistination)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(92)))), ((int)(((byte)(194)))));
            this.panel1.Controls.Add(this.buttonRegisterTrip);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(977, 571);
            this.panel1.TabIndex = 0;
            // 
            // comboBoxFrom
            // 
            this.comboBoxFrom.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBoxFrom.FormattingEnabled = true;
            this.comboBoxFrom.Location = new System.Drawing.Point(21, 20);
            this.comboBoxFrom.Name = "comboBoxFrom";
            this.comboBoxFrom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxFrom.Size = new System.Drawing.Size(183, 31);
            this.comboBoxFrom.TabIndex = 0;
            this.comboBoxFrom.Text = "From";
            this.comboBoxFrom.SelectedIndexChanged += new System.EventHandler(this.comboBoxFrom_SelectedIndexChanged);
            // 
            // comboBoxTo
            // 
            this.comboBoxTo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBoxTo.FormattingEnabled = true;
            this.comboBoxTo.Location = new System.Drawing.Point(748, 20);
            this.comboBoxTo.Name = "comboBoxTo";
            this.comboBoxTo.Size = new System.Drawing.Size(183, 31);
            this.comboBoxTo.TabIndex = 0;
            this.comboBoxTo.Text = "To";
            this.comboBoxTo.SelectedIndexChanged += new System.EventHandler(this.comboBoxTo_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(92)))), ((int)(((byte)(194)))));
            this.panel3.Controls.Add(this.comboBoxTo);
            this.panel3.Controls.Add(this.comboBoxFrom);
            this.panel3.Location = new System.Drawing.Point(0, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(977, 70);
            this.panel3.TabIndex = 2;
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
            this.panel2.Location = new System.Drawing.Point(0, 528);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(977, 43);
            this.panel2.TabIndex = 1;
            // 
            // buttonRegisterTrip
            // 
            this.buttonRegisterTrip.BackColor = System.Drawing.Color.White;
            this.buttonRegisterTrip.FlatAppearance.BorderSize = 2;
            this.buttonRegisterTrip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegisterTrip.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRegisterTrip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(92)))), ((int)(((byte)(194)))));
            this.buttonRegisterTrip.Location = new System.Drawing.Point(368, 444);
            this.buttonRegisterTrip.Name = "buttonRegisterTrip";
            this.buttonRegisterTrip.Size = new System.Drawing.Size(209, 91);
            this.buttonRegisterTrip.TabIndex = 0;
            this.buttonRegisterTrip.Text = "Book";
            this.buttonRegisterTrip.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonRegisterTrip.UseVisualStyleBackColor = false;
            this.buttonRegisterTrip.Click += new System.EventHandler(this.buttonRegisterTrip_Click);
            // 
            // dataGridViewTripsWithSourceAndDistination
            // 
            this.dataGridViewTripsWithSourceAndDistination.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewTripsWithSourceAndDistination.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTripsWithSourceAndDistination.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTripsWithSourceAndDistination.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTripsWithSourceAndDistination.Location = new System.Drawing.Point(0, 79);
            this.dataGridViewTripsWithSourceAndDistination.Name = "dataGridViewTripsWithSourceAndDistination";
            this.dataGridViewTripsWithSourceAndDistination.RowHeadersWidth = 51;
            this.dataGridViewTripsWithSourceAndDistination.RowTemplate.Height = 29;
            this.dataGridViewTripsWithSourceAndDistination.Size = new System.Drawing.Size(977, 370);
            this.dataGridViewTripsWithSourceAndDistination.TabIndex = 3;
            // 
            // RegisterTrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dataGridViewTripsWithSourceAndDistination);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "RegisterTrip";
            this.Size = new System.Drawing.Size(977, 571);
            this.Load += new System.EventHandler(this.RegisterTrip_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTripsWithSourceAndDistination)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button buttonRegisterTrip;
        private ComboBox comboBoxFrom;
        private ComboBox comboBoxTo;
        private Panel panel3;
        private Label label1;
        private Label label2;
        private Panel panel2;
        private DataGridView dataGridViewTripsWithSourceAndDistination;
    }
}
