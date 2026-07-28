namespace Lab_Form
{
    partial class Frm_M15_struct
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
            this.btnUserCommit = new System.Windows.Forms.Button();
            this.labProductPrice = new System.Windows.Forms.Label();
            this.labProductName = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.labShowProduct = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUserCommit
            // 
            this.btnUserCommit.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnUserCommit.Location = new System.Drawing.Point(237, 51);
            this.btnUserCommit.Name = "btnUserCommit";
            this.btnUserCommit.Size = new System.Drawing.Size(75, 23);
            this.btnUserCommit.TabIndex = 0;
            this.btnUserCommit.Text = "輸入";
            this.btnUserCommit.UseVisualStyleBackColor = true;
            this.btnUserCommit.Click += new System.EventHandler(this.btnUserCommit_Click);
            // 
            // labProductPrice
            // 
            this.labProductPrice.AutoSize = true;
            this.labProductPrice.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labProductPrice.Location = new System.Drawing.Point(43, 86);
            this.labProductPrice.Name = "labProductPrice";
            this.labProductPrice.Size = new System.Drawing.Size(60, 17);
            this.labProductPrice.TabIndex = 1;
            this.labProductPrice.Text = "產品單價";
            // 
            // labProductName
            // 
            this.labProductName.AutoSize = true;
            this.labProductName.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labProductName.Location = new System.Drawing.Point(43, 56);
            this.labProductName.Name = "labProductName";
            this.labProductName.Size = new System.Drawing.Size(60, 17);
            this.labProductName.TabIndex = 2;
            this.labProductName.Text = "產品名稱";
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtProductName.Location = new System.Drawing.Point(113, 53);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(100, 25);
            this.txtProductName.TabIndex = 3;
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtProductPrice.Location = new System.Drawing.Point(113, 81);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(100, 25);
            this.txtProductPrice.TabIndex = 3;
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnShow.Location = new System.Drawing.Point(237, 83);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 0;
            this.btnShow.Text = "顯示";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // labShowProduct
            // 
            this.labShowProduct.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labShowProduct.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labShowProduct.ForeColor = System.Drawing.Color.Azure;
            this.labShowProduct.Location = new System.Drawing.Point(341, 51);
            this.labShowProduct.Name = "labShowProduct";
            this.labShowProduct.Size = new System.Drawing.Size(195, 314);
            this.labShowProduct.TabIndex = 1;
            this.labShowProduct.Text = "產品";
            this.labShowProduct.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Frm_M15_struct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtProductPrice);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.labProductName);
            this.Controls.Add(this.labShowProduct);
            this.Controls.Add(this.labProductPrice);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnUserCommit);
            this.Name = "Frm_M15_struct";
            this.Text = "Frm_M15_struct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUserCommit;
        private System.Windows.Forms.Label labProductPrice;
        private System.Windows.Forms.Label labProductName;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label labShowProduct;
    }
}