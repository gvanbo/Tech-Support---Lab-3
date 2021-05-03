
namespace Tech_Support___Lab_3
{
    partial class TechnicalSupportFrm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.productsDataGrid = new System.Windows.Forms.DataGridView();
            this.ProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Version = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReleaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addBtn = new System.Windows.Forms.Button();
            this.modifyBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.displayCurrentProducttxt = new System.Windows.Forms.TextBox();
            this.lblSelectedProduct = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // productsDataGrid
            // 
            this.productsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductCode,
            this.nName,
            this.Version,
            this.ReleaseDate});
            this.productsDataGrid.Location = new System.Drawing.Point(21, 12);
            this.productsDataGrid.MultiSelect = false;
            this.productsDataGrid.Name = "productsDataGrid";
            this.productsDataGrid.RowTemplate.Height = 25;
            this.productsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productsDataGrid.Size = new System.Drawing.Size(671, 289);
            this.productsDataGrid.TabIndex = 0;
            this.productsDataGrid.SelectionChanged += new System.EventHandler(this.productsDataGrid_SelectionChanged);
            // 
            // ProductCode
            // 
            this.ProductCode.DataPropertyName = "ProductCode";
            this.ProductCode.HeaderText = "Product Code";
            this.ProductCode.Name = "ProductCode";
            // 
            // nName
            // 
            this.nName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nName.DataPropertyName = "Name";
            this.nName.HeaderText = "Name";
            this.nName.Name = "nName";
            this.nName.Width = 78;
            // 
            // Version
            // 
            this.Version.DataPropertyName = "Version";
            this.Version.HeaderText = "Version";
            this.Version.Name = "Version";
            // 
            // ReleaseDate
            // 
            this.ReleaseDate.DataPropertyName = "ReleaseDate";
            this.ReleaseDate.HeaderText = "Release Date";
            this.ReleaseDate.Name = "ReleaseDate";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(21, 395);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(106, 35);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "&Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // modifyBtn
            // 
            this.modifyBtn.Location = new System.Drawing.Point(145, 395);
            this.modifyBtn.Name = "modifyBtn";
            this.modifyBtn.Size = new System.Drawing.Size(103, 35);
            this.modifyBtn.TabIndex = 2;
            this.modifyBtn.Text = "&Modify";
            this.modifyBtn.UseVisualStyleBackColor = true;
            this.modifyBtn.Click += new System.EventHandler(this.modifyBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(263, 395);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(103, 35);
            this.removeBtn.TabIndex = 3;
            this.removeBtn.Text = "&Remove";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.DarkSalmon;
            this.exitBtn.Location = new System.Drawing.Point(589, 395);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(103, 35);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Text = "&Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // displayCurrentProducttxt
            // 
            this.displayCurrentProducttxt.Location = new System.Drawing.Point(159, 324);
            this.displayCurrentProducttxt.Name = "displayCurrentProducttxt";
            this.displayCurrentProducttxt.Size = new System.Drawing.Size(533, 27);
            this.displayCurrentProducttxt.TabIndex = 6;
            // 
            // lblSelectedProduct
            // 
            this.lblSelectedProduct.AutoSize = true;
            this.lblSelectedProduct.Location = new System.Drawing.Point(21, 328);
            this.lblSelectedProduct.Name = "lblSelectedProduct";
            this.lblSelectedProduct.Size = new System.Drawing.Size(132, 20);
            this.lblSelectedProduct.TabIndex = 7;
            this.lblSelectedProduct.Text = "Selected Product";
            // 
            // TechnicalSupportFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(712, 453);
            this.Controls.Add(this.lblSelectedProduct);
            this.Controls.Add(this.displayCurrentProducttxt);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.modifyBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.productsDataGrid);
            this.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "TechnicalSupportFrm";
            this.Text = "Technical Support";
            this.Load += new System.EventHandler(this.TechnicalSupportFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView productsDataGrid;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button modifyBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.TextBox displayCurrentProducttxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn nName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Version;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReleaseDate;
        private System.Windows.Forms.Label lblSelectedProduct;
    }
}

