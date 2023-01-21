namespace Bonus_Project__Warehouse_Management
{
    partial class AddProductForm
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
            this.Type_txt = new System.Windows.Forms.ComboBox();
            this.Model_txt = new System.Windows.Forms.TextBox();
            this.Brand_txt = new System.Windows.Forms.TextBox();
            this.Quantity_txt = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddProduct = new System.Windows.Forms.Button();
            this.BackToMenu = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Quantity_txt)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bell MT", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(146, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Product To Storage";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Type_txt);
            this.panel1.Controls.Add(this.Model_txt);
            this.panel1.Controls.Add(this.Brand_txt);
            this.panel1.Controls.Add(this.Quantity_txt);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.AddProduct);
            this.panel1.Location = new System.Drawing.Point(34, 70);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(636, 206);
            this.panel1.TabIndex = 1;
            this.panel1.Tag = "";
            // 
            // Type_txt
            // 
            this.Type_txt.FormattingEnabled = true;
            this.Type_txt.Items.AddRange(new object[] {
            "Phone",
            "Laptop",
            "Tv",
            "Headphones",
            "Console"});
            this.Type_txt.Location = new System.Drawing.Point(76, 21);
            this.Type_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Type_txt.Name = "Type_txt";
            this.Type_txt.Size = new System.Drawing.Size(176, 24);
            this.Type_txt.TabIndex = 9;
            // 
            // Model_txt
            // 
            this.Model_txt.Location = new System.Drawing.Point(413, 84);
            this.Model_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Model_txt.Name = "Model_txt";
            this.Model_txt.Size = new System.Drawing.Size(176, 22);
            this.Model_txt.TabIndex = 8;
            // 
            // Brand_txt
            // 
            this.Brand_txt.Location = new System.Drawing.Point(76, 83);
            this.Brand_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Brand_txt.Name = "Brand_txt";
            this.Brand_txt.Size = new System.Drawing.Size(176, 22);
            this.Brand_txt.TabIndex = 7;
            // 
            // Quantity_txt
            // 
            this.Quantity_txt.Location = new System.Drawing.Point(432, 21);
            this.Quantity_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Quantity_txt.Name = "Quantity_txt";
            this.Quantity_txt.Size = new System.Drawing.Size(144, 22);
            this.Quantity_txt.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(343, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Model :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(9, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Brand :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(343, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Quantity :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type :";
            // 
            // AddProduct
            // 
            this.AddProduct.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProduct.Location = new System.Drawing.Point(12, 148);
            this.AddProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddProduct.Name = "AddProduct";
            this.AddProduct.Size = new System.Drawing.Size(609, 42);
            this.AddProduct.TabIndex = 0;
            this.AddProduct.Text = "Add Product";
            this.AddProduct.UseVisualStyleBackColor = true;
            this.AddProduct.Click += new System.EventHandler(this.AddProduct_Click);
            // 
            // BackToMenu
            // 
            this.BackToMenu.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackToMenu.Location = new System.Drawing.Point(46, 290);
            this.BackToMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackToMenu.Name = "BackToMenu";
            this.BackToMenu.Size = new System.Drawing.Size(609, 42);
            this.BackToMenu.TabIndex = 1;
            this.BackToMenu.Text = "Back To Menu";
            this.BackToMenu.UseVisualStyleBackColor = true;
            this.BackToMenu.Click += new System.EventHandler(this.BackToMenu_Click);
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(711, 350);
            this.Controls.Add(this.BackToMenu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddProductForm";
            this.Text = "Add Product Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Quantity_txt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox Type_txt;
        private System.Windows.Forms.TextBox Model_txt;
        private System.Windows.Forms.TextBox Brand_txt;
        private System.Windows.Forms.NumericUpDown Quantity_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddProduct;
        private System.Windows.Forms.Button BackToMenu;
        private System.Windows.Forms.Label label4;
    }
}