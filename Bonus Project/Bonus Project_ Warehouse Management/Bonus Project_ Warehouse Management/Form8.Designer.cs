namespace Bonus_Project__Warehouse_Management
{
    partial class AllProductsForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ByID = new System.Windows.Forms.RadioButton();
            this.ByModel = new System.Windows.Forms.RadioButton();
            this.ByBrand = new System.Windows.Forms.RadioButton();
            this.Keyword_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AllProductType_txt = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TotalCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Count = new System.Windows.Forms.Label();
            this.AllProductsPictureBox = new System.Windows.Forms.PictureBox();
            this.DeleteProduct = new System.Windows.Forms.Button();
            this.SeeFullInformation = new System.Windows.Forms.Button();
            this.ProductQuantity_txt = new System.Windows.Forms.Label();
            this.ProductModel_txt = new System.Windows.Forms.Label();
            this.ProductBrand_txt = new System.Windows.Forms.Label();
            this.ProductID_txt = new System.Windows.Forms.Label();
            this.ProductType_txt = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Right = new System.Windows.Forms.Button();
            this.Left = new System.Windows.Forms.Button();
            this.LoadAllProduct = new System.Windows.Forms.Button();
            this.Exit_2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllProductsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ByID);
            this.panel1.Controls.Add(this.ByModel);
            this.panel1.Controls.Add(this.ByBrand);
            this.panel1.Controls.Add(this.Keyword_txt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.AllProductType_txt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Clear);
            this.panel1.Controls.Add(this.Search);
            this.panel1.Location = new System.Drawing.Point(31, 82);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(816, 121);
            this.panel1.TabIndex = 13;
            // 
            // ByID
            // 
            this.ByID.AutoSize = true;
            this.ByID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ByID.Location = new System.Drawing.Point(458, 74);
            this.ByID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ByID.Name = "ByID";
            this.ByID.Size = new System.Drawing.Size(62, 21);
            this.ByID.TabIndex = 25;
            this.ByID.TabStop = true;
            this.ByID.Text = "By ID";
            this.ByID.UseVisualStyleBackColor = true;
            // 
            // ByModel
            // 
            this.ByModel.AutoSize = true;
            this.ByModel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ByModel.Location = new System.Drawing.Point(228, 74);
            this.ByModel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ByModel.Name = "ByModel";
            this.ByModel.Size = new System.Drawing.Size(87, 21);
            this.ByModel.TabIndex = 24;
            this.ByModel.TabStop = true;
            this.ByModel.Text = "By Model";
            this.ByModel.UseVisualStyleBackColor = true;
            // 
            // ByBrand
            // 
            this.ByBrand.AutoSize = true;
            this.ByBrand.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ByBrand.Location = new System.Drawing.Point(20, 74);
            this.ByBrand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ByBrand.Name = "ByBrand";
            this.ByBrand.Size = new System.Drawing.Size(87, 21);
            this.ByBrand.TabIndex = 23;
            this.ByBrand.TabStop = true;
            this.ByBrand.Text = "By Brand";
            this.ByBrand.UseVisualStyleBackColor = true;
            // 
            // Keyword_txt
            // 
            this.Keyword_txt.Location = new System.Drawing.Point(106, 25);
            this.Keyword_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Keyword_txt.Name = "Keyword_txt";
            this.Keyword_txt.Size = new System.Drawing.Size(192, 22);
            this.Keyword_txt.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(17, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Keyword :";
            // 
            // AllProductType_txt
            // 
            this.AllProductType_txt.FormattingEnabled = true;
            this.AllProductType_txt.Items.AddRange(new object[] {
            "Phone",
            "Laptop",
            "Tv",
            "Headphones",
            "Console"});
            this.AllProductType_txt.Location = new System.Drawing.Point(404, 22);
            this.AllProductType_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AllProductType_txt.Name = "AllProductType_txt";
            this.AllProductType_txt.Size = new System.Drawing.Size(186, 24);
            this.AllProductType_txt.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(334, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Type :";
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(663, 66);
            this.Clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(140, 34);
            this.Clear.TabIndex = 18;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(663, 14);
            this.Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(140, 34);
            this.Search.TabIndex = 17;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TotalCount);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.Count);
            this.panel2.Controls.Add(this.AllProductsPictureBox);
            this.panel2.Controls.Add(this.DeleteProduct);
            this.panel2.Controls.Add(this.SeeFullInformation);
            this.panel2.Controls.Add(this.ProductQuantity_txt);
            this.panel2.Controls.Add(this.ProductModel_txt);
            this.panel2.Controls.Add(this.ProductBrand_txt);
            this.panel2.Controls.Add(this.ProductID_txt);
            this.panel2.Controls.Add(this.ProductType_txt);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.Right);
            this.panel2.Controls.Add(this.Left);
            this.panel2.Location = new System.Drawing.Point(31, 222);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(816, 385);
            this.panel2.TabIndex = 14;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // TotalCount
            // 
            this.TotalCount.AutoSize = true;
            this.TotalCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalCount.ForeColor = System.Drawing.Color.White;
            this.TotalCount.Location = new System.Drawing.Point(418, 12);
            this.TotalCount.Name = "TotalCount";
            this.TotalCount.Size = new System.Drawing.Size(49, 32);
            this.TotalCount.TabIndex = 41;
            this.TotalCount.Text = "20";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(344, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 32);
            this.label3.TabIndex = 40;
            this.label3.Text = "OF";
            // 
            // Count
            // 
            this.Count.AutoSize = true;
            this.Count.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Count.ForeColor = System.Drawing.Color.White;
            this.Count.Location = new System.Drawing.Point(296, 11);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(32, 32);
            this.Count.TabIndex = 39;
            this.Count.Text = "0";
            // 
            // AllProductsPictureBox
            // 
            this.AllProductsPictureBox.Location = new System.Drawing.Point(504, 83);
            this.AllProductsPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AllProductsPictureBox.Name = "AllProductsPictureBox";
            this.AllProductsPictureBox.Size = new System.Drawing.Size(268, 259);
            this.AllProductsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AllProductsPictureBox.TabIndex = 38;
            this.AllProductsPictureBox.TabStop = false;
            this.AllProductsPictureBox.Click += new System.EventHandler(this.AllProductsPictureBox_Click);
            // 
            // DeleteProduct
            // 
            this.DeleteProduct.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteProduct.Location = new System.Drawing.Point(28, 341);
            this.DeleteProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteProduct.Name = "DeleteProduct";
            this.DeleteProduct.Size = new System.Drawing.Size(381, 32);
            this.DeleteProduct.TabIndex = 37;
            this.DeleteProduct.Text = "Delete Product";
            this.DeleteProduct.UseVisualStyleBackColor = true;
            this.DeleteProduct.Click += new System.EventHandler(this.DeleteProduct_Click);
            // 
            // SeeFullInformation
            // 
            this.SeeFullInformation.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeeFullInformation.Location = new System.Drawing.Point(28, 295);
            this.SeeFullInformation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeeFullInformation.Name = "SeeFullInformation";
            this.SeeFullInformation.Size = new System.Drawing.Size(381, 32);
            this.SeeFullInformation.TabIndex = 17;
            this.SeeFullInformation.Text = "See Full Information";
            this.SeeFullInformation.UseVisualStyleBackColor = true;
            this.SeeFullInformation.Click += new System.EventHandler(this.SeeFullInformation_Click);
            // 
            // ProductQuantity_txt
            // 
            this.ProductQuantity_txt.AutoSize = true;
            this.ProductQuantity_txt.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductQuantity_txt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProductQuantity_txt.Location = new System.Drawing.Point(190, 257);
            this.ProductQuantity_txt.Name = "ProductQuantity_txt";
            this.ProductQuantity_txt.Size = new System.Drawing.Size(156, 20);
            this.ProductQuantity_txt.TabIndex = 36;
            this.ProductQuantity_txt.Text = "Product Quantity txt";
            // 
            // ProductModel_txt
            // 
            this.ProductModel_txt.AutoSize = true;
            this.ProductModel_txt.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductModel_txt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProductModel_txt.Location = new System.Drawing.Point(190, 214);
            this.ProductModel_txt.Name = "ProductModel_txt";
            this.ProductModel_txt.Size = new System.Drawing.Size(138, 20);
            this.ProductModel_txt.TabIndex = 35;
            this.ProductModel_txt.Text = "Product Model txt";
            // 
            // ProductBrand_txt
            // 
            this.ProductBrand_txt.AutoSize = true;
            this.ProductBrand_txt.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductBrand_txt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProductBrand_txt.Location = new System.Drawing.Point(190, 173);
            this.ProductBrand_txt.Name = "ProductBrand_txt";
            this.ProductBrand_txt.Size = new System.Drawing.Size(136, 20);
            this.ProductBrand_txt.TabIndex = 34;
            this.ProductBrand_txt.Text = "Product Brand txt";
            this.ProductBrand_txt.Click += new System.EventHandler(this.label12_Click);
            // 
            // ProductID_txt
            // 
            this.ProductID_txt.AutoSize = true;
            this.ProductID_txt.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductID_txt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProductID_txt.Location = new System.Drawing.Point(190, 129);
            this.ProductID_txt.Name = "ProductID_txt";
            this.ProductID_txt.Size = new System.Drawing.Size(113, 20);
            this.ProductID_txt.TabIndex = 33;
            this.ProductID_txt.Text = "Product ID txt";
            // 
            // ProductType_txt
            // 
            this.ProductType_txt.AutoSize = true;
            this.ProductType_txt.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductType_txt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProductType_txt.Location = new System.Drawing.Point(190, 83);
            this.ProductType_txt.Name = "ProductType_txt";
            this.ProductType_txt.Size = new System.Drawing.Size(131, 20);
            this.ProductType_txt.TabIndex = 32;
            this.ProductType_txt.Text = "Product Type txt";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(25, 257);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 20);
            this.label9.TabIndex = 31;
            this.label9.Text = "Product Quantity :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(25, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "Product ID :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(25, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "Product Brand :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(25, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Product Model :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(25, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Product Type :";
            // 
            // Right
            // 
            this.Right.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Right.Location = new System.Drawing.Point(736, 20);
            this.Right.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Right.Name = "Right";
            this.Right.Size = new System.Drawing.Size(54, 24);
            this.Right.TabIndex = 27;
            this.Right.Text = ">>";
            this.Right.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Right.UseVisualStyleBackColor = true;
            this.Right.Click += new System.EventHandler(this.Right_Click);
            // 
            // Left
            // 
            this.Left.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Left.Location = new System.Drawing.Point(20, 20);
            this.Left.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Left.Name = "Left";
            this.Left.Size = new System.Drawing.Size(54, 24);
            this.Left.TabIndex = 26;
            this.Left.Text = "<<";
            this.Left.UseVisualStyleBackColor = true;
            this.Left.Click += new System.EventHandler(this.Left_Click);
            // 
            // LoadAllProduct
            // 
            this.LoadAllProduct.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadAllProduct.Location = new System.Drawing.Point(648, 26);
            this.LoadAllProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoadAllProduct.Name = "LoadAllProduct";
            this.LoadAllProduct.Size = new System.Drawing.Size(199, 34);
            this.LoadAllProduct.TabIndex = 15;
            this.LoadAllProduct.Text = "Load All Products";
            this.LoadAllProduct.UseVisualStyleBackColor = true;
            this.LoadAllProduct.Click += new System.EventHandler(this.LoadAllProduct_Click);
            // 
            // Exit_2
            // 
            this.Exit_2.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_2.Location = new System.Drawing.Point(35, 619);
            this.Exit_2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Exit_2.Name = "Exit_2";
            this.Exit_2.Size = new System.Drawing.Size(812, 42);
            this.Exit_2.TabIndex = 16;
            this.Exit_2.Text = "Exit";
            this.Exit_2.UseVisualStyleBackColor = true;
            this.Exit_2.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bell MT", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(28, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(193, 39);
            this.label7.TabIndex = 12;
            this.label7.Text = "All Products";
            // 
            // AllProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(876, 670);
            this.Controls.Add(this.Exit_2);
            this.Controls.Add(this.LoadAllProduct);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AllProductsForm";
            this.Text = "All Products Form";
            this.Load += new System.EventHandler(this.AllProductsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllProductsPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button LoadAllProduct;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox AllProductType_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Keyword_txt;
        private System.Windows.Forms.RadioButton ByID;
        private System.Windows.Forms.RadioButton ByModel;
        private System.Windows.Forms.RadioButton ByBrand;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Right;
        private System.Windows.Forms.Button Left;
        private System.Windows.Forms.Label ProductModel_txt;
        private System.Windows.Forms.Label ProductBrand_txt;
        private System.Windows.Forms.Label ProductID_txt;
        private System.Windows.Forms.Label ProductType_txt;
        private System.Windows.Forms.Label ProductQuantity_txt;
        private System.Windows.Forms.Button Exit_2;
        private System.Windows.Forms.Button DeleteProduct;
        private System.Windows.Forms.Button SeeFullInformation;
        private System.Windows.Forms.PictureBox AllProductsPictureBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label TotalCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Count;
    }
}