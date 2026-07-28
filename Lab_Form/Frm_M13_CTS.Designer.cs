namespace Lab_Form
{
    partial class Frm_M13_CTS
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
            this.btnValueType = new System.Windows.Forms.Button();
            this.btnReferenceType = new System.Windows.Forms.Button();
            this.txtReferenceType = new System.Windows.Forms.TextBox();
            this.btnPassByType = new System.Windows.Forms.Button();
            this.btnPassByReference = new System.Windows.Forms.Button();
            this.btnPassByRef = new System.Windows.Forms.Button();
            this.btnPassByOut = new System.Windows.Forms.Button();
            this.btnUsingParams = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnAuthorizeByEnum = new System.Windows.Forms.Button();
            this.btnAuthorizeByMagicNum = new System.Windows.Forms.Button();
            this.btnAuthorizeByConstNum = new System.Windows.Forms.Button();
            this.btnAuthorizeBySwitchEnum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnValueType
            // 
            this.btnValueType.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnValueType.Location = new System.Drawing.Point(28, 32);
            this.btnValueType.Name = "btnValueType";
            this.btnValueType.Size = new System.Drawing.Size(120, 44);
            this.btnValueType.TabIndex = 0;
            this.btnValueType.Text = "Value Type";
            this.btnValueType.UseVisualStyleBackColor = true;
            this.btnValueType.Click += new System.EventHandler(this.btnValueType_Click);
            // 
            // btnReferenceType
            // 
            this.btnReferenceType.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReferenceType.Location = new System.Drawing.Point(28, 82);
            this.btnReferenceType.Name = "btnReferenceType";
            this.btnReferenceType.Size = new System.Drawing.Size(120, 44);
            this.btnReferenceType.TabIndex = 1;
            this.btnReferenceType.Text = "Reference Type";
            this.btnReferenceType.UseVisualStyleBackColor = true;
            this.btnReferenceType.Click += new System.EventHandler(this.btnReferenceType_Click);
            // 
            // txtReferenceType
            // 
            this.txtReferenceType.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtReferenceType.Location = new System.Drawing.Point(154, 93);
            this.txtReferenceType.Name = "txtReferenceType";
            this.txtReferenceType.Size = new System.Drawing.Size(165, 25);
            this.txtReferenceType.TabIndex = 2;
            this.txtReferenceType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnPassByType
            // 
            this.btnPassByType.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPassByType.Location = new System.Drawing.Point(28, 174);
            this.btnPassByType.Name = "btnPassByType";
            this.btnPassByType.Size = new System.Drawing.Size(163, 44);
            this.btnPassByType.TabIndex = 0;
            this.btnPassByType.Text = "Pass By Value";
            this.btnPassByType.UseVisualStyleBackColor = true;
            this.btnPassByType.Click += new System.EventHandler(this.btnPassByValueType_Click);
            // 
            // btnPassByReference
            // 
            this.btnPassByReference.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPassByReference.Location = new System.Drawing.Point(28, 224);
            this.btnPassByReference.Name = "btnPassByReference";
            this.btnPassByReference.Size = new System.Drawing.Size(163, 44);
            this.btnPassByReference.TabIndex = 1;
            this.btnPassByReference.TabStop = false;
            this.btnPassByReference.Text = "Pass By Reference";
            this.btnPassByReference.UseVisualStyleBackColor = true;
            this.btnPassByReference.Click += new System.EventHandler(this.btnPassByReference_Click);
            // 
            // btnPassByRef
            // 
            this.btnPassByRef.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPassByRef.Location = new System.Drawing.Point(218, 174);
            this.btnPassByRef.Name = "btnPassByRef";
            this.btnPassByRef.Size = new System.Drawing.Size(120, 44);
            this.btnPassByRef.TabIndex = 0;
            this.btnPassByRef.Text = "Pass By ref";
            this.btnPassByRef.UseVisualStyleBackColor = true;
            this.btnPassByRef.Click += new System.EventHandler(this.btnPassByRef_Click);
            // 
            // btnPassByOut
            // 
            this.btnPassByOut.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPassByOut.Location = new System.Drawing.Point(218, 224);
            this.btnPassByOut.Name = "btnPassByOut";
            this.btnPassByOut.Size = new System.Drawing.Size(120, 44);
            this.btnPassByOut.TabIndex = 3;
            this.btnPassByOut.Text = "Pass By out";
            this.btnPassByOut.UseVisualStyleBackColor = true;
            this.btnPassByOut.Click += new System.EventHandler(this.btnPassByOut_Click);
            // 
            // btnUsingParams
            // 
            this.btnUsingParams.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnUsingParams.Location = new System.Drawing.Point(218, 296);
            this.btnUsingParams.Name = "btnUsingParams";
            this.btnUsingParams.Size = new System.Drawing.Size(120, 44);
            this.btnUsingParams.TabIndex = 3;
            this.btnUsingParams.Text = "Using Params";
            this.btnUsingParams.UseVisualStyleBackColor = true;
            this.btnUsingParams.Click += new System.EventHandler(this.btnUsingParams_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.Enabled = false;
            this.btnProduct.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnProduct.Location = new System.Drawing.Point(392, 32);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(120, 44);
            this.btnProduct.TabIndex = 3;
            this.btnProduct.Text = "Product";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnAuthorizeByEnum
            // 
            this.btnAuthorizeByEnum.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAuthorizeByEnum.Location = new System.Drawing.Point(392, 224);
            this.btnAuthorizeByEnum.Name = "btnAuthorizeByEnum";
            this.btnAuthorizeByEnum.Size = new System.Drawing.Size(120, 44);
            this.btnAuthorizeByEnum.TabIndex = 3;
            this.btnAuthorizeByEnum.Text = "Authorize By Enum";
            this.btnAuthorizeByEnum.UseVisualStyleBackColor = true;
            this.btnAuthorizeByEnum.Click += new System.EventHandler(this.btnAuthorizeByEnum_Click);
            // 
            // btnAuthorizeByMagicNum
            // 
            this.btnAuthorizeByMagicNum.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAuthorizeByMagicNum.Location = new System.Drawing.Point(392, 93);
            this.btnAuthorizeByMagicNum.Name = "btnAuthorizeByMagicNum";
            this.btnAuthorizeByMagicNum.Size = new System.Drawing.Size(120, 44);
            this.btnAuthorizeByMagicNum.TabIndex = 3;
            this.btnAuthorizeByMagicNum.Text = "Authorize By Magic Number";
            this.btnAuthorizeByMagicNum.UseVisualStyleBackColor = true;
            this.btnAuthorizeByMagicNum.Click += new System.EventHandler(this.btnAuthorizeByMagicNum_Click);
            // 
            // btnAuthorizeByConstNum
            // 
            this.btnAuthorizeByConstNum.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAuthorizeByConstNum.Location = new System.Drawing.Point(392, 156);
            this.btnAuthorizeByConstNum.Name = "btnAuthorizeByConstNum";
            this.btnAuthorizeByConstNum.Size = new System.Drawing.Size(120, 44);
            this.btnAuthorizeByConstNum.TabIndex = 3;
            this.btnAuthorizeByConstNum.Text = "Authorize By Const Num";
            this.btnAuthorizeByConstNum.UseVisualStyleBackColor = true;
            this.btnAuthorizeByConstNum.Click += new System.EventHandler(this.btnAuthorizeByConstNum_Click);
            // 
            // btnAuthorizeBySwitchEnum
            // 
            this.btnAuthorizeBySwitchEnum.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAuthorizeBySwitchEnum.Location = new System.Drawing.Point(392, 274);
            this.btnAuthorizeBySwitchEnum.Name = "btnAuthorizeBySwitchEnum";
            this.btnAuthorizeBySwitchEnum.Size = new System.Drawing.Size(120, 44);
            this.btnAuthorizeBySwitchEnum.TabIndex = 3;
            this.btnAuthorizeBySwitchEnum.Text = "Authorize By Switch Enum";
            this.btnAuthorizeBySwitchEnum.UseVisualStyleBackColor = true;
            this.btnAuthorizeBySwitchEnum.Click += new System.EventHandler(this.btnbtnAuthorizeBySwitchEnum_Click);
            // 
            // Frm_M13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAuthorizeByConstNum);
            this.Controls.Add(this.btnAuthorizeByMagicNum);
            this.Controls.Add(this.btnAuthorizeBySwitchEnum);
            this.Controls.Add(this.btnAuthorizeByEnum);
            this.Controls.Add(this.btnProduct);
            this.Controls.Add(this.btnUsingParams);
            this.Controls.Add(this.btnPassByOut);
            this.Controls.Add(this.txtReferenceType);
            this.Controls.Add(this.btnPassByReference);
            this.Controls.Add(this.btnPassByType);
            this.Controls.Add(this.btnReferenceType);
            this.Controls.Add(this.btnPassByRef);
            this.Controls.Add(this.btnValueType);
            this.Name = "Frm_M13";
            this.Text = "Frm_M13";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnValueType;
        private System.Windows.Forms.Button btnReferenceType;
        private System.Windows.Forms.TextBox txtReferenceType;
        private System.Windows.Forms.Button btnPassByType;
        private System.Windows.Forms.Button btnPassByReference;
        private System.Windows.Forms.Button btnPassByRef;
        private System.Windows.Forms.Button btnPassByOut;
        private System.Windows.Forms.Button btnUsingParams;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnAuthorizeByEnum;
        private System.Windows.Forms.Button btnAuthorizeByMagicNum;
        private System.Windows.Forms.Button btnAuthorizeByConstNum;
        private System.Windows.Forms.Button btnAuthorizeBySwitchEnum;
    }
}