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
            this.btnTanary.Location = new System.Drawing.Point(25, 99);
            this.btnTanary.Name = "btnTanary";
            this.btnTanary.Size = new System.Drawing.Size(243, 40);
            this.btnTanary.TabIndex = 0;
            this.btnTanary.Text = "Tenaray Operator ? :";
            this.btnTanary.UseVisualStyleBackColor = false;
            this.btnTanary.Click += new System.EventHandler(this.btnTenary_Click);
            // 
            // Frm_M17_Operator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTanary);
            this.Controls.Add(this.btnReverse);
            this.Name = "Frm_M17_Operator";
            this.Text = "Frm_M17_Operator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.Button btnTanary;
    }
}