namespace Lab_Csharp
{
    partial class Frm_M22_ArrayList
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
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.labEmployeeName = new System.Windows.Forms.Label();
            this.labEmployeeAge = new System.Windows.Forms.Label();
            this.txtEmployeeAge = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.labEmployeeData = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRemoveAt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEmployeeName.Location = new System.Drawing.Point(90, 63);
            this.txtEmployeeName.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(104, 25);
            this.txtEmployeeName.TabIndex = 0;
            // 
            // labEmployeeName
            // 
            this.labEmployeeName.AutoSize = true;
            this.labEmployeeName.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEmployeeName.Location = new System.Drawing.Point(9, 63);
            this.labEmployeeName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labEmployeeName.Name = "labEmployeeName";
            this.labEmployeeName.Size = new System.Drawing.Size(66, 17);
            this.labEmployeeName.TabIndex = 1;
            this.labEmployeeName.Text = "員工姓名: ";
            // 
            // labEmployeeAge
            // 
            this.labEmployeeAge.AutoSize = true;
            this.labEmployeeAge.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEmployeeAge.Location = new System.Drawing.Point(9, 103);
            this.labEmployeeAge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labEmployeeAge.Name = "labEmployeeAge";
            this.labEmployeeAge.Size = new System.Drawing.Size(66, 17);
            this.labEmployeeAge.TabIndex = 3;
            this.labEmployeeAge.Text = "員工年齡: ";
            // 
            // txtEmployeeAge
            // 
            this.txtEmployeeAge.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEmployeeAge.Location = new System.Drawing.Point(90, 103);
            this.txtEmployeeAge.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmployeeAge.Name = "txtEmployeeAge";
            this.txtEmployeeAge.Size = new System.Drawing.Size(104, 25);
            this.txtEmployeeAge.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAdd.Location = new System.Drawing.Point(208, 32);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(101, 31);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnShow.Location = new System.Drawing.Point(208, 294);
            this.btnShow.Margin = new System.Windows.Forms.Padding(2);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(101, 31);
            this.btnShow.TabIndex = 5;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            // 
            // labEmployeeData
            // 
            this.labEmployeeData.AutoSize = true;
            this.labEmployeeData.BackColor = System.Drawing.Color.LightSteelBlue;
            this.labEmployeeData.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEmployeeData.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labEmployeeData.Location = new System.Drawing.Point(407, 9);
            this.labEmployeeData.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labEmployeeData.Name = "labEmployeeData";
            this.labEmployeeData.Size = new System.Drawing.Size(69, 19);
            this.labEmployeeData.TabIndex = 6;
            this.labEmployeeData.Text = "員工資料";
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnInsert.Location = new System.Drawing.Point(208, 75);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(101, 31);
            this.btnInsert.TabIndex = 7;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClear.Location = new System.Drawing.Point(208, 119);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(101, 31);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnRemoveAt
            // 
            this.btnRemoveAt.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRemoveAt.Location = new System.Drawing.Point(208, 165);
            this.btnRemoveAt.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveAt.Name = "btnRemoveAt";
            this.btnRemoveAt.Size = new System.Drawing.Size(101, 31);
            this.btnRemoveAt.TabIndex = 9;
            this.btnRemoveAt.Text = "RemoveAt";
            this.btnRemoveAt.UseVisualStyleBackColor = true;
            // 
            // Frm_M22_ArrayList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.btnRemoveAt);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.labEmployeeData);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.labEmployeeAge);
            this.Controls.Add(this.txtEmployeeAge);
            this.Controls.Add(this.labEmployeeName);
            this.Controls.Add(this.txtEmployeeName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_M22_ArrayList";
            this.Text = "Frm_M22_ArrayList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label labEmployeeName;
        private System.Windows.Forms.Label labEmployeeAge;
        private System.Windows.Forms.TextBox txtEmployeeAge;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label labEmployeeData;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRemoveAt;
    }
}