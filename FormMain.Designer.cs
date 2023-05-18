namespace project
{
    partial class FormMain
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
            this.Calender = new System.Windows.Forms.MonthCalendar();
            this.btnMonthlyReport = new System.Windows.Forms.Button();
            this.btnRecommend = new System.Windows.Forms.Button();
            this.btnBack2Login = new System.Windows.Forms.Button();
            this.gboxSchedular = new System.Windows.Forms.GroupBox();
            this.gboxBudget = new System.Windows.Forms.GroupBox();
            this.dgvIncome = new System.Windows.Forms.DataGridView();
            this.dgvScheduler = new System.Windows.Forms.DataGridView();
            this.dgvOutcome = new System.Windows.Forms.DataGridView();
            this.gboxSchedular.SuspendLayout();
            this.gboxBudget.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScheduler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutcome)).BeginInit();
            this.SuspendLayout();
            // 
            // Calender
            // 
            this.Calender.Location = new System.Drawing.Point(8, 9);
            this.Calender.Name = "Calender";
            this.Calender.TabIndex = 0;
            this.Calender.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Calender_DateChanged);
            // 
            // btnMonthlyReport
            // 
            this.btnMonthlyReport.Location = new System.Drawing.Point(45, 245);
            this.btnMonthlyReport.Name = "btnMonthlyReport";
            this.btnMonthlyReport.Size = new System.Drawing.Size(176, 69);
            this.btnMonthlyReport.TabIndex = 1;
            this.btnMonthlyReport.Text = "월별 리포트 보고서";
            this.btnMonthlyReport.UseVisualStyleBackColor = true;
            // 
            // btnRecommend
            // 
            this.btnRecommend.Location = new System.Drawing.Point(45, 333);
            this.btnRecommend.Name = "btnRecommend";
            this.btnRecommend.Size = new System.Drawing.Size(176, 69);
            this.btnRecommend.TabIndex = 2;
            this.btnRecommend.Text = "금융 상품 추천";
            this.btnRecommend.UseVisualStyleBackColor = true;
            this.btnRecommend.Click += new System.EventHandler(this.btnRecommend_Click);
            // 
            // btnBack2Login
            // 
            this.btnBack2Login.Location = new System.Drawing.Point(45, 424);
            this.btnBack2Login.Name = "btnBack2Login";
            this.btnBack2Login.Size = new System.Drawing.Size(176, 45);
            this.btnBack2Login.TabIndex = 3;
            this.btnBack2Login.Text = "로그아웃";
            this.btnBack2Login.UseVisualStyleBackColor = true;
            this.btnBack2Login.Click += new System.EventHandler(this.btnBack2Login_Click);
            // 
            // gboxSchedular
            // 
            this.gboxSchedular.Controls.Add(this.dgvScheduler);
            this.gboxSchedular.Location = new System.Drawing.Point(268, 9);
            this.gboxSchedular.Name = "gboxSchedular";
            this.gboxSchedular.Size = new System.Drawing.Size(377, 230);
            this.gboxSchedular.TabIndex = 4;
            this.gboxSchedular.TabStop = false;
            this.gboxSchedular.Text = "스케줄";
            this.gboxSchedular.Enter += new System.EventHandler(this.gboxSchedular_Enter);
            // 
            // gboxBudget
            // 
            this.gboxBudget.Controls.Add(this.dgvOutcome);
            this.gboxBudget.Controls.Add(this.dgvIncome);
            this.gboxBudget.Location = new System.Drawing.Point(268, 245);
            this.gboxBudget.Name = "gboxBudget";
            this.gboxBudget.Size = new System.Drawing.Size(377, 230);
            this.gboxBudget.TabIndex = 5;
            this.gboxBudget.TabStop = false;
            this.gboxBudget.Text = "가계부";
            this.gboxBudget.Enter += new System.EventHandler(this.gboxBudget_Enter);
            // 
            // dgvIncome
            // 
            this.dgvIncome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIncome.Location = new System.Drawing.Point(6, 15);
            this.dgvIncome.Name = "dgvIncome";
            this.dgvIncome.RowHeadersWidth = 51;
            this.dgvIncome.RowTemplate.Height = 27;
            this.dgvIncome.Size = new System.Drawing.Size(361, 99);
            this.dgvIncome.TabIndex = 0;
            // 
            // dgvScheduler
            // 
            this.dgvScheduler.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvScheduler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScheduler.Location = new System.Drawing.Point(6, 15);
            this.dgvScheduler.Name = "dgvScheduler";
            this.dgvScheduler.RowHeadersWidth = 51;
            this.dgvScheduler.RowTemplate.Height = 27;
            this.dgvScheduler.Size = new System.Drawing.Size(361, 207);
            this.dgvScheduler.TabIndex = 1;
            // 
            // dgvOutcome
            // 
            this.dgvOutcome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOutcome.Location = new System.Drawing.Point(6, 125);
            this.dgvOutcome.Name = "dgvOutcome";
            this.dgvOutcome.RowHeadersWidth = 51;
            this.dgvOutcome.RowTemplate.Height = 27;
            this.dgvOutcome.Size = new System.Drawing.Size(361, 99);
            this.dgvOutcome.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 481);
            this.Controls.Add(this.gboxBudget);
            this.Controls.Add(this.gboxSchedular);
            this.Controls.Add(this.btnBack2Login);
            this.Controls.Add(this.btnRecommend);
            this.Controls.Add(this.btnMonthlyReport);
            this.Controls.Add(this.Calender);
            this.Name = "FormMain";
            this.Text = "Main";
            this.gboxSchedular.ResumeLayout(false);
            this.gboxBudget.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScheduler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutcome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar Calender;
        private System.Windows.Forms.Button btnMonthlyReport;
        private System.Windows.Forms.Button btnRecommend;
        private System.Windows.Forms.Button btnBack2Login;
        private System.Windows.Forms.GroupBox gboxSchedular;
        private System.Windows.Forms.GroupBox gboxBudget;
        private System.Windows.Forms.DataGridView dgvScheduler;
        private System.Windows.Forms.DataGridView dgvOutcome;
        private System.Windows.Forms.DataGridView dgvIncome;
    }
}