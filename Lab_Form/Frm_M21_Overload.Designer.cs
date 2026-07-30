namespace Lab_Form
{
    partial class Frm_M21_Overload
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
            this.btnSwapInt = new System.Windows.Forms.Button();
            this.btnSwapString = new System.Windows.Forms.Button();
            this.btnGenericSwap = new System.Windows.Forms.Button();
            this.btnGenericSwapOverload = new System.Windows.Forms.Button();
            this.btnOptionalParam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSwapInt
            // 
            this.btnSwapInt.Location = new System.Drawing.Point(99, 109);
            this.btnSwapInt.Name = "btnSwapInt";
            this.btnSwapInt.Size = new System.Drawing.Size(109, 50);
            this.btnSwapInt.TabIndex = 0;
            this.btnSwapInt.Text = "Swap Int";
            this.btnSwapInt.UseVisualStyleBackColor = true;
            this.btnSwapInt.Click += new System.EventHandler(this.btnSwapInt_Click);
            // 
            // btnSwapString
            // 
            this.btnSwapString.Location = new System.Drawing.Point(99, 176);
            this.btnSwapString.Name = "btnSwapString";
            this.btnSwapString.Size = new System.Drawing.Size(109, 50);
            this.btnSwapString.TabIndex = 0;
            this.btnSwapString.Text = "Swap String";
            this.btnSwapString.UseVisualStyleBackColor = true;
            this.btnSwapString.Click += new System.EventHandler(this.btnSwapString_Click);
            // 
            // btnGenericSwap
            // 
            this.btnGenericSwap.Location = new System.Drawing.Point(99, 249);
            this.btnGenericSwap.Name = "btnGenericSwap";
            this.btnGenericSwap.Size = new System.Drawing.Size(109, 50);
            this.btnGenericSwap.TabIndex = 0;
            this.btnGenericSwap.Text = "Generic Swap";
            this.btnGenericSwap.UseVisualStyleBackColor = true;
            this.btnGenericSwap.Click += new System.EventHandler(this.btnGenericSwap_Click);
            // 
            // btnGenericSwapOverload
            // 
            this.btnGenericSwapOverload.Location = new System.Drawing.Point(99, 316);
            this.btnGenericSwapOverload.Name = "btnGenericSwapOverload";
            this.btnGenericSwapOverload.Size = new System.Drawing.Size(109, 50);
            this.btnGenericSwapOverload.TabIndex = 0;
            this.btnGenericSwapOverload.Text = "Generic Swap Overload";
            this.btnGenericSwapOverload.UseVisualStyleBackColor = true;
            this.btnGenericSwapOverload.Click += new System.EventHandler(this.btnGenericSwapOverloda_Click);
            // 
            // btnOptionalParam
            // 
            this.btnOptionalParam.Location = new System.Drawing.Point(257, 109);
            this.btnOptionalParam.Name = "btnOptionalParam";
            this.btnOptionalParam.Size = new System.Drawing.Size(109, 50);
            this.btnOptionalParam.TabIndex = 0;
            this.btnOptionalParam.Text = "選擇性參數";
            this.btnOptionalParam.UseVisualStyleBackColor = true;
            this.btnOptionalParam.Click += new System.EventHandler(this.btnOptionalParam_Click);
            // 
            // Frm_M21_Overload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOptionalParam);
            this.Controls.Add(this.btnGenericSwapOverload);
            this.Controls.Add(this.btnGenericSwap);
            this.Controls.Add(this.btnSwapString);
            this.Controls.Add(this.btnSwapInt);
            this.Name = "Frm_M21_Overload";
            this.Text = "Frm_M21_Overload";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSwapInt;
        private System.Windows.Forms.Button btnSwapString;
        private System.Windows.Forms.Button btnGenericSwap;
        private System.Windows.Forms.Button btnGenericSwapOverload;
        private System.Windows.Forms.Button btnOptionalParam;
    }
}