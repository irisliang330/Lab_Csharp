namespace Lab_Form
{
    partial class Frm_M04
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
            this.btnOpenHelloForm = new System.Windows.Forms.Button();
            this.btnUsingVoidMethod = new System.Windows.Forms.Button();
            this.btnUsingDiffClassMethod = new System.Windows.Forms.Button();
            this.btnNotVoidMethod = new System.Windows.Forms.Button();
            this.btnEncapsulation = new System.Windows.Forms.Button();
            this.btnPartialClass = new System.Windows.Forms.Button();
            this.NewMember = new System.Windows.Forms.Button();
            this.btnEventBinding = new System.Windows.Forms.Button();
            this.btnRegisterEvent01 = new System.Windows.Forms.Button();
            this.btnRegisterEvent02 = new System.Windows.Forms.Button();
            this.btnDelegate = new System.Windows.Forms.Button();
            this.txtDelegateInputPrice = new System.Windows.Forms.TextBox();
            this.OpenFrmM11 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenHelloForm
            // 
            this.btnOpenHelloForm.BackColor = System.Drawing.Color.Wheat;
            this.btnOpenHelloForm.Font = new System.Drawing.Font("微軟正黑體", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOpenHelloForm.Location = new System.Drawing.Point(36, 61);
            this.btnOpenHelloForm.Margin = new System.Windows.Forms.Padding(10);
            this.btnOpenHelloForm.MinimumSize = new System.Drawing.Size(200, 0);
            this.btnOpenHelloForm.Name = "btnOpenHelloForm";
            this.btnOpenHelloForm.Padding = new System.Windows.Forms.Padding(10);
            this.btnOpenHelloForm.Size = new System.Drawing.Size(425, 80);
            this.btnOpenHelloForm.TabIndex = 0;
            this.btnOpenHelloForm.Text = "Open Hello Form";
            this.btnOpenHelloForm.UseVisualStyleBackColor = false;
            this.btnOpenHelloForm.Click += new System.EventHandler(this.btnOpenHelloForm_Click);
            // 
            // btnUsingVoidMethod
            // 
            this.btnUsingVoidMethod.BackColor = System.Drawing.Color.LightBlue;
            this.btnUsingVoidMethod.Font = new System.Drawing.Font("微軟正黑體", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnUsingVoidMethod.Location = new System.Drawing.Point(36, 174);
            this.btnUsingVoidMethod.Margin = new System.Windows.Forms.Padding(10);
            this.btnUsingVoidMethod.MinimumSize = new System.Drawing.Size(200, 0);
            this.btnUsingVoidMethod.Name = "btnUsingVoidMethod";
            this.btnUsingVoidMethod.Padding = new System.Windows.Forms.Padding(10);
            this.btnUsingVoidMethod.Size = new System.Drawing.Size(425, 80);
            this.btnUsingVoidMethod.TabIndex = 1;
            this.btnUsingVoidMethod.Text = "無回傳值的Method";
            this.btnUsingVoidMethod.UseVisualStyleBackColor = false;
            this.btnUsingVoidMethod.Click += new System.EventHandler(this.btnUsingVoidMethod_Click);
            // 
            // btnUsingDiffClassMethod
            // 
            this.btnUsingDiffClassMethod.BackColor = System.Drawing.Color.LightBlue;
            this.btnUsingDiffClassMethod.Font = new System.Drawing.Font("微軟正黑體", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnUsingDiffClassMethod.Location = new System.Drawing.Point(36, 295);
            this.btnUsingDiffClassMethod.Margin = new System.Windows.Forms.Padding(10);
            this.btnUsingDiffClassMethod.MinimumSize = new System.Drawing.Size(200, 0);
            this.btnUsingDiffClassMethod.Name = "btnUsingDiffClassMethod";
            this.btnUsingDiffClassMethod.Padding = new System.Windows.Forms.Padding(10);
            this.btnUsingDiffClassMethod.Size = new System.Drawing.Size(425, 80);
            this.btnUsingDiffClassMethod.TabIndex = 2;
            this.btnUsingDiffClassMethod.Text = "呼叫不同Class的Method";
            this.btnUsingDiffClassMethod.UseVisualStyleBackColor = false;
            this.btnUsingDiffClassMethod.Click += new System.EventHandler(this.btnUsingDiffClassMethod_Click);
            // 
            // btnNotVoidMethod
            // 
            this.btnNotVoidMethod.BackColor = System.Drawing.Color.LightBlue;
            this.btnNotVoidMethod.Font = new System.Drawing.Font("微軟正黑體", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnNotVoidMethod.Location = new System.Drawing.Point(36, 419);
            this.btnNotVoidMethod.Margin = new System.Windows.Forms.Padding(10);
            this.btnNotVoidMethod.MinimumSize = new System.Drawing.Size(200, 0);
            this.btnNotVoidMethod.Name = "btnNotVoidMethod";
            this.btnNotVoidMethod.Padding = new System.Windows.Forms.Padding(10);
            this.btnNotVoidMethod.Size = new System.Drawing.Size(425, 80);
            this.btnNotVoidMethod.TabIndex = 3;
            this.btnNotVoidMethod.Text = "有回傳值的方法";
            this.btnNotVoidMethod.UseVisualStyleBackColor = false;
            this.btnNotVoidMethod.Click += new System.EventHandler(this.btnNotVoidMethod_Click);
            // 
            // btnEncapsulation
            // 
            this.btnEncapsulation.BackColor = System.Drawing.Color.LightBlue;
            this.btnEncapsulation.Font = new System.Drawing.Font("微軟正黑體", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnEncapsulation.Location = new System.Drawing.Point(36, 547);
            this.btnEncapsulation.Margin = new System.Windows.Forms.Padding(10);
            this.btnEncapsulation.MinimumSize = new System.Drawing.Size(200, 0);
            this.btnEncapsulation.Name = "btnEncapsulation";
            this.btnEncapsulation.Padding = new System.Windows.Forms.Padding(10);
            this.btnEncapsulation.Size = new System.Drawing.Size(425, 80);
            this.btnEncapsulation.TabIndex = 4;
            this.btnEncapsulation.Text = "封裝練習";
            this.btnEncapsulation.UseVisualStyleBackColor = false;
            this.btnEncapsulation.Click += new System.EventHandler(this.btnEncapsulation_Click);
            // 
            // btnPartialClass
            // 
            this.btnPartialClass.BackColor = System.Drawing.Color.LightBlue;
            this.btnPartialClass.Font = new System.Drawing.Font("微軟正黑體", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPartialClass.Location = new System.Drawing.Point(36, 675);
            this.btnPartialClass.Margin = new System.Windows.Forms.Padding(10);
            this.btnPartialClass.MinimumSize = new System.Drawing.Size(200, 0);
            this.btnPartialClass.Name = "btnPartialClass";
            this.btnPartialClass.Padding = new System.Windows.Forms.Padding(10);
            this.btnPartialClass.Size = new System.Drawing.Size(425, 80);
            this.btnPartialClass.TabIndex = 5;
            this.btnPartialClass.Text = "Partial Class";
            this.btnPartialClass.UseVisualStyleBackColor = false;
            this.btnPartialClass.Click += new System.EventHandler(this.btnPartialClass_Click);
            // 
            // NewMember
            // 
            this.NewMember.BackColor = System.Drawing.Color.LightBlue;
            this.NewMember.Font = new System.Drawing.Font("微軟正黑體", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NewMember.Location = new System.Drawing.Point(36, 804);
            this.NewMember.Margin = new System.Windows.Forms.Padding(10);
            this.NewMember.MinimumSize = new System.Drawing.Size(200, 0);
            this.NewMember.Name = "NewMember";
            this.NewMember.Padding = new System.Windows.Forms.Padding(10);
            this.NewMember.Size = new System.Drawing.Size(425, 80);
            this.NewMember.TabIndex = 6;
            this.NewMember.Text = "New Member";
            this.NewMember.UseVisualStyleBackColor = false;
            this.NewMember.Click += new System.EventHandler(this.NewMember_Click);
            // 
            // btnEventBinding
            // 
            this.btnEventBinding.BackColor = System.Drawing.Color.LightBlue;
            this.btnEventBinding.Font = new System.Drawing.Font("微軟正黑體", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnEventBinding.Location = new System.Drawing.Point(573, 58);
            this.btnEventBinding.Margin = new System.Windows.Forms.Padding(10);
            this.btnEventBinding.MinimumSize = new System.Drawing.Size(200, 0);
            this.btnEventBinding.Name = "btnEventBinding";
            this.btnEventBinding.Padding = new System.Windows.Forms.Padding(10);
            this.btnEventBinding.Size = new System.Drawing.Size(418, 80);
            this.btnEventBinding.TabIndex = 7;
            this.btnEventBinding.Text = "Event Bind";
            this.btnEventBinding.UseVisualStyleBackColor = false;
            this.btnEventBinding.Click += new System.EventHandler(this.btnEventBinding_Click);
            // 
            // btnRegisterEvent01
            // 
            this.btnRegisterEvent01.BackColor = System.Drawing.Color.LightBlue;
            this.btnRegisterEvent01.Font = new System.Drawing.Font("微軟正黑體", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRegisterEvent01.Location = new System.Drawing.Point(573, 174);
            this.btnRegisterEvent01.Margin = new System.Windows.Forms.Padding(10);
            this.btnRegisterEvent01.MinimumSize = new System.Drawing.Size(200, 0);
            this.btnRegisterEvent01.Name = "btnRegisterEvent01";
            this.btnRegisterEvent01.Padding = new System.Windows.Forms.Padding(10);
            this.btnRegisterEvent01.Size = new System.Drawing.Size(418, 80);
            this.btnRegisterEvent01.TabIndex = 8;
            this.btnRegisterEvent01.Text = "RegisterEvent01";
            this.btnRegisterEvent01.UseVisualStyleBackColor = false;
            // 
            // btnRegisterEvent02
            // 
            this.btnRegisterEvent02.BackColor = System.Drawing.Color.LightBlue;
            this.btnRegisterEvent02.Font = new System.Drawing.Font("微軟正黑體", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRegisterEvent02.Location = new System.Drawing.Point(573, 295);
            this.btnRegisterEvent02.Margin = new System.Windows.Forms.Padding(10);
            this.btnRegisterEvent02.MinimumSize = new System.Drawing.Size(200, 0);
            this.btnRegisterEvent02.Name = "btnRegisterEvent02";
            this.btnRegisterEvent02.Padding = new System.Windows.Forms.Padding(10);
            this.btnRegisterEvent02.Size = new System.Drawing.Size(418, 80);
            this.btnRegisterEvent02.TabIndex = 9;
            this.btnRegisterEvent02.Text = "Register Event02";
            this.btnRegisterEvent02.UseVisualStyleBackColor = false;
            // 
            // btnDelegate
            // 
            this.btnDelegate.BackColor = System.Drawing.Color.LightBlue;
            this.btnDelegate.Font = new System.Drawing.Font("微軟正黑體", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDelegate.Location = new System.Drawing.Point(573, 419);
            this.btnDelegate.Margin = new System.Windows.Forms.Padding(10);
            this.btnDelegate.MinimumSize = new System.Drawing.Size(200, 0);
            this.btnDelegate.Name = "btnDelegate";
            this.btnDelegate.Padding = new System.Windows.Forms.Padding(10);
            this.btnDelegate.Size = new System.Drawing.Size(418, 80);
            this.btnDelegate.TabIndex = 10;
            this.btnDelegate.Text = "Delegate";
            this.btnDelegate.UseVisualStyleBackColor = false;
            this.btnDelegate.Click += new System.EventHandler(this.btnDelegate_Click);
            // 
            // txtDelegateInputPrice
            // 
            this.txtDelegateInputPrice.BackColor = System.Drawing.Color.Azure;
            this.txtDelegateInputPrice.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDelegateInputPrice.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtDelegateInputPrice.Location = new System.Drawing.Point(573, 514);
            this.txtDelegateInputPrice.Margin = new System.Windows.Forms.Padding(5);
            this.txtDelegateInputPrice.Name = "txtDelegateInputPrice";
            this.txtDelegateInputPrice.Size = new System.Drawing.Size(418, 42);
            this.txtDelegateInputPrice.TabIndex = 11;
            this.txtDelegateInputPrice.Tag = "";
            this.txtDelegateInputPrice.Text = "1000";
            this.txtDelegateInputPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OpenFrmM11
            // 
            this.OpenFrmM11.BackColor = System.Drawing.Color.Wheat;
            this.OpenFrmM11.Font = new System.Drawing.Font("微軟正黑體", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.OpenFrmM11.Location = new System.Drawing.Point(573, 675);
            this.OpenFrmM11.Margin = new System.Windows.Forms.Padding(10);
            this.OpenFrmM11.MinimumSize = new System.Drawing.Size(200, 0);
            this.OpenFrmM11.Name = "OpenFrmM11";
            this.OpenFrmM11.Padding = new System.Windows.Forms.Padding(10);
            this.OpenFrmM11.Size = new System.Drawing.Size(425, 80);
            this.OpenFrmM11.TabIndex = 12;
            this.OpenFrmM11.Text = "Open Frm_M11";
            this.OpenFrmM11.UseVisualStyleBackColor = false;
            this.OpenFrmM11.Click += new System.EventHandler(this.OpenFrmM11_Click);
            // 
            // Frm_M04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1061, 950);
            this.Controls.Add(this.OpenFrmM11);
            this.Controls.Add(this.txtDelegateInputPrice);
            this.Controls.Add(this.btnDelegate);
            this.Controls.Add(this.btnRegisterEvent02);
            this.Controls.Add(this.btnRegisterEvent01);
            this.Controls.Add(this.btnEventBinding);
            this.Controls.Add(this.NewMember);
            this.Controls.Add(this.btnPartialClass);
            this.Controls.Add(this.btnEncapsulation);
            this.Controls.Add(this.btnNotVoidMethod);
            this.Controls.Add(this.btnUsingDiffClassMethod);
            this.Controls.Add(this.btnUsingVoidMethod);
            this.Controls.Add(this.btnOpenHelloForm);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Frm_M04";
            this.Text = " Frm_M04";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenHelloForm;
        private System.Windows.Forms.Button btnUsingVoidMethod;
        private System.Windows.Forms.Button btnUsingDiffClassMethod;
        private System.Windows.Forms.Button btnNotVoidMethod;
        private System.Windows.Forms.Button btnEncapsulation;
        private System.Windows.Forms.Button btnPartialClass;
        private System.Windows.Forms.Button NewMember;
        private System.Windows.Forms.Button btnEventBinding;
        private System.Windows.Forms.Button btnRegisterEvent01;
        private System.Windows.Forms.Button btnRegisterEvent02;
        private System.Windows.Forms.Button btnDelegate;
        private System.Windows.Forms.TextBox txtDelegateInputPrice;
        private System.Windows.Forms.Button OpenFrmM11;
    }
}