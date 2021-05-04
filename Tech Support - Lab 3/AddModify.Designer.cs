
namespace Tech_Support___Lab_3
{
    partial class AddModify
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
            this.productcodeLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.versionLbl = new System.Windows.Forms.Label();
            this.releaseDateLbl = new System.Windows.Forms.Label();
            this.productCodeTxt = new System.Windows.Forms.TextBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.versionTxt = new System.Windows.Forms.TextBox();
            this.releaseDateTxt = new System.Windows.Forms.TextBox();
            this.OKBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // productcodeLbl
            // 
            this.productcodeLbl.AutoSize = true;
            this.productcodeLbl.Location = new System.Drawing.Point(23, 40);
            this.productcodeLbl.Name = "productcodeLbl";
            this.productcodeLbl.Size = new System.Drawing.Size(83, 15);
            this.productcodeLbl.TabIndex = 0;
            this.productcodeLbl.Text = "Product Code:";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(23, 85);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(42, 15);
            this.nameLbl.TabIndex = 1;
            this.nameLbl.Text = "Name:";
            // 
            // versionLbl
            // 
            this.versionLbl.AutoSize = true;
            this.versionLbl.Location = new System.Drawing.Point(23, 132);
            this.versionLbl.Name = "versionLbl";
            this.versionLbl.Size = new System.Drawing.Size(48, 15);
            this.versionLbl.TabIndex = 2;
            this.versionLbl.Text = "Version:";
            // 
            // releaseDateLbl
            // 
            this.releaseDateLbl.AutoSize = true;
            this.releaseDateLbl.Location = new System.Drawing.Point(23, 187);
            this.releaseDateLbl.Name = "releaseDateLbl";
            this.releaseDateLbl.Size = new System.Drawing.Size(76, 15);
            this.releaseDateLbl.TabIndex = 3;
            this.releaseDateLbl.Text = "Release Date:";
            // 
            // productCodeTxt
            // 
            this.productCodeTxt.Location = new System.Drawing.Point(125, 31);
            this.productCodeTxt.Name = "productCodeTxt";
            this.productCodeTxt.Size = new System.Drawing.Size(112, 23);
            this.productCodeTxt.TabIndex = 4;
            this.productCodeTxt.TextChanged += new System.EventHandler(this.productCodeTxt_TextChanged);
            this.productCodeTxt.Validating += new System.ComponentModel.CancelEventHandler(this.productCodeTxt_Validating);
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(125, 77);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(195, 23);
            this.nameTxt.TabIndex = 5;
            // 
            // versionTxt
            // 
            this.versionTxt.Location = new System.Drawing.Point(125, 129);
            this.versionTxt.Name = "versionTxt";
            this.versionTxt.Size = new System.Drawing.Size(112, 23);
            this.versionTxt.TabIndex = 6;
            // 
            // releaseDateTxt
            // 
            this.releaseDateTxt.Location = new System.Drawing.Point(125, 179);
            this.releaseDateTxt.Name = "releaseDateTxt";
            this.releaseDateTxt.Size = new System.Drawing.Size(112, 23);
            this.releaseDateTxt.TabIndex = 7;
            // 
            // OKBtn
            // 
            this.OKBtn.Location = new System.Drawing.Point(125, 225);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(65, 23);
            this.OKBtn.TabIndex = 8;
            this.OKBtn.Text = "O&K";
            this.OKBtn.UseVisualStyleBackColor = true;
            this.OKBtn.Click += new System.EventHandler(this.OKBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(196, 225);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(65, 23);
            this.cancelBtn.TabIndex = 9;
            this.cancelBtn.Text = "&Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // AddModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 312);
            this.ControlBox = false;
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.OKBtn);
            this.Controls.Add(this.releaseDateTxt);
            this.Controls.Add(this.versionTxt);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.productCodeTxt);
            this.Controls.Add(this.releaseDateLbl);
            this.Controls.Add(this.versionLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.productcodeLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddModify";
            this.Text = "Add or Modify";
            this.Load += new System.EventHandler(this.AddModify_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label productcodeLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label versionLbl;
        private System.Windows.Forms.Label releaseDateLbl;
        private System.Windows.Forms.TextBox productCodeTxt;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.TextBox versionTxt;
        private System.Windows.Forms.TextBox releaseDateTxt;
        private System.Windows.Forms.Button OKBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}