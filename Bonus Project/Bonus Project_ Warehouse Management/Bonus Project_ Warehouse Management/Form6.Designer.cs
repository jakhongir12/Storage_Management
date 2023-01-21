namespace Bonus_Project__Warehouse_Management
{
    partial class AddHeadPhoneForm
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
            this.headphone_noisecancelling = new System.Windows.Forms.CheckBox();
            this.headphone_wireless = new System.Windows.Forms.CheckBox();
            this.HeadPhoneColor_txt = new System.Windows.Forms.ComboBox();
            this.HeadPhoneType_txt = new System.Windows.Forms.ComboBox();
            this.HeadPhoneLoudness_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.HeadPhoneLoadPhoto = new System.Windows.Forms.Button();
            this.HeadPhonePictureBox = new System.Windows.Forms.PictureBox();
            this.AddHeadPhone = new System.Windows.Forms.Button();
            this.CancelHeadPhone = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HeadPhonePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bell MT", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(21, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(263, 39);
            this.label7.TabIndex = 11;
            this.label7.Text = "Add Head Phone ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.headphone_noisecancelling);
            this.panel1.Controls.Add(this.headphone_wireless);
            this.panel1.Controls.Add(this.HeadPhoneColor_txt);
            this.panel1.Controls.Add(this.HeadPhoneType_txt);
            this.panel1.Controls.Add(this.HeadPhoneLoudness_txt);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.HeadPhoneLoadPhoto);
            this.panel1.Controls.Add(this.HeadPhonePictureBox);
            this.panel1.Location = new System.Drawing.Point(28, 66);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 269);
            this.panel1.TabIndex = 12;
            // 
            // headphone_noisecancelling
            // 
            this.headphone_noisecancelling.AutoSize = true;
            this.headphone_noisecancelling.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.headphone_noisecancelling.Location = new System.Drawing.Point(24, 203);
            this.headphone_noisecancelling.Name = "headphone_noisecancelling";
            this.headphone_noisecancelling.Size = new System.Drawing.Size(227, 21);
            this.headphone_noisecancelling.TabIndex = 18;
            this.headphone_noisecancelling.Text = "Headphone is Noise Cancelling";
            this.headphone_noisecancelling.UseVisualStyleBackColor = true;
            // 
            // headphone_wireless
            // 
            this.headphone_wireless.AutoSize = true;
            this.headphone_wireless.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.headphone_wireless.Location = new System.Drawing.Point(23, 162);
            this.headphone_wireless.Name = "headphone_wireless";
            this.headphone_wireless.Size = new System.Drawing.Size(176, 21);
            this.headphone_wireless.TabIndex = 17;
            this.headphone_wireless.Text = "Headphone is Wireless";
            this.headphone_wireless.UseVisualStyleBackColor = true;
            // 
            // HeadPhoneColor_txt
            // 
            this.HeadPhoneColor_txt.FormattingEnabled = true;
            this.HeadPhoneColor_txt.Items.AddRange(new object[] {
            "black",
            "blue",
            "white",
            "pink",
            "green",
            "red",
            "yellow"});
            this.HeadPhoneColor_txt.Location = new System.Drawing.Point(96, 110);
            this.HeadPhoneColor_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeadPhoneColor_txt.Name = "HeadPhoneColor_txt";
            this.HeadPhoneColor_txt.Size = new System.Drawing.Size(157, 24);
            this.HeadPhoneColor_txt.TabIndex = 16;
            // 
            // HeadPhoneType_txt
            // 
            this.HeadPhoneType_txt.FormattingEnabled = true;
            this.HeadPhoneType_txt.Items.AddRange(new object[] {
            "On-ear",
            "Over the ear"});
            this.HeadPhoneType_txt.Location = new System.Drawing.Point(170, 20);
            this.HeadPhoneType_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeadPhoneType_txt.Name = "HeadPhoneType_txt";
            this.HeadPhoneType_txt.Size = new System.Drawing.Size(186, 24);
            this.HeadPhoneType_txt.TabIndex = 15;
            // 
            // HeadPhoneLoudness_txt
            // 
            this.HeadPhoneLoudness_txt.Location = new System.Drawing.Point(104, 64);
            this.HeadPhoneLoudness_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeadPhoneLoudness_txt.Name = "HeadPhoneLoudness_txt";
            this.HeadPhoneLoudness_txt.Size = new System.Drawing.Size(192, 22);
            this.HeadPhoneLoudness_txt.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(20, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Colour :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(15, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Loudness :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(15, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Head Phone Type :";
            // 
            // HeadPhoneLoadPhoto
            // 
            this.HeadPhoneLoadPhoto.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadPhoneLoadPhoto.Location = new System.Drawing.Point(438, 222);
            this.HeadPhoneLoadPhoto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeadPhoneLoadPhoto.Name = "HeadPhoneLoadPhoto";
            this.HeadPhoneLoadPhoto.Size = new System.Drawing.Size(199, 34);
            this.HeadPhoneLoadPhoto.TabIndex = 4;
            this.HeadPhoneLoadPhoto.Text = "Load Photo";
            this.HeadPhoneLoadPhoto.UseVisualStyleBackColor = true;
            this.HeadPhoneLoadPhoto.Click += new System.EventHandler(this.HeadPhoneLoadPhoto_Click);
            // 
            // HeadPhonePictureBox
            // 
            this.HeadPhonePictureBox.Location = new System.Drawing.Point(438, 21);
            this.HeadPhonePictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeadPhonePictureBox.Name = "HeadPhonePictureBox";
            this.HeadPhonePictureBox.Size = new System.Drawing.Size(199, 185);
            this.HeadPhonePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HeadPhonePictureBox.TabIndex = 0;
            this.HeadPhonePictureBox.TabStop = false;
            // 
            // AddHeadPhone
            // 
            this.AddHeadPhone.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddHeadPhone.Location = new System.Drawing.Point(28, 347);
            this.AddHeadPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddHeadPhone.Name = "AddHeadPhone";
            this.AddHeadPhone.Size = new System.Drawing.Size(654, 42);
            this.AddHeadPhone.TabIndex = 13;
            this.AddHeadPhone.Text = "Add Head Phone";
            this.AddHeadPhone.UseVisualStyleBackColor = true;
            this.AddHeadPhone.Click += new System.EventHandler(this.AddHeadPhone_Click);
            // 
            // CancelHeadPhone
            // 
            this.CancelHeadPhone.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelHeadPhone.Location = new System.Drawing.Point(28, 399);
            this.CancelHeadPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CancelHeadPhone.Name = "CancelHeadPhone";
            this.CancelHeadPhone.Size = new System.Drawing.Size(654, 42);
            this.CancelHeadPhone.TabIndex = 15;
            this.CancelHeadPhone.Text = "BACK";
            this.CancelHeadPhone.UseVisualStyleBackColor = true;
            this.CancelHeadPhone.Click += new System.EventHandler(this.CancelHeadPhone_Click);
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // AddHeadPhoneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(711, 450);
            this.Controls.Add(this.CancelHeadPhone);
            this.Controls.Add(this.AddHeadPhone);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddHeadPhoneForm";
            this.Text = "Add Head Phone Form";
            this.Load += new System.EventHandler(this.AddHeadPhoneForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HeadPhonePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox HeadPhoneLoudness_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button HeadPhoneLoadPhoto;
        private System.Windows.Forms.PictureBox HeadPhonePictureBox;
        private System.Windows.Forms.Button AddHeadPhone;
        private System.Windows.Forms.ComboBox HeadPhoneType_txt;
        private System.Windows.Forms.Button CancelHeadPhone;
        private System.Windows.Forms.ComboBox HeadPhoneColor_txt;
        private System.Windows.Forms.CheckBox headphone_noisecancelling;
        private System.Windows.Forms.CheckBox headphone_wireless;
        private System.Windows.Forms.OpenFileDialog ofd;
    }
}