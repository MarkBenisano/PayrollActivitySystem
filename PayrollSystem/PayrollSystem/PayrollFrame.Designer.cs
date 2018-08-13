namespace PayrollSystem
{
    partial class PayrollFrame
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.interestRateTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salaryLoanComputationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grp = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.grp.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.interestRateTableToolStripMenuItem,
            this.salaryLoanComputationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // interestRateTableToolStripMenuItem
            // 
            this.interestRateTableToolStripMenuItem.Name = "interestRateTableToolStripMenuItem";
            this.interestRateTableToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.interestRateTableToolStripMenuItem.Text = "Interest Rate Table";
            this.interestRateTableToolStripMenuItem.Click += new System.EventHandler(this.interestRateTableToolStripMenuItem_Click);
            // 
            // salaryLoanComputationToolStripMenuItem
            // 
            this.salaryLoanComputationToolStripMenuItem.Name = "salaryLoanComputationToolStripMenuItem";
            this.salaryLoanComputationToolStripMenuItem.Size = new System.Drawing.Size(153, 20);
            this.salaryLoanComputationToolStripMenuItem.Text = "Salary Loan Computation";
            this.salaryLoanComputationToolStripMenuItem.Click += new System.EventHandler(this.salaryLoanComputationToolStripMenuItem_Click);
            // 
            // grp
            // 
            this.grp.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.grp.Controls.Add(this.label3);
            this.grp.Controls.Add(this.label2);
            this.grp.Controls.Add(this.label1);
            this.grp.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grp.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.grp.Location = new System.Drawing.Point(23, 45);
            this.grp.Name = "grp";
            this.grp.Size = new System.Drawing.Size(236, 173);
            this.grp.TabIndex = 3;
            this.grp.TabStop = false;
            this.grp.Text = "Note>>>";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Government Taxes are not";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = " included in the";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(16, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Deduction.";
            // 
            // PayrollFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.grp);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "PayrollFrame";
            this.Text = "PayrollFrame";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grp.ResumeLayout(false);
            this.grp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem interestRateTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salaryLoanComputationToolStripMenuItem;
        private System.Windows.Forms.GroupBox grp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}