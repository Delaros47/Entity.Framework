namespace Entity.Framework
{
    partial class Form1
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.lblUpdateProductName = new System.Windows.Forms.Label();
            this.tbxUpdateStockAmount = new System.Windows.Forms.TextBox();
            this.tbxUpdateProductName = new System.Windows.Forms.TextBox();
            this.lblUpdateStockAmount = new System.Windows.Forms.Label();
            this.tbxUpdateUnitPrice = new System.Windows.Forms.TextBox();
            this.gbxUpdateProduct = new System.Windows.Forms.GroupBox();
            this.lblUpdateUnitPrice = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbxAddProduct = new System.Windows.Forms.GroupBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.tbxStockAmount = new System.Windows.Forms.TextBox();
            this.tbxProductName = new System.Windows.Forms.TextBox();
            this.lblStockAmount = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.tbxUnitPrice = new System.Windows.Forms.TextBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.gbxUpdateProduct.SuspendLayout();
            this.gbxAddProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(123, 161);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(183, 25);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Location = new System.Drawing.Point(123, 130);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(183, 25);
            this.btnUpdateProduct.TabIndex = 3;
            this.btnUpdateProduct.Text = "Update";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // lblUpdateProductName
            // 
            this.lblUpdateProductName.AutoSize = true;
            this.lblUpdateProductName.Location = new System.Drawing.Point(28, 42);
            this.lblUpdateProductName.Name = "lblUpdateProductName";
            this.lblUpdateProductName.Size = new System.Drawing.Size(78, 13);
            this.lblUpdateProductName.TabIndex = 1;
            this.lblUpdateProductName.Text = "Product Name:";
            // 
            // tbxUpdateStockAmount
            // 
            this.tbxUpdateStockAmount.BackColor = System.Drawing.Color.Fuchsia;
            this.tbxUpdateStockAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxUpdateStockAmount.ForeColor = System.Drawing.Color.White;
            this.tbxUpdateStockAmount.Location = new System.Drawing.Point(123, 91);
            this.tbxUpdateStockAmount.Name = "tbxUpdateStockAmount";
            this.tbxUpdateStockAmount.Size = new System.Drawing.Size(183, 22);
            this.tbxUpdateStockAmount.TabIndex = 2;
            // 
            // tbxUpdateProductName
            // 
            this.tbxUpdateProductName.BackColor = System.Drawing.Color.Fuchsia;
            this.tbxUpdateProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxUpdateProductName.ForeColor = System.Drawing.Color.White;
            this.tbxUpdateProductName.Location = new System.Drawing.Point(123, 39);
            this.tbxUpdateProductName.Name = "tbxUpdateProductName";
            this.tbxUpdateProductName.Size = new System.Drawing.Size(183, 22);
            this.tbxUpdateProductName.TabIndex = 0;
            // 
            // lblUpdateStockAmount
            // 
            this.lblUpdateStockAmount.AutoSize = true;
            this.lblUpdateStockAmount.Location = new System.Drawing.Point(28, 94);
            this.lblUpdateStockAmount.Name = "lblUpdateStockAmount";
            this.lblUpdateStockAmount.Size = new System.Drawing.Size(77, 13);
            this.lblUpdateStockAmount.TabIndex = 1;
            this.lblUpdateStockAmount.Text = "Stock Amount:";
            // 
            // tbxUpdateUnitPrice
            // 
            this.tbxUpdateUnitPrice.BackColor = System.Drawing.Color.Fuchsia;
            this.tbxUpdateUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxUpdateUnitPrice.ForeColor = System.Drawing.Color.White;
            this.tbxUpdateUnitPrice.Location = new System.Drawing.Point(123, 65);
            this.tbxUpdateUnitPrice.Name = "tbxUpdateUnitPrice";
            this.tbxUpdateUnitPrice.Size = new System.Drawing.Size(183, 22);
            this.tbxUpdateUnitPrice.TabIndex = 1;
            // 
            // gbxUpdateProduct
            // 
            this.gbxUpdateProduct.Controls.Add(this.btnDelete);
            this.gbxUpdateProduct.Controls.Add(this.btnUpdateProduct);
            this.gbxUpdateProduct.Controls.Add(this.lblUpdateProductName);
            this.gbxUpdateProduct.Controls.Add(this.tbxUpdateStockAmount);
            this.gbxUpdateProduct.Controls.Add(this.tbxUpdateProductName);
            this.gbxUpdateProduct.Controls.Add(this.lblUpdateStockAmount);
            this.gbxUpdateProduct.Controls.Add(this.lblUpdateUnitPrice);
            this.gbxUpdateProduct.Controls.Add(this.tbxUpdateUnitPrice);
            this.gbxUpdateProduct.Location = new System.Drawing.Point(432, 274);
            this.gbxUpdateProduct.Name = "gbxUpdateProduct";
            this.gbxUpdateProduct.Size = new System.Drawing.Size(343, 211);
            this.gbxUpdateProduct.TabIndex = 6;
            this.gbxUpdateProduct.TabStop = false;
            this.gbxUpdateProduct.Text = "Update a product";
            // 
            // lblUpdateUnitPrice
            // 
            this.lblUpdateUnitPrice.AutoSize = true;
            this.lblUpdateUnitPrice.Location = new System.Drawing.Point(28, 68);
            this.lblUpdateUnitPrice.Name = "lblUpdateUnitPrice";
            this.lblUpdateUnitPrice.Size = new System.Drawing.Size(56, 13);
            this.lblUpdateUnitPrice.TabIndex = 1;
            this.lblUpdateUnitPrice.Text = "Unit Price:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(123, 130);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(183, 25);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gbxAddProduct
            // 
            this.gbxAddProduct.Controls.Add(this.btnAdd);
            this.gbxAddProduct.Controls.Add(this.tbxStockAmount);
            this.gbxAddProduct.Controls.Add(this.tbxProductName);
            this.gbxAddProduct.Controls.Add(this.lblStockAmount);
            this.gbxAddProduct.Controls.Add(this.lblUnitPrice);
            this.gbxAddProduct.Controls.Add(this.tbxUnitPrice);
            this.gbxAddProduct.Location = new System.Drawing.Point(12, 274);
            this.gbxAddProduct.Name = "gbxAddProduct";
            this.gbxAddProduct.Size = new System.Drawing.Size(343, 211);
            this.gbxAddProduct.TabIndex = 5;
            this.gbxAddProduct.TabStop = false;
            this.gbxAddProduct.Text = "Add a product";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(429, 240);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(112, 13);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Search Product Name";
            // 
            // tbxStockAmount
            // 
            this.tbxStockAmount.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tbxStockAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxStockAmount.ForeColor = System.Drawing.Color.White;
            this.tbxStockAmount.Location = new System.Drawing.Point(123, 91);
            this.tbxStockAmount.Name = "tbxStockAmount";
            this.tbxStockAmount.Size = new System.Drawing.Size(183, 22);
            this.tbxStockAmount.TabIndex = 2;
            // 
            // tbxProductName
            // 
            this.tbxProductName.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tbxProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxProductName.ForeColor = System.Drawing.Color.White;
            this.tbxProductName.Location = new System.Drawing.Point(123, 39);
            this.tbxProductName.Name = "tbxProductName";
            this.tbxProductName.Size = new System.Drawing.Size(183, 22);
            this.tbxProductName.TabIndex = 0;
            // 
            // lblStockAmount
            // 
            this.lblStockAmount.AutoSize = true;
            this.lblStockAmount.Location = new System.Drawing.Point(28, 94);
            this.lblStockAmount.Name = "lblStockAmount";
            this.lblStockAmount.Size = new System.Drawing.Size(77, 13);
            this.lblStockAmount.TabIndex = 1;
            this.lblStockAmount.Text = "Stock Amount:";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(28, 68);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(56, 13);
            this.lblUnitPrice.TabIndex = 1;
            this.lblUnitPrice.Text = "Unit Price:";
            // 
            // tbxUnitPrice
            // 
            this.tbxUnitPrice.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tbxUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxUnitPrice.ForeColor = System.Drawing.Color.White;
            this.tbxUnitPrice.Location = new System.Drawing.Point(123, 65);
            this.tbxUnitPrice.Name = "tbxUnitPrice";
            this.tbxUnitPrice.Size = new System.Drawing.Size(183, 22);
            this.tbxUnitPrice.TabIndex = 1;
            // 
            // dgvProducts
            // 
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvProducts.Location = new System.Drawing.Point(0, 0);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(802, 219);
            this.dgvProducts.TabIndex = 4;
            this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellClick);
            // 
            // tbxSearch
            // 
            this.tbxSearch.BackColor = System.Drawing.Color.Red;
            this.tbxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSearch.ForeColor = System.Drawing.Color.White;
            this.tbxSearch.Location = new System.Drawing.Point(553, 237);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(222, 20);
            this.tbxSearch.TabIndex = 7;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 495);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.gbxUpdateProduct);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.gbxAddProduct);
            this.Controls.Add(this.dgvProducts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxUpdateProduct.ResumeLayout(false);
            this.gbxUpdateProduct.PerformLayout();
            this.gbxAddProduct.ResumeLayout(false);
            this.gbxAddProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.Label lblUpdateProductName;
        private System.Windows.Forms.TextBox tbxUpdateStockAmount;
        private System.Windows.Forms.TextBox tbxUpdateProductName;
        private System.Windows.Forms.Label lblUpdateStockAmount;
        private System.Windows.Forms.TextBox tbxUpdateUnitPrice;
        private System.Windows.Forms.GroupBox gbxUpdateProduct;
        private System.Windows.Forms.Label lblUpdateUnitPrice;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbxAddProduct;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox tbxStockAmount;
        private System.Windows.Forms.TextBox tbxProductName;
        private System.Windows.Forms.Label lblStockAmount;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.TextBox tbxUnitPrice;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.TextBox tbxSearch;
    }
}