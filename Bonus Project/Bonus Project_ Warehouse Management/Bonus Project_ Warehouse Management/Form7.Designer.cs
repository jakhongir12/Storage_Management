namespace Bonus_Project__Warehouse_Management
{
    partial class AddConsoleForm
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
            this.Console = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ConsoleRAM_txt = new System.Windows.Forms.ComboBox();
            this.ConsoleGPU_txt = new System.Windows.Forms.ComboBox();
            this.ConsoleCPU_txt = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ConsoleInternalStorage_txt = new System.Windows.Forms.ComboBox();
            this.ConsoleController_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ConsoleLoadPhoto = new System.Windows.Forms.Button();
            this.ConsolePictureBox = new System.Windows.Forms.PictureBox();
            this.AddConsole = new System.Windows.Forms.Button();
            this.CancelConsole = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsolePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Console
            // 
            this.Console.AutoSize = true;
            this.Console.Font = new System.Drawing.Font("Bell MT", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Console.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Console.Location = new System.Drawing.Point(26, 26);
            this.Console.Name = "Console";
            this.Console.Size = new System.Drawing.Size(195, 39);
            this.Console.TabIndex = 12;
            this.Console.Text = "Add Console";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ConsoleRAM_txt);
            this.panel1.Controls.Add(this.ConsoleGPU_txt);
            this.panel1.Controls.Add(this.ConsoleCPU_txt);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ConsoleInternalStorage_txt);
            this.panel1.Controls.Add(this.ConsoleController_txt);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ConsoleLoadPhoto);
            this.panel1.Controls.Add(this.ConsolePictureBox);
            this.panel1.Location = new System.Drawing.Point(33, 66);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 269);
            this.panel1.TabIndex = 13;
            // 
            // ConsoleRAM_txt
            // 
            this.ConsoleRAM_txt.FormattingEnabled = true;
            this.ConsoleRAM_txt.Items.AddRange(new object[] {
            "4GB",
            "8GB",
            "16GB",
            "32GB"});
            this.ConsoleRAM_txt.Location = new System.Drawing.Point(93, 183);
            this.ConsoleRAM_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConsoleRAM_txt.Name = "ConsoleRAM_txt";
            this.ConsoleRAM_txt.Size = new System.Drawing.Size(186, 24);
            this.ConsoleRAM_txt.TabIndex = 21;
            // 
            // ConsoleGPU_txt
            // 
            this.ConsoleGPU_txt.FormattingEnabled = true;
            this.ConsoleGPU_txt.Items.AddRange(new object[] {
            "Pre-GeForce",
            "GeForce 256 series",
            "GeForce2 series",
            "GeForce3 series",
            "GeForce4 series",
            "GeForce FX (5xxx) series",
            "GeForce 6 (6xxx) series",
            "GeForce 7 (7xxx) series",
            "GeForce 8 (8xxx) series",
            "GeForce 9 (9xxx) series",
            "GeForce 100 series",
            "GeForce 200 series",
            "GeForce 300 series",
            "GeForce 400 series",
            "GeForce 500 series"});
            this.ConsoleGPU_txt.Location = new System.Drawing.Point(93, 146);
            this.ConsoleGPU_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConsoleGPU_txt.Name = "ConsoleGPU_txt";
            this.ConsoleGPU_txt.Size = new System.Drawing.Size(186, 24);
            this.ConsoleGPU_txt.TabIndex = 20;
            // 
            // ConsoleCPU_txt
            // 
            this.ConsoleCPU_txt.FormattingEnabled = true;
            this.ConsoleCPU_txt.Items.AddRange(new object[] {
            "AArch64 rev 2 (aarch64)",
            "AArch64 rev 4 (aarch64)",
            "AMD 3015Ce",
            "AC8257V/WAB",
            "AMD A4 Micro-6400T APU",
            "AMD A4 PRO-7300B APU"});
            this.ConsoleCPU_txt.Location = new System.Drawing.Point(93, 111);
            this.ConsoleCPU_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConsoleCPU_txt.Name = "ConsoleCPU_txt";
            this.ConsoleCPU_txt.Size = new System.Drawing.Size(186, 24);
            this.ConsoleCPU_txt.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(20, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "RAM :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(20, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "GPU :";
            // 
            // ConsoleInternalStorage_txt
            // 
            this.ConsoleInternalStorage_txt.FormattingEnabled = true;
            this.ConsoleInternalStorage_txt.Items.AddRange(new object[] {
            "500GB",
            "1 TB"});
            this.ConsoleInternalStorage_txt.Location = new System.Drawing.Point(170, 20);
            this.ConsoleInternalStorage_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConsoleInternalStorage_txt.Name = "ConsoleInternalStorage_txt";
            this.ConsoleInternalStorage_txt.Size = new System.Drawing.Size(186, 24);
            this.ConsoleInternalStorage_txt.TabIndex = 15;
            // 
            // ConsoleController_txt
            // 
            this.ConsoleController_txt.Location = new System.Drawing.Point(104, 64);
            this.ConsoleController_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConsoleController_txt.Name = "ConsoleController_txt";
            this.ConsoleController_txt.Size = new System.Drawing.Size(192, 22);
            this.ConsoleController_txt.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(20, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "CPU :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(15, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Controller :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(15, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Internal Storage :";
            // 
            // ConsoleLoadPhoto
            // 
            this.ConsoleLoadPhoto.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsoleLoadPhoto.Location = new System.Drawing.Point(438, 222);
            this.ConsoleLoadPhoto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConsoleLoadPhoto.Name = "ConsoleLoadPhoto";
            this.ConsoleLoadPhoto.Size = new System.Drawing.Size(199, 34);
            this.ConsoleLoadPhoto.TabIndex = 4;
            this.ConsoleLoadPhoto.Text = "Load Photo";
            this.ConsoleLoadPhoto.UseVisualStyleBackColor = true;
            this.ConsoleLoadPhoto.Click += new System.EventHandler(this.ConsoleLoadPhoto_Click);
            // 
            // ConsolePictureBox
            // 
            this.ConsolePictureBox.Location = new System.Drawing.Point(438, 21);
            this.ConsolePictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConsolePictureBox.Name = "ConsolePictureBox";
            this.ConsolePictureBox.Size = new System.Drawing.Size(199, 185);
            this.ConsolePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ConsolePictureBox.TabIndex = 0;
            this.ConsolePictureBox.TabStop = false;
            // 
            // AddConsole
            // 
            this.AddConsole.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddConsole.Location = new System.Drawing.Point(33, 350);
            this.AddConsole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddConsole.Name = "AddConsole";
            this.AddConsole.Size = new System.Drawing.Size(654, 42);
            this.AddConsole.TabIndex = 14;
            this.AddConsole.Text = "Add Console";
            this.AddConsole.UseVisualStyleBackColor = true;
            this.AddConsole.Click += new System.EventHandler(this.AddConsole_Click);
            // 
            // CancelConsole
            // 
            this.CancelConsole.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelConsole.Location = new System.Drawing.Point(33, 407);
            this.CancelConsole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CancelConsole.Name = "CancelConsole";
            this.CancelConsole.Size = new System.Drawing.Size(654, 42);
            this.CancelConsole.TabIndex = 16;
            this.CancelConsole.Text = "BACK";
            this.CancelConsole.UseVisualStyleBackColor = true;
            this.CancelConsole.Click += new System.EventHandler(this.CancelConsole_Click);
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // AddConsoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(711, 466);
            this.Controls.Add(this.CancelConsole);
            this.Controls.Add(this.AddConsole);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Console);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddConsoleForm";
            this.Text = "AddConsoleForm";
            this.Load += new System.EventHandler(this.AddConsoleForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsolePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Console;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox ConsoleInternalStorage_txt;
        private System.Windows.Forms.TextBox ConsoleController_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ConsoleLoadPhoto;
        private System.Windows.Forms.PictureBox ConsolePictureBox;
        private System.Windows.Forms.Button AddConsole;
        private System.Windows.Forms.ComboBox ConsoleRAM_txt;
        private System.Windows.Forms.ComboBox ConsoleGPU_txt;
        private System.Windows.Forms.ComboBox ConsoleCPU_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CancelConsole;
        private System.Windows.Forms.OpenFileDialog ofd;
    }
}