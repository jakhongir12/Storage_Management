namespace Bonus_Project__Warehouse_Management
{
    partial class TVFORM
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
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.YESNO = new System.Windows.Forms.ComboBox();
            this.TVSpeakers_txt = new System.Windows.Forms.TextBox();
            this.TVSize_txt = new System.Windows.Forms.TextBox();
            this.TVOS_txt = new System.Windows.Forms.TextBox();
            this.TVDisplay_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TVLoadPhoto = new System.Windows.Forms.Button();
            this.TVPictureBox = new System.Windows.Forms.PictureBox();
            this.AddTV = new System.Windows.Forms.Button();
            this.CancelTV = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TVPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bell MT", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(21, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 39);
            this.label7.TabIndex = 10;
            this.label7.Text = "Add TV";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.YESNO);
            this.panel1.Controls.Add(this.TVSpeakers_txt);
            this.panel1.Controls.Add(this.TVSize_txt);
            this.panel1.Controls.Add(this.TVOS_txt);
            this.panel1.Controls.Add(this.TVDisplay_txt);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TVLoadPhoto);
            this.panel1.Controls.Add(this.TVPictureBox);
            this.panel1.Location = new System.Drawing.Point(28, 59);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 269);
            this.panel1.TabIndex = 11;
            // 
            // YESNO
            // 
            this.YESNO.FormattingEnabled = true;
            this.YESNO.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.YESNO.Location = new System.Drawing.Point(132, 105);
            this.YESNO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.YESNO.Name = "YESNO";
            this.YESNO.Size = new System.Drawing.Size(88, 24);
            this.YESNO.TabIndex = 17;
            // 
            // TVSpeakers_txt
            // 
            this.TVSpeakers_txt.Location = new System.Drawing.Point(104, 64);
            this.TVSpeakers_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TVSpeakers_txt.Name = "TVSpeakers_txt";
            this.TVSpeakers_txt.Size = new System.Drawing.Size(192, 22);
            this.TVSpeakers_txt.TabIndex = 12;
            // 
            // TVSize_txt
            // 
            this.TVSize_txt.Location = new System.Drawing.Point(70, 146);
            this.TVSize_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TVSize_txt.Name = "TVSize_txt";
            this.TVSize_txt.Size = new System.Drawing.Size(192, 22);
            this.TVSize_txt.TabIndex = 11;
            this.TVSize_txt.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // TVOS_txt
            // 
            this.TVOS_txt.Location = new System.Drawing.Point(70, 185);
            this.TVOS_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TVOS_txt.Name = "TVOS_txt";
            this.TVOS_txt.Size = new System.Drawing.Size(192, 22);
            this.TVOS_txt.TabIndex = 10;
            // 
            // TVDisplay_txt
            // 
            this.TVDisplay_txt.Location = new System.Drawing.Point(104, 21);
            this.TVDisplay_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TVDisplay_txt.Name = "TVDisplay_txt";
            this.TVDisplay_txt.Size = new System.Drawing.Size(192, 22);
            this.TVDisplay_txt.TabIndex = 9;
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
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Size :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(15, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Voice Search :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(15, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Speakers :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(15, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Display :";
            // 
            // TVLoadPhoto
            // 
            this.TVLoadPhoto.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TVLoadPhoto.Location = new System.Drawing.Point(438, 222);
            this.TVLoadPhoto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TVLoadPhoto.Name = "TVLoadPhoto";
            this.TVLoadPhoto.Size = new System.Drawing.Size(199, 34);
            this.TVLoadPhoto.TabIndex = 4;
            this.TVLoadPhoto.Text = "Load Photo";
            this.TVLoadPhoto.UseVisualStyleBackColor = true;
            this.TVLoadPhoto.Click += new System.EventHandler(this.TVLoadPhoto_Click);
            // 
            // TVPictureBox
            // 
            this.TVPictureBox.Location = new System.Drawing.Point(438, 21);
            this.TVPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TVPictureBox.Name = "TVPictureBox";
            this.TVPictureBox.Size = new System.Drawing.Size(199, 185);
            this.TVPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TVPictureBox.TabIndex = 0;
            this.TVPictureBox.TabStop = false;
            // 
            // AddTV
            // 
            this.AddTV.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTV.Location = new System.Drawing.Point(28, 342);
            this.AddTV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddTV.Name = "AddTV";
            this.AddTV.Size = new System.Drawing.Size(654, 42);
            this.AddTV.TabIndex = 12;
            this.AddTV.Text = "Add TV";
            this.AddTV.UseVisualStyleBackColor = true;
            this.AddTV.Click += new System.EventHandler(this.AddTV_Click);
            // 
            // CancelTV
            // 
            this.CancelTV.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelTV.Location = new System.Drawing.Point(28, 395);
            this.CancelTV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CancelTV.Name = "CancelTV";
            this.CancelTV.Size = new System.Drawing.Size(654, 42);
            this.CancelTV.TabIndex = 13;
            this.CancelTV.Text = "BACK";
            this.CancelTV.UseVisualStyleBackColor = true;
            this.CancelTV.Click += new System.EventHandler(this.CancelTV_Click);
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // TVFORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(711, 451);
            this.Controls.Add(this.CancelTV);
            this.Controls.Add(this.AddTV);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TVFORM";
            this.Text = "Add Tv Form";
            this.Load += new System.EventHandler(this.TVFORM_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TVPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TVSize_txt;
        private System.Windows.Forms.TextBox TVOS_txt;
        private System.Windows.Forms.TextBox TVDisplay_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button TVLoadPhoto;
        private System.Windows.Forms.PictureBox TVPictureBox;
        private System.Windows.Forms.Button AddTV;
        private System.Windows.Forms.Button CancelTV;
        private System.Windows.Forms.TextBox TVSpeakers_txt;
        private System.Windows.Forms.ComboBox YESNO;
        private System.Windows.Forms.OpenFileDialog ofd;
    }
}