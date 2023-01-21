namespace Bonus_Project__Warehouse_Management
{
    partial class AddPhoneForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PhoneRam_txt = new System.Windows.Forms.ComboBox();
            this.PhoneStorage_txt = new System.Windows.Forms.ComboBox();
            this.PhoneDisplay_txt = new System.Windows.Forms.TextBox();
            this.PhoneCamera_txt = new System.Windows.Forms.TextBox();
            this.PhoneBattery_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PhoneLoadPhoto = new System.Windows.Forms.Button();
            this.PhonePictureBox = new System.Windows.Forms.PictureBox();
            this.AddPhone = new System.Windows.Forms.Button();
            this.CancelPhone = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhonePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bell MT", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(17, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Phone";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PhoneRam_txt);
            this.panel1.Controls.Add(this.PhoneStorage_txt);
            this.panel1.Controls.Add(this.PhoneDisplay_txt);
            this.panel1.Controls.Add(this.PhoneCamera_txt);
            this.panel1.Controls.Add(this.PhoneBattery_txt);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.PhoneLoadPhoto);
            this.panel1.Controls.Add(this.PhonePictureBox);
            this.panel1.Location = new System.Drawing.Point(24, 65);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 269);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // PhoneRam_txt
            // 
            this.PhoneRam_txt.FormattingEnabled = true;
            this.PhoneRam_txt.Items.AddRange(new object[] {
            "4GB",
            "8GB",
            "16GB",
            "32GB"});
            this.PhoneRam_txt.Location = new System.Drawing.Point(104, 106);
            this.PhoneRam_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PhoneRam_txt.Name = "PhoneRam_txt";
            this.PhoneRam_txt.Size = new System.Drawing.Size(108, 24);
            this.PhoneRam_txt.TabIndex = 13;
            this.PhoneRam_txt.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // PhoneStorage_txt
            // 
            this.PhoneStorage_txt.FormattingEnabled = true;
            this.PhoneStorage_txt.Items.AddRange(new object[] {
            "32GB",
            "64GB",
            "128GB",
            "256GB"});
            this.PhoneStorage_txt.Location = new System.Drawing.Point(104, 60);
            this.PhoneStorage_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PhoneStorage_txt.Name = "PhoneStorage_txt";
            this.PhoneStorage_txt.Size = new System.Drawing.Size(108, 24);
            this.PhoneStorage_txt.TabIndex = 12;
            this.PhoneStorage_txt.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // PhoneDisplay_txt
            // 
            this.PhoneDisplay_txt.Location = new System.Drawing.Point(104, 146);
            this.PhoneDisplay_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PhoneDisplay_txt.Name = "PhoneDisplay_txt";
            this.PhoneDisplay_txt.Size = new System.Drawing.Size(192, 22);
            this.PhoneDisplay_txt.TabIndex = 11;
            this.PhoneDisplay_txt.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // PhoneCamera_txt
            // 
            this.PhoneCamera_txt.Location = new System.Drawing.Point(104, 185);
            this.PhoneCamera_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PhoneCamera_txt.Name = "PhoneCamera_txt";
            this.PhoneCamera_txt.Size = new System.Drawing.Size(192, 22);
            this.PhoneCamera_txt.TabIndex = 10;
            this.PhoneCamera_txt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // PhoneBattery_txt
            // 
            this.PhoneBattery_txt.Location = new System.Drawing.Point(104, 21);
            this.PhoneBattery_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PhoneBattery_txt.Name = "PhoneBattery_txt";
            this.PhoneBattery_txt.Size = new System.Drawing.Size(192, 22);
            this.PhoneBattery_txt.TabIndex = 9;
            this.PhoneBattery_txt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(15, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Camera :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(15, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Display :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(15, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ram :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(15, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Storage :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(15, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Battery :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // PhoneLoadPhoto
            // 
            this.PhoneLoadPhoto.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneLoadPhoto.Location = new System.Drawing.Point(438, 222);
            this.PhoneLoadPhoto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PhoneLoadPhoto.Name = "PhoneLoadPhoto";
            this.PhoneLoadPhoto.Size = new System.Drawing.Size(199, 34);
            this.PhoneLoadPhoto.TabIndex = 4;
            this.PhoneLoadPhoto.Text = "Load Photo";
            this.PhoneLoadPhoto.UseVisualStyleBackColor = true;
            this.PhoneLoadPhoto.Click += new System.EventHandler(this.button3_Click);
            // 
            // PhonePictureBox
            // 
            this.PhonePictureBox.Location = new System.Drawing.Point(438, 21);
            this.PhonePictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PhonePictureBox.Name = "PhonePictureBox";
            this.PhonePictureBox.Size = new System.Drawing.Size(199, 185);
            this.PhonePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PhonePictureBox.TabIndex = 0;
            this.PhonePictureBox.TabStop = false;
            this.PhonePictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // AddPhone
            // 
            this.AddPhone.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPhone.Location = new System.Drawing.Point(24, 346);
            this.AddPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddPhone.Name = "AddPhone";
            this.AddPhone.Size = new System.Drawing.Size(654, 42);
            this.AddPhone.TabIndex = 2;
            this.AddPhone.Text = "Add Phone";
            this.AddPhone.UseVisualStyleBackColor = true;
            this.AddPhone.Click += new System.EventHandler(this.button1_Click);
            // 
            // CancelPhone
            // 
            this.CancelPhone.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelPhone.Location = new System.Drawing.Point(24, 393);
            this.CancelPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CancelPhone.Name = "CancelPhone";
            this.CancelPhone.Size = new System.Drawing.Size(654, 42);
            this.CancelPhone.TabIndex = 3;
            this.CancelPhone.Text = "BACK";
            this.CancelPhone.UseVisualStyleBackColor = true;
            this.CancelPhone.Click += new System.EventHandler(this.button2_Click);
            // 
            // ofd
            // 
            this.ofd.Filter = "text File | *.txt";
            // 
            // AddPhoneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(711, 446);
            this.Controls.Add(this.CancelPhone);
            this.Controls.Add(this.AddPhone);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddPhoneForm";
            this.Text = "Add Phone Form";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhonePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AddPhone;
        private System.Windows.Forms.ComboBox PhoneRam_txt;
        private System.Windows.Forms.ComboBox PhoneStorage_txt;
        private System.Windows.Forms.TextBox PhoneDisplay_txt;
        private System.Windows.Forms.TextBox PhoneCamera_txt;
        private System.Windows.Forms.TextBox PhoneBattery_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button PhoneLoadPhoto;
        private System.Windows.Forms.PictureBox PhonePictureBox;
        private System.Windows.Forms.Button CancelPhone;
        private System.Windows.Forms.OpenFileDialog ofd;
    }
}