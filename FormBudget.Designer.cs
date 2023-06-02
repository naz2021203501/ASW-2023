namespace project
{
    partial class FormBudget
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
            this.gboxIncome = new System.Windows.Forms.GroupBox();
            this.pnlIncome = new System.Windows.Forms.FlowLayoutPanel();
            this.btnIPlus = new System.Windows.Forms.Button();
            this.gboxOutcome = new System.Windows.Forms.GroupBox();
            this.pnlOutcome = new System.Windows.Forms.FlowLayoutPanel();
            this.btnOPlus = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.gboxIncome.SuspendLayout();
            this.gboxOutcome.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxIncome
            // 
            this.gboxIncome.Controls.Add(this.pnlIncome);
            this.gboxIncome.Controls.Add(this.btnIPlus);
            this.gboxIncome.Location = new System.Drawing.Point(12, 71);
            this.gboxIncome.Name = "gboxIncome";
            this.gboxIncome.Size = new System.Drawing.Size(409, 377);
            this.gboxIncome.TabIndex = 0;
            this.gboxIncome.TabStop = false;
            this.gboxIncome.Text = "Income";
            // 
            // pnlIncome
            // 
            this.pnlIncome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlIncome.AutoScroll = true;
            this.pnlIncome.Location = new System.Drawing.Point(13, 58);
            this.pnlIncome.Name = "pnlIncome";
            this.pnlIncome.Size = new System.Drawing.Size(387, 313);
            this.pnlIncome.TabIndex = 1;
            // 
            // btnIPlus
            // 
            this.btnIPlus.Location = new System.Drawing.Point(360, 15);
            this.btnIPlus.Name = "btnIPlus";
            this.btnIPlus.Size = new System.Drawing.Size(40, 37);
            this.btnIPlus.TabIndex = 0;
            this.btnIPlus.Text = "+";
            this.btnIPlus.UseVisualStyleBackColor = true;
            this.btnIPlus.Click += new System.EventHandler(this.btnIPlus_Click);
            // 
            // gboxOutcome
            // 
            this.gboxOutcome.Controls.Add(this.pnlOutcome);
            this.gboxOutcome.Controls.Add(this.btnOPlus);
            this.gboxOutcome.Location = new System.Drawing.Point(427, 71);
            this.gboxOutcome.Name = "gboxOutcome";
            this.gboxOutcome.Size = new System.Drawing.Size(409, 377);
            this.gboxOutcome.TabIndex = 1;
            this.gboxOutcome.TabStop = false;
            this.gboxOutcome.Text = "Outcome";
            // 
            // pnlOutcome
            // 
            this.pnlOutcome.AutoScroll = true;
            this.pnlOutcome.Location = new System.Drawing.Point(16, 58);
            this.pnlOutcome.Name = "pnlOutcome";
            this.pnlOutcome.Size = new System.Drawing.Size(387, 313);
            this.pnlOutcome.TabIndex = 2;
            // 
            // btnOPlus
            // 
            this.btnOPlus.Location = new System.Drawing.Point(363, 15);
            this.btnOPlus.Name = "btnOPlus";
            this.btnOPlus.Size = new System.Drawing.Size(40, 37);
            this.btnOPlus.TabIndex = 1;
            this.btnOPlus.Text = "+";
            this.btnOPlus.UseVisualStyleBackColor = true;
            this.btnOPlus.Click += new System.EventHandler(this.btnOPlus_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(22, 28);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(72, 15);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "해당 날짜";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(761, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 59);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FormBudget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 454);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.gboxOutcome);
            this.Controls.Add(this.gboxIncome);
            this.Name = "FormBudget";
            this.Text = "FormBudget";
            this.gboxIncome.ResumeLayout(false);
            this.gboxOutcome.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxIncome;
        private System.Windows.Forms.GroupBox gboxOutcome;
        private System.Windows.Forms.Button btnIPlus;
        private System.Windows.Forms.Button btnOPlus;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.FlowLayoutPanel pnlIncome;
        private System.Windows.Forms.FlowLayoutPanel pnlOutcome;
    }
}