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
            this.btnMethod = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.NewMember = new System.Windows.Forms.Button();
            this.btnDataBinding = new System.Windows.Forms.Button();
            this.btnRegitster01 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenHelloForm
            // 
            this.btnOpenHelloForm.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnOpenHelloForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenHelloForm.Font = new System.Drawing.Font("微軟正黑體", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOpenHelloForm.ForeColor = System.Drawing.Color.Navy;
            this.btnOpenHelloForm.Location = new System.Drawing.Point(34, 84);
            this.btnOpenHelloForm.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnOpenHelloForm.Name = "btnOpenHelloForm";
            this.btnOpenHelloForm.Size = new System.Drawing.Size(243, 91);
            this.btnOpenHelloForm.TabIndex = 0;
            this.btnOpenHelloForm.Text = "Open Hello Form";
            this.btnOpenHelloForm.UseVisualStyleBackColor = false;
            this.btnOpenHelloForm.Click += new System.EventHandler(this.btnOpenHelloForm_Click);
            // 
            // btnMethod
            // 
            this.btnMethod.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnMethod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMethod.Font = new System.Drawing.Font("微軟正黑體", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMethod.ForeColor = System.Drawing.Color.Navy;
            this.btnMethod.Location = new System.Drawing.Point(34, 210);
            this.btnMethod.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnMethod.Name = "btnMethod";
            this.btnMethod.Size = new System.Drawing.Size(243, 90);
            this.btnMethod.TabIndex = 1;
            this.btnMethod.Text = "無回傳值的Method";
            this.btnMethod.UseVisualStyleBackColor = false;
            this.btnMethod.Click += new System.EventHandler(this.btnUsingVoidMethod_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.ForeColor = System.Drawing.Color.Navy;
            this.button1.Location = new System.Drawing.Point(34, 334);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 90);
            this.button1.TabIndex = 2;
            this.button1.Text = "呼叫不同Class的Method";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnUsingDiffClassMethod_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.ForeColor = System.Drawing.Color.Navy;
            this.button2.Location = new System.Drawing.Point(34, 462);
            this.button2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(243, 90);
            this.button2.TabIndex = 3;
            this.button2.Text = "有回傳值的Method";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("微軟正黑體", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button3.ForeColor = System.Drawing.Color.Navy;
            this.button3.Location = new System.Drawing.Point(370, 84);
            this.button3.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(243, 90);
            this.button3.TabIndex = 4;
            this.button3.Text = "封裝練習";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("微軟正黑體", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button4.ForeColor = System.Drawing.Color.Navy;
            this.button4.Location = new System.Drawing.Point(370, 210);
            this.button4.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(243, 90);
            this.button4.TabIndex = 5;
            this.button4.Text = "Partial Class";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // NewMember
            // 
            this.NewMember.BackColor = System.Drawing.Color.LightSteelBlue;
            this.NewMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewMember.Font = new System.Drawing.Font("微軟正黑體", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NewMember.ForeColor = System.Drawing.Color.Navy;
            this.NewMember.Location = new System.Drawing.Point(370, 334);
            this.NewMember.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.NewMember.Name = "NewMember";
            this.NewMember.Size = new System.Drawing.Size(243, 90);
            this.NewMember.TabIndex = 6;
            this.NewMember.Text = "New Member";
            this.NewMember.UseVisualStyleBackColor = false;
            this.NewMember.Click += new System.EventHandler(this.NewMember_Click);
            // 
            // btnDataBinding
            // 
            this.btnDataBinding.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnDataBinding.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDataBinding.Font = new System.Drawing.Font("微軟正黑體", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDataBinding.ForeColor = System.Drawing.Color.Navy;
            this.btnDataBinding.Location = new System.Drawing.Point(370, 462);
            this.btnDataBinding.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnDataBinding.Name = "btnDataBinding";
            this.btnDataBinding.Size = new System.Drawing.Size(243, 90);
            this.btnDataBinding.TabIndex = 7;
            this.btnDataBinding.Text = "事件與方法繫結";
            this.btnDataBinding.UseVisualStyleBackColor = false;
            this.btnDataBinding.Click += new System.EventHandler(this.btnDataBinding_Click);
            // 
            // btnRegitster01
            // 
            this.btnRegitster01.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnRegitster01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegitster01.Font = new System.Drawing.Font("微軟正黑體", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRegitster01.ForeColor = System.Drawing.Color.Navy;
            this.btnRegitster01.Location = new System.Drawing.Point(370, 592);
            this.btnRegitster01.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnRegitster01.Name = "btnRegitster01";
            this.btnRegitster01.Size = new System.Drawing.Size(243, 90);
            this.btnRegitster01.TabIndex = 8;
            this.btnRegitster01.Text = "RegisterEvent01";
            this.btnRegitster01.UseVisualStyleBackColor = false;
            // 
            // Frm_M04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 788);
            this.Controls.Add(this.btnRegitster01);
            this.Controls.Add(this.btnDataBinding);
            this.Controls.Add(this.NewMember);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMethod);
            this.Controls.Add(this.btnOpenHelloForm);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Frm_M04";
            this.Text = "Frm_M04";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenHelloForm;
        private System.Windows.Forms.Button btnMethod;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button NewMember;
        private System.Windows.Forms.Button btnDataBinding;
        private System.Windows.Forms.Button btnRegitster01;
    }
}