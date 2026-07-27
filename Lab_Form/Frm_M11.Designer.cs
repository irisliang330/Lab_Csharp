namespace Lab_Form
{
    partial class Frm_M11
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
            this.btnCount = new System.Windows.Forms.Button();
            this.labCount = new System.Windows.Forms.Label();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnRemainder = new System.Windows.Forms.Button();
            this.btnPre = new System.Windows.Forms.Button();
            this.labPre = new System.Windows.Forms.Label();
            this.labPost = new System.Windows.Forms.Label();
            this.btnPost = new System.Windows.Forms.Button();
            this.labPostCount = new System.Windows.Forms.Label();
            this.labPreCount = new System.Windows.Forms.Label();
            this.labStaticCount = new System.Windows.Forms.Label();
            this.labInstanceCount = new System.Windows.Forms.Label();
            this.btnStatic = new System.Windows.Forms.Button();
            this.btnInstance = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCount
            // 
            this.btnCount.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCount.Location = new System.Drawing.Point(115, 164);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(75, 23);
            this.btnCount.TabIndex = 0;
            this.btnCount.Text = "+=";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // labCount
            // 
            this.labCount.AutoSize = true;
            this.labCount.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labCount.Location = new System.Drawing.Point(115, 131);
            this.labCount.Name = "labCount";
            this.labCount.Size = new System.Drawing.Size(70, 19);
            this.labCount.TabIndex = 1;
            this.labCount.Text = "Count: 0";
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMinus.Location = new System.Drawing.Point(115, 193);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(75, 23);
            this.btnMinus.TabIndex = 2;
            this.btnMinus.Text = "-=";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnMulti
            // 
            this.btnMulti.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMulti.Location = new System.Drawing.Point(115, 222);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(75, 23);
            this.btnMulti.TabIndex = 3;
            this.btnMulti.Text = "*=";
            this.btnMulti.UseVisualStyleBackColor = true;
            this.btnMulti.Click += new System.EventHandler(this.btnMulti_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDivide.Location = new System.Drawing.Point(115, 251);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(75, 23);
            this.btnDivide.TabIndex = 4;
            this.btnDivide.Text = "/=";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnRemainder
            // 
            this.btnRemainder.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRemainder.Location = new System.Drawing.Point(115, 280);
            this.btnRemainder.Name = "btnRemainder";
            this.btnRemainder.Size = new System.Drawing.Size(75, 23);
            this.btnRemainder.TabIndex = 5;
            this.btnRemainder.Text = "%=";
            this.btnRemainder.UseVisualStyleBackColor = true;
            this.btnRemainder.Click += new System.EventHandler(this.btnRemainder_Click);
            // 
            // btnPre
            // 
            this.btnPre.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPre.Location = new System.Drawing.Point(259, 164);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(90, 23);
            this.btnPre.TabIndex = 6;
            this.btnPre.Text = "++count";
            this.btnPre.UseVisualStyleBackColor = true;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // labPre
            // 
            this.labPre.AutoSize = true;
            this.labPre.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labPre.Location = new System.Drawing.Point(355, 168);
            this.labPre.Name = "labPre";
            this.labPre.Size = new System.Drawing.Size(60, 19);
            this.labPre.TabIndex = 7;
            this.labPre.Text = "PreB: 0";
            // 
            // labPost
            // 
            this.labPost.AutoSize = true;
            this.labPost.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labPost.Location = new System.Drawing.Point(355, 197);
            this.labPost.Name = "labPost";
            this.labPost.Size = new System.Drawing.Size(68, 19);
            this.labPost.TabIndex = 9;
            this.labPost.Text = "PostB: 0";
            // 
            // btnPost
            // 
            this.btnPost.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPost.Location = new System.Drawing.Point(259, 193);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(90, 23);
            this.btnPost.TabIndex = 8;
            this.btnPost.Text = "count++";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // labPostCount
            // 
            this.labPostCount.AutoSize = true;
            this.labPostCount.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labPostCount.Location = new System.Drawing.Point(429, 197);
            this.labPostCount.Name = "labPostCount";
            this.labPostCount.Size = new System.Drawing.Size(106, 19);
            this.labPostCount.TabIndex = 11;
            this.labPostCount.Text = "PostCount : 0";
            // 
            // labPreCount
            // 
            this.labPreCount.AutoSize = true;
            this.labPreCount.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labPreCount.Location = new System.Drawing.Point(429, 168);
            this.labPreCount.Name = "labPreCount";
            this.labPreCount.Size = new System.Drawing.Size(98, 19);
            this.labPreCount.TabIndex = 10;
            this.labPreCount.Text = "PreCount : 0";
            // 
            // labStaticCount
            // 
            this.labStaticCount.AutoSize = true;
            this.labStaticCount.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labStaticCount.Location = new System.Drawing.Point(429, 323);
            this.labStaticCount.Name = "labStaticCount";
            this.labStaticCount.Size = new System.Drawing.Size(119, 19);
            this.labStaticCount.TabIndex = 15;
            this.labStaticCount.Text = "Static Count : 0";
            // 
            // labInstanceCount
            // 
            this.labInstanceCount.AutoSize = true;
            this.labInstanceCount.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labInstanceCount.Location = new System.Drawing.Point(429, 294);
            this.labInstanceCount.Name = "labInstanceCount";
            this.labInstanceCount.Size = new System.Drawing.Size(139, 19);
            this.labInstanceCount.TabIndex = 14;
            this.labInstanceCount.Text = "Instance Count : 0";
            // 
            // btnStatic
            // 
            this.btnStatic.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStatic.Location = new System.Drawing.Point(259, 319);
            this.btnStatic.Name = "btnStatic";
            this.btnStatic.Size = new System.Drawing.Size(132, 23);
            this.btnStatic.TabIndex = 13;
            this.btnStatic.Text = "Static var";
            this.btnStatic.UseVisualStyleBackColor = true;
            this.btnStatic.Click += new System.EventHandler(this.btnStatic_Click);
            // 
            // btnInstance
            // 
            this.btnInstance.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnInstance.Location = new System.Drawing.Point(259, 290);
            this.btnInstance.Name = "btnInstance";
            this.btnInstance.Size = new System.Drawing.Size(132, 23);
            this.btnInstance.TabIndex = 12;
            this.btnInstance.Text = "Instance var";
            this.btnInstance.UseVisualStyleBackColor = true;
            this.btnInstance.Click += new System.EventHandler(this.btnInstance_Click);
            // 
            // Frm_M11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labStaticCount);
            this.Controls.Add(this.labInstanceCount);
            this.Controls.Add(this.btnStatic);
            this.Controls.Add(this.btnInstance);
            this.Controls.Add(this.labPostCount);
            this.Controls.Add(this.labPreCount);
            this.Controls.Add(this.labPost);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.labPre);
            this.Controls.Add(this.btnPre);
            this.Controls.Add(this.btnRemainder);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMulti);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.labCount);
            this.Controls.Add(this.btnCount);
            this.Name = "Frm_M11";
            this.Text = "Frm_M11";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Label labCount;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnRemainder;
        private System.Windows.Forms.Button btnPre;
        private System.Windows.Forms.Label labPre;
        private System.Windows.Forms.Label labPost;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.Label labPostCount;
        private System.Windows.Forms.Label labPreCount;
        private System.Windows.Forms.Label labStaticCount;
        private System.Windows.Forms.Label labInstanceCount;
        private System.Windows.Forms.Button btnStatic;
        private System.Windows.Forms.Button btnInstance;
    }
}