namespace project
{
    partial class FormR
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chartReport = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.rbtnIncome = new System.Windows.Forms.RadioButton();
            this.rbtnOutcome = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lblMonth = new System.Windows.Forms.Label();
            this.cboxYear = new System.Windows.Forms.ComboBox();
            this.cboxMonth = new System.Windows.Forms.ComboBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.max_i = new System.Windows.Forms.Label();
            this.max_o = new System.Windows.Forms.Label();
            this.comparison1 = new System.Windows.Forms.Label();
            this.lblMaxIncome = new System.Windows.Forms.Label();
            this.lblMaxOutcome = new System.Windows.Forms.Label();
            this.lblComparison = new System.Windows.Forms.Label();
            this.comparison2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartReport)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 379F));
            this.tableLayoutPanel1.Controls.Add(this.chartReport, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 114);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(373, 341);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // chartReport
            // 
            chartArea2.Name = "ChartArea1";
            this.chartReport.ChartAreas.Add(chartArea2);
            this.chartReport.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartReport.Legends.Add(legend2);
            this.chartReport.Location = new System.Drawing.Point(4, 55);
            this.chartReport.Name = "chartReport";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartReport.Series.Add(series2);
            this.chartReport.Size = new System.Drawing.Size(373, 282);
            this.chartReport.TabIndex = 1;
            this.chartReport.Text = "chart";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTitle.Location = new System.Drawing.Point(59, 33);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(290, 33);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "<Monthly Report>";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblDate.Location = new System.Drawing.Point(5, 4);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(82, 19);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "[ date ]";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(153, 461);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(81, 23);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // rbtnIncome
            // 
            this.rbtnIncome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtnIncome.AutoSize = true;
            this.rbtnIncome.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rbtnIncome.Location = new System.Drawing.Point(3, 3);
            this.rbtnIncome.Name = "rbtnIncome";
            this.rbtnIncome.Size = new System.Drawing.Size(180, 43);
            this.rbtnIncome.TabIndex = 2;
            this.rbtnIncome.TabStop = true;
            this.rbtnIncome.Text = "Income";
            this.rbtnIncome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtnIncome.UseVisualStyleBackColor = true;
            this.rbtnIncome.CheckedChanged += new System.EventHandler(this.rbtnIncome_CheckedChanged);
            // 
            // rbtnOutcome
            // 
            this.rbtnOutcome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtnOutcome.AutoSize = true;
            this.rbtnOutcome.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rbtnOutcome.Location = new System.Drawing.Point(189, 3);
            this.rbtnOutcome.Name = "rbtnOutcome";
            this.rbtnOutcome.Size = new System.Drawing.Size(181, 43);
            this.rbtnOutcome.TabIndex = 3;
            this.rbtnOutcome.TabStop = true;
            this.rbtnOutcome.Text = "Outcome";
            this.rbtnOutcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtnOutcome.UseVisualStyleBackColor = true;
            this.rbtnOutcome.CheckedChanged += new System.EventHandler(this.rbtnOutcome_CheckedChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.rbtnIncome, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.rbtnOutcome, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 114);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(373, 49);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.50867F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.49133F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableLayoutPanel4.Controls.Add(this.lblMonth, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.cboxYear, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.cboxMonth, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblYear, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(12, 80);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(373, 31);
            this.tableLayoutPanel4.TabIndex = 9;
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMonth.Location = new System.Drawing.Point(180, 0);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(93, 31);
            this.lblMonth.TabIndex = 3;
            this.lblMonth.Text = "Month";
            this.lblMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboxYear
            // 
            this.cboxYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboxYear.FormattingEnabled = true;
            this.cboxYear.Location = new System.Drawing.Point(82, 3);
            this.cboxYear.Name = "cboxYear";
            this.cboxYear.Size = new System.Drawing.Size(92, 23);
            this.cboxYear.TabIndex = 0;
            // 
            // cboxMonth
            // 
            this.cboxMonth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboxMonth.FormattingEnabled = true;
            this.cboxMonth.Location = new System.Drawing.Point(279, 3);
            this.cboxMonth.Name = "cboxMonth";
            this.cboxMonth.Size = new System.Drawing.Size(91, 23);
            this.cboxMonth.TabIndex = 1;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblYear.Location = new System.Drawing.Point(3, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(73, 31);
            this.lblYear.TabIndex = 2;
            this.lblYear.Text = "Year";
            this.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // max_i
            // 
            this.max_i.AutoSize = true;
            this.max_i.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.max_i.Location = new System.Drawing.Point(423, 151);
            this.max_i.Name = "max_i";
            this.max_i.Size = new System.Drawing.Size(69, 24);
            this.max_i.TabIndex = 10;
            this.max_i.Text = "label1";
            // 
            // max_o
            // 
            this.max_o.AutoSize = true;
            this.max_o.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.max_o.Location = new System.Drawing.Point(423, 268);
            this.max_o.Name = "max_o";
            this.max_o.Size = new System.Drawing.Size(69, 24);
            this.max_o.TabIndex = 11;
            this.max_o.Text = "label2";
            // 
            // comparison1
            // 
            this.comparison1.AutoSize = true;
            this.comparison1.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comparison1.Location = new System.Drawing.Point(425, 389);
            this.comparison1.Name = "comparison1";
            this.comparison1.Size = new System.Drawing.Size(69, 24);
            this.comparison1.TabIndex = 12;
            this.comparison1.Text = "label3";
            // 
            // lblMaxIncome
            // 
            this.lblMaxIncome.AutoSize = true;
            this.lblMaxIncome.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMaxIncome.Location = new System.Drawing.Point(423, 114);
            this.lblMaxIncome.Name = "lblMaxIncome";
            this.lblMaxIncome.Size = new System.Drawing.Size(109, 19);
            this.lblMaxIncome.TabIndex = 0;
            this.lblMaxIncome.Text = "Max Income";
            // 
            // lblMaxOutcome
            // 
            this.lblMaxOutcome.AutoSize = true;
            this.lblMaxOutcome.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMaxOutcome.Location = new System.Drawing.Point(423, 234);
            this.lblMaxOutcome.Name = "lblMaxOutcome";
            this.lblMaxOutcome.Size = new System.Drawing.Size(124, 19);
            this.lblMaxOutcome.TabIndex = 1;
            this.lblMaxOutcome.Text = "Max Outcome";
            // 
            // lblComparison
            // 
            this.lblComparison.AutoSize = true;
            this.lblComparison.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblComparison.Location = new System.Drawing.Point(425, 352);
            this.lblComparison.Name = "lblComparison";
            this.lblComparison.Size = new System.Drawing.Size(107, 19);
            this.lblComparison.TabIndex = 2;
            this.lblComparison.Text = "Comparison";
            // 
            // comparison2
            // 
            this.comparison2.AutoSize = true;
            this.comparison2.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comparison2.Location = new System.Drawing.Point(425, 413);
            this.comparison2.Name = "comparison2";
            this.comparison2.Size = new System.Drawing.Size(69, 24);
            this.comparison2.TabIndex = 13;
            this.comparison2.Text = "label3";
            // 
            // FormR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 494);
            this.Controls.Add(this.comparison2);
            this.Controls.Add(this.lblComparison);
            this.Controls.Add(this.max_o);
            this.Controls.Add(this.lblMaxOutcome);
            this.Controls.Add(this.max_i);
            this.Controls.Add(this.lblMaxIncome);
            this.Controls.Add(this.comparison1);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormR";
            this.Text = "월별 리포트 보고서";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartReport)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartReport;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.RadioButton rbtnOutcome;
        private System.Windows.Forms.RadioButton rbtnIncome;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.ComboBox cboxYear;
        private System.Windows.Forms.ComboBox cboxMonth;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label max_i;
        private System.Windows.Forms.Label max_o;
        private System.Windows.Forms.Label comparison1;
        private System.Windows.Forms.Label lblMaxIncome;
        private System.Windows.Forms.Label lblMaxOutcome;
        private System.Windows.Forms.Label lblComparison;
        private System.Windows.Forms.Label comparison2;
    }
}

