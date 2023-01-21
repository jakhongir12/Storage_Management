namespace Bonus_Project__Warehouse_Management
{
    partial class MenuForm
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
            this.SeeAllProducts = new System.Windows.Forms.Button();
            this.Exit_1 = new System.Windows.Forms.Button();
            this.AddNewProduct = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bell MT", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "My Storage Management";
            // 
            // SeeAllProducts
            // 
            this.SeeAllProducts.BackColor = System.Drawing.Color.Black;
            this.SeeAllProducts.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SeeAllProducts.FlatAppearance.BorderSize = 0;
            this.SeeAllProducts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.SeeAllProducts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.SeeAllProducts.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeeAllProducts.ForeColor = System.Drawing.Color.Transparent;
            this.SeeAllProducts.Location = new System.Drawing.Point(11, 177);
            this.SeeAllProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeeAllProducts.Name = "SeeAllProducts";
            this.SeeAllProducts.Size = new System.Drawing.Size(699, 52);
            this.SeeAllProducts.TabIndex = 2;
            this.SeeAllProducts.Text = "See All Products";
            this.SeeAllProducts.UseVisualStyleBackColor = false;
            this.SeeAllProducts.Click += new System.EventHandler(this.button2_Click);
            // 
            // Exit_1
            // 
            this.Exit_1.BackColor = System.Drawing.Color.Black;
            this.Exit_1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Exit_1.FlatAppearance.BorderSize = 0;
            this.Exit_1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Exit_1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Exit_1.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_1.ForeColor = System.Drawing.Color.Transparent;
            this.Exit_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Exit_1.Location = new System.Drawing.Point(11, 226);
            this.Exit_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Exit_1.Name = "Exit_1";
            this.Exit_1.Size = new System.Drawing.Size(699, 52);
            this.Exit_1.TabIndex = 3;
            this.Exit_1.Text = "Exit";
            this.Exit_1.UseVisualStyleBackColor = false;
            this.Exit_1.Click += new System.EventHandler(this.Exit_1_Click);
            // 
            // AddNewProduct
            // 
            this.AddNewProduct.BackColor = System.Drawing.Color.Black;
            this.AddNewProduct.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AddNewProduct.FlatAppearance.BorderSize = 0;
            this.AddNewProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.AddNewProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.AddNewProduct.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewProduct.ForeColor = System.Drawing.Color.Transparent;
            this.AddNewProduct.Location = new System.Drawing.Point(11, 130);
            this.AddNewProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddNewProduct.Name = "AddNewProduct";
            this.AddNewProduct.Size = new System.Drawing.Size(699, 52);
            this.AddNewProduct.TabIndex = 1;
            this.AddNewProduct.Text = "Add New Product";
            this.AddNewProduct.UseVisualStyleBackColor = false;
            this.AddNewProduct.Click += new System.EventHandler(this.AddNewProduct_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bell MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(250, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "Project by Tiger1";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(720, 360);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Exit_1);
            this.Controls.Add(this.SeeAllProducts);
            this.Controls.Add(this.AddNewProduct);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MenuForm";
            this.Text = "Menu Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddNewProduct;
        private System.Windows.Forms.Button SeeAllProducts;
        private System.Windows.Forms.Button Exit_1;
        private System.Windows.Forms.Label label2;
    }
}

