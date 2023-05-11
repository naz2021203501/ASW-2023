namespace project
{
    partial class FormFPR
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
            this.pboxCard = new System.Windows.Forms.PictureBox();
            this.lblImage = new System.Windows.Forms.Label();
            this.webCard = new System.Windows.Forms.WebBrowser();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboxCard)).BeginInit();
            this.SuspendLayout();
            // 
            // pboxCard
            // 
            this.pboxCard.Location = new System.Drawing.Point(12, 12);
            this.pboxCard.Name = "pboxCard";
            this.pboxCard.Size = new System.Drawing.Size(263, 186);
            this.pboxCard.TabIndex = 0;
            this.pboxCard.TabStop = false;
            this.pboxCard.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Location = new System.Drawing.Point(61, 210);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(164, 15);
            this.lblImage.TabIndex = 1;
            this.lblImage.Text = "<Recommend Product>";
            // 
            // webCard
            // 
            this.webCard.Location = new System.Drawing.Point(12, 241);
            this.webCard.MinimumSize = new System.Drawing.Size(20, 20);
            this.webCard.Name = "webCard";
            this.webCard.Size = new System.Drawing.Size(663, 269);
            this.webCard.TabIndex = 2;
            this.webCard.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(329, 28);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(298, 25);
            this.textBox2.TabIndex = 4;
            // 
            // FormFPR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 542);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.webCard);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.pboxCard);
            this.Name = "FormFPR";
            this.Text = "Financial product recommendation";
            ((System.ComponentModel.ISupportInitialize)(this.pboxCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pboxCard;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.WebBrowser webCard;
        private System.Windows.Forms.TextBox textBox2;
    }
}