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
            this.cboxIncome = new System.Windows.Forms.CheckedListBox();
            this.gboxExpense = new System.Windows.Forms.GroupBox();
            this.cboxExpense = new System.Windows.Forms.CheckedListBox();
            this.gboxIncome.SuspendLayout();
            this.gboxExpense.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxIncome
            // 
            this.gboxIncome.Controls.Add(this.cboxIncome);
            this.gboxIncome.Location = new System.Drawing.Point(12, 12);
            this.gboxIncome.Name = "gboxIncome";
            this.gboxIncome.Size = new System.Drawing.Size(273, 334);
            this.gboxIncome.TabIndex = 0;
            this.gboxIncome.TabStop = false;
            this.gboxIncome.Text = "Income";
            // 
            // cboxIncome
            // 
            this.cboxIncome.FormattingEnabled = true;
            this.cboxIncome.Location = new System.Drawing.Point(6, 24);
            this.cboxIncome.Name = "cboxIncome";
            this.cboxIncome.Size = new System.Drawing.Size(261, 304);
            this.cboxIncome.TabIndex = 0;
            // 
            // gboxExpense
            // 
            this.gboxExpense.Controls.Add(this.cboxExpense);
            this.gboxExpense.Location = new System.Drawing.Point(298, 12);
            this.gboxExpense.Name = "gboxExpense";
            this.gboxExpense.Size = new System.Drawing.Size(273, 334);
            this.gboxExpense.TabIndex = 1;
            this.gboxExpense.TabStop = false;
            this.gboxExpense.Text = "Expense";
            // 
            // cboxExpense
            // 
            this.cboxExpense.FormattingEnabled = true;
            this.cboxExpense.Location = new System.Drawing.Point(6, 24);
            this.cboxExpense.Name = "cboxExpense";
            this.cboxExpense.Size = new System.Drawing.Size(261, 304);
            this.cboxExpense.TabIndex = 1;
            // 
            // FormBudget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 358);
            this.Controls.Add(this.gboxExpense);
            this.Controls.Add(this.gboxIncome);
            this.Name = "FormBudget";
            this.Text = "FormBudget";
            this.gboxIncome.ResumeLayout(false);
            this.gboxExpense.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxIncome;
        private System.Windows.Forms.CheckedListBox cboxIncome;
        private System.Windows.Forms.GroupBox gboxExpense;
        private System.Windows.Forms.CheckedListBox cboxExpense;
    }
}