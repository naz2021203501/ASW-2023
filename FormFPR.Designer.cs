namespace project
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
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblAnnualFee = new System.Windows.Forms.Label();
            this.lblBasePayment = new System.Windows.Forms.Label();
            this.cboxAnnualFee = new System.Windows.Forms.ComboBox();
            this.cboxBasePayment = new System.Windows.Forms.ComboBox();
            this.gboxFPR = new System.Windows.Forms.GroupBox();
            this.txtProductBenefit = new System.Windows.Forms.TextBox();
            this.lblProductBenefits = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pboxCard)).BeginInit();
            this.gboxFPR.SuspendLayout();
            this.SuspendLayout();
            // 
            // pboxCard
            // 
            this.pboxCard.Location = new System.Drawing.Point(22, 21);
            this.pboxCard.Name = "pboxCard";
            this.pboxCard.Size = new System.Drawing.Size(263, 186);
            this.pboxCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxCard.TabIndex = 1;
            this.pboxCard.TabStop = false;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Enabled = false;
            this.lblProductName.Location = new System.Drawing.Point(81, 210);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(143, 15);
            this.lblProductName.TabIndex = 2;
            this.lblProductName.Text = "<Recommend Card>";
            this.lblProductName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAnnualFee
            // 
            this.lblAnnualFee.AutoSize = true;
            this.lblAnnualFee.Location = new System.Drawing.Point(47, 66);
            this.lblAnnualFee.Name = "lblAnnualFee";
            this.lblAnnualFee.Size = new System.Drawing.Size(80, 15);
            this.lblAnnualFee.TabIndex = 6;
            this.lblAnnualFee.Text = "Annual Fee";
            // 
            // lblBasePayment
            // 
            this.lblBasePayment.AutoSize = true;
            this.lblBasePayment.Location = new System.Drawing.Point(47, 110);
            this.lblBasePayment.Name = "lblBasePayment";
            this.lblBasePayment.Size = new System.Drawing.Size(103, 15);
            this.lblBasePayment.TabIndex = 7;
            this.lblBasePayment.Text = "Base Payment";
            // 
            // cboxAnnualFee
            // 
            this.cboxAnnualFee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxAnnualFee.FormattingEnabled = true;
            this.cboxAnnualFee.Items.AddRange(new object[] {
            "all",
            "~10000",
            "~30000",
            "~100000",
            "10000~"});
            this.cboxAnnualFee.Location = new System.Drawing.Point(168, 63);
            this.cboxAnnualFee.Name = "cboxAnnualFee";
            this.cboxAnnualFee.Size = new System.Drawing.Size(127, 23);
            this.cboxAnnualFee.TabIndex = 8;
            // 
            // cboxBasePayment
            // 
            this.cboxBasePayment.FormattingEnabled = true;
            this.cboxBasePayment.Items.AddRange(new object[] {
            "all",
            "~30000",
            "~50000"});
            this.cboxBasePayment.Location = new System.Drawing.Point(168, 107);
            this.cboxBasePayment.Name = "cboxBasePayment";
            this.cboxBasePayment.Size = new System.Drawing.Size(127, 23);
            this.cboxBasePayment.TabIndex = 9;
            // 
            // gboxFPR
            // 
            this.gboxFPR.Controls.Add(this.cboxBasePayment);
            this.gboxFPR.Controls.Add(this.cboxAnnualFee);
            this.gboxFPR.Controls.Add(this.lblBasePayment);
            this.gboxFPR.Controls.Add(this.lblAnnualFee);
            this.gboxFPR.Location = new System.Drawing.Point(305, 21);
            this.gboxFPR.Name = "gboxFPR";
            this.gboxFPR.Size = new System.Drawing.Size(331, 186);
            this.gboxFPR.TabIndex = 10;
            this.gboxFPR.TabStop = false;
            this.gboxFPR.Text = "FPR";
            // 
            // txtProductBenefit
            // 
            this.txtProductBenefit.Location = new System.Drawing.Point(101, 242);
            this.txtProductBenefit.Name = "txtProductBenefit";
            this.txtProductBenefit.ReadOnly = true;
            this.txtProductBenefit.Size = new System.Drawing.Size(535, 25);
            this.txtProductBenefit.TabIndex = 10;
            // 
            // lblProductBenefits
            // 
            this.lblProductBenefits.AutoSize = true;
            this.lblProductBenefits.Location = new System.Drawing.Point(35, 245);
            this.lblProductBenefits.Name = "lblProductBenefits";
            this.lblProductBenefits.Size = new System.Drawing.Size(60, 15);
            this.lblProductBenefits.TabIndex = 11;
            this.lblProductBenefits.Text = "Benefits";
            // 
            // FormFPR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 292);
            this.Controls.Add(this.lblProductBenefits);
            this.Controls.Add(this.txtProductBenefit);
            this.Controls.Add(this.gboxFPR);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.pboxCard);
            this.Name = "FormFPR";
            this.Text = "Financial Product Recommand";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormFPR_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pboxCard)).EndInit();
            this.gboxFPR.ResumeLayout(false);
            this.gboxFPR.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblAnnualFee;
        private System.Windows.Forms.Label lblBasePayment;
        private System.Windows.Forms.ComboBox cboxAnnualFee;
        private System.Windows.Forms.ComboBox cboxBasePayment;
        private System.Windows.Forms.GroupBox gboxFPR;
        private System.Windows.Forms.PictureBox pboxCard;
        private System.Windows.Forms.TextBox txtProductBenefit;
        private System.Windows.Forms.Label lblProductBenefits;
    }
}

