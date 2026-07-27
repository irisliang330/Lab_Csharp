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
            this.btnRegisterEvent02 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenHelloForm
            // 
            this.btnOpenHelloForm.Location = new System.Drawing.Point(36, 61);
            this.btnOpenHelloForm.Name = "btnOpenHelloForm";
            this.btnOpenHelloForm.Size = new System.Drawing.Size(113, 50);
            this.btnOpenHelloForm.TabIndex = 0;
            this.btnOpenHelloForm.Text = "Open Hello Form";
            this.btnOpenHelloForm.UseVisualStyleBackColor = true;
            this.btnOpenHelloForm.Click += new System.EventHandler(this.btnOpenHelloForm_Click);
            // 
            // btnMethod
            // 
            this.btnMethod.Location = new System.Drawing.Point(53, 135);
            this.btnMethod.Name = "btnMethod";
            this.btnMethod.Size = new System.Drawing.Size(75, 23);
            this.btnMethod.TabIndex = 1;
            this.btnMethod.Text = "Method";
            this.btnMethod.UseVisualStyleBackColor = true;
            this.btnMethod.Click += new System.EventHandler(this.btnMethod_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "呼叫不同類別的方法";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(36, 225);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "有回傳值的方法";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(53, 269);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "封裝練習";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(53, 310);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Partial Class";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // NewMember
            // 
            this.NewMember.Location = new System.Drawing.Point(33, 353);
            this.NewMember.Name = "NewMember";
            this.NewMember.Size = new System.Drawing.Size(125, 23);
            this.NewMember.TabIndex = 6;
            this.NewMember.Text = "New Member";
            this.NewMember.UseVisualStyleBackColor = true;
            this.NewMember.Click += new System.EventHandler(this.NewMember_Click);
            // 
            // btnDataBinding
            // 
            this.btnDataBinding.Location = new System.Drawing.Point(394, 118);
            this.btnDataBinding.Name = "btnDataBinding";
            this.btnDataBinding.Size = new System.Drawing.Size(75, 23);
            this.btnDataBinding.TabIndex = 7;
            this.btnDataBinding.Text = "資料繫結";
            this.btnDataBinding.UseVisualStyleBackColor = true;
            this.btnDataBinding.Click += new System.EventHandler(this.btnDataBinding_Click);
            // 
            // btnRegitster01
            // 
            this.btnRegitster01.Location = new System.Drawing.Point(394, 165);
            this.btnRegitster01.Name = "btnRegitster01";
            this.btnRegitster01.Size = new System.Drawing.Size(118, 23);
            this.btnRegitster01.TabIndex = 8;
            this.btnRegitster01.Text = "RegisterEvent01";
            this.btnRegitster01.UseVisualStyleBackColor = true;
            // 
            // btnRegisterEvent02
            // 
            this.btnRegisterEvent02.Location = new System.Drawing.Point(394, 194);
            this.btnRegisterEvent02.Name = "btnRegisterEvent02";
            this.btnRegisterEvent02.Size = new System.Drawing.Size(118, 23);
            this.btnRegisterEvent02.TabIndex = 9;
            this.btnRegisterEvent02.Text = "Register Event02";
            this.btnRegisterEvent02.UseVisualStyleBackColor = true;
            // 
            // Frm_M04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegisterEvent02);
            this.Controls.Add(this.btnRegitster01);
            this.Controls.Add(this.btnDataBinding);
            this.Controls.Add(this.NewMember);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMethod);
            this.Controls.Add(this.btnOpenHelloForm);
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
        private System.Windows.Forms.Button btnRegisterEvent02;
    }
}