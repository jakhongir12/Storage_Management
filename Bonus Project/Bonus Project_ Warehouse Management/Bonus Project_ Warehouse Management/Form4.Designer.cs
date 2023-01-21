namespace Bonus_Project__Warehouse_Management
{
    partial class AddLaptopForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LaptopMemory_txt = new System.Windows.Forms.ComboBox();
            this.LaptopProcessor_txt = new System.Windows.Forms.ComboBox();
            this.LaptopGraphicCatd_txt = new System.Windows.Forms.TextBox();
            this.LaptopOS_txt = new System.Windows.Forms.TextBox();
            this.LaptopBattery_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LaptopLoadPhoto = new System.Windows.Forms.Button();
            this.LaptopPictureBox = new System.Windows.Forms.PictureBox();
            this.AddLaptop = new System.Windows.Forms.Button();
            this.CancelLaptop = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LaptopPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(72, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Battery :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LaptopMemory_txt);
            this.panel1.Controls.Add(this.LaptopProcessor_txt);
            this.panel1.Controls.Add(this.LaptopGraphicCatd_txt);
            this.panel1.Controls.Add(this.LaptopOS_txt);
            this.panel1.Controls.Add(this.LaptopBattery_txt);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.LaptopLoadPhoto);
            this.panel1.Controls.Add(this.LaptopPictureBox);
            this.panel1.Location = new System.Drawing.Point(28, 61);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 269);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // LaptopMemory_txt
            // 
            this.LaptopMemory_txt.FormattingEnabled = true;
            this.LaptopMemory_txt.Items.AddRange(new object[] {
            "4GB",
            "8GB",
            "16GB ",
            "32GB"});
            this.LaptopMemory_txt.Location = new System.Drawing.Point(104, 106);
            this.LaptopMemory_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LaptopMemory_txt.Name = "LaptopMemory_txt";
            this.LaptopMemory_txt.Size = new System.Drawing.Size(108, 24);
            this.LaptopMemory_txt.TabIndex = 13;
            // 
            // LaptopProcessor_txt
            // 
            this.LaptopProcessor_txt.FormattingEnabled = true;
            this.LaptopProcessor_txt.Items.AddRange(new object[] {
            "Intel Core i7-12700H",
            "Intel Core i5-12500H",
            "AMD Ryzen 7 6800H",
            "AMD  Ryzen 7 6800HS",
            "Intel Core i7-10700K",
            "AMD Ryzen 9 5900HS",
            "AMD Ryzen 9 6900HX"});
            this.LaptopProcessor_txt.Location = new System.Drawing.Point(104, 60);
            this.LaptopProcessor_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LaptopProcessor_txt.Name = "LaptopProcessor_txt";
            this.LaptopProcessor_txt.Size = new System.Drawing.Size(108, 24);
            this.LaptopProcessor_txt.TabIndex = 12;
            // 
            // LaptopGraphicCatd_txt
            // 
            this.LaptopGraphicCatd_txt.Location = new System.Drawing.Point(137, 146);
            this.LaptopGraphicCatd_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LaptopGraphicCatd_txt.Name = "LaptopGraphicCatd_txt";
            this.LaptopGraphicCatd_txt.Size = new System.Drawing.Size(192, 22);
            this.LaptopGraphicCatd_txt.TabIndex = 11;
            // 
            // LaptopOS_txt
            // 
            this.LaptopOS_txt.Location = new System.Drawing.Point(70, 185);
            this.LaptopOS_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LaptopOS_txt.Name = "LaptopOS_txt";
            this.LaptopOS_txt.Size = new System.Drawing.Size(192, 22);
            this.LaptopOS_txt.TabIndex = 10;
            // 
            // LaptopBattery_txt
            // 
            this.LaptopBattery_txt.Location = new System.Drawing.Point(104, 21);
            this.LaptopBattery_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LaptopBattery_txt.Name = "LaptopBattery_txt";
            this.LaptopBattery_txt.Size = new System.Drawing.Size(192, 22);
            this.LaptopBattery_txt.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(15, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "OS :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(15, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Graphic Card :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(15, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Memory :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(15, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Processor :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(15, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Battery :";
            // 
            // LaptopLoadPhoto
            // 
            this.LaptopLoadPhoto.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaptopLoadPhoto.Location = new System.Drawing.Point(438, 222);
            this.LaptopLoadPhoto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LaptopLoadPhoto.Name = "LaptopLoadPhoto";
            this.LaptopLoadPhoto.Size = new System.Drawing.Size(199, 34);
            this.LaptopLoadPhoto.TabIndex = 4;
            this.LaptopLoadPhoto.Text = "Load Photo";
            this.LaptopLoadPhoto.UseVisualStyleBackColor = true;
            this.LaptopLoadPhoto.Click += new System.EventHandler(this.LaptopLoadPhoto_Click);
            // 
            // LaptopPictureBox
            // 
            this.LaptopPictureBox.Location = new System.Drawing.Point(438, 21);
            this.LaptopPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LaptopPictureBox.Name = "LaptopPictureBox";
            this.LaptopPictureBox.Size = new System.Drawing.Size(199, 185);
            this.LaptopPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LaptopPictureBox.TabIndex = 0;
            this.LaptopPictureBox.TabStop = false;
            // 
            // AddLaptop
            // 
            this.AddLaptop.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddLaptop.Location = new System.Drawing.Point(28, 343);
            this.AddLaptop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddLaptop.Name = "AddLaptop";
            this.AddLaptop.Size = new System.Drawing.Size(654, 42);
            this.AddLaptop.TabIndex = 7;
            this.AddLaptop.Text = "Add Laptop";
            this.AddLaptop.UseVisualStyleBackColor = true;
            this.AddLaptop.Click += new System.EventHandler(this.AddLaptop_Click);
            // 
            // CancelLaptop
            // 
            this.CancelLaptop.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelLaptop.Location = new System.Drawing.Point(28, 390);
            this.CancelLaptop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CancelLaptop.Name = "CancelLaptop";
            this.CancelLaptop.Size = new System.Drawing.Size(654, 42);
            this.CancelLaptop.TabIndex = 8;
            this.CancelLaptop.Text = "BACK";
            this.CancelLaptop.UseVisualStyleBackColor = true;
            this.CancelLaptop.Click += new System.EventHandler(this.CancelLaptop_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bell MT", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(21, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 39);
            this.label7.TabIndex = 9;
            this.label7.Text = "Add Laptop";
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // AddLaptopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(711, 443);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CancelLaptop);
            this.Controls.Add(this.AddLaptop);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddLaptopForm";
            this.Text = "Add Laptop Form";
            this.Load += new System.EventHandler(this.AddLaptopForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LaptopPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox LaptopMemory_txt;
        private System.Windows.Forms.ComboBox LaptopProcessor_txt;
        private System.Windows.Forms.TextBox LaptopGraphicCatd_txt;
        private System.Windows.Forms.TextBox LaptopOS_txt;
        private System.Windows.Forms.TextBox LaptopBattery_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LaptopLoadPhoto;
        private System.Windows.Forms.PictureBox LaptopPictureBox;
        private System.Windows.Forms.Button AddLaptop;
        private System.Windows.Forms.Button CancelLaptop;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.OpenFileDialog ofd;
    }
}