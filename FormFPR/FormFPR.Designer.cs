namespace FormFPR
{
    partial class FormFPR
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.pboxCard = new System.Windows.Forms.PictureBox();
            this.lblImage = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.annualFee = new System.Windows.Forms.Label();
            this.monthlyUsage = new System.Windows.Forms.Label();
            this.cB_annualFee = new System.Windows.Forms.ComboBox();
            this.cB_monthlyUsage = new System.Windows.Forms.ComboBox();
            this.webCard = new System.Windows.Forms.TextBox();
            this.tB1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboxCard)).BeginInit();
            this.SuspendLayout();
            // 
            // pboxCard
            // 
            this.pboxCard.Location = new System.Drawing.Point(12, 12);
            this.pboxCard.Name = "pboxCard";
            this.pboxCard.Size = new System.Drawing.Size(263, 186);
            this.pboxCard.TabIndex = 1;
            this.pboxCard.TabStop = false;
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Location = new System.Drawing.Point(53, 201);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(164, 15);
            this.lblImage.TabIndex = 2;
            this.lblImage.Text = "<Recommend Product>";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(368, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(298, 25);
            this.textBox2.TabIndex = 5;
            // 
            // annualFee
            // 
            this.annualFee.AutoSize = true;
            this.annualFee.Location = new System.Drawing.Point(365, 60);
            this.annualFee.Name = "annualFee";
            this.annualFee.Size = new System.Drawing.Size(52, 15);
            this.annualFee.TabIndex = 6;
            this.annualFee.Text = "연회비";
            // 
            // monthlyUsage
            // 
            this.monthlyUsage.AutoSize = true;
            this.monthlyUsage.Location = new System.Drawing.Point(365, 104);
            this.monthlyUsage.Name = "monthlyUsage";
            this.monthlyUsage.Size = new System.Drawing.Size(72, 15);
            this.monthlyUsage.TabIndex = 7;
            this.monthlyUsage.Text = "월 사용액";
            // 
            // cB_annualFee
            // 
            this.cB_annualFee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cB_annualFee.FormattingEnabled = true;
            this.cB_annualFee.Items.AddRange(new object[] {
            "all",
            "~10000",
            "~30000",
            "~100000",
            "10000~"});
            this.cB_annualFee.Location = new System.Drawing.Point(469, 52);
            this.cB_annualFee.Name = "cB_annualFee";
            this.cB_annualFee.Size = new System.Drawing.Size(127, 23);
            this.cB_annualFee.TabIndex = 8;
            this.cB_annualFee.SelectedIndexChanged += new System.EventHandler(this.cB_annualFee_SelectedIndexChanged);
            // 
            // cB_monthlyUsage
            // 
            this.cB_monthlyUsage.FormattingEnabled = true;
            this.cB_monthlyUsage.Items.AddRange(new object[] {
            "all",
            "~30000",
            "~50000"});
            this.cB_monthlyUsage.Location = new System.Drawing.Point(469, 96);
            this.cB_monthlyUsage.Name = "cB_monthlyUsage";
            this.cB_monthlyUsage.Size = new System.Drawing.Size(127, 23);
            this.cB_monthlyUsage.TabIndex = 9;
            this.cB_monthlyUsage.SelectedIndexChanged += new System.EventHandler(this.cB_monthlyUsage_SelectedIndexChanged);
            // 
            // webCard
            // 
            this.webCard.Location = new System.Drawing.Point(12, 236);
            this.webCard.Multiline = true;
            this.webCard.Name = "webCard";
            this.webCard.Size = new System.Drawing.Size(710, 267);
            this.webCard.TabIndex = 0;
            // 
            // tB1
            // 
            this.tB1.Location = new System.Drawing.Point(385, 161);
            this.tB1.Name = "tB1";
            this.tB1.Size = new System.Drawing.Size(183, 25);
            this.tB1.TabIndex = 10;
            // 
            // FormFPR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 515);
            this.Controls.Add(this.tB1);
            this.Controls.Add(this.cB_monthlyUsage);
            this.Controls.Add(this.cB_annualFee);
            this.Controls.Add(this.monthlyUsage);
            this.Controls.Add(this.annualFee);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.pboxCard);
            this.Controls.Add(this.webCard);
            this.Name = "FormFPR";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormFPR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pboxCard;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label annualFee;
        private System.Windows.Forms.Label monthlyUsage;
        private System.Windows.Forms.ComboBox cB_annualFee;
        private System.Windows.Forms.ComboBox cB_monthlyUsage;
        private System.Windows.Forms.TextBox webCard;
        private System.Windows.Forms.TextBox tB1;
    }
}

