namespace BikeStore.Forms
{
    partial class InsertProductForm
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
            this.btnSaveProduct = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblModelYear = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtSavePrice = new System.Windows.Forms.TextBox();
            this.txtSaveModelYear = new System.Windows.Forms.TextBox();
            this.txtSaveProductName = new System.Windows.Forms.TextBox();
            this.cmbSaveCategories = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbSaveBrands = new System.Windows.Forms.ComboBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSaveProduct
            // 
            this.btnSaveProduct.BackColor = System.Drawing.Color.LightGreen;
            this.btnSaveProduct.Location = new System.Drawing.Point(30, 220);
            this.btnSaveProduct.Name = "btnSaveProduct";
            this.btnSaveProduct.Size = new System.Drawing.Size(376, 23);
            this.btnSaveProduct.TabIndex = 18;
            this.btnSaveProduct.Text = "Save Product";
            this.btnSaveProduct.UseVisualStyleBackColor = false;
            this.btnSaveProduct.Click += new System.EventHandler(this.btnSaveProduct_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(27, 176);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(38, 16);
            this.lblPrice.TabIndex = 14;
            this.lblPrice.Text = "Price";
            // 
            // lblModelYear
            // 
            this.lblModelYear.AutoSize = true;
            this.lblModelYear.Location = new System.Drawing.Point(27, 136);
            this.lblModelYear.Name = "lblModelYear";
            this.lblModelYear.Size = new System.Drawing.Size(77, 16);
            this.lblModelYear.TabIndex = 15;
            this.lblModelYear.Text = "Model Year";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductName.Location = new System.Drawing.Point(27, 97);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(86, 15);
            this.lblProductName.TabIndex = 16;
            this.lblProductName.Text = "Product Name";
            // 
            // txtSavePrice
            // 
            this.txtSavePrice.Location = new System.Drawing.Point(126, 176);
            this.txtSavePrice.Name = "txtSavePrice";
            this.txtSavePrice.Size = new System.Drawing.Size(280, 22);
            this.txtSavePrice.TabIndex = 11;
            // 
            // txtSaveModelYear
            // 
            this.txtSaveModelYear.Location = new System.Drawing.Point(126, 136);
            this.txtSaveModelYear.Name = "txtSaveModelYear";
            this.txtSaveModelYear.Size = new System.Drawing.Size(280, 22);
            this.txtSaveModelYear.TabIndex = 12;
            // 
            // txtSaveProductName
            // 
            this.txtSaveProductName.Location = new System.Drawing.Point(126, 97);
            this.txtSaveProductName.Name = "txtSaveProductName";
            this.txtSaveProductName.Size = new System.Drawing.Size(280, 22);
            this.txtSaveProductName.TabIndex = 13;
            // 
            // cmbSaveCategories
            // 
            this.cmbSaveCategories.FormattingEnabled = true;
            this.cmbSaveCategories.Location = new System.Drawing.Point(126, 57);
            this.cmbSaveCategories.Name = "cmbSaveCategories";
            this.cmbSaveCategories.Size = new System.Drawing.Size(280, 24);
            this.cmbSaveCategories.TabIndex = 10;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(27, 57);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(62, 16);
            this.lblCategory.TabIndex = 9;
            this.lblCategory.Text = "Category";
            // 
            // cmbSaveBrands
            // 
            this.cmbSaveBrands.FormattingEnabled = true;
            this.cmbSaveBrands.Location = new System.Drawing.Point(126, 18);
            this.cmbSaveBrands.Name = "cmbSaveBrands";
            this.cmbSaveBrands.Size = new System.Drawing.Size(280, 24);
            this.cmbSaveBrands.TabIndex = 8;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(27, 18);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(43, 16);
            this.lblBrand.TabIndex = 7;
            this.lblBrand.Text = "Brand";
            // 
            // InsertProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 257);
            this.Controls.Add(this.btnSaveProduct);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblModelYear);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.txtSavePrice);
            this.Controls.Add(this.txtSaveModelYear);
            this.Controls.Add(this.txtSaveProductName);
            this.Controls.Add(this.cmbSaveCategories);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cmbSaveBrands);
            this.Controls.Add(this.lblBrand);
            this.Name = "InsertProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insert Product";
            this.Load += new System.EventHandler(this.InsertProductForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSaveProduct;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblModelYear;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtSavePrice;
        private System.Windows.Forms.TextBox txtSaveModelYear;
        private System.Windows.Forms.TextBox txtSaveProductName;
        private System.Windows.Forms.ComboBox cmbSaveCategories;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbSaveBrands;
        private System.Windows.Forms.Label lblBrand;
    }
}