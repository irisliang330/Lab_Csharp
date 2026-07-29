namespace Lab_Form
{
    partial class Frm_M17_Operator
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
            this.btnReverse = new System.Windows.Forms.Button();
            this.btnTanary = new System.Windows.Forms.Button();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.btnGrade = new System.Windows.Forms.Button();
            this.labGrade = new System.Windows.Forms.Label();
            this.btnWhile = new System.Windows.Forms.Button();
            this.btnDoWhile = new System.Windows.Forms.Button();
            this.btnFor01 = new System.Windows.Forms.Button();
            this.btnFor02 = new System.Windows.Forms.Button();
            this.btnForeach = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReverse
            // 
            this.btnReverse.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnReverse.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReverse.ForeColor = System.Drawing.SystemColors.Info;
            this.btnReverse.Location = new System.Drawing.Point(25, 25);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(89, 40);
            this.btnReverse.TabIndex = 0;
            this.btnReverse.Text = "!";
            this.btnReverse.UseVisualStyleBackColor = false;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // btnTanary
            // 
            this.btnTanary.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnTanary.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTanary.ForeColor = System.Drawing.SystemColors.Info;
            this.btnTanary.Location = new System.Drawing.Point(25, 85);
            this.btnTanary.Name = "btnTanary";
            this.btnTanary.Size = new System.Drawing.Size(243, 40);
            this.btnTanary.TabIndex = 0;
            this.btnTanary.Text = "Tenaray Operator ? :";
            this.btnTanary.UseVisualStyleBackColor = false;
            this.btnTanary.Click += new System.EventHandler(this.btnTenary_Click);
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(367, 25);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(100, 22);
            this.txtScore.TabIndex = 1;
            // 
            // btnGrade
            // 
            this.btnGrade.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnGrade.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnGrade.ForeColor = System.Drawing.SystemColors.Info;
            this.btnGrade.Location = new System.Drawing.Point(367, 55);
            this.btnGrade.Name = "btnGrade";
            this.btnGrade.Size = new System.Drawing.Size(89, 40);
            this.btnGrade.TabIndex = 0;
            this.btnGrade.Text = "分級";
            this.btnGrade.UseVisualStyleBackColor = false;
            this.btnGrade.Click += new System.EventHandler(this.btnGrade_Click);
            // 
            // labGrade
            // 
            this.labGrade.AutoSize = true;
            this.labGrade.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labGrade.Location = new System.Drawing.Point(473, 69);
            this.labGrade.Name = "labGrade";
            this.labGrade.Size = new System.Drawing.Size(96, 26);
            this.labGrade.TabIndex = 2;
            this.labGrade.Text = "成績分級";
            // 
            // btnWhile
            // 
            this.btnWhile.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnWhile.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnWhile.ForeColor = System.Drawing.SystemColors.Info;
            this.btnWhile.Location = new System.Drawing.Point(367, 155);
            this.btnWhile.Name = "btnWhile";
            this.btnWhile.Size = new System.Drawing.Size(89, 40);
            this.btnWhile.TabIndex = 0;
            this.btnWhile.Text = "While";
            this.btnWhile.UseVisualStyleBackColor = false;
            this.btnWhile.Click += new System.EventHandler(this.btnWhile_Click);
            // 
            // btnDoWhile
            // 
            this.btnDoWhile.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnDoWhile.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDoWhile.ForeColor = System.Drawing.SystemColors.Info;
            this.btnDoWhile.Location = new System.Drawing.Point(367, 215);
            this.btnDoWhile.Name = "btnDoWhile";
            this.btnDoWhile.Size = new System.Drawing.Size(89, 40);
            this.btnDoWhile.TabIndex = 0;
            this.btnDoWhile.Text = "Do While";
            this.btnDoWhile.UseVisualStyleBackColor = false;
            this.btnDoWhile.Click += new System.EventHandler(this.btnDoWhile_Click);
            // 
            // btnFor01
            // 
            this.btnFor01.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnFor01.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnFor01.ForeColor = System.Drawing.SystemColors.Info;
            this.btnFor01.Location = new System.Drawing.Point(500, 155);
            this.btnFor01.Name = "btnFor01";
            this.btnFor01.Size = new System.Drawing.Size(89, 40);
            this.btnFor01.TabIndex = 0;
            this.btnFor01.Text = "For 01";
            this.btnFor01.UseVisualStyleBackColor = false;
            this.btnFor01.Click += new System.EventHandler(this.btnFor01_Click);
            // 
            // btnFor02
            // 
            this.btnFor02.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnFor02.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnFor02.ForeColor = System.Drawing.SystemColors.Info;
            this.btnFor02.Location = new System.Drawing.Point(500, 215);
            this.btnFor02.Name = "btnFor02";
            this.btnFor02.Size = new System.Drawing.Size(89, 40);
            this.btnFor02.TabIndex = 0;
            this.btnFor02.Text = "For 02";
            this.btnFor02.UseVisualStyleBackColor = false;
            this.btnFor02.Click += new System.EventHandler(this.btnFor02_Click);
            // 
            // btnForeach
            // 
            this.btnForeach.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnForeach.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnForeach.ForeColor = System.Drawing.SystemColors.Info;
            this.btnForeach.Location = new System.Drawing.Point(500, 283);
            this.btnForeach.Name = "btnForeach";
            this.btnForeach.Size = new System.Drawing.Size(89, 40);
            this.btnForeach.TabIndex = 0;
            this.btnForeach.Text = "foreach";
            this.btnForeach.UseVisualStyleBackColor = false;
            this.btnForeach.Click += new System.EventHandler(this.btnForeach_Click);
            // 
            // Frm_M17_Operator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labGrade);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.btnTanary);
            this.Controls.Add(this.btnDoWhile);
            this.Controls.Add(this.btnForeach);
            this.Controls.Add(this.btnFor02);
            this.Controls.Add(this.btnFor01);
            this.Controls.Add(this.btnWhile);
            this.Controls.Add(this.btnGrade);
            this.Controls.Add(this.btnReverse);
            this.Name = "Frm_M17_Operator";
            this.Text = "Frm_M17_Operator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.Button btnTanary;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Button btnGrade;
        private System.Windows.Forms.Label labGrade;
        private System.Windows.Forms.Button btnWhile;
        private System.Windows.Forms.Button btnDoWhile;
        private System.Windows.Forms.Button btnFor01;
        private System.Windows.Forms.Button btnFor02;
        private System.Windows.Forms.Button btnForeach;
    }
}