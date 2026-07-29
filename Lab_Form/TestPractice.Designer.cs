namespace Lab_Form
{
    partial class TestPractice
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
            this.btnCreateMember = new Lab_Form.MyStyledButton();
            this.labName = new System.Windows.Forms.Label();
            this.labPhone = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.labBirthday = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtShowMember = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCreateMember
            // 
            this.btnCreateMember.BackColor = System.Drawing.Color.LightBlue;
            this.btnCreateMember.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btnCreateMember.ForeColor = System.Drawing.Color.Navy;
            this.btnCreateMember.Location = new System.Drawing.Point(42, 144);
            this.btnCreateMember.Name = "btnCreateMember";
            this.btnCreateMember.Size = new System.Drawing.Size(181, 46);
            this.btnCreateMember.TabIndex = 0;
            this.btnCreateMember.Text = "Create Member";
            this.btnCreateMember.UseVisualStyleBackColor = false;
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName.Location = new System.Drawing.Point(38, 48);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(52, 19);
            this.labName.TabIndex = 1;
            this.labName.Text = "Name";
            // 
            // labPhone
            // 
            this.labPhone.AutoSize = true;
            this.labPhone.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labPhone.Location = new System.Drawing.Point(38, 74);
            this.labPhone.Name = "labPhone";
            this.labPhone.Size = new System.Drawing.Size(55, 19);
            this.labPhone.TabIndex = 2;
            this.labPhone.Text = "Phone";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(123, 46);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 3;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(123, 74);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 22);
            this.txtPhone.TabIndex = 3;
            // 
            // labBirthday
            // 
            this.labBirthday.AutoSize = true;
            this.labBirthday.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labBirthday.Location = new System.Drawing.Point(38, 102);
            this.labBirthday.Name = "labBirthday";
            this.labBirthday.Size = new System.Drawing.Size(70, 19);
            this.labBirthday.TabIndex = 2;
            this.labBirthday.Text = "Birthday";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(123, 102);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 3;
            // 
            // txtShowMember
            // 
            this.txtShowMember.Location = new System.Drawing.Point(464, 73);
            this.txtShowMember.Name = "txtShowMember";
            this.txtShowMember.Size = new System.Drawing.Size(100, 22);
            this.txtShowMember.TabIndex = 4;
            // 
            // TestPractice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtShowMember);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.labBirthday);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labPhone);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.btnCreateMember);
            this.Name = "TestPractice";
            this.Text = "TestPractice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyStyledButton btnCreateMember;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labPhone;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label labBirthday;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtShowMember;
    }
}