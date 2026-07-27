namespace Lab_Form
{
    partial class Frm_HelloForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_HelloForm));
            this.txtName = new System.Windows.Forms.TextBox();
            this.labName = new System.Windows.Forms.Label();
            this.btnHello = new System.Windows.Forms.Button();
            this.btnMessageBox = new System.Windows.Forms.Button();
            this.btnUsingDialogResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(373, 378);
            this.txtName.Margin = new System.Windows.Forms.Padding(9);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(153, 29);
            this.txtName.TabIndex = 0;
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.BackColor = System.Drawing.Color.Transparent;
            this.labName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labName.Location = new System.Drawing.Point(193, 381);
            this.labName.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(94, 21);
            this.labName.TabIndex = 1;
            this.labName.Text = "請輸入姓名:";
            // 
            // btnHello
            // 
            this.btnHello.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHello.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnHello.Location = new System.Drawing.Point(262, 441);
            this.btnHello.Margin = new System.Windows.Forms.Padding(9);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(213, 69);
            this.btnHello.TabIndex = 2;
            this.btnHello.Text = "Hello";
            this.btnHello.UseVisualStyleBackColor = false;
            this.btnHello.Click += new System.EventHandler(this.btnHello_Click);
            // 
            // btnMessageBox
            // 
            this.btnMessageBox.Location = new System.Drawing.Point(588, 425);
            this.btnMessageBox.Name = "btnMessageBox";
            this.btnMessageBox.Size = new System.Drawing.Size(154, 51);
            this.btnMessageBox.TabIndex = 3;
            this.btnMessageBox.Text = "Message Box";
            this.btnMessageBox.UseVisualStyleBackColor = true;
            this.btnMessageBox.Click += new System.EventHandler(this.btnMessageBox_Click);
            // 
            // btnUsingDialogResult
            // 
            this.btnUsingDialogResult.Location = new System.Drawing.Point(0, 0);
            this.btnUsingDialogResult.Name = "btnUsingDialogResult";
            this.btnUsingDialogResult.Size = new System.Drawing.Size(75, 23);
            this.btnUsingDialogResult.TabIndex = 0;
            // 
            // Frm_HelloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1038, 544);
            this.Controls.Add(this.btnUsingDialogResult);
            this.Controls.Add(this.btnMessageBox);
            this.Controls.Add(this.btnHello);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.txtName);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(9);
            this.Name = "Frm_HelloForm";
            this.Text = "Hello Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Button btnHello;
        private System.Windows.Forms.Button btnMessageBox;
        private System.Windows.Forms.Button btnUsingDialogResult;
    }
}

