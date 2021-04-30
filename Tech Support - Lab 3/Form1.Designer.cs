
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
            this.addBtn = new System.Windows.Forms.Button();
            this.modifyBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.productsListB = new System.Windows.Forms.ListBox();
            this.displayCurrentProducttxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // productsDataGrid
            // 
            this.productsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGrid.Location = new System.Drawing.Point(658, 43);
            this.productsDataGrid.MultiSelect = false;
            this.productsDataGrid.Name = "productsDataGrid";
            this.productsDataGrid.RowTemplate.Height = 25;
            this.productsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productsDataGrid.Size = new System.Drawing.Size(671, 289);
            this.productsDataGrid.TabIndex = 0;
            this.productsDataGrid.SelectionChanged += new System.EventHandler(this.productsDataGrid_SelectionChanged);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(21, 386);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(106, 35);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "&Add";
            this.addBtn.UseVisualStyleBackColor = true;
            // 
            // modifyBtn
            // 
            this.modifyBtn.Location = new System.Drawing.Point(151, 386);
            this.modifyBtn.Name = "modifyBtn";
            this.modifyBtn.Size = new System.Drawing.Size(103, 35);
            this.modifyBtn.TabIndex = 2;
            this.modifyBtn.Text = "&Modify";
            this.modifyBtn.UseVisualStyleBackColor = true;
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(282, 386);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(103, 35);
            this.removeBtn.TabIndex = 3;
            this.removeBtn.Text = "&Remove";
            this.removeBtn.UseVisualStyleBackColor = true;
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(671, 386);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(103, 35);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Text = "&Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // productsListB
            // 
            this.productsListB.FormattingEnabled = true;
            this.productsListB.ItemHeight = 20;
            this.productsListB.Location = new System.Drawing.Point(21, 43);
            this.productsListB.Name = "productsListB";
            this.productsListB.Size = new System.Drawing.Size(619, 284);
            this.productsListB.TabIndex = 5;
            // 
            // displayCurrentProducttxt
            // 
            this.displayCurrentProducttxt.Location = new System.Drawing.Point(931, 386);
            this.displayCurrentProducttxt.Name = "displayCurrentProducttxt";
            this.displayCurrentProducttxt.Size = new System.Drawing.Size(398, 27);
            this.displayCurrentProducttxt.TabIndex = 6;
            // 
            // TechnicalSupportFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1353, 453);
            this.Controls.Add(this.displayCurrentProducttxt);
            this.Controls.Add(this.productsListB);
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
        private System.Windows.Forms.ListBox productsListB;
        private System.Windows.Forms.TextBox displayCurrentProducttxt;
    }
}

