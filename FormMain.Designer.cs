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
            this.lboxScheduler = new System.Windows.Forms.ListBox();
            this.gboxBudget = new System.Windows.Forms.GroupBox();
            this.lboxBudget = new System.Windows.Forms.ListBox();
            this.gboxSchedular.SuspendLayout();
            this.gboxBudget.SuspendLayout();
            this.SuspendLayout();
            // 
            // Calender
            // 
            this.Calender.Location = new System.Drawing.Point(18, 46);
            this.Calender.Name = "Calender";
            this.Calender.TabIndex = 0;
            // 
            // btnMonthlyReport
            // 
            this.btnMonthlyReport.Location = new System.Drawing.Point(18, 295);
            this.btnMonthlyReport.Name = "btnMonthlyReport";
            this.btnMonthlyReport.Size = new System.Drawing.Size(176, 45);
            this.btnMonthlyReport.TabIndex = 1;
            this.btnMonthlyReport.Text = "월별 리포트 보고서";
            this.btnMonthlyReport.UseVisualStyleBackColor = true;
            // 
            // btnRecommend
            // 
            this.btnRecommend.Location = new System.Drawing.Point(200, 295);
            this.btnRecommend.Name = "btnRecommend";
            this.btnRecommend.Size = new System.Drawing.Size(176, 45);
            this.btnRecommend.TabIndex = 2;
            this.btnRecommend.Text = "금융 상품 추천";
            this.btnRecommend.UseVisualStyleBackColor = true;
            this.btnRecommend.Click += new System.EventHandler(this.btnRecommend_Click);
            // 
            // btnBack2Login
            // 
            this.btnBack2Login.Location = new System.Drawing.Point(382, 295);
            this.btnBack2Login.Name = "btnBack2Login";
            this.btnBack2Login.Size = new System.Drawing.Size(176, 45);
            this.btnBack2Login.TabIndex = 3;
            this.btnBack2Login.Text = "로그아웃";
            this.btnBack2Login.UseVisualStyleBackColor = true;
            this.btnBack2Login.Click += new System.EventHandler(this.btnBack2Login_Click);
            // 
            // gboxSchedular
            // 
            this.gboxSchedular.Controls.Add(this.lboxScheduler);
            this.gboxSchedular.Location = new System.Drawing.Point(278, 29);
            this.gboxSchedular.Name = "gboxSchedular";
            this.gboxSchedular.Size = new System.Drawing.Size(280, 120);
            this.gboxSchedular.TabIndex = 4;
            this.gboxSchedular.TabStop = false;
            this.gboxSchedular.Text = "스케줄";
            this.gboxSchedular.Enter += new System.EventHandler(this.gboxSchedular_Enter);
            // 
            // lboxScheduler
            // 
            this.lboxScheduler.FormattingEnabled = true;
            this.lboxScheduler.ItemHeight = 15;
            this.lboxScheduler.Location = new System.Drawing.Point(6, 20);
            this.lboxScheduler.Name = "lboxScheduler";
            this.lboxScheduler.Size = new System.Drawing.Size(268, 94);
            this.lboxScheduler.TabIndex = 6;
            // 
            // gboxBudget
            // 
            this.gboxBudget.Controls.Add(this.lboxBudget);
            this.gboxBudget.Location = new System.Drawing.Point(278, 155);
            this.gboxBudget.Name = "gboxBudget";
            this.gboxBudget.Size = new System.Drawing.Size(280, 120);
            this.gboxBudget.TabIndex = 5;
            this.gboxBudget.TabStop = false;
            this.gboxBudget.Text = "가계부";
            this.gboxBudget.Enter += new System.EventHandler(this.gboxBudget_Enter);
            // 
            // lboxBudget
            // 
            this.lboxBudget.FormattingEnabled = true;
            this.lboxBudget.ItemHeight = 15;
            this.lboxBudget.Location = new System.Drawing.Point(6, 20);
            this.lboxBudget.Name = "lboxBudget";
            this.lboxBudget.Size = new System.Drawing.Size(268, 94);
            this.lboxBudget.TabIndex = 7;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 361);
            this.Controls.Add(this.gboxBudget);
            this.Controls.Add(this.gboxSchedular);
            this.Controls.Add(this.btnBack2Login);
            this.Controls.Add(this.btnRecommend);
            this.Controls.Add(this.btnMonthlyReport);
            this.Controls.Add(this.Calender);
            this.Name = "FormMain";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.gboxSchedular.ResumeLayout(false);
            this.gboxBudget.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar Calender;
        private System.Windows.Forms.Button btnMonthlyReport;
        private System.Windows.Forms.Button btnRecommend;
        private System.Windows.Forms.Button btnBack2Login;
        private System.Windows.Forms.GroupBox gboxSchedular;
        private System.Windows.Forms.GroupBox gboxBudget;
        private System.Windows.Forms.ListBox lboxScheduler;
        private System.Windows.Forms.ListBox lboxBudget;
    }
}