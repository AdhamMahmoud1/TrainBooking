namespace TrainBookingSystem.Forms
{
    partial class AdminForm : Form
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
            Label LoginInHeader;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            button3 = new Button();
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            LoginInHeader = new Label();
            SuspendLayout();
            // 
            // LoginInHeader
            // 
            LoginInHeader.AutoSize = true;
            LoginInHeader.Font = new Font("MS Reference Sans Serif", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            LoginInHeader.ForeColor = Color.FromArgb(91, 92, 194);
            LoginInHeader.Location = new Point(21, 9);
            LoginInHeader.Name = "LoginInHeader";
            LoginInHeader.Size = new Size(365, 34);
            LoginInHeader.TabIndex = 39;
            LoginInHeader.Text = "Welocom to Admin Page";
            LoginInHeader.TextAlign = ContentAlignment.TopCenter;
            // 
            // button3
            // 
            button3.BackColor = Color.LightSlateGray;
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(21, 181);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(181, 36);
            button3.TabIndex = 49;
            button3.Text = "Add Trip";
            button3.UseMnemonic = false;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSlateGray;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(21, 78);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(181, 38);
            button1.TabIndex = 50;
            button1.Text = "Add Train";
            button1.UseMnemonic = false;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightSlateGray;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(21, 132);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(181, 36);
            button2.TabIndex = 51;
            button2.Text = "Update Train";
            button2.UseMnemonic = false;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.LightSlateGray;
            button4.BackgroundImageLayout = ImageLayout.None;
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(21, 241);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(181, 37);
            button4.TabIndex = 52;
            button4.Text = "Update Trip";
            button4.UseMnemonic = false;
            button4.UseVisualStyleBackColor = false;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(634, 421);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(LoginInHeader);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AdminForm";
            Text = "AdminForm";
            Load += AdminForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button3;
        private Button button1;
        private Button button2;
        private Button button4;
    }
}