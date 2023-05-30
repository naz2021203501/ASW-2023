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
            this.dgv_income = new System.Windows.Forms.DataGridView();
            this.gboxExpense = new System.Windows.Forms.GroupBox();
            this.dgv_outcome = new System.Windows.Forms.DataGridView();
            this.txtD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.a_btn = new System.Windows.Forms.Button();
            this.m_btn = new System.Windows.Forms.Button();
            this.d_btn = new System.Windows.Forms.Button();
            this.income_btn = new System.Windows.Forms.RadioButton();
            this.outcome_btn = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.gboxIncome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_income)).BeginInit();
            this.gboxExpense.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_outcome)).BeginInit();
            this.SuspendLayout();
            // 
            // gboxIncome
            // 
            this.gboxIncome.Controls.Add(this.dgv_income);
            this.gboxIncome.Location = new System.Drawing.Point(12, 39);
            this.gboxIncome.Name = "gboxIncome";
            this.gboxIncome.Size = new System.Drawing.Size(273, 257);
            this.gboxIncome.TabIndex = 0;
            this.gboxIncome.TabStop = false;
            this.gboxIncome.Text = "Income";
            // 
            // dgv_income
            // 
            this.dgv_income.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_income.Location = new System.Drawing.Point(7, 22);
            this.dgv_income.Name = "dgv_income";
            this.dgv_income.RowHeadersWidth = 51;
            this.dgv_income.RowTemplate.Height = 27;
            this.dgv_income.Size = new System.Drawing.Size(260, 229);
            this.dgv_income.TabIndex = 12;
            // 
            // gboxExpense
            // 
            this.gboxExpense.Controls.Add(this.dgv_outcome);
            this.gboxExpense.Location = new System.Drawing.Point(298, 39);
            this.gboxExpense.Name = "gboxExpense";
            this.gboxExpense.Size = new System.Drawing.Size(273, 257);
            this.gboxExpense.TabIndex = 1;
            this.gboxExpense.TabStop = false;
            this.gboxExpense.Text = "Expense";
            // 
            // dgv_outcome
            // 
            this.dgv_outcome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_outcome.Location = new System.Drawing.Point(7, 22);
            this.dgv_outcome.Name = "dgv_outcome";
            this.dgv_outcome.RowHeadersWidth = 51;
            this.dgv_outcome.RowTemplate.Height = 27;
            this.dgv_outcome.Size = new System.Drawing.Size(260, 229);
            this.dgv_outcome.TabIndex = 13;
            // 
            // txtD
            // 
            this.txtD.Location = new System.Drawing.Point(56, 345);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(273, 25);
            this.txtD.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "내역";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "금액";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(392, 345);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(154, 25);
            this.txtA.TabIndex = 5;
            // 
            // a_btn
            // 
            this.a_btn.Location = new System.Drawing.Point(33, 390);
            this.a_btn.Name = "a_btn";
            this.a_btn.Size = new System.Drawing.Size(147, 40);
            this.a_btn.TabIndex = 6;
            this.a_btn.Text = "추가";
            this.a_btn.UseVisualStyleBackColor = true;
            this.a_btn.Click += new System.EventHandler(this.a_btn_Click);
            // 
            // m_btn
            // 
            this.m_btn.Location = new System.Drawing.Point(214, 390);
            this.m_btn.Name = "m_btn";
            this.m_btn.Size = new System.Drawing.Size(147, 40);
            this.m_btn.TabIndex = 7;
            this.m_btn.Text = "수정";
            this.m_btn.UseVisualStyleBackColor = true;
            this.m_btn.Click += new System.EventHandler(this.m_btn_Click);
            // 
            // d_btn
            // 
            this.d_btn.Location = new System.Drawing.Point(392, 390);
            this.d_btn.Name = "d_btn";
            this.d_btn.Size = new System.Drawing.Size(147, 40);
            this.d_btn.TabIndex = 8;
            this.d_btn.Text = "삭제";
            this.d_btn.UseVisualStyleBackColor = true;
            this.d_btn.Click += new System.EventHandler(this.d_btn_Click);
            // 
            // income_btn
            // 
            this.income_btn.AutoSize = true;
            this.income_btn.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.income_btn.Location = new System.Drawing.Point(30, 309);
            this.income_btn.Name = "income_btn";
            this.income_btn.Size = new System.Drawing.Size(63, 21);
            this.income_btn.TabIndex = 9;
            this.income_btn.TabStop = true;
            this.income_btn.Text = "수입";
            this.income_btn.UseVisualStyleBackColor = true;
            // 
            // outcome_btn
            // 
            this.outcome_btn.AutoSize = true;
            this.outcome_btn.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.outcome_btn.Location = new System.Drawing.Point(99, 309);
            this.outcome_btn.Name = "outcome_btn";
            this.outcome_btn.Size = new System.Drawing.Size(63, 21);
            this.outcome_btn.TabIndex = 10;
            this.outcome_btn.TabStop = true;
            this.outcome_btn.Text = "지출";
            this.outcome_btn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(231, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "label3";
            // 
            // FormBudget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 448);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.outcome_btn);
            this.Controls.Add(this.income_btn);
            this.Controls.Add(this.d_btn);
            this.Controls.Add(this.m_btn);
            this.Controls.Add(this.a_btn);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtD);
            this.Controls.Add(this.gboxExpense);
            this.Controls.Add(this.gboxIncome);
            this.Name = "FormBudget";
            this.Text = "FormBudget";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormBudget_FormClosing);
            this.gboxIncome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_income)).EndInit();
            this.gboxExpense.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_outcome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxIncome;
        private System.Windows.Forms.GroupBox gboxExpense;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Button a_btn;
        private System.Windows.Forms.Button m_btn;
        private System.Windows.Forms.Button d_btn;
        private System.Windows.Forms.RadioButton income_btn;
        private System.Windows.Forms.RadioButton outcome_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_income;
        private System.Windows.Forms.DataGridView dgv_outcome;
    }
}