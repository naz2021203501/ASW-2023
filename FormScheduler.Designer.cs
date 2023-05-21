namespace project
{
    partial class FormScheduler
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
            this.txtDate = new System.Windows.Forms.Label();
            this.date_scheduler = new System.Windows.Forms.CheckedListBox();
            this.addbutton = new System.Windows.Forms.Button();
            this.delbutton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDate
            // 
            this.txtDate.AutoSize = true;
            this.txtDate.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtDate.Location = new System.Drawing.Point(190, 3);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(57, 20);
            this.txtDate.TabIndex = 0;
            this.txtDate.Text = "label1";
            // 
            // date_scheduler
            // 
            this.date_scheduler.FormattingEnabled = true;
            this.date_scheduler.Location = new System.Drawing.Point(3, 3);
            this.date_scheduler.Name = "date_scheduler";
            this.date_scheduler.Size = new System.Drawing.Size(466, 284);
            this.date_scheduler.TabIndex = 1;
            this.date_scheduler.SelectedIndexChanged += new System.EventHandler(this.date_scheduler_SelectedIndexChanged);
            // 
            // addbutton
            // 
            this.addbutton.Location = new System.Drawing.Point(69, 378);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(139, 43);
            this.addbutton.TabIndex = 2;
            this.addbutton.Text = "일정 추가";
            this.addbutton.UseVisualStyleBackColor = true;
            // 
            // delbutton
            // 
            this.delbutton.Location = new System.Drawing.Point(277, 378);
            this.delbutton.Name = "delbutton";
            this.delbutton.Size = new System.Drawing.Size(150, 43);
            this.delbutton.TabIndex = 3;
            this.delbutton.Text = "일정 삭제";
            this.delbutton.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.date_scheduler);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(7, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(472, 294);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(67, 331);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(374, 25);
            this.textBox2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "일정";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 10;
            // 
            // FormScheduler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.delbutton);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "FormScheduler";
            this.Text = "FormScheduler";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtDate;
        private System.Windows.Forms.CheckedListBox date_scheduler;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Button delbutton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}